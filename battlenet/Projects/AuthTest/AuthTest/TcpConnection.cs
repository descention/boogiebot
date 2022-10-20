using System;
using System.Net.Sockets;
using System.Threading;

namespace AuthTest
{
    public class TcpConnection : IDisposable
    {
        #region Delegates

        public delegate void DataReceivedDelegate(TcpConnection conn, byte[] data);

        #endregion

        private readonly string _host;
        private readonly object _locker = new object();
        private readonly int _port;

        private readonly TcpClient _tcp;
        private NetworkStream _netStream;
        private Thread _workerThread;

        public TcpConnection(string host, int port)
        {
            _host = host;
            _port = port;
            _tcp = new TcpClient();
        }

        public NetworkStream NetStream
        {
            get { return _netStream; }
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            _workerThread.Abort();
            NetStream.Close();
            NetStream.Dispose();
            _tcp.Close();
            GC.SuppressFinalize(this);
        }

        #endregion

        public event DataReceivedDelegate DataReceived;

        private void InvokeDataReceived(byte[] data)
        {
            DataReceivedDelegate received = DataReceived;
            if (received != null)
            {
                received(this,data);
            }
        }

        public void Connect()
        {
            _tcp.Connect(_host, _port);
            _netStream = _tcp.GetStream();
            _workerThread = new Thread(AsyncRead) {IsBackground = true};
            _workerThread.Start();
        }

        private void AsyncRead()
        {
            // Lalala
            while (_workerThread.ThreadState != ThreadState.Aborted ||
                   _workerThread.ThreadState != ThreadState.AbortRequested)
            {
                lock (_locker)
                {
                    // Make sure there's data available... and we can read it.
                    if (NetStream.DataAvailable && NetStream.CanRead)
                    {
                        // Probably far too much...
                        var buffer = new byte[1024];
                        int bytesRead = NetStream.Read(buffer, 0, 1024);
                        // Resize it so we can invoke our event.
                        Array.Resize(ref buffer, bytesRead);

                        InvokeDataReceived(buffer);
                    }
                }
                Thread.Sleep(10);
            }
        }

        public void Write(byte[] data)
        {
            lock (_locker)
            {
                // Make sure we can write...
                if (NetStream.CanWrite)
                {
                    // And actually write...
                    NetStream.Write(data, 0, data.Length);
                }

                Thread.Sleep(10);
            }
        }

        ~TcpConnection()
        {
            Dispose();
        }
    }
}
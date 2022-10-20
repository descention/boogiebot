#include <Windows.h>
#include <tchar.h>

#include <map>
#include <memory>



enum StaticBufferIds
{
	BUFFER_SESSIONKEY = 0xB6E372AE,
};

enum InvokeParameterType
{
	PARAM_TYPE_BOOL = 0,
	PARAM_TYPE_INT = 1,
	PARAM_TYPE_STRING = 2,
};

class InvokeParameterImplementation
{
public:
  virtual void Function1( int a1, int a2, int a3 )
  {
  }
  virtual bool GetBoolean( BYTE* pbBuffer )
  {
	if ( FieldType != PARAM_TYPE_BOOL)
		return false;
	//MessageBoxA( 0, szError, "Length mismatch", 0 );
	pbBuffer[0] = field_8[0];
	return true;
  }
  virtual bool GetInt( int& Buffer )
  {
	  if ( FieldType == PARAM_TYPE_INT )
		  Buffer = IntField;
	  else
		  return false;

	  return true;
  }
  virtual bool GetString( char*& Buffer )
  {
	  if ( FieldType == PARAM_TYPE_STRING )
		Buffer = StringField;
	  else
		  return false;

	  return true;
  }

  int FieldType; // Type: 0 = Bool, 1 = Int, 2 = String
  BYTE field_8[4];
  int IntField;
  char* StringField;
};


// Abstract interface
class Module
{
public:
	virtual void Destroy() = 0;
	// .rdata:3C9B1C18 ; const Creep::Auth::InvokeParameterImplementation::`vftable'
	virtual void InvokeCommand( class Library* ChallengeHandlerClass, const char* Command,
		InvokeParameterImplementation **ppInvokeParameterImplementation, int ParamCount = 1) = 0;
	virtual void Data( class Library* ChallengeHandlerClass, char* Data, unsigned int Length ) = 0;
	virtual ~Module() = 0;
};

class ThumbprintModule : public Module
{
public:
	void Destroy();
	void InvokeCommand( class Library* ChallengeHandlerClass, const char* Command,
		InvokeParameterImplementation **ppInvokeParameterImplementation, int ParamCount = 1);
	void Data( class Library* ChallengeHandlerClass, char* Data, unsigned int Length );
	~ThumbprintModule();
};

class PasswordModule : public Module
{
public:
	void Destroy();
	void InvokeCommand( class Library* ChallengeHandlerClass, const char* Command,
		InvokeParameterImplementation **ppInvokeParameterImplementation, int ParamCount = 1);
	void Data( class Library* ChallengeHandlerClass, char* Data, unsigned int Length );
	~PasswordModule();
};

// Creep::Auth::Library
class Library
{
	virtual bool GetBuffer( unsigned int Index, DWORD_PTR& Buffer, int& Length) = 0;
	virtual bool SetBuffer( unsigned int Index, DWORD_PTR Buffer, int Length ) = 0;
	virtual void ClearBuffer(unsigned int Index) = 0;
	virtual void InvokeCommand(char* command, InvokeParameterImplementation** ppParams, int ParamCount) = 0;
	virtual void SetResponseData( PBYTE pbBuffer, int Length ) = 0;
	virtual void ClearResponseData() = 0;
	virtual void Function7() = 0;
	virtual void Function8(int errorCode,int,int) = 0;
};
// Creep::Auth::ChallengeHandler
class ChallengeHandler : public Library
{
private:
	struct BufferEntry
	{
		std::tr1::shared_ptr<BYTE> m_sharedPtr;
		int BufferLength;
	};
	std::map< unsigned int, BufferEntry > m_bufferMap;

	PBYTE m_pbOutBuffer;
	int* m_pOutSize;

public:
	bool GetBuffer( unsigned int Index, DWORD_PTR& Buffer, int& Length)
	{
		if ( m_bufferMap.find( Index ) == m_bufferMap.end() )
			return false;

		Buffer = (DWORD_PTR)m_bufferMap[Index].m_sharedPtr.get();
		Length = m_bufferMap[Index].BufferLength;		

		return true;
	}

	bool SetBuffer( unsigned int Index, DWORD_PTR Buffer, int Length )
	{
		std::tr1::shared_ptr<BYTE> sharedPtr;
		PBYTE pbLocalBuffer = new BYTE[Length];
		memcpy( pbLocalBuffer, (void*)Buffer, Length );
		sharedPtr.reset( pbLocalBuffer );

		m_bufferMap[Index].m_sharedPtr = sharedPtr;
		m_bufferMap[Index].BufferLength = Length;

		return true;
	}

	void ClearBuffer(unsigned int Index)
	{
	}
	void InvokeCommand(char* command,InvokeParameterImplementation** ppParams, int ParamCount)
	{
	}

	// Sets 0x418, 0x419, IsResponseNeeded to 1
	void SetResponseData( PBYTE pbBuffer, int Length )
	{
/*		for( int i = 0; i < Length; i++ )
		{
			if ( i % 16 == 0 )
				printf( "\n" );
			printf( "%02x ", pbBuffer[i] );
		}
		printf("\n");*/

		memcpy( m_pbOutBuffer, pbBuffer, Length );
		*m_pOutSize = Length;
	}

	// Sets 0x418 and 0x419 to 1, and IsResponseNeeded (0x41A) to 0
	void ClearResponseData()
	{		
	}
	void Function7(){}
	// Sets 0x418 to 1, and 0x419 and 0x41A (IsResponseNeeded) to 0
	void Function8(int,int,int)
	{		
	}

	void SetResponseBuffer(PBYTE pbBuffer, int* dwLength)
	{
		m_pbOutBuffer = pbBuffer;
		m_pOutSize = dwLength;
	}
};

class ModuleHolder
{
public:
	ModuleHolder()
	{
		hModule = LoadLibrary(_T("Modules\\Password.dll"));

		FARPROC CreateModule = GetProcAddress(hModule, "CreateModule");
		Module = reinterpret_cast<PasswordModule*>(CreateModule());

	}

	~ModuleHolder()
	{
		Module->Destroy();
		FreeLibrary( hModule );
	}

	PasswordModule* GetModule() { return Module; }

private:
	HMODULE hModule;
	PasswordModule* Module;
};

class ModuleHolder2
{
public:
	ModuleHolder2()
	{
	}
	ModuleHolder2(LPCTSTR lpsPathToModule)
	{
		
		hModule = LoadLibrary(lpsPathToModule);

		FARPROC CreateModule = GetProcAddress(hModule, "CreateModule");
		m_module = reinterpret_cast<Module*>(CreateModule());
	}

	void Init(LPCTSTR lptPath)
	{
		hModule = LoadLibrary(lptPath);
		FARPROC CreateModule = GetProcAddress(hModule, "CreateModule");
		m_module = reinterpret_cast<Module*>(CreateModule());
	}

	~ModuleHolder2()
	{
		m_module->Destroy();
		FreeLibrary( hModule );
	}

	Module* GetModule() { return m_module; }

private:
	HMODULE hModule;
	Module* m_module;
};

ChallengeHandler challengeHandler;
ModuleHolder PasswordModuleHolder;

extern "C" 
void __declspec(dllexport) WINAPI RequestPassword( PBYTE pbBuffer, int Length, PBYTE pbOutBuffer, int* pOutSize, PBYTE Password )
{
	PasswordModuleHolder.GetModule()->Data( &challengeHandler, (char*)pbBuffer, Length );

	InvokeParameterImplementation passwordParam;
	passwordParam.FieldType = PARAM_TYPE_STRING;
	memset(&passwordParam.field_8, 0, 4);
	passwordParam.IntField = 0;
	passwordParam.StringField = (char*)Password;

	challengeHandler.SetResponseBuffer(pbOutBuffer, pOutSize);

	InvokeParameterImplementation* invokeParams[] = { &passwordParam };
	PasswordModuleHolder.GetModule()->InvokeCommand( &challengeHandler, "RequestPassword", invokeParams, 1 );
}



extern "C"
void __declspec(dllexport) WINAPI PasswordHandleData(PBYTE pbBuffer, int Length)
{
	PasswordModuleHolder.GetModule()->Data(&challengeHandler, (char*)pbBuffer, Length);
}

extern "C"
void __declspec(dllexport) WINAPI GetSessionKey(PBYTE pbOutBuffer)
{
	int Length;
	DWORD_PTR pSessionKey = 0;
	challengeHandler.GetBuffer( BUFFER_SESSIONKEY, pSessionKey, Length );

	if ( Length != 64 )
	{
		char szError[128];
		sprintf(szError, "%i instead of 64", Length );
		MessageBoxA( 0, szError, "Length mismatch", 0 );
	}

	memcpy(pbOutBuffer, (void*)pSessionKey, Length);
}


extern "C"
void __declspec(dllexport) WINAPI RequestSessionKey( PBYTE pbBuffer, int Length, PBYTE pbOutBuffer )
{
	PasswordHandleData(pbBuffer, Length);
	GetSessionKey(pbOutBuffer);
	//PasswordModuleHolder.GetModule()->Data( &challengeHandler, (char*)pbBuffer, Length );
	/*DWORD_PTR pSessionKey = 0;
	challengeHandler.GetBuffer( BUFFER_SESSIONKEY, pSessionKey, Length );

	if ( Length != 64 )
	{
		char szError[128];
		sprintf(szError, "%i instead of 64", Length );
		MessageBoxA( 0, szError, "Length mismatch", 0 );
	}

	memcpy( pbOutBuffer, (void*)pSessionKey, Length );*/
}
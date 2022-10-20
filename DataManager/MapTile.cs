using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class MapTile : ADTFile
    {
        private int TileX;
        private int TileY;

        public MapTile(String mapname, int x, int y) : base(mapname, x, y)
        {
            // Keep a note of what tile we are
            TileX = x;
            TileY = y;
        }

        //public void getZ(Location c)
        //{
        //    c.Z = getZ(c.X, c.Y);
        //}

        public float getZ(double x, double y)
        {
            float diff = 500.0f / 15.0f;
            float vdiff = diff / 8.0f;

            // x/y base Locations for the top left most subtile (tile[0][0])
            float Xb = mapChunkTable[0][0].zpos;
            float Yb = mapChunkTable[0][0].xpos;

            int i = (int)Math.Abs((Xb - x) / diff);
            int j = (int)Math.Abs((Yb - y) / diff);

            if (i < 0 || i > 15 || j < 0 || j > 15)
                throw new Exception("The Locations are NOT on this Tile.");

            float X = mapChunkTable[i][j].zpos; // X Location of SubTile
            float Y = mapChunkTable[i][j].xpos; // Y Location of SubTile
            float Z = mapChunkTable[i][j].ypos; // Base Height of SubTile

            // Get Vertex Locations
            int iv = (int)Math.Round((double)Math.Abs((X - x) / vdiff));
            int jv = (int)Math.Round((double)Math.Abs((Y - y) / vdiff));

            // Add the vertex height difference to the base height of the maptile, and return it!
            float ActualZ = Z + mapChunkTable[i][j].VerticesOuter[iv][jv];

            return ActualZ;
        }


        // Broken as of 3.0
        public float getWaterHeight(float x, float y)
        {
            float diff = 500.0f / 15.0f;
            float vdiff = diff / 8.0f;

            // x/y base Locations for the top left most subtile (tile[0][0])
            float Xb = mapChunkTable[0][0].zpos;
            float Yb = mapChunkTable[0][0].xpos;

            int i = (int)Math.Abs((Xb - x) / diff);
            int j = (int)Math.Abs((Yb - y) / diff);

            if (i < 0 || i > 15 || j < 0 || j > 15)
                throw new Exception("The Locations are NOT on this Tile.");

            return mapChunkTable[i][j].Liquid.waterLevel;
        }

        public int X
        {
            get { return TileX; }
        }

        public int Y
        {
            get { return TileY; }
        }
    }
}

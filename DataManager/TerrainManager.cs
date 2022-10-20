using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    /// <summary>Manages Terrain Data. Provides numerous useful methods to query terrain data, and does so by looking up (and if nessessary, loading in) the appropriate maptile.</summary>
    public class TerrainManager
    {
        private List<MapTile> mapTiles;

        public static float TILESIZE = 533.33333f;
        public static float ZEROPOINT = 32.0f * TILESIZE;

        public static MapTable MapTable = new MapTable();
        public static AreaTable AreaTable = new AreaTable();

        public TerrainManager()
        {
            mapTiles = new List<MapTile>();
        }

        public String getMapName(uint mapid)
        {
            return MapTable.getMapName(mapid);
        }

        public String getLocationAsString(Vector3 c, uint mapid)
        {
            String mapName = MapTable.getMapName(mapid);

            return String.Format("{0}: ({1}, {2}, {3})", mapName, c.X, c.Y, c.Z);
        }

        public float getZ(uint mapid, float x, float y)
        {
            doMaintenance(false);

            int TileX = (int)(((0f - y) + TerrainManager.ZEROPOINT) / TerrainManager.TILESIZE);
            int TileY = (int)(((0f - x) + TerrainManager.ZEROPOINT) / TerrainManager.TILESIZE);

            // Find the maptile on the list of loaded tiles.
            MapTile tile = findTile(mapid, TileX, TileY);

            // Ask the maptile to get y for x,y
            return tile.getZ(x, y);
        }

        public float getWaterHeight(uint mapid, float x, float y)
        {
            doMaintenance(false);

            int TileX = (int)(((0f - y) + TerrainManager.ZEROPOINT) / TerrainManager.TILESIZE);
            int TileY = (int)(((0f - x) + TerrainManager.ZEROPOINT) / TerrainManager.TILESIZE);

            // Find the maptile on the list of loaded tiles.
            MapTile tile = findTile(mapid, TileX, TileY);

            // Ask the maptile to get y for x,y
            return tile.getWaterHeight(x, y);
        }

        // Notify the terrain manager that we have just zoned.
        public void zoned()
        {
            // If we just zoned to a different map, do maintenance and flush the current tile list
            doMaintenance(true);

            //if (BenderCore.Player != null)
            //{
            //    Location c = BenderCore.Player.Location;
            //    int TileX = (int)(((0f - c.Y) + TerrainManager.ZEROPOINT) / TerrainManager.TILESIZE);
            //    int TileY = (int)(((0f - c.X) + TerrainManager.ZEROPOINT) / TerrainManager.TILESIZE);

            //    loadTile(TileX, TileY);
            //}
        }

        // Finds Maptile x,y on the list
        private MapTile findTile(uint mapid, int x, int y)
        {
            foreach (MapTile mapTile in mapTiles)
            {
                if (mapTile.X == x && mapTile.Y == y)
                    return mapTile;
            }

            // Wasn't a tile we have currently Loaded? Load it in!!
            return loadTile(mapid, x, y);
        }

        // Loads a maptile in
        private MapTile loadTile(uint mapid, int x, int z)
        {
            String mapname = MapTable.getMapName(mapid);

            MapTile tile = new MapTile(mapname, x, z);
            mapTiles.Add(tile);
            return tile;
        }

        // Do maintenance
        private void doMaintenance(Boolean flush)
        {
            // Delete all maptiles off the list
            if (flush)
            {
                mapTiles = new List<MapTile>();
            }

            // If the list is getting long
            if (mapTiles.Count > 100)
            {
                // Prune it.
                mapTiles = new List<MapTile>();
            }
        }

        // DEBUG METHODS /////////////////////////////////////////////////////////////////
        public int DEBUG_TileCount()
        {
            return mapTiles.Count;
        }
    }
}

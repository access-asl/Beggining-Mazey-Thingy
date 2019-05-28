using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    //A subclass to hold the map's information such as width and height
    [System.Serializable]
    public class MapInfo {
        public bool debug;
        public int width;
        public int height;
        //All of the map's info: 0 valid 1 invalid 2 path 3 start 4 end
        public int[,] map;
    }

    public MapInfo mapInfo;

    /**
    Draws an empty map using game cubes
     */
    public int[,] generateEmptyMap(int width, int height) {
        int[,] mapToReturn = new int[width, height];
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                mapToReturn[x,y] = 0;
            }
        }
        return mapToReturn;
    }

    /**
    returns the in game coordinates of the cube in relation to the map
     */
    private Vector3 getPositionInMap(int mapWidth, int mapHeight, int x, int y) { return new Vector3((-mapWidth / 2) + x, 0, (-mapHeight / 2) + y); }

    void OnDrawGizmos() {
        if (mapInfo.debug) {
            for (int x = 0; x < mapInfo.width; x++) {
                for (int y = 0; y < mapInfo.height; y++) {
                    if (mapInfo.map[x, y] == 0) {
                        Gizmos.color = new Color(255, 255, 255);
                        Gizmos.DrawCube(getPositionInMap(mapInfo.width, mapInfo.height, x, y), Vector3.one);
                    } else if (mapInfo.map[x, y] == 1) {
                        Gizmos.color = new Color(0, 255, 0);
                        Gizmos.DrawCube(getPositionInMap(mapInfo.width, mapInfo.height, x, y), Vector3.one);
                    } else {
                        Gizmos.color = new Color(255, 0, 0);
                        Gizmos.DrawCube(getPositionInMap(mapInfo.width, mapInfo.height, x, y), Vector3.one);
                    }
                }
            }
        }
    }

}

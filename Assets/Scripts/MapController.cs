using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
This class will generate a map and then use the info to
create a bunch of cubes that can be edited and use A*
to find the path between two valid node.
@author Brower
 */
 [RequireComponent(typeof(MapGenerator))]
public class MapController : MonoBehaviour
{
    [System.Serializable]
    public class ColorInfo {
        public Color grass;
        public Color lake;
        public Color start;
        public Color end;
        public Color path;
    }

    public ColorInfo mapColors;

    //The mapgen object
    MapGenerator mapGen;

    // The array to base the pathfinding off of
    int[,] map;

    void Start() {
        map = mapGen.generateEmptyMap(mapGen.mapInfo.width, mapGen.mapInfo.height);
    }

    /**
    Takes in a int[,] and will create gameobjects that are white if zero
    blue if 1
     */
    void generateNodes(int[,] mapToGen) {
        
    }
}

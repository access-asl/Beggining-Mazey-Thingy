using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public bool isGrass;
    public Vector2 gridPos;
    public Node prev;

    public Node(bool isGrass, Vector2 gridPos, Node prev) {
        this.isGrass = isGrass;
        this.gridPos = gridPos;
        this.prev = prev;
    }
}

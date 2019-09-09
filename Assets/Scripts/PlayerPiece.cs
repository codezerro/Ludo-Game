using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerPiece : MonoBehaviour
{
    public bool canMove;
    public bool moveNow;
    public int moveNumberOfSteps;

    public PathObjectsParents pathsParent;

    private void Awake() {
        pathsParent = FindObjectOfType<PathObjectsParents>();    
    }
}

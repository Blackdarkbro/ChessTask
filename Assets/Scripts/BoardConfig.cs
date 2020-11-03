using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BoardData", menuName = "Board/data")]
public class BoardConfig : ScriptableObject
{
    [SerializeField] private GameObject board;

    public float StartX => board.transform.position.x;
    public float StartZ => board.transform.position.z;
    
    public float EndX => board.GetComponent<MeshRenderer>().bounds.max.x - 1.5f;
    public float EndZ => board.GetComponent<MeshRenderer>().bounds.max.z - 1.5f;
}

using System.Collections;
using System.Collections.Generic;
using Figure;
using Positions;
using UnityEngine;

public class BlackFiguresController : MonoBehaviour
{
    [SerializeField] private King king;
    [SerializeField] private Queen queen;
    [SerializeField] private Knight knight;
    [SerializeField] private Bishop bishop;
    [SerializeField] private Rook rook;
    [SerializeField] private Pawn pawn;

    [SerializeField] private StartsFiguresPositions startsFiguresPositions;
    void Start()
    {
        foreach (var k in startsFiguresPositions.BishopsStartPos)
        {
            Instantiate(bishop.Prefab, k, Quaternion.identity);
        }
        
        foreach (var k in startsFiguresPositions.RooksStartPos)
        {
            Instantiate(rook.Prefab, k, Quaternion.identity);
        }
        
        foreach (var k in startsFiguresPositions.KnightsStartPos)
        {
            Instantiate(knight.Prefab, k, Quaternion.identity);
        }
        
        foreach (var k in startsFiguresPositions.PawnsStartPos)
        {
            Instantiate(pawn.Prefab, k, Quaternion.identity);
        }

        Instantiate(king.Prefab, startsFiguresPositions.KingStartPos, Quaternion.identity);
        Instantiate(queen.Prefab, startsFiguresPositions.QueenStartPos, Quaternion.identity);
    }
}

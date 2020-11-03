using UnityEngine;

namespace Movements
{
    [CreateAssetMenu]
    public class Movements : ScriptableObject
    {
        public Vector3 BishopMovement = new Vector3(8, 0, 8);
        public Vector3 RookMovement = new Vector3(8, 0, 8);
        public Vector3 QueenMovement = new Vector3(8, 0, 8);
        public Vector3 KingMovement = new Vector3(2, 0, 2);
        public Vector3 KnightMovement = new Vector3(1, 0, 2);
        public Vector3 PawnMovement = new Vector3(0, 0, 1);
    }
}
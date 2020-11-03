using UnityEngine;

namespace Figure
{
    [CreateAssetMenu(fileName = "PawnData", menuName = "Figure/Pawn")]
    public class Pawn : ScriptableObject
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private FigureColor colorFigure = FigureColor.White;
        [SerializeField] private int count = 8;
        [SerializeField] private Movements.Movements movement;

        public GameObject Prefab => prefab;

        public int Count => count;
    }
}
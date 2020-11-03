using UnityEngine;

namespace Figure
{
    [CreateAssetMenu(fileName = "RookData", menuName = "Figure/Rook")]
    public class Rook : ScriptableObject
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private FigureColor colorFigure = FigureColor.White;
        [SerializeField] private int count = 2;
        [SerializeField] private Movements.Movements movement;

        public GameObject Prefab => prefab;

        public int Count => count;
    }
}
using UnityEngine;

namespace Figure
{
    [CreateAssetMenu(fileName = "KingData", menuName = "Figure/King")]
    public class King : ScriptableObject
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private FigureColor colorFigure = FigureColor.White;
        [SerializeField] private int count = 1;
        [SerializeField] private Movements.Movements movement;

        public GameObject Prefab => prefab;

        public int Count => count;
    }
}
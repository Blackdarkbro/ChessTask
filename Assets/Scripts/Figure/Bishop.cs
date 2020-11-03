using Movements;
using UnityEngine;

namespace Figure
{
    [CreateAssetMenu(fileName = "BishopData", menuName = "Figure/Bishop")]
    public class Bishop : ScriptableObject
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private FigureColor colorFigure = FigureColor.White;
        [SerializeField] private int count = 2;
        [SerializeField] private Movements.Movements movement;

        public GameObject Prefab => prefab;

        public int Count => count;
        
    }
}
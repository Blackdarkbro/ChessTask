using UnityEngine;

namespace Positions
{
    [CreateAssetMenu(fileName = "FiguresStartPositions", menuName = "StartFigurePositions")]
    public class StartsFiguresPositions : ScriptableObject
    {
        [SerializeField] private BoardConfig boardConfig;
        [SerializeField] private FigureColor colorFigure = FigureColor.Black;

        private float StartX => boardConfig.StartX;
        private float StartZ => boardConfig.StartZ;
        private float EndX => boardConfig.EndX;
        private float EndZ => boardConfig.EndZ;

        private float ZPosition => colorFigure == FigureColor.Black ? StartZ : EndZ;
        
        public Vector3 KingStartPos => new Vector3(StartX + 3, 0, ZPosition);
        public Vector3 QueenStartPos => new Vector3(StartX + 4, 0, ZPosition);

        public Vector3[] RooksStartPos
        {
            get
            {
                return new[] {new Vector3(StartX, 0, ZPosition), new Vector3(EndX, 0, ZPosition), };
            }
        }
        
        public Vector3[] KnightsStartPos
        {
            get
            {
                return new[] {new Vector3(StartX + 1, 0, ZPosition), new Vector3(EndX - 1, 0, ZPosition), };
            }
        }
        
        public Vector3[] BishopsStartPos
        {
            get
            {
                return new[] {new Vector3(StartX + 2, 0, ZPosition), new Vector3(EndX - 2, 0, ZPosition), };
            }
        }
        
        public Vector3[] PawnsStartPos
        {
            get
            {
                Vector3[] coords = {};
                for (var i = 0; i < EndX - StartX; i++)
                {
                    coords[i] = new Vector3(i, 0, ZPosition);
                }

                return coords;
            }
        }
    }
}
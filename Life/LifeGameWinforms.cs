using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class LifeGameWinforms : LifeGame
    {
        public int CellSize { get; }

        public Color AliveColor { get => AliveColorBrush.Color; set => AliveColorBrush.Color = value; }
        public Color DeadColor { get => DeadColorBrush.Color; set => DeadColorBrush.Color = value; }
        protected SolidBrush AliveColorBrush { get; set; }
        protected SolidBrush DeadColorBrush { get; set; }

        public Bitmap ResizedBitmap { get; }
        protected Graphics G { get; }

        public LifeGameWinforms(int width, int height, LifeGameRules rules, int cellSize, Color alive, Color dead) :
            base(width, height, rules)
        {
            CellSize = cellSize;
            ResizedBitmap = new Bitmap(Width * CellSize, Height * CellSize);
            G = Graphics.FromImage(ResizedBitmap);

            AliveColorBrush = new(alive);
            DeadColorBrush = new(dead);
        }

        protected override void DrawCellOnCanvas(int x, int y, bool alive)
        {
            G.FillRectangle(alive ? AliveColorBrush : DeadColorBrush, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
        }

        protected override void ClearCanvas()
        {
            G.Clear(DeadColor);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public abstract class LifeGame
    {
        public int Width { get; }
        public int Height { get; }
        public int FrequencyMax { get; }
        public int Frequency { get; }
        public LifeGameRules Rules { get; set; }
        public int Generation { get; private set; }

        protected WrapVector<bool> Cells { get; set; }
        private WrapVector<bool> PreviousCells { get; set; }

        public LifeGame(int width, int height, LifeGameRules rules)
        {
            Width = width;
            Height = height;
            Cells = new(Width, Height);
            PreviousCells = new(Width, Height);
            Rules = rules;
        }

        public virtual void GenerateRandom(int frequency, int maxFrequency)
        {
            Random random = new();
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Cells[x, y] = random.Next(0, maxFrequency) < frequency;
                }
            }
        }

        public virtual void NextGeneration()
        {
            (Cells, PreviousCells) = (PreviousCells, Cells);
            Generation++;
            ClearCanvas();
            
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    bool[] neighbours = new bool[8]
                    {
                        PreviousCells[x + 1, y + 1],
                        PreviousCells[x - 1, y + 1],
                        PreviousCells[x + 1, y - 1],
                        PreviousCells[x - 1, y - 1],
                        PreviousCells[x + 1, y],
                        PreviousCells[x - 1, y],
                        PreviousCells[x, y + 1],
                        PreviousCells[x, y - 1],
                    };
                    int count = neighbours.Count((bool a) => a);
                    bool changes = Rules.DoesCellChange(PreviousCells[x, y], count);
                    Cells[x, y] = changes ? !PreviousCells[x, y] : PreviousCells[x, y];
                    if (Cells[x, y])
                    {
                        DrawCellOnCanvas(x, y, true);
                    }
                }
            }
        }

        public virtual void SetCell(int x, int y, bool alive)
        {
            Cells[x, y] = alive;
        }

        public virtual void SetCellAndDraw(int x, int y, bool alive)
        {
            Cells[x, y] = alive;
            DrawCellOnCanvas(x, y, alive);
        }

        protected abstract void DrawCellOnCanvas(int x, int y, bool alive);
        protected abstract void ClearCanvas();
    }
}

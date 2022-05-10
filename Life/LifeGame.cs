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

        protected WrapVector<bool> Cells { get; set; }

        public LifeGame(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new(Width, Height);
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
            WrapVector<bool> nextCells = new(Width, Height);

            ClearCanvas();
            
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    bool[] neighbours = new bool[8]
                    {
                        Cells[x + 1, y + 1],
                        Cells[x - 1, y + 1],
                        Cells[x + 1, y - 1],
                        Cells[x - 1, y - 1],
                        Cells[x + 1, y],
                        Cells[x - 1, y],
                        Cells[x, y + 1],
                        Cells[x, y - 1],
                    };
                    int count = neighbours.Count((bool a) => a);
                    if (Cells[x, y])
                    {
                        if (count == 2 || count == 3)
                        {
                            nextCells[x, y] = true;
                            DrawCellOnCanvas(x, y, true);
                        }
                    }
                    else if (count == 3)
                    {
                        nextCells[x, y] = true;
                        DrawCellOnCanvas(x, y, true);
                    }
                }
            }
            Cells = nextCells;
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

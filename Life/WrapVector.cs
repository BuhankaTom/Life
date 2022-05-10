using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class WrapVector<T>
    {
        private T[,] Source { get; }
        public int Width { get; }
        public int Height { get; }

        public WrapVector(int width, int height)
        {
            Source = new T[width, height];
            Width = width;
            Height = height;
        }

        public T this[int x, int y]
        {
            get => Source[Wrap(x, Width), Wrap(y, Height)];
            set => Source[Wrap(x, Width), Wrap(y, Height)] = value;
        }

        private static int Wrap(int value, int max)
        {
            return value > 0 ?
                value % max :
                value % max + (value % max == 0 ? 0 : max);
        }
    }
}

using System.Text;

namespace Sevriukoff.AsciiArena.CommonLib;

public class Map
    {
        public int Width { get; }
        public int Height { get; }
        public CellType[,] Cells { get; set; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new CellType[width, height];
            Generate();
        }

        private void Generate()
        {
            Random rand = new Random();

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    // Устанавливаем границы карты как стены
                    if (x == 0 || y == 0 || x == Width - 1 || y == Height - 1)
                    {
                        Cells[x, y] = CellType.Wall;
                    }
                    else
                    {
                        // Генерируем случайное число от 0 до 1
                        double p = rand.NextDouble();
                        if (p < 0.1) // 10% вероятность для стены
                        {
                            Cells[x, y] = CellType.Wall;
                        }
                        else if (p < 0.15) // 5% вероятность для дерева (0.1 <= p < 0.15)
                        {
                            Cells[x, y] = CellType.Tree;
                        }
                        else
                        {
                            Cells[x, y] = CellType.Floor;
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    char c = Cells[x, y] switch
                    {
                        CellType.Floor => '.',
                        CellType.Wall  => '#',
                        CellType.Tree  => 'T',
                        _              => '?'
                    };
                    sb.Append(c);
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
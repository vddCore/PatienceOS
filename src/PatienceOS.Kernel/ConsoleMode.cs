namespace PatienceOS.Kernel
{
    public struct ConsoleMode
    {
        public int Columns { get; }
        public int Rows { get; }

        private ConsoleMode(int columns, int rows)
        {
            Columns = columns;
            Rows = rows;
        }

        public static ConsoleMode VGA_80x25 => new(80, 25);
    }
}
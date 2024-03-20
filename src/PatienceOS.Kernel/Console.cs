namespace PatienceOS.Kernel
{
    public unsafe struct Console
    {
        private int _pos;
        
        private int _width;
        private int _height;

        private FrameBuffer _fb;

        public Console(ConsoleMode mode, FrameBuffer fb)
        {
            _pos = 0;
            
            _width = mode.Columns;
            _height = mode.Rows;
            
            _fb = fb;
        }

        public void Clear()
        {
            for (var i = 0; i < _width * _height * 2; i++)
            {
                _fb.Write(i, 0);
            }
        }

        public void Print(string s)
        {
            fixed (char* ps = s)
            {
                for (var i = 0; i < s.Length; i++)
                {
                    _fb.Write(_pos, (byte)ps[i]);
                    _fb.Write(_pos + 1, 0x0F);

                    _pos += 2;
                }
            }
        }
    }
}

namespace PatienceOS.Kernel
{
    public unsafe struct FrameBuffer
    {
        private byte* _memory;

        public FrameBuffer(byte* memory)
        {
            _memory = memory;
        }

        public byte Fetch(int position)
        {
            return _memory[position];
        }

        public void Write(int position, byte value)
        {
            _memory[position] = value;
        }
    }
}

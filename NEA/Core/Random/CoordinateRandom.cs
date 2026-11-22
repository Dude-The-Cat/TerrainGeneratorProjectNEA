namespace NEA.Core.Random
{
    public static class CoordinateRandom
    {
        // Takes coordinates and seed to generate a random integer
        public static uint GetUInt(int x, int y, int seed)
        {
            uint hash = (uint)seed;

            // Mix the X coordinate into the hash
            hash ^= (uint)x;
            hash *= 0x27d4eb2d; // A large prime number
            has ^= hash >> 13;

        }
    }
}
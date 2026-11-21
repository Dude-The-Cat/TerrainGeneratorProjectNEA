namespace NEA.Core.Parameters
{
    public class TerrainParameters
    {
        // Dimensions of the terrain in chunks
        public int ChunkSize { get; set; } = 128;

        // Terrain generation parameters
        public float Scale { get; set; } = 50f;
        public float Frequency { get; set; } = 1f;
        public float Amplitude { get; set; } = 1f;

        // Fractal noise parameters
        public float Lacunarity { get; set; } = 2f;
        public float Persistence { get; set; } = 0.5f;
        public int Octaves { get; set; } = 4;

        // Seed
        public int Seed {get; set;} = 0;
    }
}
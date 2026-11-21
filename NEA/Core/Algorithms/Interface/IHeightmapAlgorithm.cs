using TerrainGenerator.Core.Parameters;

namespace NEA.Core.Algorithms.Interface
{
    public interface IHeightmapAlgorithm
    {
        // Method for generating a heightmap
        float[,] Generate(TerrainParameters parameters);
    }
}   
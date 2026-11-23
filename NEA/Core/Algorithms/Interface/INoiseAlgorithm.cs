namespace NEA.Core.Algorithms.Interface
{
    public interface INoiseAlgorithm
    {
        // Sample method for calculating noise value at a given point
        float Sample(float x, float y, int seed);
    }
}
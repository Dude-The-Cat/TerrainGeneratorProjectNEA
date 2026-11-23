namespace NEA.Core.Parameters
{
    public class LoadParameters
    {
        // Location
        public string LoadPath { get; set; } = string.Empty;

        // Default
        public string DefaultLoadPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.Pictures);
    }
}
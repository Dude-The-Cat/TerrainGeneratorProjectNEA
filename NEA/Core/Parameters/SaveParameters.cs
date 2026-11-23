namespace NEA.Core.Parameters
{
    public class SaveParameters
    {
        // Format
        public TerrainFileType FileType { get; set; } = TerrainFileType.PNG;

        // Location
        public string SaveLocation { get; set; } = string.Empty;

        public string SavePath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // File name
        public string FileName { get; set; } = "Terrain";

        // Export
        public bool IncludeMetadata { get; set; } = true;

        public bool OverwriteExisting { get; set; } = false;
    }
}


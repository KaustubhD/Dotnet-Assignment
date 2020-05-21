namespace Assignment.Core
{
    public class ImageInfo
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string ColorType { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Sequence { get; set; }
        public string ObjectLabels { get; set; }
    }
}
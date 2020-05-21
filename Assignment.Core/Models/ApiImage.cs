namespace Assignment.Core
{
    public class ApiImage
    {
        public int Id { get; set; }
        public int Sequence { get; set; }
        public int BuilderId { get; set; }
        public int CommId { get; set; }
        public int SpecId { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Path { get; set; }
        public string OriginalPath { get; set; }
        public string Description { get; set; }
        public string Name{ get; set; }
        public string ClickThruURL { get; set; }
        public string PrimaryFlag { get; set; }
        public bool is360Image { get; set; }
    }
}
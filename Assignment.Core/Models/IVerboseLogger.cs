namespace Assignment.Core
{
    public interface IVerboseLogger
    {
        public bool IsResultFromCache { get; set; }
        public ResourceType ResourceType { get; set; }
    }
}
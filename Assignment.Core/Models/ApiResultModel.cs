namespace Assignment.Core
{
    public class ApiResultModel<T>
    {
        public string Time { get; set; }
        public string ErrorMessage { get; set; }
        public string Server { get; set; }
        public string Status { get; set; }
        public T Result { get; set; }

    }
}
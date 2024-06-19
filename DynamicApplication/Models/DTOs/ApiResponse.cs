namespace DynamicApplication.Models.DTOs
{
    public class ApiResponse
    {
        public string Message { get; set; }
        public bool Status { get; set; }
    }

    public class ApiResponse<T> : ApiResponse
    {
        public T Data { get; set; }
    }
}

namespace HospitalApp.Model.DTOs
{
    public class ResponseDto<T>
    {
        public int StatusCode { get; set; }
        public string DisplayMessage { get; set; }
        public List<string> ErrorMessage { get; set; }
        public T Result { get; set; }
    }
}

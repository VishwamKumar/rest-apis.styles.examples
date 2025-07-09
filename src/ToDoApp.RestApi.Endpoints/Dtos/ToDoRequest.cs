namespace ToDoApp.RestApi.Endpoints.Dtos;

public class ToDoRequest
{
    [Required]
    public string ToDoName { get; set; } = null!;
}

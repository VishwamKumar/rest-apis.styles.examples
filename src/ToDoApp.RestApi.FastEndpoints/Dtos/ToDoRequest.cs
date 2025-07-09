namespace ToDoApp.RestApi.FastEndpoints.Dtos;

public class ToDoRequest
{
    [Required]
    public string? ToDoName { get; set; }
}

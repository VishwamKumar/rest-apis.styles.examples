namespace ToDoApp.RestApi.Minimal.Dtos;

public class ToDoRequest
{
    [Required]
    public string ToDoName { get; set; } = null!;
}

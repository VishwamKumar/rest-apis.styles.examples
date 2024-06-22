namespace ToDoApp.RestApi.Controllers.Dtos;

public class ToDoRequest
{
    [Required]
    public string ToDoName { get; set; } = null!;
}

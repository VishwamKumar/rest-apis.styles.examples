
namespace ToDoApp.RestApi.Controllers.Profiles;

public class ProjectProfile:Profile
{
    public ProjectProfile()
    {
        CreateMap<ToDo,ToDoResponse>();
    }
}

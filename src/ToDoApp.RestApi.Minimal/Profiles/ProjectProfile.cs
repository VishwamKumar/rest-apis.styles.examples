
namespace ToDoApp.RestApi.Minimal.Profiles;

public class ProjectProfile:Profile
{
    public ProjectProfile()
    {
        CreateMap<ToDo,ToDoResponse>();
    }
}

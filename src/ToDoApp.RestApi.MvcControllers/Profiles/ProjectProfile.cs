
namespace ToDoApp.RestApi.MvcControllers.Profiles;

public class ProjectProfile:Profile
{
    public ProjectProfile()
    {
        CreateMap<ToDo,ToDoResponse>();
    }
}

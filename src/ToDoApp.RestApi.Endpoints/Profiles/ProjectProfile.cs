
namespace ToDoApp.RestApi.Endpoints.Profiles;

public class ProjectProfile:Profile
{
    public ProjectProfile()
    {
        CreateMap<ToDo,ToDoResponse>();
    }
}

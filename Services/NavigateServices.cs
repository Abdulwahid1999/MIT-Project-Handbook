
namespace HandbookSchool.Services
{
    public class NavigateServices : INavigationServicesMIT
    {


        public Task NavigateToAsync(string route, IDictionary<string, object> parameters)
        {
            if (parameters != null)
            {
                return Shell.Current.GoToAsync(route, parameters);
            }
            else
            {
                return Shell.Current.GoToAsync(route);
            }
        }
    }
}

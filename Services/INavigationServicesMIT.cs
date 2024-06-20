using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandbookSchool.Services
{
    public interface INavigationServicesMIT
    {
        Task NavigateToAsync(string route, IDictionary<string, object> parameters = null);
    }
}

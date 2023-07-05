using System.Threading.Tasks;

namespace Truckrrapp.Web.Abstractions
{
    public interface IViewRenderService
    {
        Task<string> RenderViewToStringAsync<TModel>(string viewName, TModel model);
    }
}
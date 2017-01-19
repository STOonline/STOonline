/*
 * Сделано в SharpDevelop.
 * Пользователь: Artem
 * Дата: 1/19/2017
 * Время: 17:32
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace STOonline
{
	public class MvcApplication : HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.Ignore("{resource}.axd/{*pathInfo}");
			
			routes.MapRoute(
				"Default",
				"{controller}/{action}/{id}",
				new {
					controller = "Home",
					action = "Index",
					id = UrlParameter.Optional
				});
		}
		
		protected void Application_Start()
		{
			RegisterRoutes(RouteTable.Routes);
		}
	}
}

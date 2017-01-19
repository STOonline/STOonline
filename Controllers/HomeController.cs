/*
 * Сделано в SharpDevelop.
 * Пользователь: Artem
 * Дата: 1/19/2017
 * Время: 17:32
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Web.Mvc;

namespace STOonline.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		
		public ActionResult Contact()
		{
			return View();
		}
	}
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SearchUsers.Models;

namespace SearchUsers.Controllers;

public class HomeController : Controller
{
    /// <summary>
    /// 因为这是首页的默认方法 所以在这里初始化用户信息
    /// </summary>
    /// <returns>首页的HTML</returns>
    public IActionResult Index(string searchStr)
    {
        // save user's infomation
        List<User> info = new List<User>();

        // 初始化用户信息
        info.Add(new Models.User("Jerry", "Software Engineer", "M"));
        info.Add(new Models.User("Hogan", "Data Scientist", "M"));
        info.Add(new Models.User("Jean", "Consultant", "F"));
        info.Add(new Models.User("Kelly", "Software Engineer", "F"));
        info.Add(new Models.User("John", "Consultantt", "M"));
        info.Add(new Models.User("Kim", "Data Scientist", "F"));
        info.Add(new Models.User("Larry", "Consultant", "M"));

        // 把信息传入对应的视图中供它调用
        ViewBag.searchStr = searchStr;
        if(searchStr != null)
        {
            searchStr = searchStr.ToLower();
            List<User> filter = new List<User>();
            foreach(var item in info)
            {
                if (item.JobTitle.ToLower().Contains(searchStr)){
                    filter.Add(item);
                }
            }
            ViewBag.info = filter;
        }
        else
        {
            ViewBag.info = info;
        }

        // 根据convention寻找到它的视图
        return View();
        
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


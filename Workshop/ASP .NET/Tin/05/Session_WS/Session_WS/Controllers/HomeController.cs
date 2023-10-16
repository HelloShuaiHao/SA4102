using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Session_WS.Models;

namespace Session_WS.Controllers;

public class HomeController : Controller
{
    // dependency injection
    private readonly SessionDic sessionDic;
    
    public HomeController(SessionDic sessionDic)
    {
        this.sessionDic = sessionDic;
    }



    /// <summary>
    /// 返回用户登陆界面
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public IActionResult Login(string username)
    {
        if(username == null)
        {
            return View();
        }
        else
        {
            string? sessionId = Request.Cookies["SessionId"];
            if(sessionId == null)
            {
                sessionId = new Guid().ToString();
                CookieOptions options = new CookieOptions();
                // options.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("SessionId", sessionId, options);
            }
            // 这样子在用户在受到http response以后 cookie里，就会有sessionId的值
            return RedirectToAction("Track", "Home");
        }
    }

    /// <summary>
    /// 返回Track功能页面
    /// </summary>
    /// <param name="clickedBtn"></param>
    /// <returns></returns>
    public IActionResult Track(string clickedBtn)
    {
        // 因为在之前接受http response的时候 cookie被更改了 所以发过来的http request可以读取sessionId

        // 有可能是null 所以要加问号
        string? sessionId = Request.Cookies["SessionId"];
        if (sessionId == null) return RedirectToAction("Login", "Home");


        Guid guidSessionId = Guid.Parse(sessionId);
        if (!sessionDic.Dic.ContainsKey(guidSessionId))
        {
            sessionDic.Dic.Add(guidSessionId, new List<string>());
        }

        if (clickedBtn != null) sessionDic.Dic[guidSessionId].Add(clickedBtn);


        // Debug.WriteLine(dic[guidSessionId].Count);



        ViewBag.list = sessionDic.Dic[guidSessionId]; // 把数据传到前端去

        return View();
    }


    public IActionResult Logout()
    {
        sessionDic.Dic.Clear();
        Response.Cookies.Delete("SessionId");

        return RedirectToAction("Login", "Home");
    }


    public IActionResult Index()
    {
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


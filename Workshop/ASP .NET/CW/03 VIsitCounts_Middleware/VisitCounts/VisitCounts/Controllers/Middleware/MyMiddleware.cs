using System;
using System.Diagnostics;
using VisitCounts.Models;

namespace VisitCounts.Controllers.Middleware
{
	public class MyMiddleware
	{
		private RequestDelegate next; // 已经被系统注册的 在运行时变化，可以直接注入

		private readonly Count count; // 我们自己注册的，可以直接注入

		public MyMiddleware(Count count, RequestDelegate next)
		{
			this.next = next;
			this.count = count; // dependency injection
		}


		// 写中间件的逻辑
		public async Task Invoke(HttpContext context)
		{
			// Debug.WriteLine("Hi");
			// to be default, its path will be /
			if (context.Request.Path.StartsWithSegments("/Home/Index") || context.Request.Path.StartsWithSegments("/"))
			{
				count.CountHome++;
			}
			else if(context.Request.Path.StartsWithSegments("/Gallery/Index") || context.Request.Path.StartsWithSegments("/Gallery"))
			{
				count.CountGallery++;
            }
            else if (context.Request.Path.StartsWithSegments("/Stats/Index") || context.Request.Path.StartsWithSegments("/Stats"))
			{
			}
            await next(context);

			return;
        }
    }
}


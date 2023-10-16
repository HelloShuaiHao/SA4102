using System;
namespace Session_WS.Models
{

	/// <summary>
	/// 作为dependency injection使用
	/// </summary>
	public class SessionDic
	{
		public Dictionary<Guid, List<string>> Dic { get; set; }

		public SessionDic()
		{
			Dic = new Dictionary<Guid, List<string>>();
		}
	}
}


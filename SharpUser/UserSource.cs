using System.Security.Principal;

namespace SharpUser
{
	public class User
	{
		public static string GetName()
		{
			return WindowsIdentity.GetCurrent().Name;
		}
	}
}

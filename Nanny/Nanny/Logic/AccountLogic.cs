using System;

namespace Nanny.Logic
{
	public class AccountLogic
	{
		private static AccountLogic _Instance;
		private  AccountLogic ()
		{
		}
		
		public static AccountLogic Instance 
		{
			get
			{
				if(_Instance == null)
					_Instance = new AccountLogic();
				return _Instance;
			}
		}

		//ACCOUNT FUNCTIONS, EXAMPLE LOGIN
	}
}


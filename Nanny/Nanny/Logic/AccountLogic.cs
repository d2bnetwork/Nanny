using System;

namespace Nanny
{
	public class AccountLogic
	{
		private static AccountLogic _Instance;
		private  AccountLogic ()
		{
		}
		
		public AccountLogic Instance 
		{
			get
			{
				if(_Instance == null)
					_Instance = new AccountLogic();
				return _Instance;
			}
		}
	}
}


using System;
using Nanny.DOM;

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

		public bool IsUserLogged{
			get
			{
				return StorageLogic.Instance.Settings.ContainsKey("UserLogin") && StorageLogic.Instance.Settings["UserLogin"]!=null;
			}
		}

		UserInfo _CurrentUser = null;
		public UserInfo CurrentUser
		{
			get
			{
				if(IsUserLogged && _CurrentUser == null)
					_CurrentUser = DataLogic.Instance.GetUserInfo(StorageLogic.Instance.Settings["UserLogin"]);
				return _CurrentUser;
			}
		}

		public void LogoutUser(){
			StorageLogic.Instance.Settings["UserLogin"] = null;
			_CurrentUser = null;
		}

		public bool LoginUser(string email, string pass){
			_CurrentUser = DataLogic.Instance.ValidUser(email, pass);
			if(_CurrentUser !=null)
			{
				//lo guardo en session
				StorageLogic.Instance.SaveSetting("UserLogin", email);
				return true;
			}
			return false;
		}

		public bool AddUser(UserInfo user){
			var newUser = DataLogic.Instance.AddUser(user);
			if(newUser != null){
				_CurrentUser = newUser;
				StorageLogic.Instance.SaveSetting("UserLogin", newUser.Email);
				return true;
			}
			return false;

		}
	}
}


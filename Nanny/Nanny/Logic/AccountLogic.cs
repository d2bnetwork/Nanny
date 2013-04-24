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

		public void LogoutUser(){
			//TODO
		}

		public bool LoginUser(string email, string pass){
			//TODO 
			//ver si no lo tenemos en "session" por email
			//si esta en session retorno true
			// si no voy a la base de datos para ver si esta ok



			if(DataLogic.Instance.ValidUser(email, pass))
			{
				//lo guardo en session
				return true;
			}
			return false;

		}

		public bool AddUser(ParentInfo user){
			var newUser = DataLogic.Instance.AddUser(user);
			if(newUser != null){
			//TODO Agregar el usuario a session como logueado.

				return true;
			}
			return false;

		}
	}
}


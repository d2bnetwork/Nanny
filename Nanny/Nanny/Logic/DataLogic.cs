using System;
using Parse;
using Nanny.DOM;

namespace Nanny.Logic
{
	public class DataLogic
	{
		private static DataLogic _Instance;
		private DataLogic ()
		{
			//ParseClient.Initialize("ic5msCXZIpGFNDWDerRFFEPIZNPshuj9atDxEDXC", "iiLmBAPfDYb25nfNahVzwDpWNc7eEmttmmccuVNh");
		}
		
		public static DataLogic Instance 
		{
			get
			{
				if(_Instance == null)
					_Instance = new DataLogic();
				return _Instance;
			}
		}

		public UserInfo ValidUser (string email, string pass)
		{
			//TODO 
			return GetUserInfo(email);
		}

		public UserInfo GetUserInfo (string email)
		{
			//TODO
			return new UserInfo(){
				Name = email,
				Email = email
			};
		}

		public UserInfo AddUser(UserInfo user)
		{
			//TODO
			//throw new NotImplementedException ();
			return user;
		}

		public void SaveObject(object item){
			/*var testObject = new ParseObject ("TestObject");
			testObject ["foo"] = "bar";
			testObject.SaveAsync ();*/

			/*foreach (var prop in item.GetType().GetProperties()) {
				var val = prop.GetValue(item,null);
				Console.Write(prop.Name + " - " + val + " - ");
				if(prop.PropertyType.IsSubclassOf(typeof(System.Collections.ICollection))){
					Console.WriteLine("IsArray");
				}
				else if(prop.PropertyType.Namespace == "Nanny.DOM" && ! prop.PropertyType.IsEnum)
				{
					Console.WriteLine("Namespace");
				}else
					Console.WriteLine("Valor");
			}*/
		}


		///DATA BASE FUNCTIONS (PARSE)

	}
}


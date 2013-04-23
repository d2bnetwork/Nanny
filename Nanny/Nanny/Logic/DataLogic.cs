using System;
using Parse;

namespace Nanny.Logic
{
	public class DataLogic
	{
		private static DataLogic _Instance;
		private DataLogic ()
		{
			//ParseClient.Initialize("ic5msCXZIpGFNDWDerRFFEPIZNPshuj9atDxEDXC",
			  //                     "iiLmBAPfDYb25nfNahVzwDpWNc7eEmttmmccuVNh");
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


		public void SaveObject<T>(object obj){
			//var testObject = new ParseObject ("TestObject");
			//testObject ["foo"] = "bar";
			//await testObject.SaveAsync ();

			foreach (var prop in obj.GetType().GetProperties()) {

			}
		}


		///DATA BASE FUNCTIONS (PARSE)

	}
}


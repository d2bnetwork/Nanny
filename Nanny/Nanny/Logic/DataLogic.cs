using System;

namespace Nanny.Logic
{
	public class DataLogic
	{
		private static DataLogic _Instance;
		private DataLogic ()
		{
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


		private void SaveObject<T>(object obj){
			foreach (var prop in obj.GetType().GetProperties()) {

			}
		}


		///DATA BASE FUNCTIONS (PARSE)

	}
}


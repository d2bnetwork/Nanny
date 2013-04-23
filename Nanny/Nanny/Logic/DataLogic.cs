using System;

namespace Nanny
{
	public class DataLogic
	{
		private static DataLogic _Instance;
		private  DataLogic ()
		{
		}
		
		public DataLogic Instance 
		{
			get
			{
				if(_Instance == null)
					_Instance = new DataLogic();
				return _Instance;
			}
		}
	}
}


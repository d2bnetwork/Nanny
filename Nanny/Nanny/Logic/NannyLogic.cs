using System;

namespace Nanny.Logic
{
	public class NannyLogic
	{
		private static NannyLogic _Instance;
		private  NannyLogic ()
		{
		}
		
		public static NannyLogic Instance 
		{
			get
			{
				if(_Instance == null)
					_Instance = new NannyLogic();
				return _Instance;
			}
		}


	}
}


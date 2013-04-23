using System;

namespace Nanny
{
	public class NannyLogic
	{
		private static NannyLogic _Instance;
		private  NannyLogic ()
		{
		}
		
		public NannyLogic Instance 
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


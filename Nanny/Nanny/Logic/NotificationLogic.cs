using System;

namespace Nanny
{
	public class NotificationLogic
	{
		private static NotificationLogic _Instance;
		private  NotificationLogic ()
		{
		}
		
		public NotificationLogic Instance 
		{
			get
			{
				if(_Instance == null)
					_Instance = new NotificationLogic();
				return _Instance;
			}
		}

		///NOTIFICATION FUNCTIONS

	}
}


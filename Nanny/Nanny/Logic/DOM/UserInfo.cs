using System;
using System.Collections.Generic;

namespace Nanny.DOM
{
	public class UserInfo
	{
		public int ID{get;set;}
		public string Name{get;set;}
		public string Email{get;set;}
		public string Password{get;set;}
		public string Avatar {get;set;}
		public string MobileNumber{get;set;}

		public List<ChildInfo> Childrens{get;set;} //Created by Mi
		public List<ChildInfo> Childrens2{get;set;} //Invited from other User
		public List<ChildInfo> Childrens23{get;set;} //Nanny

		public UserInfo ()
		{
		}
	}
}


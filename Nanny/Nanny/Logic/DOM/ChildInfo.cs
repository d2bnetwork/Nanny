using System;
using System.Collections.Generic;

namespace Nanny.DOM
{
	public class ChildInfo
	{
		public enum E_Gender
		{
			Boy =0,
			Girl =1
		}
		public int ID {get;set;}
		public string Name {get;set;}
		public string Avatar {get;set;}
		public E_Gender Gender {get;set;}
		public UserInfo Parent {get;set;}
		public List<UserInfo> Parents{get;set;}

		public ChildInfo ()
		{

		}

	}
}


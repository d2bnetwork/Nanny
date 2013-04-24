using System;
using System.Collections.Generic;

namespace Nanny.DOM
{
	public class ParentInfo
	{
		public int ID{get;set;}
		public string Name{get;set;}
		public string Email{get;set;}
		public string Avatar {get;set;}
		public List<ChildInfo> Childrens{get;set;}

		public ParentInfo ()
		{
		}
	}
}


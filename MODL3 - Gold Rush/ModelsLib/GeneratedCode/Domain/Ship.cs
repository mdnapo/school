﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Domain
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Ship : Vehicle
	{
		public override int Load
		{
			get;
			set;
		}

		public virtual Water Water
		{
			get;
			set;
		}

		public override void Move()
		{
			throw new System.NotImplementedException();
		}

		public virtual void Unload()
		{
			throw new System.NotImplementedException();
		}

	}
}


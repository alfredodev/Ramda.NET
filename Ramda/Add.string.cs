﻿// <autogenerated>
//   This file was generated by T4 code generator Add.string.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Add(string a, string b) {
			return Currying.Add(a, b);
		    }

		public static dynamic Add(RamdaPlaceholder a, string b) {
			return Currying.Add(a, b);
		}

		public static dynamic Add(string a, RamdaPlaceholder b = null) {
			return Currying.Add(a, b);
		}
	}
}
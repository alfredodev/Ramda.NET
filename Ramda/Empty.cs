﻿// <autogenerated>
//   This file was generated by T4 code generator Empty.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Empty<TValue>(TValue x) {
			return Currying.Empty(x);
		}
		
		public static dynamic Empty<TValue>(RamdaPlaceholder x = null) {
			return Currying.Empty(x); 
		}
	}
}
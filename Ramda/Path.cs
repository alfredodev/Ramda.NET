﻿// <autogenerated>
//   This file was generated by T4 code generator Path.tt.
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
		public static dynamic Path<TTarget>(IList<string> path, TTarget obj) {
			return Currying.Path(path, obj);
		}
			
		public static dynamic Path<TTarget>(RamdaPlaceholder path, TTarget obj) {
			return Currying.Path(path, obj);
		}
			
		public static dynamic Path<TTarget>(IList<string> path, RamdaPlaceholder obj = null) {
			return Currying.Path(path, obj);
		}
		
		public static dynamic Path<TTarget>(RamdaPlaceholder path = null, RamdaPlaceholder obj = null) {
			return Currying.Path(path, obj);
		}
	}
}
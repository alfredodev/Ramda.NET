﻿// <autogenerated>
//   This file was generated by T4 code generator AssocPath.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections;
using System.Collections.Generic;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic AssocPath<TValue, TTarget>(IList<string> path, TValue value, TTarget target) {
			return Currying.AssocPath(path, value, target);
		}
		
		public static dynamic AssocPath<TValue, TTarget>(RamdaPlaceholder path, TValue value, TTarget target) {
			return Currying.AssocPath(path, value, target); 
		}
		
		public static dynamic AssocPath<TValue, TTarget>(IList<string> path, RamdaPlaceholder value, TTarget target) {
			return Currying.AssocPath(path, value, target); 
		}
		
		public static dynamic AssocPath<TValue, TTarget>(IList<string> path, TValue value, RamdaPlaceholder target = null) {
			return Currying.AssocPath(path, value, target); 
		}
		
		
		public static dynamic AssocPath<TValue, TTarget>(IList<string> path, RamdaPlaceholder value = null, RamdaPlaceholder target = null) {
			return Currying.AssocPath(path, value, target);
		}
		
		public static dynamic AssocPath<TValue, TTarget>(RamdaPlaceholder path = null, RamdaPlaceholder value = null, RamdaPlaceholder target = null) {
			return Currying.AssocPath(path, value, target);
		}
	}
}
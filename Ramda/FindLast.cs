﻿// <autogenerated>
//   This file was generated by T4 code generator FindLast.tt.
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
		public static dynamic FindLast<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.FindLast(fn, list);
		}
			
		public static dynamic FindLast<TSource>(Func<TSource, bool> fn, IList<TSource> list) {
			return Currying.FindLast(fn, list);
		}
		
		public static dynamic FindLast<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.FindLast(fn, list); 
		}

		public static dynamic FindLast(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.FindLast(fn, list);
		}
		
		public static dynamic FindLast<TSource>(Func<TSource, bool> fn, RamdaPlaceholder list = null) {
			return Currying.FindLast(fn, list); 
		}
		
		public static dynamic FindLast<TSource>(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.FindLast(fn, list);
		}
	}
}
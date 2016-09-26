﻿// <autogenerated>
//   This file was generated by T4 code generator SortBy.tt.
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
		public static dynamic SortBy<TSource>(Func<TSource, int> pred, IList<TSource> list) {
			return Currying.SortBy(pred, list);
		}
			
		public static dynamic SortBy<TSource>(RamdaPlaceholder pred, IList<TSource> list) {
			return Currying.SortBy(pred, list);
		}

		public static dynamic SortBy<TSource>(dynamic pred, IList<TSource> list) {
			return Currying.SortBy(pred, list); 
		}
					
		public static dynamic SortBy(dynamic pred, RamdaPlaceholder list = null) {
			return Currying.SortBy(pred, list);
		}
			
		public static dynamic SortBy<TSource>(Func<TSource, int> pred, RamdaPlaceholder list = null) {
			return Currying.SortBy(pred, list);
		}
		
		public static dynamic SortBy<TSource>(RamdaPlaceholder pred = null, RamdaPlaceholder list = null) {
			return Currying.SortBy(pred, list);
		}
	}
}
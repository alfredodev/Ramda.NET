﻿// <autogenerated>
//   This file was generated by T4 code generator ZipObj.tt.
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
		public static dynamic ZipObj<TSource>(IList<string> keys, IList<TSource> values) {
			return Currying.ZipObj(keys, values);
		}

		public static dynamic ZipObj<TSource>(RamdaPlaceholder keys, IList<TSource> values) {
			return Currying.ZipObj(keys, values);
		}

		public static dynamic ZipObj(IList<string> keys, RamdaPlaceholder values = null) {
			return Currying.ZipObj(keys, values);
		}

		public static dynamic ZipObj(RamdaPlaceholder keys = null, RamdaPlaceholder values = null) {
			return Currying.ZipObj(keys, values);
		}
	}
}
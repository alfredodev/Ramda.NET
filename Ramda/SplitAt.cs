﻿// <autogenerated>
//   This file was generated by T4 code generator SplitAt.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using System.Threading.Tasks;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic SplitAt<TSource>(int index, IList<TSource> array) {
			return Currying.SplitAt(index, array);
		}

		public static dynamic SplitAt<TSource>(RamdaPlaceholder index, IList<TSource> array) {
			return Currying.SplitAt(index, array);
		}

		public static dynamic SplitAt(int index, RamdaPlaceholder array = null) {
			return Currying.SplitAt(index, array);
		}

		public static dynamic SplitAt(RamdaPlaceholder index = null, RamdaPlaceholder array = null) {
			return Currying.SplitAt(index, array);
		}
	}
}
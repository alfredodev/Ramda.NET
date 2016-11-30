﻿// <autogenerated>
//   This file was generated by T4 code generator Both.func.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Both<TSource>(Func<TSource, bool> f, Func<TSource, bool> g) {
			return Currying.Both(new DelegateDecorator(f), new DelegateDecorator(g));
		}

		public static dynamic Both<TSource>(RamdaPlaceholder f, Func<TSource, bool> g) {
			return Currying.Both(f, new DelegateDecorator(g));
		}

		public static dynamic Both<TSource>(Func<TSource, bool> f, RamdaPlaceholder g = null) {
			return Currying.Both(new DelegateDecorator(f), g);
		}

		public static dynamic Both(RamdaPlaceholder f, dynamic g) {
			return Currying.Both(f, g);
		}

		public static dynamic Both(dynamic f, RamdaPlaceholder g = null) {
			return Currying.Both(f, g);
		}

		public static dynamic Both<TSource>(dynamic f, Func<TSource, bool> g) {
			return Currying.Both(f, g);
		}

		public static dynamic Both<TSource>(Func<TSource, bool> f, dynamic g) {
			return Currying.Both(f, g);
		}

		public static dynamic Both(RamdaPlaceholder f = null, RamdaPlaceholder g = null) {
			return Currying.Both(f, g);
		}
	}
}
﻿// <autogenerated>
//   This file was generated by T4 code generator AnyPass.tt.
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
		public static dynamic AnyPass<TSource>(IList<Func<TSource, bool>> preds) {
			return Currying.AnyPass(preds);
		}

		public static dynamic AnyPass(RamdaPlaceholder preds = null) {
			return Currying.AnyPass(preds);
		}
	}
}
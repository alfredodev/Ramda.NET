﻿// <autogenerated>
//   This file was generated by T4 code generator Of.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
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
		/// <summary>
		/// Returns a singleton array containing the value provided.Note this `of` is different from the ES6 `of`; Seehttps://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/of
		/// <para />
		/// sig: a -> [a]
		/// </summary>
		/// <param name="x">any value</param>
		/// <returns>An array wrapping `x`.</returns>
		public static dynamic Of<TSource>(TSource x) {
			return Currying.Of(x);
		}

		/// <summary>
		/// Returns a singleton array containing the value provided.Note this `of` is different from the ES6 `of`; Seehttps://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/of
		/// <para />
		/// sig: a -> [a]
		/// </summary>
		/// <param name="x">any value</param>
		/// <returns>An array wrapping `x`.</returns>
		public static dynamic Of(RamdaPlaceholder x = null) {
			return Currying.Of(x);
		}
	}
}
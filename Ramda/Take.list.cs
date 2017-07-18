﻿// <autogenerated>
//   This file was generated by T4 code generator Take.list.tt.
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
		/// <summary>
		/// Returns the first `n` elements of the given list, string, ortransducer/transformer (or object with a `take` method).Dispatches to the `take` method of the second argument, if present.
		/// <para />
		/// sig: Number -> [a] -> [a]
		/// </summary>
		/// <param name="n">first</param>
		/// <param name="list">second</param>
		/// <returns>*</returns>
		/// <see cref="R.Drop"/>
		public static dynamic Take<TSource>(int n, IList<TSource> list) {
			return Currying.Take(n, list);
		}

		/// <summary>
		/// Returns the first `n` elements of the given list, string, ortransducer/transformer (or object with a `take` method).Dispatches to the `take` method of the second argument, if present.
		/// <para />
		/// sig: Number -> [a] -> [a]
		/// </summary>
		/// <param name="n">first</param>
		/// <param name="list">second</param>
		/// <returns>*</returns>
		/// <see cref="R.Drop"/>
		public static dynamic Take<TSource>(RamdaPlaceholder n, IList<TSource> list) {
			return Currying.Take(n, list);
		}

		/// <summary>
		/// Returns the first `n` elements of the given list, string, ortransducer/transformer (or object with a `take` method).Dispatches to the `take` method of the second argument, if present.
		/// <para />
		/// sig: Number -> [a] -> [a]
		/// </summary>
		/// <param name="n">first</param>
		/// <param name="list">second</param>
		/// <returns>*</returns>
		/// <see cref="R.Drop"/>
		public static dynamic Take(int n, RamdaPlaceholder list = null) {
			return Currying.Take(n, list);
		}

		/// <summary>
		/// Returns the first `n` elements of the given list, string, ortransducer/transformer (or object with a `take` method).Dispatches to the `take` method of the second argument, if present.
		/// <para />
		/// sig: Number -> [a] -> [a]
		/// </summary>
		/// <param name="n">first</param>
		/// <param name="list">second</param>
		/// <returns>*</returns>
		/// <see cref="R.Drop"/>
		public static dynamic Take(RamdaPlaceholder n = null, RamdaPlaceholder list = null) {
			return Currying.Take(n, list);
		}
	}
}
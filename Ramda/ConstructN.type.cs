﻿// <autogenerated>
//   This file was generated by T4 code generator ConstructN.type.tt.
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
		/// Wraps a constructor function inside a curried function that can be calledwith the same arguments and returns the same type. The arity of the functionreturned is specified to allow using variadic constructor functions.
		/// <para />
		/// sig: Number -> (* -> {*}) -> (* -> {*})
		/// </summary>
		/// <param name="n">The arity of the constructor function.</param>
		/// <param name="Fn">The constructor function to wrap.</param>
		/// <returns>A wrapped, curried constructor function.</returns>
		public static dynamic ConstructN<TTarget>(int n) {
			return Currying.ConstructN(n, typeof(TTarget));
		}

		/// <summary>
		/// Wraps a constructor function inside a curried function that can be calledwith the same arguments and returns the same type. The arity of the functionreturned is specified to allow using variadic constructor functions.
		/// <para />
		/// sig: Number -> (* -> {*}) -> (* -> {*})
		/// </summary>
		/// <param name="n">The arity of the constructor function.</param>
		/// <param name="Fn">The constructor function to wrap.</param>
		/// <returns>A wrapped, curried constructor function.</returns>
		public static dynamic ConstructN<TTarget>(RamdaPlaceholder n = null) {
			return Currying.ConstructN(n, typeof(TTarget));
		}
	}
}
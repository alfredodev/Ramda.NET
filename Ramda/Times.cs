﻿// <autogenerated>
//   This file was generated by T4 code generator Times.tt.
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
		/// Calls an input function `n` times, returning an array containing the resultsof those function calls.`fn` is passed one argument: The current value of `n`, which begins at `0`and is gradually incremented to `n - 1`.
		/// <para />
		/// sig: (Number -> a) -> Number -> [a]
		/// </summary>
		/// <param name="fn">The function to invoke. Passed one argument, the current value of `n`.</param>
		/// <param name="n">A value between `0` and `n - 1`. Increments after each function call.</param>
		/// <returns>An array containing the return values of all calls to `fn`.</returns>
		public static dynamic Times<TReturn>(Func<int, TReturn> fn, int n) {
			return Currying.Times(Delegate(fn), n);
		}

		/// <summary>
		/// Calls an input function `n` times, returning an array containing the resultsof those function calls.`fn` is passed one argument: The current value of `n`, which begins at `0`and is gradually incremented to `n - 1`.
		/// <para />
		/// sig: (Number -> a) -> Number -> [a]
		/// </summary>
		/// <param name="fn">The function to invoke. Passed one argument, the current value of `n`.</param>
		/// <param name="n">A value between `0` and `n - 1`. Increments after each function call.</param>
		/// <returns>An array containing the return values of all calls to `fn`.</returns>
		public static dynamic Times(RamdaPlaceholder fn, int n) {
			return Currying.Times(fn, n);
		}

		/// <summary>
		/// Calls an input function `n` times, returning an array containing the resultsof those function calls.`fn` is passed one argument: The current value of `n`, which begins at `0`and is gradually incremented to `n - 1`.
		/// <para />
		/// sig: (Number -> a) -> Number -> [a]
		/// </summary>
		/// <param name="fn">The function to invoke. Passed one argument, the current value of `n`.</param>
		/// <param name="n">A value between `0` and `n - 1`. Increments after each function call.</param>
		/// <returns>An array containing the return values of all calls to `fn`.</returns>
		public static dynamic Times<TReturn>(Func<int, TReturn> fn, RamdaPlaceholder n = null) {
			return Currying.Times(Delegate(fn), n);
		}

		/// <summary>
		/// Calls an input function `n` times, returning an array containing the resultsof those function calls.`fn` is passed one argument: The current value of `n`, which begins at `0`and is gradually incremented to `n - 1`.
		/// <para />
		/// sig: (Number -> a) -> Number -> [a]
		/// </summary>
		/// <param name="fn">The function to invoke. Passed one argument, the current value of `n`.</param>
		/// <param name="n">A value between `0` and `n - 1`. Increments after each function call.</param>
		/// <returns>An array containing the return values of all calls to `fn`.</returns>
		public static dynamic Times(dynamic fn, RamdaPlaceholder n = null) {
			return Currying.Times(Delegate(fn), n);
		}

		/// <summary>
		/// Calls an input function `n` times, returning an array containing the resultsof those function calls.`fn` is passed one argument: The current value of `n`, which begins at `0`and is gradually incremented to `n - 1`.
		/// <para />
		/// sig: (Number -> a) -> Number -> [a]
		/// </summary>
		/// <param name="fn">The function to invoke. Passed one argument, the current value of `n`.</param>
		/// <param name="n">A value between `0` and `n - 1`. Increments after each function call.</param>
		/// <returns>An array containing the return values of all calls to `fn`.</returns>
		public static dynamic Times(dynamic fn, int n) {
			return Currying.Times(Delegate(fn), n);
		}

		/// <summary>
		/// Calls an input function `n` times, returning an array containing the resultsof those function calls.`fn` is passed one argument: The current value of `n`, which begins at `0`and is gradually incremented to `n - 1`.
		/// <para />
		/// sig: (Number -> a) -> Number -> [a]
		/// </summary>
		/// <param name="fn">The function to invoke. Passed one argument, the current value of `n`.</param>
		/// <param name="n">A value between `0` and `n - 1`. Increments after each function call.</param>
		/// <returns>An array containing the return values of all calls to `fn`.</returns>
		public static dynamic Times(RamdaPlaceholder fn = null, RamdaPlaceholder n = null) {
			return Currying.Times(fn, n);
		}
	}
}
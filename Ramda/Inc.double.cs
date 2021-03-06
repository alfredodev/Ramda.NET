﻿// <autogenerated>
//   This file was generated by T4 code generator Inc.double.tt.
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
		/// Increments its argument.
		/// <para />
		/// sig: Number -> Number
		/// </summary>
		/// <param name="n">first</param>
		/// <returns>n + 1</returns>
		/// <see cref="R.Dec"/>
		public static dynamic Inc(double n) {
			return Currying.Inc(n);
		}

		/// <summary>
		/// Increments its argument.
		/// <para />
		/// sig: Number -> Number
		/// </summary>
		/// <param name="n">first</param>
		/// <returns>n + 1</returns>
		/// <see cref="R.Dec"/>
		public static dynamic Inc(RamdaPlaceholder n = null) {
			return Currying.Inc(n);
		}
	}
}
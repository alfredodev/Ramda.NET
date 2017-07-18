﻿// <autogenerated>
//   This file was generated by T4 code generator Prepend.object.tt.
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
		/// Returns a new list with the given element at the front, followed by thecontents of the list.
		/// <para />
		/// sig: a -> [a] -> [a]
		/// </summary>
		/// <param name="el">The item to add to the head of the output list.</param>
		/// <param name="list">The array to add to the tail of the output list.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.Append"/>
		public static dynamic Prepend(object el, IList list) {
			return Currying.Prepend(el, list);
		}

		/// <summary>
		/// Returns a new list with the given element at the front, followed by thecontents of the list.
		/// <para />
		/// sig: a -> [a] -> [a]
		/// </summary>
		/// <param name="el">The item to add to the head of the output list.</param>
		/// <param name="list">The array to add to the tail of the output list.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.Append"/>
		public static dynamic Prepend(RamdaPlaceholder el, IList list) {
			return Currying.Prepend(el, list);
		}

		/// <summary>
		/// Returns a new list with the given element at the front, followed by thecontents of the list.
		/// <para />
		/// sig: a -> [a] -> [a]
		/// </summary>
		/// <param name="el">The item to add to the head of the output list.</param>
		/// <param name="list">The array to add to the tail of the output list.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.Append"/>
		public static dynamic Prepend(object el, RamdaPlaceholder list = null) {
			return Currying.Prepend(el, list);
		}
	}
}
﻿// <autogenerated>
//   This file was generated by T4 code generator Prop.string.tt.
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
		/// Returns a function that when supplied an object returns the indicatedproperty of that object, if it exists.
		/// <para />
		/// sig: s -> {s: a} -> a | Undefined
		/// </summary>
		/// <param name="p">The property name</param>
		/// <param name="obj">The object to query</param>
		/// <returns>The value at `obj.p`.</returns>
		/// <see cref="R.Path"/>
		public static dynamic Prop<TTarget>(string p, TTarget obj) {
			return Currying.Prop(p, obj);
		}

		/// <summary>
		/// Returns a function that when supplied an object returns the indicatedproperty of that object, if it exists.
		/// <para />
		/// sig: s -> {s: a} -> a | Undefined
		/// </summary>
		/// <param name="p">The property name</param>
		/// <param name="obj">The object to query</param>
		/// <returns>The value at `obj.p`.</returns>
		/// <see cref="R.Path"/>
		public static dynamic Prop<TTarget>(RamdaPlaceholder p, TTarget obj) {
			return Currying.Prop(p, obj);
		}

		/// <summary>
		/// Returns a function that when supplied an object returns the indicatedproperty of that object, if it exists.
		/// <para />
		/// sig: s -> {s: a} -> a | Undefined
		/// </summary>
		/// <param name="p">The property name</param>
		/// <param name="obj">The object to query</param>
		/// <returns>The value at `obj.p`.</returns>
		/// <see cref="R.Path"/>
		public static dynamic Prop(string p, RamdaPlaceholder obj = null) {
			return Currying.Prop(p, obj);
		}

		/// <summary>
		/// Returns a function that when supplied an object returns the indicatedproperty of that object, if it exists.
		/// <para />
		/// sig: s -> {s: a} -> a | Undefined
		/// </summary>
		/// <param name="p">The property name</param>
		/// <param name="obj">The object to query</param>
		/// <returns>The value at `obj.p`.</returns>
		/// <see cref="R.Path"/>
		public static dynamic Prop(RamdaPlaceholder p = null, RamdaPlaceholder obj = null) {
			return Currying.Prop(p, obj);
		}
	}
}
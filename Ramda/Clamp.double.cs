﻿// <autogenerated>
//   This file was generated by T4 code generator Clamp.double.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections;
using System.Collections.Generic;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Clamp(double min, double max, double value) {
			return Currying.Clamp(min, max, value);
		}
		
		public static dynamic Clamp(RamdaPlaceholder min, double max, double value) {
			return Currying.Clamp(min, max, value); 
		}
		
		public static dynamic Clamp(double min, RamdaPlaceholder max, double value) {
			return Currying.Clamp(min, max, value); 
		}
		
		public static dynamic Clamp(double min, double max, RamdaPlaceholder value = null) {
			return Currying.Clamp(min, max, value); 
		}
		
		
		public static dynamic Clamp(double min, RamdaPlaceholder max = null, RamdaPlaceholder value = null) {
			return Currying.Clamp(min, max, value);
		}
	}
}
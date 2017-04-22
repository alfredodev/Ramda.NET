﻿using System;
using System.Dynamic;
using System.Collections;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
    public static partial class R
    {
        public static dynamic IfElse(dynamic condition, dynamic onTrue, Delegate onFalse) {
            return Currying.IfElse(Delegate(condition), Delegate(onTrue), Delegate(onFalse));
        }

        public static dynamic IfElse(dynamic condition, Delegate onTrue, dynamic onFalse) {
            return Currying.IfElse(Delegate(condition), Delegate(onTrue), Delegate(onFalse));
        }

        public static dynamic IfElse(Delegate condition, dynamic onTrue, dynamic onFalse) {
            return Currying.IfElse(Delegate(condition), Delegate(onTrue), Delegate(onFalse));
        }

        public static dynamic IfElse(dynamic condition, dynamic onTrue, dynamic onFalse) {
            return Currying.IfElse(Delegate(condition), Delegate(onTrue), Delegate(onFalse));
        }
    }
}
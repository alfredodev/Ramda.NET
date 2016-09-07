﻿using System;
using System.Collections;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
    public static partial class R
    {
        public static RamdaPlaceholder __ = new RamdaPlaceholder();

        public static dynamic CurryN(int length, Delegate fn) {
            return Currying.CurryN(length, fn);
        }

        public static dynamic Add(int arg1) {
            return Currying.Add(arg1);
        }

        public static dynamic Add(double arg1) {
            return Currying.Add(arg1);
        }

        public static dynamic Add(long arg1) {
            return Currying.Add(arg1);
        }

        public static dynamic Add(string arg1) {
            return Currying.Add(arg1);
        }

        public static dynamic Add(RamdaPlaceholder arg1) {
            return Currying.Add(arg1);
        }

        public static dynamic Add(RamdaPlaceholder arg1, RamdaPlaceholder arg2) {
            return Currying.Add(arg1, arg2);
        }


        public static dynamic Add(int arg1, int arg2) {
            return Currying.Add(arg1, arg2);
        }

        public static dynamic Add(double arg1, double arg2) {
            return Currying.Add(arg1, arg2);
        }

        public static dynamic Add(long arg1, long arg2) {
            return Currying.Add(arg1, arg2);
        }

        public static dynamic Add(string arg1, string arg2) {
            return Currying.Add(arg1, arg2);
        }

        public static dynamic Adjust<TValue>(Func<TValue, TValue> fn) {
            return Currying.Adjust(fn);
        }

        public static dynamic Adjust<TValue>(Func<TValue, TValue> fn, int idx) {
            return Currying.Adjust(fn, idx);
        }

        public static dynamic Adjust<TValue>(Func<TValue, TValue> fn, int idx, IList<TValue> list) {
            return Currying.Adjust(fn, idx, list);
        }

        public static dynamic Always<TValue>(TValue value) {
            return Currying.Always(value);
        }

        public static dynamic DefaultTo<TArg1>(TArg1 arg1) {
            return Currying.DefaultTo(arg1);
        }

        public static dynamic DefaultTo(RamdaPlaceholder arg1 = null) {
            return Currying.DefaultTo(arg1);
        }

        public static dynamic DefaultTo<TArg1, TArg2>(TArg1 arg1, TArg2 arg2) {
            return Currying.DefaultTo(arg1, arg2);
        }

        public static dynamic Assoc(string memberName, object value, object target) {
            return Currying.Assoc(memberName, value, target);
        }

        public static dynamic Assoc(RamdaPlaceholder __, object value, object target) {
            return Currying.Assoc(__, value, target);
        }

        public static dynamic Assoc(string memberName, object value, RamdaPlaceholder target = null) {
            return Currying.Assoc(memberName, value, target);
        }

        public static dynamic DissocPath(IList<string> list) {
            return Currying.DissocPath(list);
        }

        public static dynamic DissocPath() {
            return Currying.DissocPath(__, __);
        }

        public static dynamic DissocPath(IList<string> list, object obj) {
            return Currying.DissocPath(list, obj);
        }

        public static dynamic DissocPath(RamdaPlaceholder __, object obj) {
            return Currying.DissocPath(__, obj);
        }

        public static dynamic DissocPath(IList<string> list, RamdaPlaceholder __) {
            return Currying.DissocPath(list, __);
        }

        public static dynamic Evolve(Dictionary<string, object> transformations, object target) {
            return Currying.Evolve(transformations, target);
        }

        public static dynamic Has(string member, object target) {
            return Currying.Has(member, target);
        }

        public static dynamic Has(string member, RamdaPlaceholder __ = null) {
            return Currying.Has(member, __);
        }

        public static dynamic Identical<TArg1, TArg2>(TArg1 arg1, TArg2 arg2) {
            return Currying.Identical(arg1, arg2);
        }

        public static dynamic IfElse(Delegate predicate, Delegate onTrue, Delegate onFalse) {
            return Currying.IfElse(predicate, onTrue, onFalse);
        }

        public static dynamic Gt<TArg1, TArg2>(TArg1 arg1, TArg2 arg2) {
            return Currying.Gt(arg1, arg2);
        }

        public static dynamic Gt<TArg1, TArg2>(TArg1 arg1, RamdaPlaceholder __ = null) {
            return Currying.Gt(arg1, __);
        }

        public static dynamic Intersperse<TValue>(object seperator, IList<TValue> list) {
            return Currying.Intersperse(seperator, list);
        }

        public static dynamic Is<TType>(object value) {
            return Currying.Is(typeof(TType), value);
        }

        public static dynamic Keys(object value) {
            return Currying.Keys(value);
        }

        public static dynamic Length<TValue>(IList<TValue> list) {
            return Currying.Length(list);
        }

        public static dynamic MapAccum(Func<dynamic, dynamic, Tuple<object, object>> fn, object acc, IList list) {
            return Currying.MapAccum(fn, acc, list);
        }

        public static dynamic MapAccumRight(Func<dynamic, dynamic, Tuple<object, object>> fn, object acc, IList list) {
            return Currying.MapAccumRight(fn, acc, list);
        }

        public static dynamic Match(Regex rx, string str) {
            return Currying.Match(rx, str);
        }

        public static dynamic Match(Regex rx, RamdaPlaceholder __ = null) {
            return Currying.Match(rx, __);
        }

        public static dynamic MathMod(int m, int p) {
            return Currying.MathMod(m, p);
        }

        public static dynamic MathMod(RamdaPlaceholder __, int p) {
            return Currying.MathMod(__, p);
        }

        public static dynamic MathMod(int m, RamdaPlaceholder __ = null) {
            return Currying.MathMod(m);
        }

        public static dynamic IsNil(object value) {
            return Currying.IsNil(value);
        }
    }
}
﻿namespace ExpressionReflect
{
	using System;
	using System.Linq.Expressions;

	public static class FuncExtensions
	{
		public static Func<TResult> Reflect<TResult>(this Expression<Func<TResult>> target)
		{
			Func<TResult> func = () => (TResult)target.Execute();
			return func;
		}

		public static Func<T, TResult> Reflect<T, TResult>(this Expression<Func<T, TResult>> target)
		{
			Func<T, TResult> func = a => (TResult)target.Execute(a);
			return func;
		}

		public static Func<T1, T2, TResult> Reflect<T1, T2, TResult>(this Expression<Func<T1, T2, TResult>> target)
		{
			Func<T1, T2, TResult> func = (a, b) => (TResult)target.Execute(a, b);
			return func;
		}

		public static Func<T1, T2, T3, TResult> Reflect<T1, T2, T3, TResult>(this Expression<Func<T1, T2, T3, TResult>> target)
		{
			Func<T1, T2, T3, TResult> func = (a, b, c) => (TResult)target.Execute(a, b, c);
			return func;
		}

		public static Func<T1, T2, T3, T4, TResult> Reflect<T1, T2, T3, T4, TResult>(this Expression<Func<T1, T2, T3, T4, TResult>> target)
		{
			Func<T1, T2, T3, T4, TResult> func = (a, b, c, d) => (TResult)target.Execute(a, b, c, d);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, TResult> Reflect<T1, T2, T3, T4, T5, TResult>(this Expression<Func<T1, T2, T3, T4, T5, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, TResult> func = (a, b, c, d, e) => (TResult)target.Execute(a, b, c, d, e);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, TResult> Reflect<T1, T2, T3, T4, T5, T6, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, TResult> func = (a, b, c, d, e, f) => (TResult)target.Execute(a, b, c, d, e, f);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, TResult> func = (a, b, c, d, e, f, g) => (TResult)target.Execute(a, b, c, d, e, f, g);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func = (a, b, c, d, e, f, g, h) => (TResult)target.Execute(a, b, c, d, e, f, g, h);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func = (a, b, c, d, e, f, g, h, i) => (TResult)target.Execute(a, b, c, d, e, f, g, h, i);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func = (a, b, c, d, e, f, g, h, i, j) => (TResult)target.Execute(a, b, c, d, e, f, g, h, i, j);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func = (a, b, c, d, e, f, g, h, i, j, k) => (TResult)target.Execute(a, b, c, d, e, f, g, h, i, j, k);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func = (a, b, c, d, e, f, g, h, i, j, k, l) => (TResult)target.Execute(a, b, c, d, e, f, g, h, i, j, k, l);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func = (a, b, c, d, e, f, g, h, i, j, k, l, m) => (TResult)target.Execute(a, b, c, d, e, f, g, h, i, j, k, l, m);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => (TResult)target.Execute(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => (TResult)target.Execute(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
			return func;
		}

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Reflect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> target)
		{
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => (TResult)target.Execute(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
			return func;
		}
	}
}
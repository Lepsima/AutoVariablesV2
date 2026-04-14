using System;
using AutoVariablesApp;
namespace Generated.Units {
public struct ForceAccel : IAutoUnit {
    public float x;
    
    public ForceAccel(float x) {
        this.x = x;
    }
    public static implicit operator float(ForceAccel v) => v.x;
    public ForceAccel magnitude => new(x);

    public float ToMillinewtons_Microsecond() => x * 0.001f;
    public static ForceAccel Millinewtons_Microsecond(float x) => new ForceAccel(x * 1000f);

    public float ToMillinewtons_Millisecond() => x * 1f;
    public static ForceAccel Millinewtons_Millisecond(float x) => new ForceAccel(x * 1f);

    public float ToMillinewtons_Second() => x * 1000f;
    public static ForceAccel Millinewtons_Second(float x) => new ForceAccel(x * 0.001f);

    public float ToMillinewtons_Minute() => x * 60000f;
    public static ForceAccel Millinewtons_Minute(float x) => new ForceAccel(x * 1.666666667E-05f);

    public float ToMillinewtons_Hour() => x * 3600000f;
    public static ForceAccel Millinewtons_Hour(float x) => new ForceAccel(x * 2.777777778E-07f);

    public float ToNewtons_Microsecond() => x * 1E-06f;
    public static ForceAccel Newtons_Microsecond(float x) => new ForceAccel(x * 1000000f);

    public float ToNewtons_Millisecond() => x * 0.001f;
    public static ForceAccel Newtons_Millisecond(float x) => new ForceAccel(x * 1000f);

    public float ToNewtons_Second() => x * 1f;
    public static ForceAccel Newtons_Second(float x) => new ForceAccel(x * 1f);

    public float ToNewtons_Minute() => x * 60f;
    public static ForceAccel Newtons_Minute(float x) => new ForceAccel(x * 0.01666666667f);

    public float ToNewtons_Hour() => x * 3600f;
    public static ForceAccel Newtons_Hour(float x) => new ForceAccel(x * 0.0002777777778f);

    public float ToKilonewtons_Microsecond() => x * 1E-09f;
    public static ForceAccel Kilonewtons_Microsecond(float x) => new ForceAccel(x * 1000000000f);

    public float ToKilonewtons_Millisecond() => x * 1E-06f;
    public static ForceAccel Kilonewtons_Millisecond(float x) => new ForceAccel(x * 1000000f);

    public float ToKilonewtons_Second() => x * 0.001f;
    public static ForceAccel Kilonewtons_Second(float x) => new ForceAccel(x * 1000f);

    public float ToKilonewtons_Minute() => x * 0.06f;
    public static ForceAccel Kilonewtons_Minute(float x) => new ForceAccel(x * 16.66666667f);

    public float ToKilonewtons_Hour() => x * 3.6f;
    public static ForceAccel Kilonewtons_Hour(float x) => new ForceAccel(x * 0.2777777778f);

    public float ToMeganewtons_Microsecond() => x * 1E-12f;
    public static ForceAccel Meganewtons_Microsecond(float x) => new ForceAccel(x * 1E+12f);

    public float ToMeganewtons_Millisecond() => x * 1E-09f;
    public static ForceAccel Meganewtons_Millisecond(float x) => new ForceAccel(x * 1000000000f);

    public float ToMeganewtons_Second() => x * 1E-06f;
    public static ForceAccel Meganewtons_Second(float x) => new ForceAccel(x * 1000000f);

    public float ToMeganewtons_Minute() => x * 6E-05f;
    public static ForceAccel Meganewtons_Minute(float x) => new ForceAccel(x * 16666.66667f);

    public float ToMeganewtons_Hour() => x * 0.0036f;
    public static ForceAccel Meganewtons_Hour(float x) => new ForceAccel(x * 277.7777778f);

    public static ForceAccel operator +(ForceAccel a, ForceAccel b) => new(a.x + b.x);
    public static ForceAccel operator -(ForceAccel a, ForceAccel b) => new(a.x - b.x);
    public static ForceAccel operator *(ForceAccel a, ForceAccel b) => new(a.x * b.x);
    public static ForceAccel operator /(ForceAccel a, ForceAccel b) => new(a.x / b.x);
    public Force Force(Time v) => new(v * x);
    public Time Time(Force v) => new(v / x);
    public ForceAccel(Force a, Time b) => a.ForceAccel(b);
    public ForceAccel(Time b, Force a) => a.ForceAccel(b);
}
}

using System;
using AutoVariablesApp;
namespace Generated.Units {
public struct ForceAccel2 : IAutoUnit2 {
    public float x, y;
    
    public ForceAccel2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public ForceAccel2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public static implicit operator Vector2(ForceAccel2 v) => new Vector2(v.x, v.y);
    public ForceAccel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToMillinewtons_Microsecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static ForceAccel2 Millinewtons_Microsecond(float x, float y) => new ForceAccel2(x * 1000f, y * 1000f);
    public static ForceAccel2 Millinewtons_Microsecond(Vector2 v) => new ForceAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillinewtons_Millisecond() => new Vector2(x * 1f, y * 1f);
    public static ForceAccel2 Millinewtons_Millisecond(float x, float y) => new ForceAccel2(x * 1f, y * 1f);
    public static ForceAccel2 Millinewtons_Millisecond(Vector2 v) => new ForceAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtons_Second() => new Vector2(x * 1000f, y * 1000f);
    public static ForceAccel2 Millinewtons_Second(float x, float y) => new ForceAccel2(x * 0.001f, y * 0.001f);
    public static ForceAccel2 Millinewtons_Second(Vector2 v) => new ForceAccel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtons_Minute() => new Vector2(x * 60000f, y * 60000f);
    public static ForceAccel2 Millinewtons_Minute(float x, float y) => new ForceAccel2(x * 1.666666667E-05f, y * 1.666666667E-05f);
    public static ForceAccel2 Millinewtons_Minute(Vector2 v) => new ForceAccel2(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f);

    public Vector2 ToMillinewtons_Hour() => new Vector2(x * 3600000f, y * 3600000f);
    public static ForceAccel2 Millinewtons_Hour(float x, float y) => new ForceAccel2(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static ForceAccel2 Millinewtons_Hour(Vector2 v) => new ForceAccel2(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToNewtons_Microsecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static ForceAccel2 Newtons_Microsecond(float x, float y) => new ForceAccel2(x * 1000000f, y * 1000000f);
    public static ForceAccel2 Newtons_Microsecond(Vector2 v) => new ForceAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToNewtons_Millisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static ForceAccel2 Newtons_Millisecond(float x, float y) => new ForceAccel2(x * 1000f, y * 1000f);
    public static ForceAccel2 Newtons_Millisecond(Vector2 v) => new ForceAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtons_Second() => new Vector2(x * 1f, y * 1f);
    public static ForceAccel2 Newtons_Second(float x, float y) => new ForceAccel2(x * 1f, y * 1f);
    public static ForceAccel2 Newtons_Second(Vector2 v) => new ForceAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtons_Minute() => new Vector2(x * 60f, y * 60f);
    public static ForceAccel2 Newtons_Minute(float x, float y) => new ForceAccel2(x * 0.01666666667f, y * 0.01666666667f);
    public static ForceAccel2 Newtons_Minute(Vector2 v) => new ForceAccel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToNewtons_Hour() => new Vector2(x * 3600f, y * 3600f);
    public static ForceAccel2 Newtons_Hour(float x, float y) => new ForceAccel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static ForceAccel2 Newtons_Hour(Vector2 v) => new ForceAccel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToKilonewtons_Microsecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static ForceAccel2 Kilonewtons_Microsecond(float x, float y) => new ForceAccel2(x * 1000000000f, y * 1000000000f);
    public static ForceAccel2 Kilonewtons_Microsecond(Vector2 v) => new ForceAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilonewtons_Millisecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static ForceAccel2 Kilonewtons_Millisecond(float x, float y) => new ForceAccel2(x * 1000000f, y * 1000000f);
    public static ForceAccel2 Kilonewtons_Millisecond(Vector2 v) => new ForceAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtons_Second() => new Vector2(x * 0.001f, y * 0.001f);
    public static ForceAccel2 Kilonewtons_Second(float x, float y) => new ForceAccel2(x * 1000f, y * 1000f);
    public static ForceAccel2 Kilonewtons_Second(Vector2 v) => new ForceAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtons_Minute() => new Vector2(x * 0.06f, y * 0.06f);
    public static ForceAccel2 Kilonewtons_Minute(float x, float y) => new ForceAccel2(x * 16.66666667f, y * 16.66666667f);
    public static ForceAccel2 Kilonewtons_Minute(Vector2 v) => new ForceAccel2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToKilonewtons_Hour() => new Vector2(x * 3.6f, y * 3.6f);
    public static ForceAccel2 Kilonewtons_Hour(float x, float y) => new ForceAccel2(x * 0.2777777778f, y * 0.2777777778f);
    public static ForceAccel2 Kilonewtons_Hour(Vector2 v) => new ForceAccel2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMeganewtons_Microsecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static ForceAccel2 Meganewtons_Microsecond(float x, float y) => new ForceAccel2(x * 1E+12f, y * 1E+12f);
    public static ForceAccel2 Meganewtons_Microsecond(Vector2 v) => new ForceAccel2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMeganewtons_Millisecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static ForceAccel2 Meganewtons_Millisecond(float x, float y) => new ForceAccel2(x * 1000000000f, y * 1000000000f);
    public static ForceAccel2 Meganewtons_Millisecond(Vector2 v) => new ForceAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtons_Second() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static ForceAccel2 Meganewtons_Second(float x, float y) => new ForceAccel2(x * 1000000f, y * 1000000f);
    public static ForceAccel2 Meganewtons_Second(Vector2 v) => new ForceAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtons_Minute() => new Vector2(x * 6E-05f, y * 6E-05f);
    public static ForceAccel2 Meganewtons_Minute(float x, float y) => new ForceAccel2(x * 16666.66667f, y * 16666.66667f);
    public static ForceAccel2 Meganewtons_Minute(Vector2 v) => new ForceAccel2(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMeganewtons_Hour() => new Vector2(x * 0.0036f, y * 0.0036f);
    public static ForceAccel2 Meganewtons_Hour(float x, float y) => new ForceAccel2(x * 277.7777778f, y * 277.7777778f);
    public static ForceAccel2 Meganewtons_Hour(Vector2 v) => new ForceAccel2(v.x * 277.7777778f, v.y * 277.7777778f);

    public static ForceAccel2 operator +(ForceAccel2 a, ForceAccel2 b) => new(a.x + b.x, a.y + b.y);
    public static ForceAccel2 operator -(ForceAccel2 a, ForceAccel2 b) => new(a.x - b.x, a.y - b.y);
    public static ForceAccel2 operator *(ForceAccel2 a, ForceAccel2 b) => new(a.x * b.x, a.y * b.y);
    public static ForceAccel2 operator /(ForceAccel2 a, ForceAccel2 b) => new(a.x / b.x, a.y / b.y);
    public Force2 Force2(Time v) => new(v * x, v * y);
    public Time Time(Force2 v) => new(v.magnitude / magnitude);
    public ForceAccel2(Force2 a, Time b) => a.ForceAccel2(b);
    public ForceAccel2(Time b, Force2 a) => a.ForceAccel2(b);
}
}

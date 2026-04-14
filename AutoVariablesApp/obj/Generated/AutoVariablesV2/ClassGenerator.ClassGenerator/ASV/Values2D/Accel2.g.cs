using System;
using AutoVariablesApp;
namespace Generated.Units {
public struct Accel2 : IAutoUnit2 {
    public float x, y;
    
    public Accel2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Accel2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public static implicit operator Vector2(Accel2 v) => new Vector2(v.x, v.y);
    public Accel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToMeterSeconds_Microsecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Accel2 MeterSeconds_Microsecond(float x, float y) => new Accel2(x * 1000000f, y * 1000000f);
    public static Accel2 MeterSeconds_Microsecond(Vector2 v) => new Accel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeterSeconds_Millisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 MeterSeconds_Millisecond(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 MeterSeconds_Millisecond(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeterSecond2() => new Vector2(x * 1f, y * 1f);
    public static Accel2 MeterSecond2(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 MeterSecond2(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMeterSeconds_Minute() => new Vector2(x * 60f, y * 60f);
    public static Accel2 MeterSeconds_Minute(float x, float y) => new Accel2(x * 0.01666666667f, y * 0.01666666667f);
    public static Accel2 MeterSeconds_Minute(Vector2 v) => new Accel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMeterSeconds_Hour() => new Vector2(x * 3600f, y * 3600f);
    public static Accel2 MeterSeconds_Hour(float x, float y) => new Accel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Accel2 MeterSeconds_Hour(Vector2 v) => new Accel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMillinewtons_Milligram() => new Vector2(x * 1000000000f, y * 1000000000f);
    public static Accel2 Millinewtons_Milligram(float x, float y) => new Accel2(x * 1E-09f, y * 1E-09f);
    public static Accel2 Millinewtons_Milligram(Vector2 v) => new Accel2(v.x * 1E-09f, v.y * 1E-09f);

    public Vector2 ToMillinewtons_Gram() => new Vector2(x * 1000000f, y * 1000000f);
    public static Accel2 Millinewtons_Gram(float x, float y) => new Accel2(x * 1E-06f, y * 1E-06f);
    public static Accel2 Millinewtons_Gram(Vector2 v) => new Accel2(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToMillinewtons_Kilogram() => new Vector2(x * 1000f, y * 1000f);
    public static Accel2 Millinewtons_Kilogram(float x, float y) => new Accel2(x * 0.001f, y * 0.001f);
    public static Accel2 Millinewtons_Kilogram(Vector2 v) => new Accel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtons_Ton() => new Vector2(x * 1f, y * 1f);
    public static Accel2 Millinewtons_Ton(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 Millinewtons_Ton(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtons_Kiloton() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 Millinewtons_Kiloton(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 Millinewtons_Kiloton(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtons_Milligram() => new Vector2(x * 1000000f, y * 1000000f);
    public static Accel2 Newtons_Milligram(float x, float y) => new Accel2(x * 1E-06f, y * 1E-06f);
    public static Accel2 Newtons_Milligram(Vector2 v) => new Accel2(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToNewtons_Gram() => new Vector2(x * 1000f, y * 1000f);
    public static Accel2 Newtons_Gram(float x, float y) => new Accel2(x * 0.001f, y * 0.001f);
    public static Accel2 Newtons_Gram(Vector2 v) => new Accel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToNewtons_Kilogram() => new Vector2(x * 1f, y * 1f);
    public static Accel2 Newtons_Kilogram(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 Newtons_Kilogram(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtons_Ton() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 Newtons_Ton(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 Newtons_Ton(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtons_Kiloton() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Accel2 Newtons_Kiloton(float x, float y) => new Accel2(x * 1000000f, y * 1000000f);
    public static Accel2 Newtons_Kiloton(Vector2 v) => new Accel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtons_Milligram() => new Vector2(x * 1000f, y * 1000f);
    public static Accel2 Kilonewtons_Milligram(float x, float y) => new Accel2(x * 0.001f, y * 0.001f);
    public static Accel2 Kilonewtons_Milligram(Vector2 v) => new Accel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToKilonewtons_Gram() => new Vector2(x * 1f, y * 1f);
    public static Accel2 Kilonewtons_Gram(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 Kilonewtons_Gram(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToKilonewtons_Kilogram() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 Kilonewtons_Kilogram(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 Kilonewtons_Kilogram(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtons_Ton() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Accel2 Kilonewtons_Ton(float x, float y) => new Accel2(x * 1000000f, y * 1000000f);
    public static Accel2 Kilonewtons_Ton(Vector2 v) => new Accel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtons_Kiloton() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Accel2 Kilonewtons_Kiloton(float x, float y) => new Accel2(x * 1000000000f, y * 1000000000f);
    public static Accel2 Kilonewtons_Kiloton(Vector2 v) => new Accel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtons_Milligram() => new Vector2(x * 1f, y * 1f);
    public static Accel2 Meganewtons_Milligram(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 Meganewtons_Milligram(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMeganewtons_Gram() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 Meganewtons_Gram(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 Meganewtons_Gram(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeganewtons_Kilogram() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Accel2 Meganewtons_Kilogram(float x, float y) => new Accel2(x * 1000000f, y * 1000000f);
    public static Accel2 Meganewtons_Kilogram(Vector2 v) => new Accel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtons_Ton() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Accel2 Meganewtons_Ton(float x, float y) => new Accel2(x * 1000000000f, y * 1000000000f);
    public static Accel2 Meganewtons_Ton(Vector2 v) => new Accel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtons_Kiloton() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static Accel2 Meganewtons_Kiloton(float x, float y) => new Accel2(x * 1E+12f, y * 1E+12f);
    public static Accel2 Meganewtons_Kiloton(Vector2 v) => new Accel2(v.x * 1E+12f, v.y * 1E+12f);

    public static Accel2 operator +(Accel2 a, Accel2 b) => new(a.x + b.x, a.y + b.y);
    public static Accel2 operator -(Accel2 a, Accel2 b) => new(a.x - b.x, a.y - b.y);
    public static Accel2 operator *(Accel2 a, Accel2 b) => new(a.x * b.x, a.y * b.y);
    public static Accel2 operator /(Accel2 a, Accel2 b) => new(a.x / b.x, a.y / b.y);
    public Velocity2 Velocity2(Time v) => new(v * x, v * y);
    public Time Time(Velocity2 v) => new(v.magnitude / magnitude);
    public Accel2(Velocity2 a, Time b) => a.Accel2(b);
    public Accel2(Time b, Velocity2 a) => a.Accel2(b);
    public Force2 Force2(Mass v) => new(v * x, v * y);
    public Mass Mass(Force2 v) => new(v.magnitude / magnitude);
    public Accel2(Force2 a, Mass b) => a.Accel2(b);
    public Accel2(Mass b, Force2 a) => a.Accel2(b);
}
}

using System;
using AutoVariablesApp;
namespace Generated.Units {
public struct Accel : IAutoUnit {
    public float x;
    
    public Accel(float x) {
        this.x = x;
    }
    public static implicit operator float(Accel v) => v.x;
    public Accel magnitude => new(x);

    public float ToMeterSeconds_Microsecond() => x * 1E-06f;
    public static Accel MeterSeconds_Microsecond(float x) => new Accel(x * 1000000f);

    public float ToMeterSeconds_Millisecond() => x * 0.001f;
    public static Accel MeterSeconds_Millisecond(float x) => new Accel(x * 1000f);

    public float ToMeterSecond2() => x * 1f;
    public static Accel MeterSecond2(float x) => new Accel(x * 1f);

    public float ToMeterSeconds_Minute() => x * 60f;
    public static Accel MeterSeconds_Minute(float x) => new Accel(x * 0.01666666667f);

    public float ToMeterSeconds_Hour() => x * 3600f;
    public static Accel MeterSeconds_Hour(float x) => new Accel(x * 0.0002777777778f);

    public float ToMillinewtons_Milligram() => x * 1000000000f;
    public static Accel Millinewtons_Milligram(float x) => new Accel(x * 1E-09f);

    public float ToMillinewtons_Gram() => x * 1000000f;
    public static Accel Millinewtons_Gram(float x) => new Accel(x * 1E-06f);

    public float ToMillinewtons_Kilogram() => x * 1000f;
    public static Accel Millinewtons_Kilogram(float x) => new Accel(x * 0.001f);

    public float ToMillinewtons_Ton() => x * 1f;
    public static Accel Millinewtons_Ton(float x) => new Accel(x * 1f);

    public float ToMillinewtons_Kiloton() => x * 0.001f;
    public static Accel Millinewtons_Kiloton(float x) => new Accel(x * 1000f);

    public float ToNewtons_Milligram() => x * 1000000f;
    public static Accel Newtons_Milligram(float x) => new Accel(x * 1E-06f);

    public float ToNewtons_Gram() => x * 1000f;
    public static Accel Newtons_Gram(float x) => new Accel(x * 0.001f);

    public float ToNewtons_Kilogram() => x * 1f;
    public static Accel Newtons_Kilogram(float x) => new Accel(x * 1f);

    public float ToNewtons_Ton() => x * 0.001f;
    public static Accel Newtons_Ton(float x) => new Accel(x * 1000f);

    public float ToNewtons_Kiloton() => x * 1E-06f;
    public static Accel Newtons_Kiloton(float x) => new Accel(x * 1000000f);

    public float ToKilonewtons_Milligram() => x * 1000f;
    public static Accel Kilonewtons_Milligram(float x) => new Accel(x * 0.001f);

    public float ToKilonewtons_Gram() => x * 1f;
    public static Accel Kilonewtons_Gram(float x) => new Accel(x * 1f);

    public float ToKilonewtons_Kilogram() => x * 0.001f;
    public static Accel Kilonewtons_Kilogram(float x) => new Accel(x * 1000f);

    public float ToKilonewtons_Ton() => x * 1E-06f;
    public static Accel Kilonewtons_Ton(float x) => new Accel(x * 1000000f);

    public float ToKilonewtons_Kiloton() => x * 1E-09f;
    public static Accel Kilonewtons_Kiloton(float x) => new Accel(x * 1000000000f);

    public float ToMeganewtons_Milligram() => x * 1f;
    public static Accel Meganewtons_Milligram(float x) => new Accel(x * 1f);

    public float ToMeganewtons_Gram() => x * 0.001f;
    public static Accel Meganewtons_Gram(float x) => new Accel(x * 1000f);

    public float ToMeganewtons_Kilogram() => x * 1E-06f;
    public static Accel Meganewtons_Kilogram(float x) => new Accel(x * 1000000f);

    public float ToMeganewtons_Ton() => x * 1E-09f;
    public static Accel Meganewtons_Ton(float x) => new Accel(x * 1000000000f);

    public float ToMeganewtons_Kiloton() => x * 1E-12f;
    public static Accel Meganewtons_Kiloton(float x) => new Accel(x * 1E+12f);

    public static Accel operator +(Accel a, Accel b) => new(a.x + b.x);
    public static Accel operator -(Accel a, Accel b) => new(a.x - b.x);
    public static Accel operator *(Accel a, Accel b) => new(a.x * b.x);
    public static Accel operator /(Accel a, Accel b) => new(a.x / b.x);
    public Velocity Velocity(Time v) => new(v * x);
    public Time Time(Velocity v) => new(v / x);
    public Accel(Velocity a, Time b) => a.Accel(b);
    public Accel(Time b, Velocity a) => a.Accel(b);
    public Force Force(Mass v) => new(v * x);
    public Mass Mass(Force v) => new(v / x);
    public Accel(Force a, Mass b) => a.Accel(b);
    public Accel(Mass b, Force a) => a.Accel(b);
}
}

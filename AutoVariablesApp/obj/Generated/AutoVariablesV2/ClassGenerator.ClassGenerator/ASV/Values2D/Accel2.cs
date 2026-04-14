using System;
using UnityEngine;

namespace Lepsima.ASV {
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

    public Vector2 vector => this;

    public static implicit operator Vector2(Accel2 v) => new Vector2(v.x, v.y);
    public Accel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToMeterSecondsPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Accel2 MeterSecondsPerMicrosecond(float x, float y) => new Accel2(x * 1000000f, y * 1000000f);
    public static Accel2 MeterSecondsPerMicrosecond(Vector2 v) => new Accel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeterSecondsPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 MeterSecondsPerMillisecond(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 MeterSecondsPerMillisecond(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeterSecond2() => new Vector2(x * 1f, y * 1f);
    public static Accel2 MeterSecond2(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 MeterSecond2(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMeterSecondsPerMinute() => new Vector2(x * 60f, y * 60f);
    public static Accel2 MeterSecondsPerMinute(float x, float y) => new Accel2(x * 0.01666666667f, y * 0.01666666667f);
    public static Accel2 MeterSecondsPerMinute(Vector2 v) => new Accel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMeterSecondsPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static Accel2 MeterSecondsPerHour(float x, float y) => new Accel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Accel2 MeterSecondsPerHour(Vector2 v) => new Accel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMillinewtonsPerMilligram() => new Vector2(x * 1000000000f, y * 1000000000f);
    public static Accel2 MillinewtonsPerMilligram(float x, float y) => new Accel2(x * 1E-09f, y * 1E-09f);
    public static Accel2 MillinewtonsPerMilligram(Vector2 v) => new Accel2(v.x * 1E-09f, v.y * 1E-09f);

    public Vector2 ToMillinewtonsPerGram() => new Vector2(x * 1000000f, y * 1000000f);
    public static Accel2 MillinewtonsPerGram(float x, float y) => new Accel2(x * 1E-06f, y * 1E-06f);
    public static Accel2 MillinewtonsPerGram(Vector2 v) => new Accel2(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToMillinewtonsPerKilogram() => new Vector2(x * 1000f, y * 1000f);
    public static Accel2 MillinewtonsPerKilogram(float x, float y) => new Accel2(x * 0.001f, y * 0.001f);
    public static Accel2 MillinewtonsPerKilogram(Vector2 v) => new Accel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtonsPerTon() => new Vector2(x * 1f, y * 1f);
    public static Accel2 MillinewtonsPerTon(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 MillinewtonsPerTon(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtonsPerKiloton() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 MillinewtonsPerKiloton(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 MillinewtonsPerKiloton(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerMilligram() => new Vector2(x * 1000000f, y * 1000000f);
    public static Accel2 NewtonsPerMilligram(float x, float y) => new Accel2(x * 1E-06f, y * 1E-06f);
    public static Accel2 NewtonsPerMilligram(Vector2 v) => new Accel2(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToNewtonsPerGram() => new Vector2(x * 1000f, y * 1000f);
    public static Accel2 NewtonsPerGram(float x, float y) => new Accel2(x * 0.001f, y * 0.001f);
    public static Accel2 NewtonsPerGram(Vector2 v) => new Accel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToNewtonsPerKilogram() => new Vector2(x * 1f, y * 1f);
    public static Accel2 NewtonsPerKilogram(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 NewtonsPerKilogram(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtonsPerTon() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 NewtonsPerTon(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 NewtonsPerTon(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerKiloton() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Accel2 NewtonsPerKiloton(float x, float y) => new Accel2(x * 1000000f, y * 1000000f);
    public static Accel2 NewtonsPerKiloton(Vector2 v) => new Accel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerMilligram() => new Vector2(x * 1000f, y * 1000f);
    public static Accel2 KilonewtonsPerMilligram(float x, float y) => new Accel2(x * 0.001f, y * 0.001f);
    public static Accel2 KilonewtonsPerMilligram(Vector2 v) => new Accel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToKilonewtonsPerGram() => new Vector2(x * 1f, y * 1f);
    public static Accel2 KilonewtonsPerGram(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 KilonewtonsPerGram(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToKilonewtonsPerKilogram() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 KilonewtonsPerKilogram(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 KilonewtonsPerKilogram(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtonsPerTon() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Accel2 KilonewtonsPerTon(float x, float y) => new Accel2(x * 1000000f, y * 1000000f);
    public static Accel2 KilonewtonsPerTon(Vector2 v) => new Accel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerKiloton() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Accel2 KilonewtonsPerKiloton(float x, float y) => new Accel2(x * 1000000000f, y * 1000000000f);
    public static Accel2 KilonewtonsPerKiloton(Vector2 v) => new Accel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerMilligram() => new Vector2(x * 1f, y * 1f);
    public static Accel2 MeganewtonsPerMilligram(float x, float y) => new Accel2(x * 1f, y * 1f);
    public static Accel2 MeganewtonsPerMilligram(Vector2 v) => new Accel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMeganewtonsPerGram() => new Vector2(x * 0.001f, y * 0.001f);
    public static Accel2 MeganewtonsPerGram(float x, float y) => new Accel2(x * 1000f, y * 1000f);
    public static Accel2 MeganewtonsPerGram(Vector2 v) => new Accel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeganewtonsPerKilogram() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Accel2 MeganewtonsPerKilogram(float x, float y) => new Accel2(x * 1000000f, y * 1000000f);
    public static Accel2 MeganewtonsPerKilogram(Vector2 v) => new Accel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtonsPerTon() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Accel2 MeganewtonsPerTon(float x, float y) => new Accel2(x * 1000000000f, y * 1000000000f);
    public static Accel2 MeganewtonsPerTon(Vector2 v) => new Accel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerKiloton() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static Accel2 MeganewtonsPerKiloton(float x, float y) => new Accel2(x * 1E+12f, y * 1E+12f);
    public static Accel2 MeganewtonsPerKiloton(Vector2 v) => new Accel2(v.x * 1E+12f, v.y * 1E+12f);

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

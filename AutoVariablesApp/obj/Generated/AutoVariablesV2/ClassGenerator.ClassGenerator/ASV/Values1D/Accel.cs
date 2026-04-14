using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Accel : IAutoUnit {
    public float x;
    
    public Accel(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(Accel v) => v.x;
    public Accel magnitude => new(x);

    public float ToMeterSecondsPerMicrosecond() => x * 1E-06f;
    public static Accel MeterSecondsPerMicrosecond(float x) => new Accel(x * 1000000f);

    public float ToMeterSecondsPerMillisecond() => x * 0.001f;
    public static Accel MeterSecondsPerMillisecond(float x) => new Accel(x * 1000f);

    public float ToMeterSecond2() => x * 1f;
    public static Accel MeterSecond2(float x) => new Accel(x * 1f);

    public float ToMeterSecondsPerMinute() => x * 60f;
    public static Accel MeterSecondsPerMinute(float x) => new Accel(x * 0.01666666667f);

    public float ToMeterSecondsPerHour() => x * 3600f;
    public static Accel MeterSecondsPerHour(float x) => new Accel(x * 0.0002777777778f);

    public float ToMillinewtonsPerMilligram() => x * 1000000000f;
    public static Accel MillinewtonsPerMilligram(float x) => new Accel(x * 1E-09f);

    public float ToMillinewtonsPerGram() => x * 1000000f;
    public static Accel MillinewtonsPerGram(float x) => new Accel(x * 1E-06f);

    public float ToMillinewtonsPerKilogram() => x * 1000f;
    public static Accel MillinewtonsPerKilogram(float x) => new Accel(x * 0.001f);

    public float ToMillinewtonsPerTon() => x * 1f;
    public static Accel MillinewtonsPerTon(float x) => new Accel(x * 1f);

    public float ToMillinewtonsPerKiloton() => x * 0.001f;
    public static Accel MillinewtonsPerKiloton(float x) => new Accel(x * 1000f);

    public float ToNewtonsPerMilligram() => x * 1000000f;
    public static Accel NewtonsPerMilligram(float x) => new Accel(x * 1E-06f);

    public float ToNewtonsPerGram() => x * 1000f;
    public static Accel NewtonsPerGram(float x) => new Accel(x * 0.001f);

    public float ToNewtonsPerKilogram() => x * 1f;
    public static Accel NewtonsPerKilogram(float x) => new Accel(x * 1f);

    public float ToNewtonsPerTon() => x * 0.001f;
    public static Accel NewtonsPerTon(float x) => new Accel(x * 1000f);

    public float ToNewtonsPerKiloton() => x * 1E-06f;
    public static Accel NewtonsPerKiloton(float x) => new Accel(x * 1000000f);

    public float ToKilonewtonsPerMilligram() => x * 1000f;
    public static Accel KilonewtonsPerMilligram(float x) => new Accel(x * 0.001f);

    public float ToKilonewtonsPerGram() => x * 1f;
    public static Accel KilonewtonsPerGram(float x) => new Accel(x * 1f);

    public float ToKilonewtonsPerKilogram() => x * 0.001f;
    public static Accel KilonewtonsPerKilogram(float x) => new Accel(x * 1000f);

    public float ToKilonewtonsPerTon() => x * 1E-06f;
    public static Accel KilonewtonsPerTon(float x) => new Accel(x * 1000000f);

    public float ToKilonewtonsPerKiloton() => x * 1E-09f;
    public static Accel KilonewtonsPerKiloton(float x) => new Accel(x * 1000000000f);

    public float ToMeganewtonsPerMilligram() => x * 1f;
    public static Accel MeganewtonsPerMilligram(float x) => new Accel(x * 1f);

    public float ToMeganewtonsPerGram() => x * 0.001f;
    public static Accel MeganewtonsPerGram(float x) => new Accel(x * 1000f);

    public float ToMeganewtonsPerKilogram() => x * 1E-06f;
    public static Accel MeganewtonsPerKilogram(float x) => new Accel(x * 1000000f);

    public float ToMeganewtonsPerTon() => x * 1E-09f;
    public static Accel MeganewtonsPerTon(float x) => new Accel(x * 1000000000f);

    public float ToMeganewtonsPerKiloton() => x * 1E-12f;
    public static Accel MeganewtonsPerKiloton(float x) => new Accel(x * 1E+12f);

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

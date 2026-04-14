using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct ForceAccel : IAutoUnit {
    public float x;
    
    public ForceAccel(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(ForceAccel v) => v.x;
    public ForceAccel magnitude => new(x);

    public float ToMillinewtonsPerMicrosecond() => x * 0.001f;
    public static ForceAccel MillinewtonsPerMicrosecond(float x) => new ForceAccel(x * 1000f);

    public float ToMillinewtonsPerMillisecond() => x * 1f;
    public static ForceAccel MillinewtonsPerMillisecond(float x) => new ForceAccel(x * 1f);

    public float ToMillinewtonsPerSecond() => x * 1000f;
    public static ForceAccel MillinewtonsPerSecond(float x) => new ForceAccel(x * 0.001f);

    public float ToMillinewtonsPerMinute() => x * 60000f;
    public static ForceAccel MillinewtonsPerMinute(float x) => new ForceAccel(x * 1.666666667E-05f);

    public float ToMillinewtonsPerHour() => x * 3600000f;
    public static ForceAccel MillinewtonsPerHour(float x) => new ForceAccel(x * 2.777777778E-07f);

    public float ToNewtonsPerMicrosecond() => x * 1E-06f;
    public static ForceAccel NewtonsPerMicrosecond(float x) => new ForceAccel(x * 1000000f);

    public float ToNewtonsPerMillisecond() => x * 0.001f;
    public static ForceAccel NewtonsPerMillisecond(float x) => new ForceAccel(x * 1000f);

    public float ToNewtonsPerSecond() => x * 1f;
    public static ForceAccel NewtonsPerSecond(float x) => new ForceAccel(x * 1f);

    public float ToNewtonsPerMinute() => x * 60f;
    public static ForceAccel NewtonsPerMinute(float x) => new ForceAccel(x * 0.01666666667f);

    public float ToNewtonsPerHour() => x * 3600f;
    public static ForceAccel NewtonsPerHour(float x) => new ForceAccel(x * 0.0002777777778f);

    public float ToKilonewtonsPerMicrosecond() => x * 1E-09f;
    public static ForceAccel KilonewtonsPerMicrosecond(float x) => new ForceAccel(x * 1000000000f);

    public float ToKilonewtonsPerMillisecond() => x * 1E-06f;
    public static ForceAccel KilonewtonsPerMillisecond(float x) => new ForceAccel(x * 1000000f);

    public float ToKilonewtonsPerSecond() => x * 0.001f;
    public static ForceAccel KilonewtonsPerSecond(float x) => new ForceAccel(x * 1000f);

    public float ToKilonewtonsPerMinute() => x * 0.06f;
    public static ForceAccel KilonewtonsPerMinute(float x) => new ForceAccel(x * 16.66666667f);

    public float ToKilonewtonsPerHour() => x * 3.6f;
    public static ForceAccel KilonewtonsPerHour(float x) => new ForceAccel(x * 0.2777777778f);

    public float ToMeganewtonsPerMicrosecond() => x * 1E-12f;
    public static ForceAccel MeganewtonsPerMicrosecond(float x) => new ForceAccel(x * 1E+12f);

    public float ToMeganewtonsPerMillisecond() => x * 1E-09f;
    public static ForceAccel MeganewtonsPerMillisecond(float x) => new ForceAccel(x * 1000000000f);

    public float ToMeganewtonsPerSecond() => x * 1E-06f;
    public static ForceAccel MeganewtonsPerSecond(float x) => new ForceAccel(x * 1000000f);

    public float ToMeganewtonsPerMinute() => x * 6E-05f;
    public static ForceAccel MeganewtonsPerMinute(float x) => new ForceAccel(x * 16666.66667f);

    public float ToMeganewtonsPerHour() => x * 0.0036f;
    public static ForceAccel MeganewtonsPerHour(float x) => new ForceAccel(x * 277.7777778f);

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

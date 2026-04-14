using System;
using UnityEngine;

namespace Lepsima.ASV {
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

    public Vector2 vector => this;

    public static implicit operator Vector2(ForceAccel2 v) => new Vector2(v.x, v.y);
    public ForceAccel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToMillinewtonsPerMicrosecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static ForceAccel2 MillinewtonsPerMicrosecond(float x, float y) => new ForceAccel2(x * 1000f, y * 1000f);
    public static ForceAccel2 MillinewtonsPerMicrosecond(Vector2 v) => new ForceAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillinewtonsPerMillisecond() => new Vector2(x * 1f, y * 1f);
    public static ForceAccel2 MillinewtonsPerMillisecond(float x, float y) => new ForceAccel2(x * 1f, y * 1f);
    public static ForceAccel2 MillinewtonsPerMillisecond(Vector2 v) => new ForceAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtonsPerSecond() => new Vector2(x * 1000f, y * 1000f);
    public static ForceAccel2 MillinewtonsPerSecond(float x, float y) => new ForceAccel2(x * 0.001f, y * 0.001f);
    public static ForceAccel2 MillinewtonsPerSecond(Vector2 v) => new ForceAccel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtonsPerMinute() => new Vector2(x * 60000f, y * 60000f);
    public static ForceAccel2 MillinewtonsPerMinute(float x, float y) => new ForceAccel2(x * 1.666666667E-05f, y * 1.666666667E-05f);
    public static ForceAccel2 MillinewtonsPerMinute(Vector2 v) => new ForceAccel2(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f);

    public Vector2 ToMillinewtonsPerHour() => new Vector2(x * 3600000f, y * 3600000f);
    public static ForceAccel2 MillinewtonsPerHour(float x, float y) => new ForceAccel2(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static ForceAccel2 MillinewtonsPerHour(Vector2 v) => new ForceAccel2(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToNewtonsPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static ForceAccel2 NewtonsPerMicrosecond(float x, float y) => new ForceAccel2(x * 1000000f, y * 1000000f);
    public static ForceAccel2 NewtonsPerMicrosecond(Vector2 v) => new ForceAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToNewtonsPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static ForceAccel2 NewtonsPerMillisecond(float x, float y) => new ForceAccel2(x * 1000f, y * 1000f);
    public static ForceAccel2 NewtonsPerMillisecond(Vector2 v) => new ForceAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerSecond() => new Vector2(x * 1f, y * 1f);
    public static ForceAccel2 NewtonsPerSecond(float x, float y) => new ForceAccel2(x * 1f, y * 1f);
    public static ForceAccel2 NewtonsPerSecond(Vector2 v) => new ForceAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtonsPerMinute() => new Vector2(x * 60f, y * 60f);
    public static ForceAccel2 NewtonsPerMinute(float x, float y) => new ForceAccel2(x * 0.01666666667f, y * 0.01666666667f);
    public static ForceAccel2 NewtonsPerMinute(Vector2 v) => new ForceAccel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToNewtonsPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static ForceAccel2 NewtonsPerHour(float x, float y) => new ForceAccel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static ForceAccel2 NewtonsPerHour(Vector2 v) => new ForceAccel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToKilonewtonsPerMicrosecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static ForceAccel2 KilonewtonsPerMicrosecond(float x, float y) => new ForceAccel2(x * 1000000000f, y * 1000000000f);
    public static ForceAccel2 KilonewtonsPerMicrosecond(Vector2 v) => new ForceAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilonewtonsPerMillisecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static ForceAccel2 KilonewtonsPerMillisecond(float x, float y) => new ForceAccel2(x * 1000000f, y * 1000000f);
    public static ForceAccel2 KilonewtonsPerMillisecond(Vector2 v) => new ForceAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerSecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static ForceAccel2 KilonewtonsPerSecond(float x, float y) => new ForceAccel2(x * 1000f, y * 1000f);
    public static ForceAccel2 KilonewtonsPerSecond(Vector2 v) => new ForceAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtonsPerMinute() => new Vector2(x * 0.06f, y * 0.06f);
    public static ForceAccel2 KilonewtonsPerMinute(float x, float y) => new ForceAccel2(x * 16.66666667f, y * 16.66666667f);
    public static ForceAccel2 KilonewtonsPerMinute(Vector2 v) => new ForceAccel2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToKilonewtonsPerHour() => new Vector2(x * 3.6f, y * 3.6f);
    public static ForceAccel2 KilonewtonsPerHour(float x, float y) => new ForceAccel2(x * 0.2777777778f, y * 0.2777777778f);
    public static ForceAccel2 KilonewtonsPerHour(Vector2 v) => new ForceAccel2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMeganewtonsPerMicrosecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static ForceAccel2 MeganewtonsPerMicrosecond(float x, float y) => new ForceAccel2(x * 1E+12f, y * 1E+12f);
    public static ForceAccel2 MeganewtonsPerMicrosecond(Vector2 v) => new ForceAccel2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMeganewtonsPerMillisecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static ForceAccel2 MeganewtonsPerMillisecond(float x, float y) => new ForceAccel2(x * 1000000000f, y * 1000000000f);
    public static ForceAccel2 MeganewtonsPerMillisecond(Vector2 v) => new ForceAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerSecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static ForceAccel2 MeganewtonsPerSecond(float x, float y) => new ForceAccel2(x * 1000000f, y * 1000000f);
    public static ForceAccel2 MeganewtonsPerSecond(Vector2 v) => new ForceAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtonsPerMinute() => new Vector2(x * 6E-05f, y * 6E-05f);
    public static ForceAccel2 MeganewtonsPerMinute(float x, float y) => new ForceAccel2(x * 16666.66667f, y * 16666.66667f);
    public static ForceAccel2 MeganewtonsPerMinute(Vector2 v) => new ForceAccel2(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMeganewtonsPerHour() => new Vector2(x * 0.0036f, y * 0.0036f);
    public static ForceAccel2 MeganewtonsPerHour(float x, float y) => new ForceAccel2(x * 277.7777778f, y * 277.7777778f);
    public static ForceAccel2 MeganewtonsPerHour(Vector2 v) => new ForceAccel2(v.x * 277.7777778f, v.y * 277.7777778f);

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

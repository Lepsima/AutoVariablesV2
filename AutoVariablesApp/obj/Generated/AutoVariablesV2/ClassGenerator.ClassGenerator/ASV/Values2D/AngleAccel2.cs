using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct AngleAccel2 : IAutoUnit2 {
    public float x, y;
    
    public AngleAccel2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public AngleAccel2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;

    public static implicit operator Vector2(AngleAccel2 v) => new Vector2(v.x, v.y);
    public AngleAccel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToDegreeSecondsPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static AngleAccel2 DegreeSecondsPerMicrosecond(float x, float y) => new AngleAccel2(x * 1000000f, y * 1000000f);
    public static AngleAccel2 DegreeSecondsPerMicrosecond(Vector2 v) => new AngleAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToDegreeSecondsPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static AngleAccel2 DegreeSecondsPerMillisecond(float x, float y) => new AngleAccel2(x * 1000f, y * 1000f);
    public static AngleAccel2 DegreeSecondsPerMillisecond(Vector2 v) => new AngleAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToDegreeSecond2() => new Vector2(x * 1f, y * 1f);
    public static AngleAccel2 DegreeSecond2(float x, float y) => new AngleAccel2(x * 1f, y * 1f);
    public static AngleAccel2 DegreeSecond2(Vector2 v) => new AngleAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToDegreeSecondsPerMinute() => new Vector2(x * 60f, y * 60f);
    public static AngleAccel2 DegreeSecondsPerMinute(float x, float y) => new AngleAccel2(x * 0.01666666667f, y * 0.01666666667f);
    public static AngleAccel2 DegreeSecondsPerMinute(Vector2 v) => new AngleAccel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToDegreeSecondsPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static AngleAccel2 DegreeSecondsPerHour(float x, float y) => new AngleAccel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleAccel2 DegreeSecondsPerHour(Vector2 v) => new AngleAccel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public static AngleAccel2 operator +(AngleAccel2 a, AngleAccel2 b) => new(a.x + b.x, a.y + b.y);
    public static AngleAccel2 operator -(AngleAccel2 a, AngleAccel2 b) => new(a.x - b.x, a.y - b.y);
    public static AngleAccel2 operator *(AngleAccel2 a, AngleAccel2 b) => new(a.x * b.x, a.y * b.y);
    public static AngleAccel2 operator /(AngleAccel2 a, AngleAccel2 b) => new(a.x / b.x, a.y / b.y);
    public AngleVel2 AngleVel2(Time v) => new(v * x, v * y);
    public Time Time(AngleVel2 v) => new(v.magnitude / magnitude);
    public AngleAccel2(AngleVel2 a, Time b) => a.AngleAccel2(b);
    public AngleAccel2(Time b, AngleVel2 a) => a.AngleAccel2(b);
}
}

using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct AngleAccel : IAutoUnit {
    public float x;
    
    public AngleAccel(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(AngleAccel v) => v.x;
    public AngleAccel magnitude => new(x);

    public float ToDegreeSecondsPerMicrosecond() => x * 1E-06f;
    public static AngleAccel DegreeSecondsPerMicrosecond(float x) => new AngleAccel(x * 1000000f);

    public float ToDegreeSecondsPerMillisecond() => x * 0.001f;
    public static AngleAccel DegreeSecondsPerMillisecond(float x) => new AngleAccel(x * 1000f);

    public float ToDegreeSecond2() => x * 1f;
    public static AngleAccel DegreeSecond2(float x) => new AngleAccel(x * 1f);

    public float ToDegreeSecondsPerMinute() => x * 60f;
    public static AngleAccel DegreeSecondsPerMinute(float x) => new AngleAccel(x * 0.01666666667f);

    public float ToDegreeSecondsPerHour() => x * 3600f;
    public static AngleAccel DegreeSecondsPerHour(float x) => new AngleAccel(x * 0.0002777777778f);

    public static AngleAccel operator +(AngleAccel a, AngleAccel b) => new(a.x + b.x);
    public static AngleAccel operator -(AngleAccel a, AngleAccel b) => new(a.x - b.x);
    public static AngleAccel operator *(AngleAccel a, AngleAccel b) => new(a.x * b.x);
    public static AngleAccel operator /(AngleAccel a, AngleAccel b) => new(a.x / b.x);
    public AngleVel AngleVel(Time v) => new(v * x);
    public Time Time(AngleVel v) => new(v / x);
    public AngleAccel(AngleVel a, Time b) => a.AngleAccel(b);
    public AngleAccel(Time b, AngleVel a) => a.AngleAccel(b);
}
}

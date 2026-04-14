using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct AngleVel : IAutoUnit {
    public float x;
    
    public AngleVel(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(AngleVel v) => v.x;
    public AngleVel magnitude => new(x);

    public float ToDegreesPerMicrosecond() => x * 1E-06f;
    public static AngleVel DegreesPerMicrosecond(float x) => new AngleVel(x * 1000000f);

    public float ToDegreesPerMillisecond() => x * 0.001f;
    public static AngleVel DegreesPerMillisecond(float x) => new AngleVel(x * 1000f);

    public float ToDegreesPerSecond() => x * 1f;
    public static AngleVel DegreesPerSecond(float x) => new AngleVel(x * 1f);

    public float ToDegreesPerMinute() => x * 60f;
    public static AngleVel DegreesPerMinute(float x) => new AngleVel(x * 0.01666666667f);

    public float ToDegreesPerHour() => x * 3600f;
    public static AngleVel DegreesPerHour(float x) => new AngleVel(x * 0.0002777777778f);

    public float ToRadiansPerMicrosecond() => x * 5.729577996E-05f;
    public static AngleVel RadiansPerMicrosecond(float x) => new AngleVel(x * 17453.29238f);

    public float ToRadiansPerMillisecond() => x * 0.05729577996f;
    public static AngleVel RadiansPerMillisecond(float x) => new AngleVel(x * 17.45329238f);

    public float ToRadiansPerSecond() => x * 57.29577996f;
    public static AngleVel RadiansPerSecond(float x) => new AngleVel(x * 0.01745329238f);

    public float ToRadiansPerMinute() => x * 3437.746797f;
    public static AngleVel RadiansPerMinute(float x) => new AngleVel(x * 0.0002908882064f);

    public float ToRadiansPerHour() => x * 206264.8078f;
    public static AngleVel RadiansPerHour(float x) => new AngleVel(x * 4.848136774E-06f);

    public float ToTurnsPerMicrosecond() => x * 2.777777778E-09f;
    public static AngleVel TurnsPerMicrosecond(float x) => new AngleVel(x * 360000000f);

    public float ToTurnsPerMillisecond() => x * 2.777777778E-06f;
    public static AngleVel TurnsPerMillisecond(float x) => new AngleVel(x * 360000f);

    public float ToTurnsPerSecond() => x * 0.002777777778f;
    public static AngleVel TurnsPerSecond(float x) => new AngleVel(x * 360f);

    public float ToTurnsPerMinute() => x * 0.1666666667f;
    public static AngleVel TurnsPerMinute(float x) => new AngleVel(x * 6f);

    public float ToTurnsPerHour() => x * 10f;
    public static AngleVel TurnsPerHour(float x) => new AngleVel(x * 0.1f);

    public float ToMinuteDegreesPerMicrosecond() => x * 6E-05f;
    public static AngleVel MinuteDegreesPerMicrosecond(float x) => new AngleVel(x * 16666.66667f);

    public float ToMinuteDegreesPerMillisecond() => x * 0.06f;
    public static AngleVel MinuteDegreesPerMillisecond(float x) => new AngleVel(x * 16.66666667f);

    public float ToMinuteDegreesPerSecond() => x * 60f;
    public static AngleVel MinuteDegreesPerSecond(float x) => new AngleVel(x * 0.01666666667f);

    public float ToMinuteDegreesPerMinute() => x * 3600f;
    public static AngleVel MinuteDegreesPerMinute(float x) => new AngleVel(x * 0.0002777777778f);

    public float ToMinuteDegreesPerHour() => x * 216000f;
    public static AngleVel MinuteDegreesPerHour(float x) => new AngleVel(x * 4.62962963E-06f);

    public float ToSecondDegreesPerMicrosecond() => x * 0.0036f;
    public static AngleVel SecondDegreesPerMicrosecond(float x) => new AngleVel(x * 277.7777778f);

    public float ToSecondDegreesPerMillisecond() => x * 3.6f;
    public static AngleVel SecondDegreesPerMillisecond(float x) => new AngleVel(x * 0.2777777778f);

    public float ToSecondDegreesPerSecond() => x * 3600f;
    public static AngleVel SecondDegreesPerSecond(float x) => new AngleVel(x * 0.0002777777778f);

    public float ToSecondDegreesPerMinute() => x * 216000f;
    public static AngleVel SecondDegreesPerMinute(float x) => new AngleVel(x * 4.62962963E-06f);

    public float ToSecondDegreesPerHour() => x * 12960000f;
    public static AngleVel SecondDegreesPerHour(float x) => new AngleVel(x * 7.716049383E-08f);

    public static AngleVel operator +(AngleVel a, AngleVel b) => new(a.x + b.x);
    public static AngleVel operator -(AngleVel a, AngleVel b) => new(a.x - b.x);
    public static AngleVel operator *(AngleVel a, AngleVel b) => new(a.x * b.x);
    public static AngleVel operator /(AngleVel a, AngleVel b) => new(a.x / b.x);
    public Angle Angle(Time v) => new(v * x);
    public Time Time(Angle v) => new(v / x);
    public AngleVel(Angle a, Time b) => a.AngleVel(b);
    public AngleVel(Time b, Angle a) => a.AngleVel(b);

    public static AngleVel operator +(AngleAccel a, AngleVel b) => b + a.AngleVel(VTime.deltaTime);
    public static AngleVel operator +(AngleVel b, AngleAccel a) => b + a.AngleVel(VTime.deltaTime);
    public static AngleVel operator -(AngleAccel a, AngleVel b) => a.AngleVel(VTime.deltaTime) - b;
    public static AngleVel operator -(AngleVel b, AngleAccel a) => b - a.AngleVel(VTime.deltaTime);
    
    public AngleAccel AngleAccel(Time v) => new(x / v);
    public Time Time(AngleAccel v) => new(x / v);
    public AngleVel(AngleAccel a, Time b) => a.AngleVel(b);
    public AngleVel(Time b, AngleAccel a) => a.AngleVel(b);
}
}

using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct AngleVel2 : IAutoUnit2 {
    public float x, y;
    
    public AngleVel2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public AngleVel2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;

    public static implicit operator Vector2(AngleVel2 v) => new Vector2(v.x, v.y);
    public AngleVel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToDegreesPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static AngleVel2 DegreesPerMicrosecond(float x, float y) => new AngleVel2(x * 1000000f, y * 1000000f);
    public static AngleVel2 DegreesPerMicrosecond(Vector2 v) => new AngleVel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToDegreesPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static AngleVel2 DegreesPerMillisecond(float x, float y) => new AngleVel2(x * 1000f, y * 1000f);
    public static AngleVel2 DegreesPerMillisecond(Vector2 v) => new AngleVel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToDegreesPerSecond() => new Vector2(x * 1f, y * 1f);
    public static AngleVel2 DegreesPerSecond(float x, float y) => new AngleVel2(x * 1f, y * 1f);
    public static AngleVel2 DegreesPerSecond(Vector2 v) => new AngleVel2(v.x * 1f, v.y * 1f);

    public Vector2 ToDegreesPerMinute() => new Vector2(x * 60f, y * 60f);
    public static AngleVel2 DegreesPerMinute(float x, float y) => new AngleVel2(x * 0.01666666667f, y * 0.01666666667f);
    public static AngleVel2 DegreesPerMinute(Vector2 v) => new AngleVel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToDegreesPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static AngleVel2 DegreesPerHour(float x, float y) => new AngleVel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleVel2 DegreesPerHour(Vector2 v) => new AngleVel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToRadiansPerMicrosecond() => new Vector2(x * 5.729577996E-05f, y * 5.729577996E-05f);
    public static AngleVel2 RadiansPerMicrosecond(float x, float y) => new AngleVel2(x * 17453.29238f, y * 17453.29238f);
    public static AngleVel2 RadiansPerMicrosecond(Vector2 v) => new AngleVel2(v.x * 17453.29238f, v.y * 17453.29238f);

    public Vector2 ToRadiansPerMillisecond() => new Vector2(x * 0.05729577996f, y * 0.05729577996f);
    public static AngleVel2 RadiansPerMillisecond(float x, float y) => new AngleVel2(x * 17.45329238f, y * 17.45329238f);
    public static AngleVel2 RadiansPerMillisecond(Vector2 v) => new AngleVel2(v.x * 17.45329238f, v.y * 17.45329238f);

    public Vector2 ToRadiansPerSecond() => new Vector2(x * 57.29577996f, y * 57.29577996f);
    public static AngleVel2 RadiansPerSecond(float x, float y) => new AngleVel2(x * 0.01745329238f, y * 0.01745329238f);
    public static AngleVel2 RadiansPerSecond(Vector2 v) => new AngleVel2(v.x * 0.01745329238f, v.y * 0.01745329238f);

    public Vector2 ToRadiansPerMinute() => new Vector2(x * 3437.746797f, y * 3437.746797f);
    public static AngleVel2 RadiansPerMinute(float x, float y) => new AngleVel2(x * 0.0002908882064f, y * 0.0002908882064f);
    public static AngleVel2 RadiansPerMinute(Vector2 v) => new AngleVel2(v.x * 0.0002908882064f, v.y * 0.0002908882064f);

    public Vector2 ToRadiansPerHour() => new Vector2(x * 206264.8078f, y * 206264.8078f);
    public static AngleVel2 RadiansPerHour(float x, float y) => new AngleVel2(x * 4.848136774E-06f, y * 4.848136774E-06f);
    public static AngleVel2 RadiansPerHour(Vector2 v) => new AngleVel2(v.x * 4.848136774E-06f, v.y * 4.848136774E-06f);

    public Vector2 ToTurnsPerMicrosecond() => new Vector2(x * 2.777777778E-09f, y * 2.777777778E-09f);
    public static AngleVel2 TurnsPerMicrosecond(float x, float y) => new AngleVel2(x * 360000000f, y * 360000000f);
    public static AngleVel2 TurnsPerMicrosecond(Vector2 v) => new AngleVel2(v.x * 360000000f, v.y * 360000000f);

    public Vector2 ToTurnsPerMillisecond() => new Vector2(x * 2.777777778E-06f, y * 2.777777778E-06f);
    public static AngleVel2 TurnsPerMillisecond(float x, float y) => new AngleVel2(x * 360000f, y * 360000f);
    public static AngleVel2 TurnsPerMillisecond(Vector2 v) => new AngleVel2(v.x * 360000f, v.y * 360000f);

    public Vector2 ToTurnsPerSecond() => new Vector2(x * 0.002777777778f, y * 0.002777777778f);
    public static AngleVel2 TurnsPerSecond(float x, float y) => new AngleVel2(x * 360f, y * 360f);
    public static AngleVel2 TurnsPerSecond(Vector2 v) => new AngleVel2(v.x * 360f, v.y * 360f);

    public Vector2 ToTurnsPerMinute() => new Vector2(x * 0.1666666667f, y * 0.1666666667f);
    public static AngleVel2 TurnsPerMinute(float x, float y) => new AngleVel2(x * 6f, y * 6f);
    public static AngleVel2 TurnsPerMinute(Vector2 v) => new AngleVel2(v.x * 6f, v.y * 6f);

    public Vector2 ToTurnsPerHour() => new Vector2(x * 10f, y * 10f);
    public static AngleVel2 TurnsPerHour(float x, float y) => new AngleVel2(x * 0.1f, y * 0.1f);
    public static AngleVel2 TurnsPerHour(Vector2 v) => new AngleVel2(v.x * 0.1f, v.y * 0.1f);

    public Vector2 ToMinuteDegreesPerMicrosecond() => new Vector2(x * 6E-05f, y * 6E-05f);
    public static AngleVel2 MinuteDegreesPerMicrosecond(float x, float y) => new AngleVel2(x * 16666.66667f, y * 16666.66667f);
    public static AngleVel2 MinuteDegreesPerMicrosecond(Vector2 v) => new AngleVel2(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMinuteDegreesPerMillisecond() => new Vector2(x * 0.06f, y * 0.06f);
    public static AngleVel2 MinuteDegreesPerMillisecond(float x, float y) => new AngleVel2(x * 16.66666667f, y * 16.66666667f);
    public static AngleVel2 MinuteDegreesPerMillisecond(Vector2 v) => new AngleVel2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToMinuteDegreesPerSecond() => new Vector2(x * 60f, y * 60f);
    public static AngleVel2 MinuteDegreesPerSecond(float x, float y) => new AngleVel2(x * 0.01666666667f, y * 0.01666666667f);
    public static AngleVel2 MinuteDegreesPerSecond(Vector2 v) => new AngleVel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMinuteDegreesPerMinute() => new Vector2(x * 3600f, y * 3600f);
    public static AngleVel2 MinuteDegreesPerMinute(float x, float y) => new AngleVel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleVel2 MinuteDegreesPerMinute(Vector2 v) => new AngleVel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMinuteDegreesPerHour() => new Vector2(x * 216000f, y * 216000f);
    public static AngleVel2 MinuteDegreesPerHour(float x, float y) => new AngleVel2(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static AngleVel2 MinuteDegreesPerHour(Vector2 v) => new AngleVel2(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToSecondDegreesPerMicrosecond() => new Vector2(x * 0.0036f, y * 0.0036f);
    public static AngleVel2 SecondDegreesPerMicrosecond(float x, float y) => new AngleVel2(x * 277.7777778f, y * 277.7777778f);
    public static AngleVel2 SecondDegreesPerMicrosecond(Vector2 v) => new AngleVel2(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToSecondDegreesPerMillisecond() => new Vector2(x * 3.6f, y * 3.6f);
    public static AngleVel2 SecondDegreesPerMillisecond(float x, float y) => new AngleVel2(x * 0.2777777778f, y * 0.2777777778f);
    public static AngleVel2 SecondDegreesPerMillisecond(Vector2 v) => new AngleVel2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToSecondDegreesPerSecond() => new Vector2(x * 3600f, y * 3600f);
    public static AngleVel2 SecondDegreesPerSecond(float x, float y) => new AngleVel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleVel2 SecondDegreesPerSecond(Vector2 v) => new AngleVel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToSecondDegreesPerMinute() => new Vector2(x * 216000f, y * 216000f);
    public static AngleVel2 SecondDegreesPerMinute(float x, float y) => new AngleVel2(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static AngleVel2 SecondDegreesPerMinute(Vector2 v) => new AngleVel2(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToSecondDegreesPerHour() => new Vector2(x * 12960000f, y * 12960000f);
    public static AngleVel2 SecondDegreesPerHour(float x, float y) => new AngleVel2(x * 7.716049383E-08f, y * 7.716049383E-08f);
    public static AngleVel2 SecondDegreesPerHour(Vector2 v) => new AngleVel2(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f);

    public static AngleVel2 operator +(AngleVel2 a, AngleVel2 b) => new(a.x + b.x, a.y + b.y);
    public static AngleVel2 operator -(AngleVel2 a, AngleVel2 b) => new(a.x - b.x, a.y - b.y);
    public static AngleVel2 operator *(AngleVel2 a, AngleVel2 b) => new(a.x * b.x, a.y * b.y);
    public static AngleVel2 operator /(AngleVel2 a, AngleVel2 b) => new(a.x / b.x, a.y / b.y);
    public Angle2 Angle2(Time v) => new(v * x, v * y);
    public Time Time(Angle2 v) => new(v.magnitude / magnitude);
    public AngleVel2(Angle2 a, Time b) => a.AngleVel2(b);
    public AngleVel2(Time b, Angle2 a) => a.AngleVel2(b);

    public static AngleVel2 operator +(AngleAccel2 a, AngleVel2 b) => b + a.AngleVel2(VTime.deltaTime);
    public static AngleVel2 operator +(AngleVel2 b, AngleAccel2 a) => b + a.AngleVel2(VTime.deltaTime);
    public static AngleVel2 operator -(AngleAccel2 a, AngleVel2 b) => a.AngleVel2(VTime.deltaTime) - b;
    public static AngleVel2 operator -(AngleVel2 b, AngleAccel2 a) => b - a.AngleVel2(VTime.deltaTime);
    
    public AngleAccel2 AngleAccel2(Time v) => new(x / v, y / v);
    public Time Time(AngleAccel2 v) => new(magnitude / v.magnitude);
    public AngleVel2(AngleAccel2 a, Time b) => a.AngleVel2(b);
    public AngleVel2(Time b, AngleAccel2 a) => a.AngleVel2(b);
}
}

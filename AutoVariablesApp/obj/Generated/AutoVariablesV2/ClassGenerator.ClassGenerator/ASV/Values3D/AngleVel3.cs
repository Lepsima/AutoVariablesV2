using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct AngleVel3 : IAutoUnit3 {
    public float x, y, z;
    
    public AngleVel3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public AngleVel3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    
    public static implicit operator Vector3(AngleVel3 v) => new Vector3(v.x, v.y, v.z);
    public AngleVel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToDegreesPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleVel3 DegreesPerMicrosecond(float x, float y, float z) => new AngleVel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleVel3 DegreesPerMicrosecond(Vector3 v) => new AngleVel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToDegreesPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleVel3 DegreesPerMillisecond(float x, float y, float z) => new AngleVel3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleVel3 DegreesPerMillisecond(Vector3 v) => new AngleVel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToDegreesPerSecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static AngleVel3 DegreesPerSecond(float x, float y, float z) => new AngleVel3(x * 1f, y * 1f, z * 1f);
    public static AngleVel3 DegreesPerSecond(Vector3 v) => new AngleVel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToDegreesPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static AngleVel3 DegreesPerMinute(float x, float y, float z) => new AngleVel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static AngleVel3 DegreesPerMinute(Vector3 v) => new AngleVel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToDegreesPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleVel3 DegreesPerHour(float x, float y, float z) => new AngleVel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleVel3 DegreesPerHour(Vector3 v) => new AngleVel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToRadiansPerMicrosecond() => new Vector3(x * 5.729577996E-05f, y * 5.729577996E-05f, z * 5.729577996E-05f);
    public static AngleVel3 RadiansPerMicrosecond(float x, float y, float z) => new AngleVel3(x * 17453.29238f, y * 17453.29238f, z * 17453.29238f);
    public static AngleVel3 RadiansPerMicrosecond(Vector3 v) => new AngleVel3(v.x * 17453.29238f, v.y * 17453.29238f, v.z * 17453.29238f);

    public Vector3 ToRadiansPerMillisecond() => new Vector3(x * 0.05729577996f, y * 0.05729577996f, z * 0.05729577996f);
    public static AngleVel3 RadiansPerMillisecond(float x, float y, float z) => new AngleVel3(x * 17.45329238f, y * 17.45329238f, z * 17.45329238f);
    public static AngleVel3 RadiansPerMillisecond(Vector3 v) => new AngleVel3(v.x * 17.45329238f, v.y * 17.45329238f, v.z * 17.45329238f);

    public Vector3 ToRadiansPerSecond() => new Vector3(x * 57.29577996f, y * 57.29577996f, z * 57.29577996f);
    public static AngleVel3 RadiansPerSecond(float x, float y, float z) => new AngleVel3(x * 0.01745329238f, y * 0.01745329238f, z * 0.01745329238f);
    public static AngleVel3 RadiansPerSecond(Vector3 v) => new AngleVel3(v.x * 0.01745329238f, v.y * 0.01745329238f, v.z * 0.01745329238f);

    public Vector3 ToRadiansPerMinute() => new Vector3(x * 3437.746797f, y * 3437.746797f, z * 3437.746797f);
    public static AngleVel3 RadiansPerMinute(float x, float y, float z) => new AngleVel3(x * 0.0002908882064f, y * 0.0002908882064f, z * 0.0002908882064f);
    public static AngleVel3 RadiansPerMinute(Vector3 v) => new AngleVel3(v.x * 0.0002908882064f, v.y * 0.0002908882064f, v.z * 0.0002908882064f);

    public Vector3 ToRadiansPerHour() => new Vector3(x * 206264.8078f, y * 206264.8078f, z * 206264.8078f);
    public static AngleVel3 RadiansPerHour(float x, float y, float z) => new AngleVel3(x * 4.848136774E-06f, y * 4.848136774E-06f, z * 4.848136774E-06f);
    public static AngleVel3 RadiansPerHour(Vector3 v) => new AngleVel3(v.x * 4.848136774E-06f, v.y * 4.848136774E-06f, v.z * 4.848136774E-06f);

    public Vector3 ToTurnsPerMicrosecond() => new Vector3(x * 2.777777778E-09f, y * 2.777777778E-09f, z * 2.777777778E-09f);
    public static AngleVel3 TurnsPerMicrosecond(float x, float y, float z) => new AngleVel3(x * 360000000f, y * 360000000f, z * 360000000f);
    public static AngleVel3 TurnsPerMicrosecond(Vector3 v) => new AngleVel3(v.x * 360000000f, v.y * 360000000f, v.z * 360000000f);

    public Vector3 ToTurnsPerMillisecond() => new Vector3(x * 2.777777778E-06f, y * 2.777777778E-06f, z * 2.777777778E-06f);
    public static AngleVel3 TurnsPerMillisecond(float x, float y, float z) => new AngleVel3(x * 360000f, y * 360000f, z * 360000f);
    public static AngleVel3 TurnsPerMillisecond(Vector3 v) => new AngleVel3(v.x * 360000f, v.y * 360000f, v.z * 360000f);

    public Vector3 ToTurnsPerSecond() => new Vector3(x * 0.002777777778f, y * 0.002777777778f, z * 0.002777777778f);
    public static AngleVel3 TurnsPerSecond(float x, float y, float z) => new AngleVel3(x * 360f, y * 360f, z * 360f);
    public static AngleVel3 TurnsPerSecond(Vector3 v) => new AngleVel3(v.x * 360f, v.y * 360f, v.z * 360f);

    public Vector3 ToTurnsPerMinute() => new Vector3(x * 0.1666666667f, y * 0.1666666667f, z * 0.1666666667f);
    public static AngleVel3 TurnsPerMinute(float x, float y, float z) => new AngleVel3(x * 6f, y * 6f, z * 6f);
    public static AngleVel3 TurnsPerMinute(Vector3 v) => new AngleVel3(v.x * 6f, v.y * 6f, v.z * 6f);

    public Vector3 ToTurnsPerHour() => new Vector3(x * 10f, y * 10f, z * 10f);
    public static AngleVel3 TurnsPerHour(float x, float y, float z) => new AngleVel3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static AngleVel3 TurnsPerHour(Vector3 v) => new AngleVel3(v.x * 0.1f, v.y * 0.1f, v.z * 0.1f);

    public Vector3 ToMinuteDegreesPerMicrosecond() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static AngleVel3 MinuteDegreesPerMicrosecond(float x, float y, float z) => new AngleVel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static AngleVel3 MinuteDegreesPerMicrosecond(Vector3 v) => new AngleVel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMinuteDegreesPerMillisecond() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static AngleVel3 MinuteDegreesPerMillisecond(float x, float y, float z) => new AngleVel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static AngleVel3 MinuteDegreesPerMillisecond(Vector3 v) => new AngleVel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToMinuteDegreesPerSecond() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static AngleVel3 MinuteDegreesPerSecond(float x, float y, float z) => new AngleVel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static AngleVel3 MinuteDegreesPerSecond(Vector3 v) => new AngleVel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMinuteDegreesPerMinute() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleVel3 MinuteDegreesPerMinute(float x, float y, float z) => new AngleVel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleVel3 MinuteDegreesPerMinute(Vector3 v) => new AngleVel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMinuteDegreesPerHour() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static AngleVel3 MinuteDegreesPerHour(float x, float y, float z) => new AngleVel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static AngleVel3 MinuteDegreesPerHour(Vector3 v) => new AngleVel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToSecondDegreesPerMicrosecond() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static AngleVel3 SecondDegreesPerMicrosecond(float x, float y, float z) => new AngleVel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static AngleVel3 SecondDegreesPerMicrosecond(Vector3 v) => new AngleVel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToSecondDegreesPerMillisecond() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static AngleVel3 SecondDegreesPerMillisecond(float x, float y, float z) => new AngleVel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static AngleVel3 SecondDegreesPerMillisecond(Vector3 v) => new AngleVel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToSecondDegreesPerSecond() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleVel3 SecondDegreesPerSecond(float x, float y, float z) => new AngleVel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleVel3 SecondDegreesPerSecond(Vector3 v) => new AngleVel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToSecondDegreesPerMinute() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static AngleVel3 SecondDegreesPerMinute(float x, float y, float z) => new AngleVel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static AngleVel3 SecondDegreesPerMinute(Vector3 v) => new AngleVel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToSecondDegreesPerHour() => new Vector3(x * 12960000f, y * 12960000f, z * 12960000f);
    public static AngleVel3 SecondDegreesPerHour(float x, float y, float z) => new AngleVel3(x * 7.716049383E-08f, y * 7.716049383E-08f, z * 7.716049383E-08f);
    public static AngleVel3 SecondDegreesPerHour(Vector3 v) => new AngleVel3(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f, v.z * 7.716049383E-08f);

    public static AngleVel3 operator +(AngleVel3 a, AngleVel3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static AngleVel3 operator -(AngleVel3 a, AngleVel3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    
    public static AngleVel3 operator *(AngleVel3 a, AngleVel3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static AngleVel3 operator /(AngleVel3 a, AngleVel3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    
    public Angle3 Angle3(Time v) => new(v * x, v * y, v * z);
    public Time Time(Angle3 v) => new(v.magnitude / magnitude);

    public AngleVel3(Angle3 a, Time b) => a.AngleVel3(b);
    public AngleVel3(Time b, Angle3 a) => a.AngleVel3(b);

    public static AngleVel3 operator +(AngleAccel3 a, AngleVel3 b) => b + a.AngleVel3(VTime.deltaTime);
    public static AngleVel3 operator +(AngleVel3 b, AngleAccel3 a) => b + a.AngleVel3(VTime.deltaTime);
    public static AngleVel3 operator -(AngleAccel3 a, AngleVel3 b) => a.AngleVel3(VTime.deltaTime) - b;
    public static AngleVel3 operator -(AngleVel3 b, AngleAccel3 a) => b - a.AngleVel3(VTime.deltaTime);
    
    public AngleAccel3 AngleAccel3(Time v) => new(x / v, y / v, z / v);
    public Time Time(AngleAccel3 v) => new(magnitude / v.magnitude);

    public AngleVel3(AngleAccel3 a, Time b) => a.AngleVel3(b);
    public AngleVel3(Time b, AngleAccel3 a) => a.AngleVel3(b);

}
}

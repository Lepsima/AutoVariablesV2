using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct AngleAccel3 : IAutoUnit3 {
    public float x, y, z;
    
    public AngleAccel3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public AngleAccel3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    
    public static implicit operator Vector3(AngleAccel3 v) => new Vector3(v.x, v.y, v.z);
    public AngleAccel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToDegreeSecondsPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleAccel3 DegreeSecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleAccel3 DegreeSecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToDegreeSecondsPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 DegreeSecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 DegreeSecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToDegreeSecond2() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 DegreeSecond2(float x, float y, float z) => new AngleAccel3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 DegreeSecond2(Vector3 v) => new AngleAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToDegreeSecondsPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static AngleAccel3 DegreeSecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static AngleAccel3 DegreeSecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToDegreeSecondsPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleAccel3 DegreeSecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleAccel3 DegreeSecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public static AngleAccel3 operator +(AngleAccel3 a, AngleAccel3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static AngleAccel3 operator -(AngleAccel3 a, AngleAccel3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    public static AngleAccel3 operator *(AngleAccel3 a, AngleAccel3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static AngleAccel3 operator /(AngleAccel3 a, AngleAccel3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    public AngleVel3 AngleVel3(Time v) => new(v * x, v * y, v * z);
    public Time Time(AngleVel3 v) => new(v.magnitude / magnitude);
    public AngleAccel3(AngleVel3 a, Time b) => a.AngleAccel3(b);
    public AngleAccel3(Time b, AngleVel3 a) => a.AngleAccel3(b);
}
}

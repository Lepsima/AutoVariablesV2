using System;
using AutoVariablesApp;
namespace Generated.Units {
public struct ForceAccel3 : IAutoUnit3 {
    public float x, y, z;
    
    public ForceAccel3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public ForceAccel3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public static implicit operator Vector3(ForceAccel3 v) => new Vector3(v.x, v.y, v.z);
    public ForceAccel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToMillinewtons_Microsecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static ForceAccel3 Millinewtons_Microsecond(float x, float y, float z) => new ForceAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static ForceAccel3 Millinewtons_Microsecond(Vector3 v) => new ForceAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillinewtons_Millisecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static ForceAccel3 Millinewtons_Millisecond(float x, float y, float z) => new ForceAccel3(x * 1f, y * 1f, z * 1f);
    public static ForceAccel3 Millinewtons_Millisecond(Vector3 v) => new ForceAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtons_Second() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static ForceAccel3 Millinewtons_Second(float x, float y, float z) => new ForceAccel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static ForceAccel3 Millinewtons_Second(Vector3 v) => new ForceAccel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillinewtons_Minute() => new Vector3(x * 60000f, y * 60000f, z * 60000f);
    public static ForceAccel3 Millinewtons_Minute(float x, float y, float z) => new ForceAccel3(x * 1.666666667E-05f, y * 1.666666667E-05f, z * 1.666666667E-05f);
    public static ForceAccel3 Millinewtons_Minute(Vector3 v) => new ForceAccel3(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f, v.z * 1.666666667E-05f);

    public Vector3 ToMillinewtons_Hour() => new Vector3(x * 3600000f, y * 3600000f, z * 3600000f);
    public static ForceAccel3 Millinewtons_Hour(float x, float y, float z) => new ForceAccel3(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static ForceAccel3 Millinewtons_Hour(Vector3 v) => new ForceAccel3(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToNewtons_Microsecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static ForceAccel3 Newtons_Microsecond(float x, float y, float z) => new ForceAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static ForceAccel3 Newtons_Microsecond(Vector3 v) => new ForceAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToNewtons_Millisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static ForceAccel3 Newtons_Millisecond(float x, float y, float z) => new ForceAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static ForceAccel3 Newtons_Millisecond(Vector3 v) => new ForceAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtons_Second() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static ForceAccel3 Newtons_Second(float x, float y, float z) => new ForceAccel3(x * 1f, y * 1f, z * 1f);
    public static ForceAccel3 Newtons_Second(Vector3 v) => new ForceAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToNewtons_Minute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static ForceAccel3 Newtons_Minute(float x, float y, float z) => new ForceAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static ForceAccel3 Newtons_Minute(Vector3 v) => new ForceAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToNewtons_Hour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static ForceAccel3 Newtons_Hour(float x, float y, float z) => new ForceAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static ForceAccel3 Newtons_Hour(Vector3 v) => new ForceAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToKilonewtons_Microsecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static ForceAccel3 Kilonewtons_Microsecond(float x, float y, float z) => new ForceAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static ForceAccel3 Kilonewtons_Microsecond(Vector3 v) => new ForceAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilonewtons_Millisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static ForceAccel3 Kilonewtons_Millisecond(float x, float y, float z) => new ForceAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static ForceAccel3 Kilonewtons_Millisecond(Vector3 v) => new ForceAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtons_Second() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static ForceAccel3 Kilonewtons_Second(float x, float y, float z) => new ForceAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static ForceAccel3 Kilonewtons_Second(Vector3 v) => new ForceAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilonewtons_Minute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static ForceAccel3 Kilonewtons_Minute(float x, float y, float z) => new ForceAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static ForceAccel3 Kilonewtons_Minute(Vector3 v) => new ForceAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToKilonewtons_Hour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static ForceAccel3 Kilonewtons_Hour(float x, float y, float z) => new ForceAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static ForceAccel3 Kilonewtons_Hour(Vector3 v) => new ForceAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMeganewtons_Microsecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static ForceAccel3 Meganewtons_Microsecond(float x, float y, float z) => new ForceAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static ForceAccel3 Meganewtons_Microsecond(Vector3 v) => new ForceAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMeganewtons_Millisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static ForceAccel3 Meganewtons_Millisecond(float x, float y, float z) => new ForceAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static ForceAccel3 Meganewtons_Millisecond(Vector3 v) => new ForceAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtons_Second() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static ForceAccel3 Meganewtons_Second(float x, float y, float z) => new ForceAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static ForceAccel3 Meganewtons_Second(Vector3 v) => new ForceAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeganewtons_Minute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static ForceAccel3 Meganewtons_Minute(float x, float y, float z) => new ForceAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static ForceAccel3 Meganewtons_Minute(Vector3 v) => new ForceAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMeganewtons_Hour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static ForceAccel3 Meganewtons_Hour(float x, float y, float z) => new ForceAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static ForceAccel3 Meganewtons_Hour(Vector3 v) => new ForceAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public static ForceAccel3 operator +(ForceAccel3 a, ForceAccel3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static ForceAccel3 operator -(ForceAccel3 a, ForceAccel3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    public static ForceAccel3 operator *(ForceAccel3 a, ForceAccel3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static ForceAccel3 operator /(ForceAccel3 a, ForceAccel3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    public Force3 Force3(Time v) => new(v * x, v * y, v * z);
    public Time Time(Force3 v) => new(v.magnitude / magnitude);
    public ForceAccel3(Force3 a, Time b) => a.ForceAccel3(b);
    public ForceAccel3(Time b, Force3 a) => a.ForceAccel3(b);
}
}

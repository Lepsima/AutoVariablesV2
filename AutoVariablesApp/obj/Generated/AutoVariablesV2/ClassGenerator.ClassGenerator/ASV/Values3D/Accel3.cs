using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Accel3 : IAutoUnit3 {
    public float x, y, z;
    
    public Accel3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public Accel3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    
    public static implicit operator Vector3(Accel3 v) => new Vector3(v.x, v.y, v.z);
    public Accel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToMeterSecondsPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MeterSecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MeterSecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeterSecondsPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MeterSecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MeterSecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMeterSecond2() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MeterSecond2(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MeterSecond2(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMeterSecondsPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static Accel3 MeterSecondsPerMinute(float x, float y, float z) => new Accel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static Accel3 MeterSecondsPerMinute(Vector3 v) => new Accel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMeterSecondsPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static Accel3 MeterSecondsPerHour(float x, float y, float z) => new Accel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static Accel3 MeterSecondsPerHour(Vector3 v) => new Accel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMillinewtonsPerMilligram() => new Vector3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 MillinewtonsPerMilligram(float x, float y, float z) => new Accel3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 MillinewtonsPerMilligram(Vector3 v) => new Accel3(v.x * 1E-09f, v.y * 1E-09f, v.z * 1E-09f);

    public Vector3 ToMillinewtonsPerGram() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MillinewtonsPerGram(float x, float y, float z) => new Accel3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MillinewtonsPerGram(Vector3 v) => new Accel3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToMillinewtonsPerKilogram() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MillinewtonsPerKilogram(float x, float y, float z) => new Accel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MillinewtonsPerKilogram(Vector3 v) => new Accel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillinewtonsPerTon() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MillinewtonsPerTon(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MillinewtonsPerTon(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtonsPerKiloton() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MillinewtonsPerKiloton(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MillinewtonsPerKiloton(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerMilligram() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 NewtonsPerMilligram(float x, float y, float z) => new Accel3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 NewtonsPerMilligram(Vector3 v) => new Accel3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToNewtonsPerGram() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 NewtonsPerGram(float x, float y, float z) => new Accel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 NewtonsPerGram(Vector3 v) => new Accel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToNewtonsPerKilogram() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 NewtonsPerKilogram(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 NewtonsPerKilogram(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToNewtonsPerTon() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 NewtonsPerTon(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 NewtonsPerTon(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerKiloton() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 NewtonsPerKiloton(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 NewtonsPerKiloton(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerMilligram() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 KilonewtonsPerMilligram(float x, float y, float z) => new Accel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 KilonewtonsPerMilligram(Vector3 v) => new Accel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToKilonewtonsPerGram() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 KilonewtonsPerGram(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 KilonewtonsPerGram(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToKilonewtonsPerKilogram() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 KilonewtonsPerKilogram(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 KilonewtonsPerKilogram(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilonewtonsPerTon() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 KilonewtonsPerTon(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 KilonewtonsPerTon(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerKiloton() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 KilonewtonsPerKiloton(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 KilonewtonsPerKiloton(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerMilligram() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MeganewtonsPerMilligram(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MeganewtonsPerMilligram(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMeganewtonsPerGram() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MeganewtonsPerGram(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MeganewtonsPerGram(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMeganewtonsPerKilogram() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MeganewtonsPerKilogram(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MeganewtonsPerKilogram(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeganewtonsPerTon() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 MeganewtonsPerTon(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 MeganewtonsPerTon(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerKiloton() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Accel3 MeganewtonsPerKiloton(float x, float y, float z) => new Accel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Accel3 MeganewtonsPerKiloton(Vector3 v) => new Accel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public static Accel3 operator +(Accel3 a, Accel3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static Accel3 operator -(Accel3 a, Accel3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    public static Accel3 operator *(Accel3 a, Accel3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static Accel3 operator /(Accel3 a, Accel3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    public Velocity3 Velocity3(Time v) => new(v * x, v * y, v * z);
    public Time Time(Velocity3 v) => new(v.magnitude / magnitude);
    public Accel3(Velocity3 a, Time b) => a.Accel3(b);
    public Accel3(Time b, Velocity3 a) => a.Accel3(b);
    public Force3 Force3(Mass v) => new(v * x, v * y, v * z);
    public Mass Mass(Force3 v) => new(v.magnitude / magnitude);
    public Accel3(Force3 a, Mass b) => a.Accel3(b);
    public Accel3(Mass b, Force3 a) => a.Accel3(b);
}
}

using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct TorqueAccel3 : IAutoUnit3 {
    public float x, y, z;
    
    public TorqueAccel3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public TorqueAccel3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    
    public static implicit operator Vector3(TorqueAccel3 v) => new Vector3(v.x, v.y, v.z);
    public TorqueAccel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToMeterNewtonsPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 MeterNewtonsPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 MeterNewtonsPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeterNewtonsPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 MeterNewtonsPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 MeterNewtonsPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMeterNewtonsPerSecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MeterNewtonsPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MeterNewtonsPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMeterNewtonsPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static TorqueAccel3 MeterNewtonsPerMinute(float x, float y, float z) => new TorqueAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static TorqueAccel3 MeterNewtonsPerMinute(Vector3 v) => new TorqueAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMeterNewtonsPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static TorqueAccel3 MeterNewtonsPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static TorqueAccel3 MeterNewtonsPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public static TorqueAccel3 operator +(TorqueAccel3 a, TorqueAccel3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static TorqueAccel3 operator -(TorqueAccel3 a, TorqueAccel3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    public static TorqueAccel3 operator *(TorqueAccel3 a, TorqueAccel3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static TorqueAccel3 operator /(TorqueAccel3 a, TorqueAccel3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    public Torque3 Torque3(Time v) => new(v * x, v * y, v * z);
    public Time Time(Torque3 v) => new(v.magnitude / magnitude);
    public TorqueAccel3(Torque3 a, Time b) => a.TorqueAccel3(b);
    public TorqueAccel3(Time b, Torque3 a) => a.TorqueAccel3(b);
}
}

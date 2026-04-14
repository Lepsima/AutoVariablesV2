using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct TorqueAccel2 : IAutoUnit2 {
    public float x, y;
    
    public TorqueAccel2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public TorqueAccel2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;

    public static implicit operator Vector2(TorqueAccel2 v) => new Vector2(v.x, v.y);
    public TorqueAccel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToMeterNewtonsPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 MeterNewtonsPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 MeterNewtonsPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeterNewtonsPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 MeterNewtonsPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 MeterNewtonsPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeterNewtonsPerSecond() => new Vector2(x * 1f, y * 1f);
    public static TorqueAccel2 MeterNewtonsPerSecond(float x, float y) => new TorqueAccel2(x * 1f, y * 1f);
    public static TorqueAccel2 MeterNewtonsPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMeterNewtonsPerMinute() => new Vector2(x * 60f, y * 60f);
    public static TorqueAccel2 MeterNewtonsPerMinute(float x, float y) => new TorqueAccel2(x * 0.01666666667f, y * 0.01666666667f);
    public static TorqueAccel2 MeterNewtonsPerMinute(Vector2 v) => new TorqueAccel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMeterNewtonsPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static TorqueAccel2 MeterNewtonsPerHour(float x, float y) => new TorqueAccel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static TorqueAccel2 MeterNewtonsPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public static TorqueAccel2 operator +(TorqueAccel2 a, TorqueAccel2 b) => new(a.x + b.x, a.y + b.y);
    public static TorqueAccel2 operator -(TorqueAccel2 a, TorqueAccel2 b) => new(a.x - b.x, a.y - b.y);
    public static TorqueAccel2 operator *(TorqueAccel2 a, TorqueAccel2 b) => new(a.x * b.x, a.y * b.y);
    public static TorqueAccel2 operator /(TorqueAccel2 a, TorqueAccel2 b) => new(a.x / b.x, a.y / b.y);
    public Torque2 Torque2(Time v) => new(v * x, v * y);
    public Time Time(Torque2 v) => new(v.magnitude / magnitude);
    public TorqueAccel2(Torque2 a, Time b) => a.TorqueAccel2(b);
    public TorqueAccel2(Time b, Torque2 a) => a.TorqueAccel2(b);
}
}

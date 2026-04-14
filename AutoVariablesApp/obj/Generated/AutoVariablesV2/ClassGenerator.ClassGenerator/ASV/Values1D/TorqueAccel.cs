using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct TorqueAccel : IAutoUnit {
    public float x;
    
    public TorqueAccel(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(TorqueAccel v) => v.x;
    public TorqueAccel magnitude => new(x);

    public float ToMeterNewtonsPerMicrosecond() => x * 1E-06f;
    public static TorqueAccel MeterNewtonsPerMicrosecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToMeterNewtonsPerMillisecond() => x * 0.001f;
    public static TorqueAccel MeterNewtonsPerMillisecond(float x) => new TorqueAccel(x * 1000f);

    public float ToMeterNewtonsPerSecond() => x * 1f;
    public static TorqueAccel MeterNewtonsPerSecond(float x) => new TorqueAccel(x * 1f);

    public float ToMeterNewtonsPerMinute() => x * 60f;
    public static TorqueAccel MeterNewtonsPerMinute(float x) => new TorqueAccel(x * 0.01666666667f);

    public float ToMeterNewtonsPerHour() => x * 3600f;
    public static TorqueAccel MeterNewtonsPerHour(float x) => new TorqueAccel(x * 0.0002777777778f);

    public static TorqueAccel operator +(TorqueAccel a, TorqueAccel b) => new(a.x + b.x);
    public static TorqueAccel operator -(TorqueAccel a, TorqueAccel b) => new(a.x - b.x);
    public static TorqueAccel operator *(TorqueAccel a, TorqueAccel b) => new(a.x * b.x);
    public static TorqueAccel operator /(TorqueAccel a, TorqueAccel b) => new(a.x / b.x);
    public Torque Torque(Time v) => new(v * x);
    public Time Time(Torque v) => new(v / x);
    public TorqueAccel(Torque a, Time b) => a.TorqueAccel(b);
    public TorqueAccel(Time b, Torque a) => a.TorqueAccel(b);
}
}

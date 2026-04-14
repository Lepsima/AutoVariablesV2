using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Velocity : IAutoUnit {
    public float x;
    
    public Velocity(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(Velocity v) => v.x;
    public Velocity magnitude => new(x);

    public float ToFeetsPerMicrosecond() => x * 3.048E-07f;
    public static Velocity FeetsPerMicrosecond(float x) => new Velocity(x * 3280839.895f);

    public float ToFeetsPerMillisecond() => x * 0.0003048f;
    public static Velocity FeetsPerMillisecond(float x) => new Velocity(x * 3280.839895f);

    public float ToFeetsPerSecond() => x * 0.3048f;
    public static Velocity FeetsPerSecond(float x) => new Velocity(x * 3.280839895f);

    public float ToFeetsPerMinute() => x * 18.288f;
    public static Velocity FeetsPerMinute(float x) => new Velocity(x * 0.05468066492f);

    public float ToFeetsPerHour() => x * 1097.28f;
    public static Velocity FeetsPerHour(float x) => new Velocity(x * 0.0009113444153f);

    public float ToMilesPerMicrosecond() => x * 6.213711922E-10f;
    public static Velocity MilesPerMicrosecond(float x) => new Velocity(x * 1609344000f);

    public float ToMilesPerMillisecond() => x * 6.213711922E-07f;
    public static Velocity MilesPerMillisecond(float x) => new Velocity(x * 1609344f);

    public float ToMilesPerSecond() => x * 0.0006213711922f;
    public static Velocity MilesPerSecond(float x) => new Velocity(x * 1609.344f);

    public float ToMilesPerMinute() => x * 0.03728227153f;
    public static Velocity MilesPerMinute(float x) => new Velocity(x * 26.8224f);

    public float ToMilesPerHour() => x * 2.236936292f;
    public static Velocity MilesPerHour(float x) => new Velocity(x * 0.44704f);

    public float ToMillimetersPerMicrosecond() => x * 0.001f;
    public static Velocity MillimetersPerMicrosecond(float x) => new Velocity(x * 1000f);

    public float ToMillimetersPerMillisecond() => x * 1f;
    public static Velocity MillimetersPerMillisecond(float x) => new Velocity(x * 1f);

    public float ToMillimetersPerSecond() => x * 1000f;
    public static Velocity MillimetersPerSecond(float x) => new Velocity(x * 0.001f);

    public float ToMillimetersPerMinute() => x * 60000f;
    public static Velocity MillimetersPerMinute(float x) => new Velocity(x * 1.666666667E-05f);

    public float ToMillimetersPerHour() => x * 3600000f;
    public static Velocity MillimetersPerHour(float x) => new Velocity(x * 2.777777778E-07f);

    public float ToCentimetersPerMicrosecond() => x * 0.0001f;
    public static Velocity CentimetersPerMicrosecond(float x) => new Velocity(x * 10000f);

    public float ToCentimetersPerMillisecond() => x * 0.1f;
    public static Velocity CentimetersPerMillisecond(float x) => new Velocity(x * 10f);

    public float ToCentimetersPerSecond() => x * 100f;
    public static Velocity CentimetersPerSecond(float x) => new Velocity(x * 0.01f);

    public float ToCentimetersPerMinute() => x * 6000f;
    public static Velocity CentimetersPerMinute(float x) => new Velocity(x * 0.0001666666667f);

    public float ToCentimetersPerHour() => x * 360000f;
    public static Velocity CentimetersPerHour(float x) => new Velocity(x * 2.777777778E-06f);

    public float ToMetersPerMicrosecond() => x * 1E-06f;
    public static Velocity MetersPerMicrosecond(float x) => new Velocity(x * 1000000f);

    public float ToMetersPerMillisecond() => x * 0.001f;
    public static Velocity MetersPerMillisecond(float x) => new Velocity(x * 1000f);

    public float ToMetersPerSecond() => x * 1f;
    public static Velocity MetersPerSecond(float x) => new Velocity(x * 1f);

    public float ToMetersPerMinute() => x * 60f;
    public static Velocity MetersPerMinute(float x) => new Velocity(x * 0.01666666667f);

    public float ToMetersPerHour() => x * 3600f;
    public static Velocity MetersPerHour(float x) => new Velocity(x * 0.0002777777778f);

    public float ToKilometersPerMicrosecond() => x * 1E-09f;
    public static Velocity KilometersPerMicrosecond(float x) => new Velocity(x * 1000000000f);

    public float ToKilometersPerMillisecond() => x * 1E-06f;
    public static Velocity KilometersPerMillisecond(float x) => new Velocity(x * 1000000f);

    public float ToKilometersPerSecond() => x * 0.001f;
    public static Velocity KilometersPerSecond(float x) => new Velocity(x * 1000f);

    public float ToKilometersPerMinute() => x * 0.06f;
    public static Velocity KilometersPerMinute(float x) => new Velocity(x * 16.66666667f);

    public float ToKilometersPerHour() => x * 3.6f;
    public static Velocity KilometersPerHour(float x) => new Velocity(x * 0.2777777778f);

    public float ToMegametersPerMicrosecond() => x * 1E-12f;
    public static Velocity MegametersPerMicrosecond(float x) => new Velocity(x * 1E+12f);

    public float ToMegametersPerMillisecond() => x * 1E-09f;
    public static Velocity MegametersPerMillisecond(float x) => new Velocity(x * 1000000000f);

    public float ToMegametersPerSecond() => x * 1E-06f;
    public static Velocity MegametersPerSecond(float x) => new Velocity(x * 1000000f);

    public float ToMegametersPerMinute() => x * 6E-05f;
    public static Velocity MegametersPerMinute(float x) => new Velocity(x * 16666.66667f);

    public float ToMegametersPerHour() => x * 0.0036f;
    public static Velocity MegametersPerHour(float x) => new Velocity(x * 277.7777778f);

    public static Velocity operator +(Velocity a, Velocity b) => new(a.x + b.x);
    public static Velocity operator -(Velocity a, Velocity b) => new(a.x - b.x);
    
    public static Velocity operator *(Velocity a, Velocity b) => new(a.x * b.x);
    public static Velocity operator /(Velocity a, Velocity b) => new(a.x / b.x);
    
    public Position Position(Time v) => new(v * x);
    public Time Time(Position v) => new(v / x);

    public Velocity(Position a, Time b) => a.Velocity(b);
    public Velocity(Time b, Position a) => a.Velocity(b);

    public static Velocity operator +(Accel a, Velocity b) => b + a.Velocity(VTime.deltaTime);
    public static Velocity operator +(Velocity b, Accel a) => b + a.Velocity(VTime.deltaTime);
    public static Velocity operator -(Accel a, Velocity b) => a.Velocity(VTime.deltaTime) - b;
    public static Velocity operator -(Velocity b, Accel a) => b - a.Velocity(VTime.deltaTime);
    
    public Accel Accel(Time v) => new(x / v);
    public Time Time(Accel v) => new(x / v);

    public Velocity(Accel a, Time b) => a.Velocity(b);
    public Velocity(Time b, Accel a) => a.Velocity(b);

}
}

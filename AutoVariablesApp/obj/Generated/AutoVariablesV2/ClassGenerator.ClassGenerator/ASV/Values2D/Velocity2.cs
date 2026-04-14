using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Velocity2 : IAutoUnit2 {
    public float x, y;
    
    public Velocity2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Velocity2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;

    public static implicit operator Vector2(Velocity2 v) => new Vector2(v.x, v.y);
    public Velocity magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToFeetsPerMicrosecond() => new Vector2(x * 3.048E-07f, y * 3.048E-07f);
    public static Velocity2 FeetsPerMicrosecond(float x, float y) => new Velocity2(x * 3280839.895f, y * 3280839.895f);
    public static Velocity2 FeetsPerMicrosecond(Vector2 v) => new Velocity2(v.x * 3280839.895f, v.y * 3280839.895f);

    public Vector2 ToFeetsPerMillisecond() => new Vector2(x * 0.0003048f, y * 0.0003048f);
    public static Velocity2 FeetsPerMillisecond(float x, float y) => new Velocity2(x * 3280.839895f, y * 3280.839895f);
    public static Velocity2 FeetsPerMillisecond(Vector2 v) => new Velocity2(v.x * 3280.839895f, v.y * 3280.839895f);

    public Vector2 ToFeetsPerSecond() => new Vector2(x * 0.3048f, y * 0.3048f);
    public static Velocity2 FeetsPerSecond(float x, float y) => new Velocity2(x * 3.280839895f, y * 3.280839895f);
    public static Velocity2 FeetsPerSecond(Vector2 v) => new Velocity2(v.x * 3.280839895f, v.y * 3.280839895f);

    public Vector2 ToFeetsPerMinute() => new Vector2(x * 18.288f, y * 18.288f);
    public static Velocity2 FeetsPerMinute(float x, float y) => new Velocity2(x * 0.05468066492f, y * 0.05468066492f);
    public static Velocity2 FeetsPerMinute(Vector2 v) => new Velocity2(v.x * 0.05468066492f, v.y * 0.05468066492f);

    public Vector2 ToFeetsPerHour() => new Vector2(x * 1097.28f, y * 1097.28f);
    public static Velocity2 FeetsPerHour(float x, float y) => new Velocity2(x * 0.0009113444153f, y * 0.0009113444153f);
    public static Velocity2 FeetsPerHour(Vector2 v) => new Velocity2(v.x * 0.0009113444153f, v.y * 0.0009113444153f);

    public Vector2 ToMilesPerMicrosecond() => new Vector2(x * 6.213711922E-10f, y * 6.213711922E-10f);
    public static Velocity2 MilesPerMicrosecond(float x, float y) => new Velocity2(x * 1609344000f, y * 1609344000f);
    public static Velocity2 MilesPerMicrosecond(Vector2 v) => new Velocity2(v.x * 1609344000f, v.y * 1609344000f);

    public Vector2 ToMilesPerMillisecond() => new Vector2(x * 6.213711922E-07f, y * 6.213711922E-07f);
    public static Velocity2 MilesPerMillisecond(float x, float y) => new Velocity2(x * 1609344f, y * 1609344f);
    public static Velocity2 MilesPerMillisecond(Vector2 v) => new Velocity2(v.x * 1609344f, v.y * 1609344f);

    public Vector2 ToMilesPerSecond() => new Vector2(x * 0.0006213711922f, y * 0.0006213711922f);
    public static Velocity2 MilesPerSecond(float x, float y) => new Velocity2(x * 1609.344f, y * 1609.344f);
    public static Velocity2 MilesPerSecond(Vector2 v) => new Velocity2(v.x * 1609.344f, v.y * 1609.344f);

    public Vector2 ToMilesPerMinute() => new Vector2(x * 0.03728227153f, y * 0.03728227153f);
    public static Velocity2 MilesPerMinute(float x, float y) => new Velocity2(x * 26.8224f, y * 26.8224f);
    public static Velocity2 MilesPerMinute(Vector2 v) => new Velocity2(v.x * 26.8224f, v.y * 26.8224f);

    public Vector2 ToMilesPerHour() => new Vector2(x * 2.236936292f, y * 2.236936292f);
    public static Velocity2 MilesPerHour(float x, float y) => new Velocity2(x * 0.44704f, y * 0.44704f);
    public static Velocity2 MilesPerHour(Vector2 v) => new Velocity2(v.x * 0.44704f, v.y * 0.44704f);

    public Vector2 ToMillimetersPerMicrosecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static Velocity2 MillimetersPerMicrosecond(float x, float y) => new Velocity2(x * 1000f, y * 1000f);
    public static Velocity2 MillimetersPerMicrosecond(Vector2 v) => new Velocity2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillimetersPerMillisecond() => new Vector2(x * 1f, y * 1f);
    public static Velocity2 MillimetersPerMillisecond(float x, float y) => new Velocity2(x * 1f, y * 1f);
    public static Velocity2 MillimetersPerMillisecond(Vector2 v) => new Velocity2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillimetersPerSecond() => new Vector2(x * 1000f, y * 1000f);
    public static Velocity2 MillimetersPerSecond(float x, float y) => new Velocity2(x * 0.001f, y * 0.001f);
    public static Velocity2 MillimetersPerSecond(Vector2 v) => new Velocity2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillimetersPerMinute() => new Vector2(x * 60000f, y * 60000f);
    public static Velocity2 MillimetersPerMinute(float x, float y) => new Velocity2(x * 1.666666667E-05f, y * 1.666666667E-05f);
    public static Velocity2 MillimetersPerMinute(Vector2 v) => new Velocity2(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f);

    public Vector2 ToMillimetersPerHour() => new Vector2(x * 3600000f, y * 3600000f);
    public static Velocity2 MillimetersPerHour(float x, float y) => new Velocity2(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static Velocity2 MillimetersPerHour(Vector2 v) => new Velocity2(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToCentimetersPerMicrosecond() => new Vector2(x * 0.0001f, y * 0.0001f);
    public static Velocity2 CentimetersPerMicrosecond(float x, float y) => new Velocity2(x * 10000f, y * 10000f);
    public static Velocity2 CentimetersPerMicrosecond(Vector2 v) => new Velocity2(v.x * 10000f, v.y * 10000f);

    public Vector2 ToCentimetersPerMillisecond() => new Vector2(x * 0.1f, y * 0.1f);
    public static Velocity2 CentimetersPerMillisecond(float x, float y) => new Velocity2(x * 10f, y * 10f);
    public static Velocity2 CentimetersPerMillisecond(Vector2 v) => new Velocity2(v.x * 10f, v.y * 10f);

    public Vector2 ToCentimetersPerSecond() => new Vector2(x * 100f, y * 100f);
    public static Velocity2 CentimetersPerSecond(float x, float y) => new Velocity2(x * 0.01f, y * 0.01f);
    public static Velocity2 CentimetersPerSecond(Vector2 v) => new Velocity2(v.x * 0.01f, v.y * 0.01f);

    public Vector2 ToCentimetersPerMinute() => new Vector2(x * 6000f, y * 6000f);
    public static Velocity2 CentimetersPerMinute(float x, float y) => new Velocity2(x * 0.0001666666667f, y * 0.0001666666667f);
    public static Velocity2 CentimetersPerMinute(Vector2 v) => new Velocity2(v.x * 0.0001666666667f, v.y * 0.0001666666667f);

    public Vector2 ToCentimetersPerHour() => new Vector2(x * 360000f, y * 360000f);
    public static Velocity2 CentimetersPerHour(float x, float y) => new Velocity2(x * 2.777777778E-06f, y * 2.777777778E-06f);
    public static Velocity2 CentimetersPerHour(Vector2 v) => new Velocity2(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f);

    public Vector2 ToMetersPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Velocity2 MetersPerMicrosecond(float x, float y) => new Velocity2(x * 1000000f, y * 1000000f);
    public static Velocity2 MetersPerMicrosecond(Vector2 v) => new Velocity2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMetersPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static Velocity2 MetersPerMillisecond(float x, float y) => new Velocity2(x * 1000f, y * 1000f);
    public static Velocity2 MetersPerMillisecond(Vector2 v) => new Velocity2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMetersPerSecond() => new Vector2(x * 1f, y * 1f);
    public static Velocity2 MetersPerSecond(float x, float y) => new Velocity2(x * 1f, y * 1f);
    public static Velocity2 MetersPerSecond(Vector2 v) => new Velocity2(v.x * 1f, v.y * 1f);

    public Vector2 ToMetersPerMinute() => new Vector2(x * 60f, y * 60f);
    public static Velocity2 MetersPerMinute(float x, float y) => new Velocity2(x * 0.01666666667f, y * 0.01666666667f);
    public static Velocity2 MetersPerMinute(Vector2 v) => new Velocity2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMetersPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static Velocity2 MetersPerHour(float x, float y) => new Velocity2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Velocity2 MetersPerHour(Vector2 v) => new Velocity2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToKilometersPerMicrosecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Velocity2 KilometersPerMicrosecond(float x, float y) => new Velocity2(x * 1000000000f, y * 1000000000f);
    public static Velocity2 KilometersPerMicrosecond(Vector2 v) => new Velocity2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilometersPerMillisecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Velocity2 KilometersPerMillisecond(float x, float y) => new Velocity2(x * 1000000f, y * 1000000f);
    public static Velocity2 KilometersPerMillisecond(Vector2 v) => new Velocity2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilometersPerSecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static Velocity2 KilometersPerSecond(float x, float y) => new Velocity2(x * 1000f, y * 1000f);
    public static Velocity2 KilometersPerSecond(Vector2 v) => new Velocity2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilometersPerMinute() => new Vector2(x * 0.06f, y * 0.06f);
    public static Velocity2 KilometersPerMinute(float x, float y) => new Velocity2(x * 16.66666667f, y * 16.66666667f);
    public static Velocity2 KilometersPerMinute(Vector2 v) => new Velocity2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToKilometersPerHour() => new Vector2(x * 3.6f, y * 3.6f);
    public static Velocity2 KilometersPerHour(float x, float y) => new Velocity2(x * 0.2777777778f, y * 0.2777777778f);
    public static Velocity2 KilometersPerHour(Vector2 v) => new Velocity2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMegametersPerMicrosecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static Velocity2 MegametersPerMicrosecond(float x, float y) => new Velocity2(x * 1E+12f, y * 1E+12f);
    public static Velocity2 MegametersPerMicrosecond(Vector2 v) => new Velocity2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMegametersPerMillisecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Velocity2 MegametersPerMillisecond(float x, float y) => new Velocity2(x * 1000000000f, y * 1000000000f);
    public static Velocity2 MegametersPerMillisecond(Vector2 v) => new Velocity2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMegametersPerSecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Velocity2 MegametersPerSecond(float x, float y) => new Velocity2(x * 1000000f, y * 1000000f);
    public static Velocity2 MegametersPerSecond(Vector2 v) => new Velocity2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMegametersPerMinute() => new Vector2(x * 6E-05f, y * 6E-05f);
    public static Velocity2 MegametersPerMinute(float x, float y) => new Velocity2(x * 16666.66667f, y * 16666.66667f);
    public static Velocity2 MegametersPerMinute(Vector2 v) => new Velocity2(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMegametersPerHour() => new Vector2(x * 0.0036f, y * 0.0036f);
    public static Velocity2 MegametersPerHour(float x, float y) => new Velocity2(x * 277.7777778f, y * 277.7777778f);
    public static Velocity2 MegametersPerHour(Vector2 v) => new Velocity2(v.x * 277.7777778f, v.y * 277.7777778f);

    public static Velocity2 operator +(Velocity2 a, Velocity2 b) => new(a.x + b.x, a.y + b.y);
    public static Velocity2 operator -(Velocity2 a, Velocity2 b) => new(a.x - b.x, a.y - b.y);
    public static Velocity2 operator *(Velocity2 a, Velocity2 b) => new(a.x * b.x, a.y * b.y);
    public static Velocity2 operator /(Velocity2 a, Velocity2 b) => new(a.x / b.x, a.y / b.y);
    public Position2 Position2(Time v) => new(v * x, v * y);
    public Time Time(Position2 v) => new(v.magnitude / magnitude);
    public Velocity2(Position2 a, Time b) => a.Velocity2(b);
    public Velocity2(Time b, Position2 a) => a.Velocity2(b);

    public static Velocity2 operator +(Accel2 a, Velocity2 b) => b + a.Velocity2(VTime.deltaTime);
    public static Velocity2 operator +(Velocity2 b, Accel2 a) => b + a.Velocity2(VTime.deltaTime);
    public static Velocity2 operator -(Accel2 a, Velocity2 b) => a.Velocity2(VTime.deltaTime) - b;
    public static Velocity2 operator -(Velocity2 b, Accel2 a) => b - a.Velocity2(VTime.deltaTime);
    
    public Accel2 Accel2(Time v) => new(x / v, y / v);
    public Time Time(Accel2 v) => new(magnitude / v.magnitude);
    public Velocity2(Accel2 a, Time b) => a.Velocity2(b);
    public Velocity2(Time b, Accel2 a) => a.Velocity2(b);
}
}

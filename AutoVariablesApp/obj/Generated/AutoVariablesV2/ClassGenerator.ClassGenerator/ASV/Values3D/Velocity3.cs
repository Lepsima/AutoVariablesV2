using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Velocity3 : IAutoUnit3 {
    public float x, y, z;
    
    public Velocity3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public Velocity3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    
    public static implicit operator Vector3(Velocity3 v) => new Vector3(v.x, v.y, v.z);
    public Velocity magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToFeetsPerMicrosecond() => new Vector3(x * 3.048E-07f, y * 3.048E-07f, z * 3.048E-07f);
    public static Velocity3 FeetsPerMicrosecond(float x, float y, float z) => new Velocity3(x * 3280839.895f, y * 3280839.895f, z * 3280839.895f);
    public static Velocity3 FeetsPerMicrosecond(Vector3 v) => new Velocity3(v.x * 3280839.895f, v.y * 3280839.895f, v.z * 3280839.895f);

    public Vector3 ToFeetsPerMillisecond() => new Vector3(x * 0.0003048f, y * 0.0003048f, z * 0.0003048f);
    public static Velocity3 FeetsPerMillisecond(float x, float y, float z) => new Velocity3(x * 3280.839895f, y * 3280.839895f, z * 3280.839895f);
    public static Velocity3 FeetsPerMillisecond(Vector3 v) => new Velocity3(v.x * 3280.839895f, v.y * 3280.839895f, v.z * 3280.839895f);

    public Vector3 ToFeetsPerSecond() => new Vector3(x * 0.3048f, y * 0.3048f, z * 0.3048f);
    public static Velocity3 FeetsPerSecond(float x, float y, float z) => new Velocity3(x * 3.280839895f, y * 3.280839895f, z * 3.280839895f);
    public static Velocity3 FeetsPerSecond(Vector3 v) => new Velocity3(v.x * 3.280839895f, v.y * 3.280839895f, v.z * 3.280839895f);

    public Vector3 ToFeetsPerMinute() => new Vector3(x * 18.288f, y * 18.288f, z * 18.288f);
    public static Velocity3 FeetsPerMinute(float x, float y, float z) => new Velocity3(x * 0.05468066492f, y * 0.05468066492f, z * 0.05468066492f);
    public static Velocity3 FeetsPerMinute(Vector3 v) => new Velocity3(v.x * 0.05468066492f, v.y * 0.05468066492f, v.z * 0.05468066492f);

    public Vector3 ToFeetsPerHour() => new Vector3(x * 1097.28f, y * 1097.28f, z * 1097.28f);
    public static Velocity3 FeetsPerHour(float x, float y, float z) => new Velocity3(x * 0.0009113444153f, y * 0.0009113444153f, z * 0.0009113444153f);
    public static Velocity3 FeetsPerHour(Vector3 v) => new Velocity3(v.x * 0.0009113444153f, v.y * 0.0009113444153f, v.z * 0.0009113444153f);

    public Vector3 ToMilesPerMicrosecond() => new Vector3(x * 6.213711922E-10f, y * 6.213711922E-10f, z * 6.213711922E-10f);
    public static Velocity3 MilesPerMicrosecond(float x, float y, float z) => new Velocity3(x * 1609344000f, y * 1609344000f, z * 1609344000f);
    public static Velocity3 MilesPerMicrosecond(Vector3 v) => new Velocity3(v.x * 1609344000f, v.y * 1609344000f, v.z * 1609344000f);

    public Vector3 ToMilesPerMillisecond() => new Vector3(x * 6.213711922E-07f, y * 6.213711922E-07f, z * 6.213711922E-07f);
    public static Velocity3 MilesPerMillisecond(float x, float y, float z) => new Velocity3(x * 1609344f, y * 1609344f, z * 1609344f);
    public static Velocity3 MilesPerMillisecond(Vector3 v) => new Velocity3(v.x * 1609344f, v.y * 1609344f, v.z * 1609344f);

    public Vector3 ToMilesPerSecond() => new Vector3(x * 0.0006213711922f, y * 0.0006213711922f, z * 0.0006213711922f);
    public static Velocity3 MilesPerSecond(float x, float y, float z) => new Velocity3(x * 1609.344f, y * 1609.344f, z * 1609.344f);
    public static Velocity3 MilesPerSecond(Vector3 v) => new Velocity3(v.x * 1609.344f, v.y * 1609.344f, v.z * 1609.344f);

    public Vector3 ToMilesPerMinute() => new Vector3(x * 0.03728227153f, y * 0.03728227153f, z * 0.03728227153f);
    public static Velocity3 MilesPerMinute(float x, float y, float z) => new Velocity3(x * 26.8224f, y * 26.8224f, z * 26.8224f);
    public static Velocity3 MilesPerMinute(Vector3 v) => new Velocity3(v.x * 26.8224f, v.y * 26.8224f, v.z * 26.8224f);

    public Vector3 ToMilesPerHour() => new Vector3(x * 2.236936292f, y * 2.236936292f, z * 2.236936292f);
    public static Velocity3 MilesPerHour(float x, float y, float z) => new Velocity3(x * 0.44704f, y * 0.44704f, z * 0.44704f);
    public static Velocity3 MilesPerHour(Vector3 v) => new Velocity3(v.x * 0.44704f, v.y * 0.44704f, v.z * 0.44704f);

    public Vector3 ToMillimetersPerMicrosecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Velocity3 MillimetersPerMicrosecond(float x, float y, float z) => new Velocity3(x * 1000f, y * 1000f, z * 1000f);
    public static Velocity3 MillimetersPerMicrosecond(Vector3 v) => new Velocity3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillimetersPerMillisecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Velocity3 MillimetersPerMillisecond(float x, float y, float z) => new Velocity3(x * 1f, y * 1f, z * 1f);
    public static Velocity3 MillimetersPerMillisecond(Vector3 v) => new Velocity3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillimetersPerSecond() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Velocity3 MillimetersPerSecond(float x, float y, float z) => new Velocity3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Velocity3 MillimetersPerSecond(Vector3 v) => new Velocity3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillimetersPerMinute() => new Vector3(x * 60000f, y * 60000f, z * 60000f);
    public static Velocity3 MillimetersPerMinute(float x, float y, float z) => new Velocity3(x * 1.666666667E-05f, y * 1.666666667E-05f, z * 1.666666667E-05f);
    public static Velocity3 MillimetersPerMinute(Vector3 v) => new Velocity3(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f, v.z * 1.666666667E-05f);

    public Vector3 ToMillimetersPerHour() => new Vector3(x * 3600000f, y * 3600000f, z * 3600000f);
    public static Velocity3 MillimetersPerHour(float x, float y, float z) => new Velocity3(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static Velocity3 MillimetersPerHour(Vector3 v) => new Velocity3(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToCentimetersPerMicrosecond() => new Vector3(x * 0.0001f, y * 0.0001f, z * 0.0001f);
    public static Velocity3 CentimetersPerMicrosecond(float x, float y, float z) => new Velocity3(x * 10000f, y * 10000f, z * 10000f);
    public static Velocity3 CentimetersPerMicrosecond(Vector3 v) => new Velocity3(v.x * 10000f, v.y * 10000f, v.z * 10000f);

    public Vector3 ToCentimetersPerMillisecond() => new Vector3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static Velocity3 CentimetersPerMillisecond(float x, float y, float z) => new Velocity3(x * 10f, y * 10f, z * 10f);
    public static Velocity3 CentimetersPerMillisecond(Vector3 v) => new Velocity3(v.x * 10f, v.y * 10f, v.z * 10f);

    public Vector3 ToCentimetersPerSecond() => new Vector3(x * 100f, y * 100f, z * 100f);
    public static Velocity3 CentimetersPerSecond(float x, float y, float z) => new Velocity3(x * 0.01f, y * 0.01f, z * 0.01f);
    public static Velocity3 CentimetersPerSecond(Vector3 v) => new Velocity3(v.x * 0.01f, v.y * 0.01f, v.z * 0.01f);

    public Vector3 ToCentimetersPerMinute() => new Vector3(x * 6000f, y * 6000f, z * 6000f);
    public static Velocity3 CentimetersPerMinute(float x, float y, float z) => new Velocity3(x * 0.0001666666667f, y * 0.0001666666667f, z * 0.0001666666667f);
    public static Velocity3 CentimetersPerMinute(Vector3 v) => new Velocity3(v.x * 0.0001666666667f, v.y * 0.0001666666667f, v.z * 0.0001666666667f);

    public Vector3 ToCentimetersPerHour() => new Vector3(x * 360000f, y * 360000f, z * 360000f);
    public static Velocity3 CentimetersPerHour(float x, float y, float z) => new Velocity3(x * 2.777777778E-06f, y * 2.777777778E-06f, z * 2.777777778E-06f);
    public static Velocity3 CentimetersPerHour(Vector3 v) => new Velocity3(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f, v.z * 2.777777778E-06f);

    public Vector3 ToMetersPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Velocity3 MetersPerMicrosecond(float x, float y, float z) => new Velocity3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Velocity3 MetersPerMicrosecond(Vector3 v) => new Velocity3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMetersPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Velocity3 MetersPerMillisecond(float x, float y, float z) => new Velocity3(x * 1000f, y * 1000f, z * 1000f);
    public static Velocity3 MetersPerMillisecond(Vector3 v) => new Velocity3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMetersPerSecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Velocity3 MetersPerSecond(float x, float y, float z) => new Velocity3(x * 1f, y * 1f, z * 1f);
    public static Velocity3 MetersPerSecond(Vector3 v) => new Velocity3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMetersPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static Velocity3 MetersPerMinute(float x, float y, float z) => new Velocity3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static Velocity3 MetersPerMinute(Vector3 v) => new Velocity3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMetersPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static Velocity3 MetersPerHour(float x, float y, float z) => new Velocity3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static Velocity3 MetersPerHour(Vector3 v) => new Velocity3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToKilometersPerMicrosecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Velocity3 KilometersPerMicrosecond(float x, float y, float z) => new Velocity3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Velocity3 KilometersPerMicrosecond(Vector3 v) => new Velocity3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilometersPerMillisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Velocity3 KilometersPerMillisecond(float x, float y, float z) => new Velocity3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Velocity3 KilometersPerMillisecond(Vector3 v) => new Velocity3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilometersPerSecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Velocity3 KilometersPerSecond(float x, float y, float z) => new Velocity3(x * 1000f, y * 1000f, z * 1000f);
    public static Velocity3 KilometersPerSecond(Vector3 v) => new Velocity3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilometersPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static Velocity3 KilometersPerMinute(float x, float y, float z) => new Velocity3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static Velocity3 KilometersPerMinute(Vector3 v) => new Velocity3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToKilometersPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static Velocity3 KilometersPerHour(float x, float y, float z) => new Velocity3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static Velocity3 KilometersPerHour(Vector3 v) => new Velocity3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMegametersPerMicrosecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Velocity3 MegametersPerMicrosecond(float x, float y, float z) => new Velocity3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Velocity3 MegametersPerMicrosecond(Vector3 v) => new Velocity3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMegametersPerMillisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Velocity3 MegametersPerMillisecond(float x, float y, float z) => new Velocity3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Velocity3 MegametersPerMillisecond(Vector3 v) => new Velocity3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMegametersPerSecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Velocity3 MegametersPerSecond(float x, float y, float z) => new Velocity3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Velocity3 MegametersPerSecond(Vector3 v) => new Velocity3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMegametersPerMinute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static Velocity3 MegametersPerMinute(float x, float y, float z) => new Velocity3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static Velocity3 MegametersPerMinute(Vector3 v) => new Velocity3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMegametersPerHour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static Velocity3 MegametersPerHour(float x, float y, float z) => new Velocity3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static Velocity3 MegametersPerHour(Vector3 v) => new Velocity3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public static Velocity3 operator +(Velocity3 a, Velocity3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static Velocity3 operator -(Velocity3 a, Velocity3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    
    public static Velocity3 operator *(Velocity3 a, Velocity3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static Velocity3 operator /(Velocity3 a, Velocity3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    
    public Position3 Position3(Time v) => new(v * x, v * y, v * z);
    public Time Time(Position3 v) => new(v.magnitude / magnitude);

    public Velocity3(Position3 a, Time b) => a.Velocity3(b);
    public Velocity3(Time b, Position3 a) => a.Velocity3(b);

    public static Velocity3 operator +(Accel3 a, Velocity3 b) => b + a.Velocity3(VTime.deltaTime);
    public static Velocity3 operator +(Velocity3 b, Accel3 a) => b + a.Velocity3(VTime.deltaTime);
    public static Velocity3 operator -(Accel3 a, Velocity3 b) => a.Velocity3(VTime.deltaTime) - b;
    public static Velocity3 operator -(Velocity3 b, Accel3 a) => b - a.Velocity3(VTime.deltaTime);
    
    public Accel3 Accel3(Time v) => new(x / v, y / v, z / v);
    public Time Time(Accel3 v) => new(magnitude / v.magnitude);

    public Velocity3(Accel3 a, Time b) => a.Velocity3(b);
    public Velocity3(Time b, Accel3 a) => a.Velocity3(b);

}
}

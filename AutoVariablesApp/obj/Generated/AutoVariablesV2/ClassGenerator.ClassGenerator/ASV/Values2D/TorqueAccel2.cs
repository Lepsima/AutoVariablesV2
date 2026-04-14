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

    public Vector2 ToMillinewtonsPerMicrosecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 MillinewtonsPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 MillinewtonsPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillinewtonsPerMillisecond() => new Vector2(x * 1f, y * 1f);
    public static TorqueAccel2 MillinewtonsPerMillisecond(float x, float y) => new TorqueAccel2(x * 1f, y * 1f);
    public static TorqueAccel2 MillinewtonsPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtonsPerSecond() => new Vector2(x * 1000f, y * 1000f);
    public static TorqueAccel2 MillinewtonsPerSecond(float x, float y) => new TorqueAccel2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 MillinewtonsPerSecond(Vector2 v) => new TorqueAccel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtonsPerMinute() => new Vector2(x * 60000f, y * 60000f);
    public static TorqueAccel2 MillinewtonsPerMinute(float x, float y) => new TorqueAccel2(x * 1.666666667E-05f, y * 1.666666667E-05f);
    public static TorqueAccel2 MillinewtonsPerMinute(Vector2 v) => new TorqueAccel2(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f);

    public Vector2 ToMillinewtonsPerHour() => new Vector2(x * 3600000f, y * 3600000f);
    public static TorqueAccel2 MillinewtonsPerHour(float x, float y) => new TorqueAccel2(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static TorqueAccel2 MillinewtonsPerHour(Vector2 v) => new TorqueAccel2(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToNewtonsPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 NewtonsPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 NewtonsPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToNewtonsPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 NewtonsPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 NewtonsPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerSecond() => new Vector2(x * 1f, y * 1f);
    public static TorqueAccel2 NewtonsPerSecond(float x, float y) => new TorqueAccel2(x * 1f, y * 1f);
    public static TorqueAccel2 NewtonsPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtonsPerMinute() => new Vector2(x * 60f, y * 60f);
    public static TorqueAccel2 NewtonsPerMinute(float x, float y) => new TorqueAccel2(x * 0.01666666667f, y * 0.01666666667f);
    public static TorqueAccel2 NewtonsPerMinute(Vector2 v) => new TorqueAccel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToNewtonsPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static TorqueAccel2 NewtonsPerHour(float x, float y) => new TorqueAccel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static TorqueAccel2 NewtonsPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToKilonewtonsPerMicrosecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 KilonewtonsPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 KilonewtonsPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilonewtonsPerMillisecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 KilonewtonsPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 KilonewtonsPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerSecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 KilonewtonsPerSecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 KilonewtonsPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtonsPerMinute() => new Vector2(x * 0.06f, y * 0.06f);
    public static TorqueAccel2 KilonewtonsPerMinute(float x, float y) => new TorqueAccel2(x * 16.66666667f, y * 16.66666667f);
    public static TorqueAccel2 KilonewtonsPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToKilonewtonsPerHour() => new Vector2(x * 3.6f, y * 3.6f);
    public static TorqueAccel2 KilonewtonsPerHour(float x, float y) => new TorqueAccel2(x * 0.2777777778f, y * 0.2777777778f);
    public static TorqueAccel2 KilonewtonsPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMeganewtonsPerMicrosecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static TorqueAccel2 MeganewtonsPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1E+12f, y * 1E+12f);
    public static TorqueAccel2 MeganewtonsPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMeganewtonsPerMillisecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 MeganewtonsPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 MeganewtonsPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerSecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 MeganewtonsPerSecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 MeganewtonsPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtonsPerMinute() => new Vector2(x * 6E-05f, y * 6E-05f);
    public static TorqueAccel2 MeganewtonsPerMinute(float x, float y) => new TorqueAccel2(x * 16666.66667f, y * 16666.66667f);
    public static TorqueAccel2 MeganewtonsPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMeganewtonsPerHour() => new Vector2(x * 0.0036f, y * 0.0036f);
    public static TorqueAccel2 MeganewtonsPerHour(float x, float y) => new TorqueAccel2(x * 277.7777778f, y * 277.7777778f);
    public static TorqueAccel2 MeganewtonsPerHour(Vector2 v) => new TorqueAccel2(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToMillinewtonsPerFeetsPerMicrosecond() => new Vector2(x * 0.0003048f, y * 0.0003048f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerMicrosecond(float x, float y) => new TorqueAccel2(x * 3280.839895f, y * 3280.839895f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 3280.839895f, v.y * 3280.839895f);

    public Vector2 ToMillinewtonsPerFeetsPerMillisecond() => new Vector2(x * 0.3048f, y * 0.3048f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerMillisecond(float x, float y) => new TorqueAccel2(x * 3.280839895f, y * 3.280839895f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 3.280839895f, v.y * 3.280839895f);

    public Vector2 ToMillinewtonsPerFeetsPerSecond() => new Vector2(x * 304.8f, y * 304.8f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerSecond(float x, float y) => new TorqueAccel2(x * 0.003280839895f, y * 0.003280839895f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerSecond(Vector2 v) => new TorqueAccel2(v.x * 0.003280839895f, v.y * 0.003280839895f);

    public Vector2 ToMillinewtonsPerFeetsPerMinute() => new Vector2(x * 18288f, y * 18288f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerMinute(float x, float y) => new TorqueAccel2(x * 5.468066492E-05f, y * 5.468066492E-05f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerMinute(Vector2 v) => new TorqueAccel2(v.x * 5.468066492E-05f, v.y * 5.468066492E-05f);

    public Vector2 ToMillinewtonsPerFeetsPerHour() => new Vector2(x * 1097280f, y * 1097280f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerHour(float x, float y) => new TorqueAccel2(x * 9.113444153E-07f, y * 9.113444153E-07f);
    public static TorqueAccel2 MillinewtonsPerFeetsPerHour(Vector2 v) => new TorqueAccel2(v.x * 9.113444153E-07f, v.y * 9.113444153E-07f);

    public Vector2 ToMillinewtonsPerMilesPerMicrosecond() => new Vector2(x * 6.213711922E-07f, y * 6.213711922E-07f);
    public static TorqueAccel2 MillinewtonsPerMilesPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1609344f, y * 1609344f);
    public static TorqueAccel2 MillinewtonsPerMilesPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1609344f, v.y * 1609344f);

    public Vector2 ToMillinewtonsPerMilesPerMillisecond() => new Vector2(x * 0.0006213711922f, y * 0.0006213711922f);
    public static TorqueAccel2 MillinewtonsPerMilesPerMillisecond(float x, float y) => new TorqueAccel2(x * 1609.344f, y * 1609.344f);
    public static TorqueAccel2 MillinewtonsPerMilesPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1609.344f, v.y * 1609.344f);

    public Vector2 ToMillinewtonsPerMilesPerSecond() => new Vector2(x * 0.6213711922f, y * 0.6213711922f);
    public static TorqueAccel2 MillinewtonsPerMilesPerSecond(float x, float y) => new TorqueAccel2(x * 1.609344f, y * 1.609344f);
    public static TorqueAccel2 MillinewtonsPerMilesPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1.609344f, v.y * 1.609344f);

    public Vector2 ToMillinewtonsPerMilesPerMinute() => new Vector2(x * 37.28227153f, y * 37.28227153f);
    public static TorqueAccel2 MillinewtonsPerMilesPerMinute(float x, float y) => new TorqueAccel2(x * 0.0268224f, y * 0.0268224f);
    public static TorqueAccel2 MillinewtonsPerMilesPerMinute(Vector2 v) => new TorqueAccel2(v.x * 0.0268224f, v.y * 0.0268224f);

    public Vector2 ToMillinewtonsPerMilesPerHour() => new Vector2(x * 2236.936292f, y * 2236.936292f);
    public static TorqueAccel2 MillinewtonsPerMilesPerHour(float x, float y) => new TorqueAccel2(x * 0.00044704f, y * 0.00044704f);
    public static TorqueAccel2 MillinewtonsPerMilesPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.00044704f, v.y * 0.00044704f);

    public Vector2 ToMillinewtonsPerMillimetersPerMicrosecond() => new Vector2(x * 1f, y * 1f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1f, y * 1f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtonsPerMillimetersPerMillisecond() => new Vector2(x * 1000f, y * 1000f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtonsPerMillimetersPerSecond() => new Vector2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerSecond(float x, float y) => new TorqueAccel2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToMillinewtonsPerMillimetersPerMinute() => new Vector2(x * 60000000f, y * 60000000f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerMinute(float x, float y) => new TorqueAccel2(x * 1.666666667E-08f, y * 1.666666667E-08f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 1.666666667E-08f, v.y * 1.666666667E-08f);

    public Vector2 ToMillinewtonsPerMillimetersPerHour() => new Vector2(x * 3600000000f, y * 3600000000f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerHour(float x, float y) => new TorqueAccel2(x * 2.777777778E-10f, y * 2.777777778E-10f);
    public static TorqueAccel2 MillinewtonsPerMillimetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 2.777777778E-10f, v.y * 2.777777778E-10f);

    public Vector2 ToMillinewtonsPerCentimetersPerMicrosecond() => new Vector2(x * 0.1f, y * 0.1f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 10f, y * 10f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 10f, v.y * 10f);

    public Vector2 ToMillinewtonsPerCentimetersPerMillisecond() => new Vector2(x * 100f, y * 100f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 0.01f, y * 0.01f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 0.01f, v.y * 0.01f);

    public Vector2 ToMillinewtonsPerCentimetersPerSecond() => new Vector2(x * 100000f, y * 100000f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerSecond(float x, float y) => new TorqueAccel2(x * 1E-05f, y * 1E-05f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1E-05f, v.y * 1E-05f);

    public Vector2 ToMillinewtonsPerCentimetersPerMinute() => new Vector2(x * 6000000f, y * 6000000f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerMinute(float x, float y) => new TorqueAccel2(x * 1.666666667E-07f, y * 1.666666667E-07f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 1.666666667E-07f, v.y * 1.666666667E-07f);

    public Vector2 ToMillinewtonsPerCentimetersPerHour() => new Vector2(x * 360000000f, y * 360000000f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerHour(float x, float y) => new TorqueAccel2(x * 2.777777778E-09f, y * 2.777777778E-09f);
    public static TorqueAccel2 MillinewtonsPerCentimetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 2.777777778E-09f, v.y * 2.777777778E-09f);

    public Vector2 ToMillinewtonsPerMetersPerMicrosecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 MillinewtonsPerMetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 MillinewtonsPerMetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillinewtonsPerMetersPerMillisecond() => new Vector2(x * 1f, y * 1f);
    public static TorqueAccel2 MillinewtonsPerMetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1f, y * 1f);
    public static TorqueAccel2 MillinewtonsPerMetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtonsPerMetersPerSecond() => new Vector2(x * 1000f, y * 1000f);
    public static TorqueAccel2 MillinewtonsPerMetersPerSecond(float x, float y) => new TorqueAccel2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 MillinewtonsPerMetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtonsPerMetersPerMinute() => new Vector2(x * 60000f, y * 60000f);
    public static TorqueAccel2 MillinewtonsPerMetersPerMinute(float x, float y) => new TorqueAccel2(x * 1.666666667E-05f, y * 1.666666667E-05f);
    public static TorqueAccel2 MillinewtonsPerMetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f);

    public Vector2 ToMillinewtonsPerMetersPerHour() => new Vector2(x * 3600000f, y * 3600000f);
    public static TorqueAccel2 MillinewtonsPerMetersPerHour(float x, float y) => new TorqueAccel2(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static TorqueAccel2 MillinewtonsPerMetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToMillinewtonsPerKilometersPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMillinewtonsPerKilometersPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillinewtonsPerKilometersPerSecond() => new Vector2(x * 1f, y * 1f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerSecond(float x, float y) => new TorqueAccel2(x * 1f, y * 1f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtonsPerKilometersPerMinute() => new Vector2(x * 60f, y * 60f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerMinute(float x, float y) => new TorqueAccel2(x * 0.01666666667f, y * 0.01666666667f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMillinewtonsPerKilometersPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerHour(float x, float y) => new TorqueAccel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static TorqueAccel2 MillinewtonsPerKilometersPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMillinewtonsPerMegametersPerMicrosecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMillinewtonsPerMegametersPerMillisecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMillinewtonsPerMegametersPerSecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerSecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillinewtonsPerMegametersPerMinute() => new Vector2(x * 0.06f, y * 0.06f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerMinute(float x, float y) => new TorqueAccel2(x * 16.66666667f, y * 16.66666667f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToMillinewtonsPerMegametersPerHour() => new Vector2(x * 3.6f, y * 3.6f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerHour(float x, float y) => new TorqueAccel2(x * 0.2777777778f, y * 0.2777777778f);
    public static TorqueAccel2 MillinewtonsPerMegametersPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToNewtonsPerFeetsPerMicrosecond() => new Vector2(x * 3.048E-07f, y * 3.048E-07f);
    public static TorqueAccel2 NewtonsPerFeetsPerMicrosecond(float x, float y) => new TorqueAccel2(x * 3280839.895f, y * 3280839.895f);
    public static TorqueAccel2 NewtonsPerFeetsPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 3280839.895f, v.y * 3280839.895f);

    public Vector2 ToNewtonsPerFeetsPerMillisecond() => new Vector2(x * 0.0003048f, y * 0.0003048f);
    public static TorqueAccel2 NewtonsPerFeetsPerMillisecond(float x, float y) => new TorqueAccel2(x * 3280.839895f, y * 3280.839895f);
    public static TorqueAccel2 NewtonsPerFeetsPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 3280.839895f, v.y * 3280.839895f);

    public Vector2 ToNewtonsPerFeetsPerSecond() => new Vector2(x * 0.3048f, y * 0.3048f);
    public static TorqueAccel2 NewtonsPerFeetsPerSecond(float x, float y) => new TorqueAccel2(x * 3.280839895f, y * 3.280839895f);
    public static TorqueAccel2 NewtonsPerFeetsPerSecond(Vector2 v) => new TorqueAccel2(v.x * 3.280839895f, v.y * 3.280839895f);

    public Vector2 ToNewtonsPerFeetsPerMinute() => new Vector2(x * 18.288f, y * 18.288f);
    public static TorqueAccel2 NewtonsPerFeetsPerMinute(float x, float y) => new TorqueAccel2(x * 0.05468066492f, y * 0.05468066492f);
    public static TorqueAccel2 NewtonsPerFeetsPerMinute(Vector2 v) => new TorqueAccel2(v.x * 0.05468066492f, v.y * 0.05468066492f);

    public Vector2 ToNewtonsPerFeetsPerHour() => new Vector2(x * 1097.28f, y * 1097.28f);
    public static TorqueAccel2 NewtonsPerFeetsPerHour(float x, float y) => new TorqueAccel2(x * 0.0009113444153f, y * 0.0009113444153f);
    public static TorqueAccel2 NewtonsPerFeetsPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.0009113444153f, v.y * 0.0009113444153f);

    public Vector2 ToNewtonsPerMilesPerMicrosecond() => new Vector2(x * 6.213711922E-10f, y * 6.213711922E-10f);
    public static TorqueAccel2 NewtonsPerMilesPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1609344000f, y * 1609344000f);
    public static TorqueAccel2 NewtonsPerMilesPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1609344000f, v.y * 1609344000f);

    public Vector2 ToNewtonsPerMilesPerMillisecond() => new Vector2(x * 6.213711922E-07f, y * 6.213711922E-07f);
    public static TorqueAccel2 NewtonsPerMilesPerMillisecond(float x, float y) => new TorqueAccel2(x * 1609344f, y * 1609344f);
    public static TorqueAccel2 NewtonsPerMilesPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1609344f, v.y * 1609344f);

    public Vector2 ToNewtonsPerMilesPerSecond() => new Vector2(x * 0.0006213711922f, y * 0.0006213711922f);
    public static TorqueAccel2 NewtonsPerMilesPerSecond(float x, float y) => new TorqueAccel2(x * 1609.344f, y * 1609.344f);
    public static TorqueAccel2 NewtonsPerMilesPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1609.344f, v.y * 1609.344f);

    public Vector2 ToNewtonsPerMilesPerMinute() => new Vector2(x * 0.03728227153f, y * 0.03728227153f);
    public static TorqueAccel2 NewtonsPerMilesPerMinute(float x, float y) => new TorqueAccel2(x * 26.8224f, y * 26.8224f);
    public static TorqueAccel2 NewtonsPerMilesPerMinute(Vector2 v) => new TorqueAccel2(v.x * 26.8224f, v.y * 26.8224f);

    public Vector2 ToNewtonsPerMilesPerHour() => new Vector2(x * 2.236936292f, y * 2.236936292f);
    public static TorqueAccel2 NewtonsPerMilesPerHour(float x, float y) => new TorqueAccel2(x * 0.44704f, y * 0.44704f);
    public static TorqueAccel2 NewtonsPerMilesPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.44704f, v.y * 0.44704f);

    public Vector2 ToNewtonsPerMillimetersPerMicrosecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 NewtonsPerMillimetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 NewtonsPerMillimetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerMillimetersPerMillisecond() => new Vector2(x * 1f, y * 1f);
    public static TorqueAccel2 NewtonsPerMillimetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1f, y * 1f);
    public static TorqueAccel2 NewtonsPerMillimetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtonsPerMillimetersPerSecond() => new Vector2(x * 1000f, y * 1000f);
    public static TorqueAccel2 NewtonsPerMillimetersPerSecond(float x, float y) => new TorqueAccel2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 NewtonsPerMillimetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToNewtonsPerMillimetersPerMinute() => new Vector2(x * 60000f, y * 60000f);
    public static TorqueAccel2 NewtonsPerMillimetersPerMinute(float x, float y) => new TorqueAccel2(x * 1.666666667E-05f, y * 1.666666667E-05f);
    public static TorqueAccel2 NewtonsPerMillimetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f);

    public Vector2 ToNewtonsPerMillimetersPerHour() => new Vector2(x * 3600000f, y * 3600000f);
    public static TorqueAccel2 NewtonsPerMillimetersPerHour(float x, float y) => new TorqueAccel2(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static TorqueAccel2 NewtonsPerMillimetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToNewtonsPerCentimetersPerMicrosecond() => new Vector2(x * 0.0001f, y * 0.0001f);
    public static TorqueAccel2 NewtonsPerCentimetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 10000f, y * 10000f);
    public static TorqueAccel2 NewtonsPerCentimetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 10000f, v.y * 10000f);

    public Vector2 ToNewtonsPerCentimetersPerMillisecond() => new Vector2(x * 0.1f, y * 0.1f);
    public static TorqueAccel2 NewtonsPerCentimetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 10f, y * 10f);
    public static TorqueAccel2 NewtonsPerCentimetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 10f, v.y * 10f);

    public Vector2 ToNewtonsPerCentimetersPerSecond() => new Vector2(x * 100f, y * 100f);
    public static TorqueAccel2 NewtonsPerCentimetersPerSecond(float x, float y) => new TorqueAccel2(x * 0.01f, y * 0.01f);
    public static TorqueAccel2 NewtonsPerCentimetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 0.01f, v.y * 0.01f);

    public Vector2 ToNewtonsPerCentimetersPerMinute() => new Vector2(x * 6000f, y * 6000f);
    public static TorqueAccel2 NewtonsPerCentimetersPerMinute(float x, float y) => new TorqueAccel2(x * 0.0001666666667f, y * 0.0001666666667f);
    public static TorqueAccel2 NewtonsPerCentimetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 0.0001666666667f, v.y * 0.0001666666667f);

    public Vector2 ToNewtonsPerCentimetersPerHour() => new Vector2(x * 360000f, y * 360000f);
    public static TorqueAccel2 NewtonsPerCentimetersPerHour(float x, float y) => new TorqueAccel2(x * 2.777777778E-06f, y * 2.777777778E-06f);
    public static TorqueAccel2 NewtonsPerCentimetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f);

    public Vector2 ToNewtonsPerMetersPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 NewtonsPerMetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 NewtonsPerMetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToNewtonsPerMetersPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 NewtonsPerMetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 NewtonsPerMetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerMetersPerSecond() => new Vector2(x * 1f, y * 1f);
    public static TorqueAccel2 NewtonsPerMetersPerSecond(float x, float y) => new TorqueAccel2(x * 1f, y * 1f);
    public static TorqueAccel2 NewtonsPerMetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtonsPerMetersPerMinute() => new Vector2(x * 60f, y * 60f);
    public static TorqueAccel2 NewtonsPerMetersPerMinute(float x, float y) => new TorqueAccel2(x * 0.01666666667f, y * 0.01666666667f);
    public static TorqueAccel2 NewtonsPerMetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToNewtonsPerMetersPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static TorqueAccel2 NewtonsPerMetersPerHour(float x, float y) => new TorqueAccel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static TorqueAccel2 NewtonsPerMetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToNewtonsPerKilometersPerMicrosecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 NewtonsPerKilometersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 NewtonsPerKilometersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToNewtonsPerKilometersPerMillisecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 NewtonsPerKilometersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 NewtonsPerKilometersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToNewtonsPerKilometersPerSecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 NewtonsPerKilometersPerSecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 NewtonsPerKilometersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerKilometersPerMinute() => new Vector2(x * 0.06f, y * 0.06f);
    public static TorqueAccel2 NewtonsPerKilometersPerMinute(float x, float y) => new TorqueAccel2(x * 16.66666667f, y * 16.66666667f);
    public static TorqueAccel2 NewtonsPerKilometersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToNewtonsPerKilometersPerHour() => new Vector2(x * 3.6f, y * 3.6f);
    public static TorqueAccel2 NewtonsPerKilometersPerHour(float x, float y) => new TorqueAccel2(x * 0.2777777778f, y * 0.2777777778f);
    public static TorqueAccel2 NewtonsPerKilometersPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToNewtonsPerMegametersPerMicrosecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static TorqueAccel2 NewtonsPerMegametersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1E+12f, y * 1E+12f);
    public static TorqueAccel2 NewtonsPerMegametersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToNewtonsPerMegametersPerMillisecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 NewtonsPerMegametersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 NewtonsPerMegametersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToNewtonsPerMegametersPerSecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 NewtonsPerMegametersPerSecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 NewtonsPerMegametersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToNewtonsPerMegametersPerMinute() => new Vector2(x * 6E-05f, y * 6E-05f);
    public static TorqueAccel2 NewtonsPerMegametersPerMinute(float x, float y) => new TorqueAccel2(x * 16666.66667f, y * 16666.66667f);
    public static TorqueAccel2 NewtonsPerMegametersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToNewtonsPerMegametersPerHour() => new Vector2(x * 0.0036f, y * 0.0036f);
    public static TorqueAccel2 NewtonsPerMegametersPerHour(float x, float y) => new TorqueAccel2(x * 277.7777778f, y * 277.7777778f);
    public static TorqueAccel2 NewtonsPerMegametersPerHour(Vector2 v) => new TorqueAccel2(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToKilonewtonsPerFeetsPerMicrosecond() => new Vector2(x * 3.048E-10f, y * 3.048E-10f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerMicrosecond(float x, float y) => new TorqueAccel2(x * 3280839895f, y * 3280839895f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 3280839895f, v.y * 3280839895f);

    public Vector2 ToKilonewtonsPerFeetsPerMillisecond() => new Vector2(x * 3.048E-07f, y * 3.048E-07f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerMillisecond(float x, float y) => new TorqueAccel2(x * 3280839.895f, y * 3280839.895f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 3280839.895f, v.y * 3280839.895f);

    public Vector2 ToKilonewtonsPerFeetsPerSecond() => new Vector2(x * 0.0003048f, y * 0.0003048f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerSecond(float x, float y) => new TorqueAccel2(x * 3280.839895f, y * 3280.839895f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerSecond(Vector2 v) => new TorqueAccel2(v.x * 3280.839895f, v.y * 3280.839895f);

    public Vector2 ToKilonewtonsPerFeetsPerMinute() => new Vector2(x * 0.018288f, y * 0.018288f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerMinute(float x, float y) => new TorqueAccel2(x * 54.68066492f, y * 54.68066492f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerMinute(Vector2 v) => new TorqueAccel2(v.x * 54.68066492f, v.y * 54.68066492f);

    public Vector2 ToKilonewtonsPerFeetsPerHour() => new Vector2(x * 1.09728f, y * 1.09728f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerHour(float x, float y) => new TorqueAccel2(x * 0.9113444153f, y * 0.9113444153f);
    public static TorqueAccel2 KilonewtonsPerFeetsPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.9113444153f, v.y * 0.9113444153f);

    public Vector2 ToKilonewtonsPerMilesPerMicrosecond() => new Vector2(x * 6.213711922E-13f, y * 6.213711922E-13f);
    public static TorqueAccel2 KilonewtonsPerMilesPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1.609344E+12f, y * 1.609344E+12f);
    public static TorqueAccel2 KilonewtonsPerMilesPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1.609344E+12f, v.y * 1.609344E+12f);

    public Vector2 ToKilonewtonsPerMilesPerMillisecond() => new Vector2(x * 6.213711922E-10f, y * 6.213711922E-10f);
    public static TorqueAccel2 KilonewtonsPerMilesPerMillisecond(float x, float y) => new TorqueAccel2(x * 1609344000f, y * 1609344000f);
    public static TorqueAccel2 KilonewtonsPerMilesPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1609344000f, v.y * 1609344000f);

    public Vector2 ToKilonewtonsPerMilesPerSecond() => new Vector2(x * 6.213711922E-07f, y * 6.213711922E-07f);
    public static TorqueAccel2 KilonewtonsPerMilesPerSecond(float x, float y) => new TorqueAccel2(x * 1609344f, y * 1609344f);
    public static TorqueAccel2 KilonewtonsPerMilesPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1609344f, v.y * 1609344f);

    public Vector2 ToKilonewtonsPerMilesPerMinute() => new Vector2(x * 3.728227153E-05f, y * 3.728227153E-05f);
    public static TorqueAccel2 KilonewtonsPerMilesPerMinute(float x, float y) => new TorqueAccel2(x * 26822.4f, y * 26822.4f);
    public static TorqueAccel2 KilonewtonsPerMilesPerMinute(Vector2 v) => new TorqueAccel2(v.x * 26822.4f, v.y * 26822.4f);

    public Vector2 ToKilonewtonsPerMilesPerHour() => new Vector2(x * 0.002236936292f, y * 0.002236936292f);
    public static TorqueAccel2 KilonewtonsPerMilesPerHour(float x, float y) => new TorqueAccel2(x * 447.04f, y * 447.04f);
    public static TorqueAccel2 KilonewtonsPerMilesPerHour(Vector2 v) => new TorqueAccel2(v.x * 447.04f, v.y * 447.04f);

    public Vector2 ToKilonewtonsPerMillimetersPerMicrosecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerMillimetersPerMillisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtonsPerMillimetersPerSecond() => new Vector2(x * 1f, y * 1f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerSecond(float x, float y) => new TorqueAccel2(x * 1f, y * 1f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1f, v.y * 1f);

    public Vector2 ToKilonewtonsPerMillimetersPerMinute() => new Vector2(x * 60f, y * 60f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerMinute(float x, float y) => new TorqueAccel2(x * 0.01666666667f, y * 0.01666666667f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToKilonewtonsPerMillimetersPerHour() => new Vector2(x * 3600f, y * 3600f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerHour(float x, float y) => new TorqueAccel2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static TorqueAccel2 KilonewtonsPerMillimetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToKilonewtonsPerCentimetersPerMicrosecond() => new Vector2(x * 1E-07f, y * 1E-07f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 10000000f, y * 10000000f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 10000000f, v.y * 10000000f);

    public Vector2 ToKilonewtonsPerCentimetersPerMillisecond() => new Vector2(x * 0.0001f, y * 0.0001f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 10000f, y * 10000f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 10000f, v.y * 10000f);

    public Vector2 ToKilonewtonsPerCentimetersPerSecond() => new Vector2(x * 0.1f, y * 0.1f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerSecond(float x, float y) => new TorqueAccel2(x * 10f, y * 10f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 10f, v.y * 10f);

    public Vector2 ToKilonewtonsPerCentimetersPerMinute() => new Vector2(x * 6f, y * 6f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerMinute(float x, float y) => new TorqueAccel2(x * 0.1666666667f, y * 0.1666666667f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 0.1666666667f, v.y * 0.1666666667f);

    public Vector2 ToKilonewtonsPerCentimetersPerHour() => new Vector2(x * 360f, y * 360f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerHour(float x, float y) => new TorqueAccel2(x * 0.002777777778f, y * 0.002777777778f);
    public static TorqueAccel2 KilonewtonsPerCentimetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.002777777778f, v.y * 0.002777777778f);

    public Vector2 ToKilonewtonsPerMetersPerMicrosecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 KilonewtonsPerMetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 KilonewtonsPerMetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilonewtonsPerMetersPerMillisecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 KilonewtonsPerMetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 KilonewtonsPerMetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerMetersPerSecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 KilonewtonsPerMetersPerSecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 KilonewtonsPerMetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtonsPerMetersPerMinute() => new Vector2(x * 0.06f, y * 0.06f);
    public static TorqueAccel2 KilonewtonsPerMetersPerMinute(float x, float y) => new TorqueAccel2(x * 16.66666667f, y * 16.66666667f);
    public static TorqueAccel2 KilonewtonsPerMetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToKilonewtonsPerMetersPerHour() => new Vector2(x * 3.6f, y * 3.6f);
    public static TorqueAccel2 KilonewtonsPerMetersPerHour(float x, float y) => new TorqueAccel2(x * 0.2777777778f, y * 0.2777777778f);
    public static TorqueAccel2 KilonewtonsPerMetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToKilonewtonsPerKilometersPerMicrosecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1E+12f, y * 1E+12f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToKilonewtonsPerKilometersPerMillisecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilonewtonsPerKilometersPerSecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerSecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerKilometersPerMinute() => new Vector2(x * 6E-05f, y * 6E-05f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerMinute(float x, float y) => new TorqueAccel2(x * 16666.66667f, y * 16666.66667f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToKilonewtonsPerKilometersPerHour() => new Vector2(x * 0.0036f, y * 0.0036f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerHour(float x, float y) => new TorqueAccel2(x * 277.7777778f, y * 277.7777778f);
    public static TorqueAccel2 KilonewtonsPerKilometersPerHour(Vector2 v) => new TorqueAccel2(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToKilonewtonsPerMegametersPerMicrosecond() => new Vector2(x * 1E-15f, y * 1E-15f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1E+15f, y * 1E+15f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1E+15f, v.y * 1E+15f);

    public Vector2 ToKilonewtonsPerMegametersPerMillisecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1E+12f, y * 1E+12f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToKilonewtonsPerMegametersPerSecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerSecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilonewtonsPerMegametersPerMinute() => new Vector2(x * 6E-08f, y * 6E-08f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerMinute(float x, float y) => new TorqueAccel2(x * 16666666.67f, y * 16666666.67f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16666666.67f, v.y * 16666666.67f);

    public Vector2 ToKilonewtonsPerMegametersPerHour() => new Vector2(x * 3.6E-06f, y * 3.6E-06f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerHour(float x, float y) => new TorqueAccel2(x * 277777.7778f, y * 277777.7778f);
    public static TorqueAccel2 KilonewtonsPerMegametersPerHour(Vector2 v) => new TorqueAccel2(v.x * 277777.7778f, v.y * 277777.7778f);

    public Vector2 ToMeganewtonsPerFeetsPerMicrosecond() => new Vector2(x * 3.048E-13f, y * 3.048E-13f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerMicrosecond(float x, float y) => new TorqueAccel2(x * 3.280839895E+12f, y * 3.280839895E+12f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 3.280839895E+12f, v.y * 3.280839895E+12f);

    public Vector2 ToMeganewtonsPerFeetsPerMillisecond() => new Vector2(x * 3.048E-10f, y * 3.048E-10f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerMillisecond(float x, float y) => new TorqueAccel2(x * 3280839895f, y * 3280839895f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 3280839895f, v.y * 3280839895f);

    public Vector2 ToMeganewtonsPerFeetsPerSecond() => new Vector2(x * 3.048E-07f, y * 3.048E-07f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerSecond(float x, float y) => new TorqueAccel2(x * 3280839.895f, y * 3280839.895f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerSecond(Vector2 v) => new TorqueAccel2(v.x * 3280839.895f, v.y * 3280839.895f);

    public Vector2 ToMeganewtonsPerFeetsPerMinute() => new Vector2(x * 1.8288E-05f, y * 1.8288E-05f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerMinute(float x, float y) => new TorqueAccel2(x * 54680.66492f, y * 54680.66492f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerMinute(Vector2 v) => new TorqueAccel2(v.x * 54680.66492f, v.y * 54680.66492f);

    public Vector2 ToMeganewtonsPerFeetsPerHour() => new Vector2(x * 0.00109728f, y * 0.00109728f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerHour(float x, float y) => new TorqueAccel2(x * 911.3444153f, y * 911.3444153f);
    public static TorqueAccel2 MeganewtonsPerFeetsPerHour(Vector2 v) => new TorqueAccel2(v.x * 911.3444153f, v.y * 911.3444153f);

    public Vector2 ToMeganewtonsPerMilesPerMicrosecond() => new Vector2(x * 6.213711922E-16f, y * 6.213711922E-16f);
    public static TorqueAccel2 MeganewtonsPerMilesPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1.609344E+15f, y * 1.609344E+15f);
    public static TorqueAccel2 MeganewtonsPerMilesPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1.609344E+15f, v.y * 1.609344E+15f);

    public Vector2 ToMeganewtonsPerMilesPerMillisecond() => new Vector2(x * 6.213711922E-13f, y * 6.213711922E-13f);
    public static TorqueAccel2 MeganewtonsPerMilesPerMillisecond(float x, float y) => new TorqueAccel2(x * 1.609344E+12f, y * 1.609344E+12f);
    public static TorqueAccel2 MeganewtonsPerMilesPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1.609344E+12f, v.y * 1.609344E+12f);

    public Vector2 ToMeganewtonsPerMilesPerSecond() => new Vector2(x * 6.213711922E-10f, y * 6.213711922E-10f);
    public static TorqueAccel2 MeganewtonsPerMilesPerSecond(float x, float y) => new TorqueAccel2(x * 1609344000f, y * 1609344000f);
    public static TorqueAccel2 MeganewtonsPerMilesPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1609344000f, v.y * 1609344000f);

    public Vector2 ToMeganewtonsPerMilesPerMinute() => new Vector2(x * 3.728227153E-08f, y * 3.728227153E-08f);
    public static TorqueAccel2 MeganewtonsPerMilesPerMinute(float x, float y) => new TorqueAccel2(x * 26822400f, y * 26822400f);
    public static TorqueAccel2 MeganewtonsPerMilesPerMinute(Vector2 v) => new TorqueAccel2(v.x * 26822400f, v.y * 26822400f);

    public Vector2 ToMeganewtonsPerMilesPerHour() => new Vector2(x * 2.236936292E-06f, y * 2.236936292E-06f);
    public static TorqueAccel2 MeganewtonsPerMilesPerHour(float x, float y) => new TorqueAccel2(x * 447040f, y * 447040f);
    public static TorqueAccel2 MeganewtonsPerMilesPerHour(Vector2 v) => new TorqueAccel2(v.x * 447040f, v.y * 447040f);

    public Vector2 ToMeganewtonsPerMillimetersPerMicrosecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerMillimetersPerMillisecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtonsPerMillimetersPerSecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerSecond(float x, float y) => new TorqueAccel2(x * 1000f, y * 1000f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeganewtonsPerMillimetersPerMinute() => new Vector2(x * 0.06f, y * 0.06f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerMinute(float x, float y) => new TorqueAccel2(x * 16.66666667f, y * 16.66666667f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToMeganewtonsPerMillimetersPerHour() => new Vector2(x * 3.6f, y * 3.6f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerHour(float x, float y) => new TorqueAccel2(x * 0.2777777778f, y * 0.2777777778f);
    public static TorqueAccel2 MeganewtonsPerMillimetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMeganewtonsPerCentimetersPerMicrosecond() => new Vector2(x * 1E-10f, y * 1E-10f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1E+10f, y * 1E+10f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1E+10f, v.y * 1E+10f);

    public Vector2 ToMeganewtonsPerCentimetersPerMillisecond() => new Vector2(x * 1E-07f, y * 1E-07f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 10000000f, y * 10000000f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 10000000f, v.y * 10000000f);

    public Vector2 ToMeganewtonsPerCentimetersPerSecond() => new Vector2(x * 0.0001f, y * 0.0001f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerSecond(float x, float y) => new TorqueAccel2(x * 10000f, y * 10000f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 10000f, v.y * 10000f);

    public Vector2 ToMeganewtonsPerCentimetersPerMinute() => new Vector2(x * 0.006f, y * 0.006f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerMinute(float x, float y) => new TorqueAccel2(x * 166.6666667f, y * 166.6666667f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 166.6666667f, v.y * 166.6666667f);

    public Vector2 ToMeganewtonsPerCentimetersPerHour() => new Vector2(x * 0.36f, y * 0.36f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerHour(float x, float y) => new TorqueAccel2(x * 2.777777778f, y * 2.777777778f);
    public static TorqueAccel2 MeganewtonsPerCentimetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 2.777777778f, v.y * 2.777777778f);

    public Vector2 ToMeganewtonsPerMetersPerMicrosecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static TorqueAccel2 MeganewtonsPerMetersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1E+12f, y * 1E+12f);
    public static TorqueAccel2 MeganewtonsPerMetersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMeganewtonsPerMetersPerMillisecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 MeganewtonsPerMetersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 MeganewtonsPerMetersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerMetersPerSecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static TorqueAccel2 MeganewtonsPerMetersPerSecond(float x, float y) => new TorqueAccel2(x * 1000000f, y * 1000000f);
    public static TorqueAccel2 MeganewtonsPerMetersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtonsPerMetersPerMinute() => new Vector2(x * 6E-05f, y * 6E-05f);
    public static TorqueAccel2 MeganewtonsPerMetersPerMinute(float x, float y) => new TorqueAccel2(x * 16666.66667f, y * 16666.66667f);
    public static TorqueAccel2 MeganewtonsPerMetersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMeganewtonsPerMetersPerHour() => new Vector2(x * 0.0036f, y * 0.0036f);
    public static TorqueAccel2 MeganewtonsPerMetersPerHour(float x, float y) => new TorqueAccel2(x * 277.7777778f, y * 277.7777778f);
    public static TorqueAccel2 MeganewtonsPerMetersPerHour(Vector2 v) => new TorqueAccel2(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToMeganewtonsPerKilometersPerMicrosecond() => new Vector2(x * 1E-15f, y * 1E-15f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1E+15f, y * 1E+15f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1E+15f, v.y * 1E+15f);

    public Vector2 ToMeganewtonsPerKilometersPerMillisecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1E+12f, y * 1E+12f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMeganewtonsPerKilometersPerSecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerSecond(float x, float y) => new TorqueAccel2(x * 1000000000f, y * 1000000000f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerKilometersPerMinute() => new Vector2(x * 6E-08f, y * 6E-08f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerMinute(float x, float y) => new TorqueAccel2(x * 16666666.67f, y * 16666666.67f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 16666666.67f, v.y * 16666666.67f);

    public Vector2 ToMeganewtonsPerKilometersPerHour() => new Vector2(x * 3.6E-06f, y * 3.6E-06f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerHour(float x, float y) => new TorqueAccel2(x * 277777.7778f, y * 277777.7778f);
    public static TorqueAccel2 MeganewtonsPerKilometersPerHour(Vector2 v) => new TorqueAccel2(v.x * 277777.7778f, v.y * 277777.7778f);

    public Vector2 ToMeganewtonsPerMegametersPerMicrosecond() => new Vector2(x * 1E-18f, y * 1E-18f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerMicrosecond(float x, float y) => new TorqueAccel2(x * 1E+18f, y * 1E+18f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerMicrosecond(Vector2 v) => new TorqueAccel2(v.x * 1E+18f, v.y * 1E+18f);

    public Vector2 ToMeganewtonsPerMegametersPerMillisecond() => new Vector2(x * 1E-15f, y * 1E-15f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerMillisecond(float x, float y) => new TorqueAccel2(x * 1E+15f, y * 1E+15f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerMillisecond(Vector2 v) => new TorqueAccel2(v.x * 1E+15f, v.y * 1E+15f);

    public Vector2 ToMeganewtonsPerMegametersPerSecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerSecond(float x, float y) => new TorqueAccel2(x * 1E+12f, y * 1E+12f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerSecond(Vector2 v) => new TorqueAccel2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMeganewtonsPerMegametersPerMinute() => new Vector2(x * 6E-11f, y * 6E-11f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerMinute(float x, float y) => new TorqueAccel2(x * 1.666666667E+10f, y * 1.666666667E+10f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerMinute(Vector2 v) => new TorqueAccel2(v.x * 1.666666667E+10f, v.y * 1.666666667E+10f);

    public Vector2 ToMeganewtonsPerMegametersPerHour() => new Vector2(x * 3.6E-09f, y * 3.6E-09f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerHour(float x, float y) => new TorqueAccel2(x * 277777777.8f, y * 277777777.8f);
    public static TorqueAccel2 MeganewtonsPerMegametersPerHour(Vector2 v) => new TorqueAccel2(v.x * 277777777.8f, v.y * 277777777.8f);

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

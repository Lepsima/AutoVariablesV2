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

    public Vector3 ToMillinewtonsPerMicrosecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 MillinewtonsPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 MillinewtonsPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillinewtonsPerMillisecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MillinewtonsPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MillinewtonsPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtonsPerSecond() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 MillinewtonsPerSecond(float x, float y, float z) => new TorqueAccel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 MillinewtonsPerSecond(Vector3 v) => new TorqueAccel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillinewtonsPerMinute() => new Vector3(x * 60000f, y * 60000f, z * 60000f);
    public static TorqueAccel3 MillinewtonsPerMinute(float x, float y, float z) => new TorqueAccel3(x * 1.666666667E-05f, y * 1.666666667E-05f, z * 1.666666667E-05f);
    public static TorqueAccel3 MillinewtonsPerMinute(Vector3 v) => new TorqueAccel3(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f, v.z * 1.666666667E-05f);

    public Vector3 ToMillinewtonsPerHour() => new Vector3(x * 3600000f, y * 3600000f, z * 3600000f);
    public static TorqueAccel3 MillinewtonsPerHour(float x, float y, float z) => new TorqueAccel3(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static TorqueAccel3 MillinewtonsPerHour(Vector3 v) => new TorqueAccel3(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToNewtonsPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 NewtonsPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 NewtonsPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToNewtonsPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 NewtonsPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 NewtonsPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerSecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 NewtonsPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 NewtonsPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToNewtonsPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static TorqueAccel3 NewtonsPerMinute(float x, float y, float z) => new TorqueAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static TorqueAccel3 NewtonsPerMinute(Vector3 v) => new TorqueAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToNewtonsPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static TorqueAccel3 NewtonsPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static TorqueAccel3 NewtonsPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToKilonewtonsPerMicrosecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 KilonewtonsPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 KilonewtonsPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilonewtonsPerMillisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 KilonewtonsPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 KilonewtonsPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerSecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 KilonewtonsPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 KilonewtonsPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilonewtonsPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static TorqueAccel3 KilonewtonsPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static TorqueAccel3 KilonewtonsPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToKilonewtonsPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static TorqueAccel3 KilonewtonsPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static TorqueAccel3 KilonewtonsPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMeganewtonsPerMicrosecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static TorqueAccel3 MeganewtonsPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static TorqueAccel3 MeganewtonsPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMeganewtonsPerMillisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 MeganewtonsPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 MeganewtonsPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerSecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 MeganewtonsPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 MeganewtonsPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeganewtonsPerMinute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static TorqueAccel3 MeganewtonsPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static TorqueAccel3 MeganewtonsPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMeganewtonsPerHour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static TorqueAccel3 MeganewtonsPerHour(float x, float y, float z) => new TorqueAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static TorqueAccel3 MeganewtonsPerHour(Vector3 v) => new TorqueAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToMillinewtonsPerFeetsPerMicrosecond() => new Vector3(x * 0.0003048f, y * 0.0003048f, z * 0.0003048f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 3280.839895f, y * 3280.839895f, z * 3280.839895f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 3280.839895f, v.y * 3280.839895f, v.z * 3280.839895f);

    public Vector3 ToMillinewtonsPerFeetsPerMillisecond() => new Vector3(x * 0.3048f, y * 0.3048f, z * 0.3048f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 3.280839895f, y * 3.280839895f, z * 3.280839895f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 3.280839895f, v.y * 3.280839895f, v.z * 3.280839895f);

    public Vector3 ToMillinewtonsPerFeetsPerSecond() => new Vector3(x * 304.8f, y * 304.8f, z * 304.8f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerSecond(float x, float y, float z) => new TorqueAccel3(x * 0.003280839895f, y * 0.003280839895f, z * 0.003280839895f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerSecond(Vector3 v) => new TorqueAccel3(v.x * 0.003280839895f, v.y * 0.003280839895f, v.z * 0.003280839895f);

    public Vector3 ToMillinewtonsPerFeetsPerMinute() => new Vector3(x * 18288f, y * 18288f, z * 18288f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerMinute(float x, float y, float z) => new TorqueAccel3(x * 5.468066492E-05f, y * 5.468066492E-05f, z * 5.468066492E-05f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerMinute(Vector3 v) => new TorqueAccel3(v.x * 5.468066492E-05f, v.y * 5.468066492E-05f, v.z * 5.468066492E-05f);

    public Vector3 ToMillinewtonsPerFeetsPerHour() => new Vector3(x * 1097280f, y * 1097280f, z * 1097280f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerHour(float x, float y, float z) => new TorqueAccel3(x * 9.113444153E-07f, y * 9.113444153E-07f, z * 9.113444153E-07f);
    public static TorqueAccel3 MillinewtonsPerFeetsPerHour(Vector3 v) => new TorqueAccel3(v.x * 9.113444153E-07f, v.y * 9.113444153E-07f, v.z * 9.113444153E-07f);

    public Vector3 ToMillinewtonsPerMilesPerMicrosecond() => new Vector3(x * 6.213711922E-07f, y * 6.213711922E-07f, z * 6.213711922E-07f);
    public static TorqueAccel3 MillinewtonsPerMilesPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1609344f, y * 1609344f, z * 1609344f);
    public static TorqueAccel3 MillinewtonsPerMilesPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1609344f, v.y * 1609344f, v.z * 1609344f);

    public Vector3 ToMillinewtonsPerMilesPerMillisecond() => new Vector3(x * 0.0006213711922f, y * 0.0006213711922f, z * 0.0006213711922f);
    public static TorqueAccel3 MillinewtonsPerMilesPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1609.344f, y * 1609.344f, z * 1609.344f);
    public static TorqueAccel3 MillinewtonsPerMilesPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1609.344f, v.y * 1609.344f, v.z * 1609.344f);

    public Vector3 ToMillinewtonsPerMilesPerSecond() => new Vector3(x * 0.6213711922f, y * 0.6213711922f, z * 0.6213711922f);
    public static TorqueAccel3 MillinewtonsPerMilesPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1.609344f, y * 1.609344f, z * 1.609344f);
    public static TorqueAccel3 MillinewtonsPerMilesPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1.609344f, v.y * 1.609344f, v.z * 1.609344f);

    public Vector3 ToMillinewtonsPerMilesPerMinute() => new Vector3(x * 37.28227153f, y * 37.28227153f, z * 37.28227153f);
    public static TorqueAccel3 MillinewtonsPerMilesPerMinute(float x, float y, float z) => new TorqueAccel3(x * 0.0268224f, y * 0.0268224f, z * 0.0268224f);
    public static TorqueAccel3 MillinewtonsPerMilesPerMinute(Vector3 v) => new TorqueAccel3(v.x * 0.0268224f, v.y * 0.0268224f, v.z * 0.0268224f);

    public Vector3 ToMillinewtonsPerMilesPerHour() => new Vector3(x * 2236.936292f, y * 2236.936292f, z * 2236.936292f);
    public static TorqueAccel3 MillinewtonsPerMilesPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.00044704f, y * 0.00044704f, z * 0.00044704f);
    public static TorqueAccel3 MillinewtonsPerMilesPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.00044704f, v.y * 0.00044704f, v.z * 0.00044704f);

    public Vector3 ToMillinewtonsPerMillimetersPerMicrosecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtonsPerMillimetersPerMillisecond() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillinewtonsPerMillimetersPerSecond() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToMillinewtonsPerMillimetersPerMinute() => new Vector3(x * 60000000f, y * 60000000f, z * 60000000f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 1.666666667E-08f, y * 1.666666667E-08f, z * 1.666666667E-08f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 1.666666667E-08f, v.y * 1.666666667E-08f, v.z * 1.666666667E-08f);

    public Vector3 ToMillinewtonsPerMillimetersPerHour() => new Vector3(x * 3600000000f, y * 3600000000f, z * 3600000000f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 2.777777778E-10f, y * 2.777777778E-10f, z * 2.777777778E-10f);
    public static TorqueAccel3 MillinewtonsPerMillimetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 2.777777778E-10f, v.y * 2.777777778E-10f, v.z * 2.777777778E-10f);

    public Vector3 ToMillinewtonsPerCentimetersPerMicrosecond() => new Vector3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 10f, y * 10f, z * 10f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 10f, v.y * 10f, v.z * 10f);

    public Vector3 ToMillinewtonsPerCentimetersPerMillisecond() => new Vector3(x * 100f, y * 100f, z * 100f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 0.01f, y * 0.01f, z * 0.01f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 0.01f, v.y * 0.01f, v.z * 0.01f);

    public Vector3 ToMillinewtonsPerCentimetersPerSecond() => new Vector3(x * 100000f, y * 100000f, z * 100000f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1E-05f, y * 1E-05f, z * 1E-05f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1E-05f, v.y * 1E-05f, v.z * 1E-05f);

    public Vector3 ToMillinewtonsPerCentimetersPerMinute() => new Vector3(x * 6000000f, y * 6000000f, z * 6000000f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 1.666666667E-07f, y * 1.666666667E-07f, z * 1.666666667E-07f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 1.666666667E-07f, v.y * 1.666666667E-07f, v.z * 1.666666667E-07f);

    public Vector3 ToMillinewtonsPerCentimetersPerHour() => new Vector3(x * 360000000f, y * 360000000f, z * 360000000f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 2.777777778E-09f, y * 2.777777778E-09f, z * 2.777777778E-09f);
    public static TorqueAccel3 MillinewtonsPerCentimetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 2.777777778E-09f, v.y * 2.777777778E-09f, v.z * 2.777777778E-09f);

    public Vector3 ToMillinewtonsPerMetersPerMicrosecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 MillinewtonsPerMetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 MillinewtonsPerMetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillinewtonsPerMetersPerMillisecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MillinewtonsPerMetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MillinewtonsPerMetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtonsPerMetersPerSecond() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 MillinewtonsPerMetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 MillinewtonsPerMetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillinewtonsPerMetersPerMinute() => new Vector3(x * 60000f, y * 60000f, z * 60000f);
    public static TorqueAccel3 MillinewtonsPerMetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 1.666666667E-05f, y * 1.666666667E-05f, z * 1.666666667E-05f);
    public static TorqueAccel3 MillinewtonsPerMetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f, v.z * 1.666666667E-05f);

    public Vector3 ToMillinewtonsPerMetersPerHour() => new Vector3(x * 3600000f, y * 3600000f, z * 3600000f);
    public static TorqueAccel3 MillinewtonsPerMetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static TorqueAccel3 MillinewtonsPerMetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToMillinewtonsPerKilometersPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMillinewtonsPerKilometersPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillinewtonsPerKilometersPerSecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtonsPerKilometersPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMillinewtonsPerKilometersPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static TorqueAccel3 MillinewtonsPerKilometersPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMillinewtonsPerMegametersPerMicrosecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMillinewtonsPerMegametersPerMillisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMillinewtonsPerMegametersPerSecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillinewtonsPerMegametersPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToMillinewtonsPerMegametersPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static TorqueAccel3 MillinewtonsPerMegametersPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToNewtonsPerFeetsPerMicrosecond() => new Vector3(x * 3.048E-07f, y * 3.048E-07f, z * 3.048E-07f);
    public static TorqueAccel3 NewtonsPerFeetsPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 3280839.895f, y * 3280839.895f, z * 3280839.895f);
    public static TorqueAccel3 NewtonsPerFeetsPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 3280839.895f, v.y * 3280839.895f, v.z * 3280839.895f);

    public Vector3 ToNewtonsPerFeetsPerMillisecond() => new Vector3(x * 0.0003048f, y * 0.0003048f, z * 0.0003048f);
    public static TorqueAccel3 NewtonsPerFeetsPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 3280.839895f, y * 3280.839895f, z * 3280.839895f);
    public static TorqueAccel3 NewtonsPerFeetsPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 3280.839895f, v.y * 3280.839895f, v.z * 3280.839895f);

    public Vector3 ToNewtonsPerFeetsPerSecond() => new Vector3(x * 0.3048f, y * 0.3048f, z * 0.3048f);
    public static TorqueAccel3 NewtonsPerFeetsPerSecond(float x, float y, float z) => new TorqueAccel3(x * 3.280839895f, y * 3.280839895f, z * 3.280839895f);
    public static TorqueAccel3 NewtonsPerFeetsPerSecond(Vector3 v) => new TorqueAccel3(v.x * 3.280839895f, v.y * 3.280839895f, v.z * 3.280839895f);

    public Vector3 ToNewtonsPerFeetsPerMinute() => new Vector3(x * 18.288f, y * 18.288f, z * 18.288f);
    public static TorqueAccel3 NewtonsPerFeetsPerMinute(float x, float y, float z) => new TorqueAccel3(x * 0.05468066492f, y * 0.05468066492f, z * 0.05468066492f);
    public static TorqueAccel3 NewtonsPerFeetsPerMinute(Vector3 v) => new TorqueAccel3(v.x * 0.05468066492f, v.y * 0.05468066492f, v.z * 0.05468066492f);

    public Vector3 ToNewtonsPerFeetsPerHour() => new Vector3(x * 1097.28f, y * 1097.28f, z * 1097.28f);
    public static TorqueAccel3 NewtonsPerFeetsPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.0009113444153f, y * 0.0009113444153f, z * 0.0009113444153f);
    public static TorqueAccel3 NewtonsPerFeetsPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.0009113444153f, v.y * 0.0009113444153f, v.z * 0.0009113444153f);

    public Vector3 ToNewtonsPerMilesPerMicrosecond() => new Vector3(x * 6.213711922E-10f, y * 6.213711922E-10f, z * 6.213711922E-10f);
    public static TorqueAccel3 NewtonsPerMilesPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1609344000f, y * 1609344000f, z * 1609344000f);
    public static TorqueAccel3 NewtonsPerMilesPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1609344000f, v.y * 1609344000f, v.z * 1609344000f);

    public Vector3 ToNewtonsPerMilesPerMillisecond() => new Vector3(x * 6.213711922E-07f, y * 6.213711922E-07f, z * 6.213711922E-07f);
    public static TorqueAccel3 NewtonsPerMilesPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1609344f, y * 1609344f, z * 1609344f);
    public static TorqueAccel3 NewtonsPerMilesPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1609344f, v.y * 1609344f, v.z * 1609344f);

    public Vector3 ToNewtonsPerMilesPerSecond() => new Vector3(x * 0.0006213711922f, y * 0.0006213711922f, z * 0.0006213711922f);
    public static TorqueAccel3 NewtonsPerMilesPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1609.344f, y * 1609.344f, z * 1609.344f);
    public static TorqueAccel3 NewtonsPerMilesPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1609.344f, v.y * 1609.344f, v.z * 1609.344f);

    public Vector3 ToNewtonsPerMilesPerMinute() => new Vector3(x * 0.03728227153f, y * 0.03728227153f, z * 0.03728227153f);
    public static TorqueAccel3 NewtonsPerMilesPerMinute(float x, float y, float z) => new TorqueAccel3(x * 26.8224f, y * 26.8224f, z * 26.8224f);
    public static TorqueAccel3 NewtonsPerMilesPerMinute(Vector3 v) => new TorqueAccel3(v.x * 26.8224f, v.y * 26.8224f, v.z * 26.8224f);

    public Vector3 ToNewtonsPerMilesPerHour() => new Vector3(x * 2.236936292f, y * 2.236936292f, z * 2.236936292f);
    public static TorqueAccel3 NewtonsPerMilesPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.44704f, y * 0.44704f, z * 0.44704f);
    public static TorqueAccel3 NewtonsPerMilesPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.44704f, v.y * 0.44704f, v.z * 0.44704f);

    public Vector3 ToNewtonsPerMillimetersPerMicrosecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 NewtonsPerMillimetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 NewtonsPerMillimetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerMillimetersPerMillisecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 NewtonsPerMillimetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 NewtonsPerMillimetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToNewtonsPerMillimetersPerSecond() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 NewtonsPerMillimetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 NewtonsPerMillimetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToNewtonsPerMillimetersPerMinute() => new Vector3(x * 60000f, y * 60000f, z * 60000f);
    public static TorqueAccel3 NewtonsPerMillimetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 1.666666667E-05f, y * 1.666666667E-05f, z * 1.666666667E-05f);
    public static TorqueAccel3 NewtonsPerMillimetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f, v.z * 1.666666667E-05f);

    public Vector3 ToNewtonsPerMillimetersPerHour() => new Vector3(x * 3600000f, y * 3600000f, z * 3600000f);
    public static TorqueAccel3 NewtonsPerMillimetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static TorqueAccel3 NewtonsPerMillimetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToNewtonsPerCentimetersPerMicrosecond() => new Vector3(x * 0.0001f, y * 0.0001f, z * 0.0001f);
    public static TorqueAccel3 NewtonsPerCentimetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 10000f, y * 10000f, z * 10000f);
    public static TorqueAccel3 NewtonsPerCentimetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 10000f, v.y * 10000f, v.z * 10000f);

    public Vector3 ToNewtonsPerCentimetersPerMillisecond() => new Vector3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static TorqueAccel3 NewtonsPerCentimetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 10f, y * 10f, z * 10f);
    public static TorqueAccel3 NewtonsPerCentimetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 10f, v.y * 10f, v.z * 10f);

    public Vector3 ToNewtonsPerCentimetersPerSecond() => new Vector3(x * 100f, y * 100f, z * 100f);
    public static TorqueAccel3 NewtonsPerCentimetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 0.01f, y * 0.01f, z * 0.01f);
    public static TorqueAccel3 NewtonsPerCentimetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 0.01f, v.y * 0.01f, v.z * 0.01f);

    public Vector3 ToNewtonsPerCentimetersPerMinute() => new Vector3(x * 6000f, y * 6000f, z * 6000f);
    public static TorqueAccel3 NewtonsPerCentimetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 0.0001666666667f, y * 0.0001666666667f, z * 0.0001666666667f);
    public static TorqueAccel3 NewtonsPerCentimetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 0.0001666666667f, v.y * 0.0001666666667f, v.z * 0.0001666666667f);

    public Vector3 ToNewtonsPerCentimetersPerHour() => new Vector3(x * 360000f, y * 360000f, z * 360000f);
    public static TorqueAccel3 NewtonsPerCentimetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 2.777777778E-06f, y * 2.777777778E-06f, z * 2.777777778E-06f);
    public static TorqueAccel3 NewtonsPerCentimetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f, v.z * 2.777777778E-06f);

    public Vector3 ToNewtonsPerMetersPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 NewtonsPerMetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 NewtonsPerMetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToNewtonsPerMetersPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 NewtonsPerMetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 NewtonsPerMetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerMetersPerSecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 NewtonsPerMetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 NewtonsPerMetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToNewtonsPerMetersPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static TorqueAccel3 NewtonsPerMetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static TorqueAccel3 NewtonsPerMetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToNewtonsPerMetersPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static TorqueAccel3 NewtonsPerMetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static TorqueAccel3 NewtonsPerMetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToNewtonsPerKilometersPerMicrosecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 NewtonsPerKilometersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 NewtonsPerKilometersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToNewtonsPerKilometersPerMillisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 NewtonsPerKilometersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 NewtonsPerKilometersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToNewtonsPerKilometersPerSecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 NewtonsPerKilometersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 NewtonsPerKilometersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerKilometersPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static TorqueAccel3 NewtonsPerKilometersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static TorqueAccel3 NewtonsPerKilometersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToNewtonsPerKilometersPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static TorqueAccel3 NewtonsPerKilometersPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static TorqueAccel3 NewtonsPerKilometersPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToNewtonsPerMegametersPerMicrosecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static TorqueAccel3 NewtonsPerMegametersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static TorqueAccel3 NewtonsPerMegametersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToNewtonsPerMegametersPerMillisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 NewtonsPerMegametersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 NewtonsPerMegametersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToNewtonsPerMegametersPerSecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 NewtonsPerMegametersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 NewtonsPerMegametersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToNewtonsPerMegametersPerMinute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static TorqueAccel3 NewtonsPerMegametersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static TorqueAccel3 NewtonsPerMegametersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToNewtonsPerMegametersPerHour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static TorqueAccel3 NewtonsPerMegametersPerHour(float x, float y, float z) => new TorqueAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static TorqueAccel3 NewtonsPerMegametersPerHour(Vector3 v) => new TorqueAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToKilonewtonsPerFeetsPerMicrosecond() => new Vector3(x * 3.048E-10f, y * 3.048E-10f, z * 3.048E-10f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 3280839895f, y * 3280839895f, z * 3280839895f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 3280839895f, v.y * 3280839895f, v.z * 3280839895f);

    public Vector3 ToKilonewtonsPerFeetsPerMillisecond() => new Vector3(x * 3.048E-07f, y * 3.048E-07f, z * 3.048E-07f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 3280839.895f, y * 3280839.895f, z * 3280839.895f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 3280839.895f, v.y * 3280839.895f, v.z * 3280839.895f);

    public Vector3 ToKilonewtonsPerFeetsPerSecond() => new Vector3(x * 0.0003048f, y * 0.0003048f, z * 0.0003048f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerSecond(float x, float y, float z) => new TorqueAccel3(x * 3280.839895f, y * 3280.839895f, z * 3280.839895f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerSecond(Vector3 v) => new TorqueAccel3(v.x * 3280.839895f, v.y * 3280.839895f, v.z * 3280.839895f);

    public Vector3 ToKilonewtonsPerFeetsPerMinute() => new Vector3(x * 0.018288f, y * 0.018288f, z * 0.018288f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerMinute(float x, float y, float z) => new TorqueAccel3(x * 54.68066492f, y * 54.68066492f, z * 54.68066492f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerMinute(Vector3 v) => new TorqueAccel3(v.x * 54.68066492f, v.y * 54.68066492f, v.z * 54.68066492f);

    public Vector3 ToKilonewtonsPerFeetsPerHour() => new Vector3(x * 1.09728f, y * 1.09728f, z * 1.09728f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.9113444153f, y * 0.9113444153f, z * 0.9113444153f);
    public static TorqueAccel3 KilonewtonsPerFeetsPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.9113444153f, v.y * 0.9113444153f, v.z * 0.9113444153f);

    public Vector3 ToKilonewtonsPerMilesPerMicrosecond() => new Vector3(x * 6.213711922E-13f, y * 6.213711922E-13f, z * 6.213711922E-13f);
    public static TorqueAccel3 KilonewtonsPerMilesPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1.609344E+12f, y * 1.609344E+12f, z * 1.609344E+12f);
    public static TorqueAccel3 KilonewtonsPerMilesPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1.609344E+12f, v.y * 1.609344E+12f, v.z * 1.609344E+12f);

    public Vector3 ToKilonewtonsPerMilesPerMillisecond() => new Vector3(x * 6.213711922E-10f, y * 6.213711922E-10f, z * 6.213711922E-10f);
    public static TorqueAccel3 KilonewtonsPerMilesPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1609344000f, y * 1609344000f, z * 1609344000f);
    public static TorqueAccel3 KilonewtonsPerMilesPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1609344000f, v.y * 1609344000f, v.z * 1609344000f);

    public Vector3 ToKilonewtonsPerMilesPerSecond() => new Vector3(x * 6.213711922E-07f, y * 6.213711922E-07f, z * 6.213711922E-07f);
    public static TorqueAccel3 KilonewtonsPerMilesPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1609344f, y * 1609344f, z * 1609344f);
    public static TorqueAccel3 KilonewtonsPerMilesPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1609344f, v.y * 1609344f, v.z * 1609344f);

    public Vector3 ToKilonewtonsPerMilesPerMinute() => new Vector3(x * 3.728227153E-05f, y * 3.728227153E-05f, z * 3.728227153E-05f);
    public static TorqueAccel3 KilonewtonsPerMilesPerMinute(float x, float y, float z) => new TorqueAccel3(x * 26822.4f, y * 26822.4f, z * 26822.4f);
    public static TorqueAccel3 KilonewtonsPerMilesPerMinute(Vector3 v) => new TorqueAccel3(v.x * 26822.4f, v.y * 26822.4f, v.z * 26822.4f);

    public Vector3 ToKilonewtonsPerMilesPerHour() => new Vector3(x * 0.002236936292f, y * 0.002236936292f, z * 0.002236936292f);
    public static TorqueAccel3 KilonewtonsPerMilesPerHour(float x, float y, float z) => new TorqueAccel3(x * 447.04f, y * 447.04f, z * 447.04f);
    public static TorqueAccel3 KilonewtonsPerMilesPerHour(Vector3 v) => new TorqueAccel3(v.x * 447.04f, v.y * 447.04f, v.z * 447.04f);

    public Vector3 ToKilonewtonsPerMillimetersPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerMillimetersPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilonewtonsPerMillimetersPerSecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1f, y * 1f, z * 1f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToKilonewtonsPerMillimetersPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToKilonewtonsPerMillimetersPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static TorqueAccel3 KilonewtonsPerMillimetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToKilonewtonsPerCentimetersPerMicrosecond() => new Vector3(x * 1E-07f, y * 1E-07f, z * 1E-07f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 10000000f, y * 10000000f, z * 10000000f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 10000000f, v.y * 10000000f, v.z * 10000000f);

    public Vector3 ToKilonewtonsPerCentimetersPerMillisecond() => new Vector3(x * 0.0001f, y * 0.0001f, z * 0.0001f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 10000f, y * 10000f, z * 10000f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 10000f, v.y * 10000f, v.z * 10000f);

    public Vector3 ToKilonewtonsPerCentimetersPerSecond() => new Vector3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 10f, y * 10f, z * 10f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 10f, v.y * 10f, v.z * 10f);

    public Vector3 ToKilonewtonsPerCentimetersPerMinute() => new Vector3(x * 6f, y * 6f, z * 6f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 0.1666666667f, y * 0.1666666667f, z * 0.1666666667f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 0.1666666667f, v.y * 0.1666666667f, v.z * 0.1666666667f);

    public Vector3 ToKilonewtonsPerCentimetersPerHour() => new Vector3(x * 360f, y * 360f, z * 360f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.002777777778f, y * 0.002777777778f, z * 0.002777777778f);
    public static TorqueAccel3 KilonewtonsPerCentimetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.002777777778f, v.y * 0.002777777778f, v.z * 0.002777777778f);

    public Vector3 ToKilonewtonsPerMetersPerMicrosecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 KilonewtonsPerMetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 KilonewtonsPerMetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilonewtonsPerMetersPerMillisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 KilonewtonsPerMetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 KilonewtonsPerMetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerMetersPerSecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 KilonewtonsPerMetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 KilonewtonsPerMetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilonewtonsPerMetersPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static TorqueAccel3 KilonewtonsPerMetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static TorqueAccel3 KilonewtonsPerMetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToKilonewtonsPerMetersPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static TorqueAccel3 KilonewtonsPerMetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static TorqueAccel3 KilonewtonsPerMetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToKilonewtonsPerKilometersPerMicrosecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToKilonewtonsPerKilometersPerMillisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilonewtonsPerKilometersPerSecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerKilometersPerMinute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToKilonewtonsPerKilometersPerHour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerHour(float x, float y, float z) => new TorqueAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static TorqueAccel3 KilonewtonsPerKilometersPerHour(Vector3 v) => new TorqueAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToKilonewtonsPerMegametersPerMicrosecond() => new Vector3(x * 1E-15f, y * 1E-15f, z * 1E-15f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1E+15f, y * 1E+15f, z * 1E+15f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1E+15f, v.y * 1E+15f, v.z * 1E+15f);

    public Vector3 ToKilonewtonsPerMegametersPerMillisecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToKilonewtonsPerMegametersPerSecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilonewtonsPerMegametersPerMinute() => new Vector3(x * 6E-08f, y * 6E-08f, z * 6E-08f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16666666.67f, y * 16666666.67f, z * 16666666.67f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16666666.67f, v.y * 16666666.67f, v.z * 16666666.67f);

    public Vector3 ToKilonewtonsPerMegametersPerHour() => new Vector3(x * 3.6E-06f, y * 3.6E-06f, z * 3.6E-06f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerHour(float x, float y, float z) => new TorqueAccel3(x * 277777.7778f, y * 277777.7778f, z * 277777.7778f);
    public static TorqueAccel3 KilonewtonsPerMegametersPerHour(Vector3 v) => new TorqueAccel3(v.x * 277777.7778f, v.y * 277777.7778f, v.z * 277777.7778f);

    public Vector3 ToMeganewtonsPerFeetsPerMicrosecond() => new Vector3(x * 3.048E-13f, y * 3.048E-13f, z * 3.048E-13f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 3.280839895E+12f, y * 3.280839895E+12f, z * 3.280839895E+12f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 3.280839895E+12f, v.y * 3.280839895E+12f, v.z * 3.280839895E+12f);

    public Vector3 ToMeganewtonsPerFeetsPerMillisecond() => new Vector3(x * 3.048E-10f, y * 3.048E-10f, z * 3.048E-10f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 3280839895f, y * 3280839895f, z * 3280839895f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 3280839895f, v.y * 3280839895f, v.z * 3280839895f);

    public Vector3 ToMeganewtonsPerFeetsPerSecond() => new Vector3(x * 3.048E-07f, y * 3.048E-07f, z * 3.048E-07f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerSecond(float x, float y, float z) => new TorqueAccel3(x * 3280839.895f, y * 3280839.895f, z * 3280839.895f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerSecond(Vector3 v) => new TorqueAccel3(v.x * 3280839.895f, v.y * 3280839.895f, v.z * 3280839.895f);

    public Vector3 ToMeganewtonsPerFeetsPerMinute() => new Vector3(x * 1.8288E-05f, y * 1.8288E-05f, z * 1.8288E-05f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerMinute(float x, float y, float z) => new TorqueAccel3(x * 54680.66492f, y * 54680.66492f, z * 54680.66492f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerMinute(Vector3 v) => new TorqueAccel3(v.x * 54680.66492f, v.y * 54680.66492f, v.z * 54680.66492f);

    public Vector3 ToMeganewtonsPerFeetsPerHour() => new Vector3(x * 0.00109728f, y * 0.00109728f, z * 0.00109728f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerHour(float x, float y, float z) => new TorqueAccel3(x * 911.3444153f, y * 911.3444153f, z * 911.3444153f);
    public static TorqueAccel3 MeganewtonsPerFeetsPerHour(Vector3 v) => new TorqueAccel3(v.x * 911.3444153f, v.y * 911.3444153f, v.z * 911.3444153f);

    public Vector3 ToMeganewtonsPerMilesPerMicrosecond() => new Vector3(x * 6.213711922E-16f, y * 6.213711922E-16f, z * 6.213711922E-16f);
    public static TorqueAccel3 MeganewtonsPerMilesPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1.609344E+15f, y * 1.609344E+15f, z * 1.609344E+15f);
    public static TorqueAccel3 MeganewtonsPerMilesPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1.609344E+15f, v.y * 1.609344E+15f, v.z * 1.609344E+15f);

    public Vector3 ToMeganewtonsPerMilesPerMillisecond() => new Vector3(x * 6.213711922E-13f, y * 6.213711922E-13f, z * 6.213711922E-13f);
    public static TorqueAccel3 MeganewtonsPerMilesPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1.609344E+12f, y * 1.609344E+12f, z * 1.609344E+12f);
    public static TorqueAccel3 MeganewtonsPerMilesPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1.609344E+12f, v.y * 1.609344E+12f, v.z * 1.609344E+12f);

    public Vector3 ToMeganewtonsPerMilesPerSecond() => new Vector3(x * 6.213711922E-10f, y * 6.213711922E-10f, z * 6.213711922E-10f);
    public static TorqueAccel3 MeganewtonsPerMilesPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1609344000f, y * 1609344000f, z * 1609344000f);
    public static TorqueAccel3 MeganewtonsPerMilesPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1609344000f, v.y * 1609344000f, v.z * 1609344000f);

    public Vector3 ToMeganewtonsPerMilesPerMinute() => new Vector3(x * 3.728227153E-08f, y * 3.728227153E-08f, z * 3.728227153E-08f);
    public static TorqueAccel3 MeganewtonsPerMilesPerMinute(float x, float y, float z) => new TorqueAccel3(x * 26822400f, y * 26822400f, z * 26822400f);
    public static TorqueAccel3 MeganewtonsPerMilesPerMinute(Vector3 v) => new TorqueAccel3(v.x * 26822400f, v.y * 26822400f, v.z * 26822400f);

    public Vector3 ToMeganewtonsPerMilesPerHour() => new Vector3(x * 2.236936292E-06f, y * 2.236936292E-06f, z * 2.236936292E-06f);
    public static TorqueAccel3 MeganewtonsPerMilesPerHour(float x, float y, float z) => new TorqueAccel3(x * 447040f, y * 447040f, z * 447040f);
    public static TorqueAccel3 MeganewtonsPerMilesPerHour(Vector3 v) => new TorqueAccel3(v.x * 447040f, v.y * 447040f, v.z * 447040f);

    public Vector3 ToMeganewtonsPerMillimetersPerMicrosecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerMillimetersPerMillisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeganewtonsPerMillimetersPerSecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMeganewtonsPerMillimetersPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToMeganewtonsPerMillimetersPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static TorqueAccel3 MeganewtonsPerMillimetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMeganewtonsPerCentimetersPerMicrosecond() => new Vector3(x * 1E-10f, y * 1E-10f, z * 1E-10f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1E+10f, y * 1E+10f, z * 1E+10f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1E+10f, v.y * 1E+10f, v.z * 1E+10f);

    public Vector3 ToMeganewtonsPerCentimetersPerMillisecond() => new Vector3(x * 1E-07f, y * 1E-07f, z * 1E-07f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 10000000f, y * 10000000f, z * 10000000f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 10000000f, v.y * 10000000f, v.z * 10000000f);

    public Vector3 ToMeganewtonsPerCentimetersPerSecond() => new Vector3(x * 0.0001f, y * 0.0001f, z * 0.0001f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 10000f, y * 10000f, z * 10000f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 10000f, v.y * 10000f, v.z * 10000f);

    public Vector3 ToMeganewtonsPerCentimetersPerMinute() => new Vector3(x * 0.006f, y * 0.006f, z * 0.006f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 166.6666667f, y * 166.6666667f, z * 166.6666667f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 166.6666667f, v.y * 166.6666667f, v.z * 166.6666667f);

    public Vector3 ToMeganewtonsPerCentimetersPerHour() => new Vector3(x * 0.36f, y * 0.36f, z * 0.36f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 2.777777778f, y * 2.777777778f, z * 2.777777778f);
    public static TorqueAccel3 MeganewtonsPerCentimetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 2.777777778f, v.y * 2.777777778f, v.z * 2.777777778f);

    public Vector3 ToMeganewtonsPerMetersPerMicrosecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static TorqueAccel3 MeganewtonsPerMetersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static TorqueAccel3 MeganewtonsPerMetersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMeganewtonsPerMetersPerMillisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 MeganewtonsPerMetersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 MeganewtonsPerMetersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerMetersPerSecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static TorqueAccel3 MeganewtonsPerMetersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static TorqueAccel3 MeganewtonsPerMetersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeganewtonsPerMetersPerMinute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static TorqueAccel3 MeganewtonsPerMetersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static TorqueAccel3 MeganewtonsPerMetersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMeganewtonsPerMetersPerHour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static TorqueAccel3 MeganewtonsPerMetersPerHour(float x, float y, float z) => new TorqueAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static TorqueAccel3 MeganewtonsPerMetersPerHour(Vector3 v) => new TorqueAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToMeganewtonsPerKilometersPerMicrosecond() => new Vector3(x * 1E-15f, y * 1E-15f, z * 1E-15f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1E+15f, y * 1E+15f, z * 1E+15f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1E+15f, v.y * 1E+15f, v.z * 1E+15f);

    public Vector3 ToMeganewtonsPerKilometersPerMillisecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMeganewtonsPerKilometersPerSecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerKilometersPerMinute() => new Vector3(x * 6E-08f, y * 6E-08f, z * 6E-08f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 16666666.67f, y * 16666666.67f, z * 16666666.67f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 16666666.67f, v.y * 16666666.67f, v.z * 16666666.67f);

    public Vector3 ToMeganewtonsPerKilometersPerHour() => new Vector3(x * 3.6E-06f, y * 3.6E-06f, z * 3.6E-06f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerHour(float x, float y, float z) => new TorqueAccel3(x * 277777.7778f, y * 277777.7778f, z * 277777.7778f);
    public static TorqueAccel3 MeganewtonsPerKilometersPerHour(Vector3 v) => new TorqueAccel3(v.x * 277777.7778f, v.y * 277777.7778f, v.z * 277777.7778f);

    public Vector3 ToMeganewtonsPerMegametersPerMicrosecond() => new Vector3(x * 1E-18f, y * 1E-18f, z * 1E-18f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerMicrosecond(float x, float y, float z) => new TorqueAccel3(x * 1E+18f, y * 1E+18f, z * 1E+18f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerMicrosecond(Vector3 v) => new TorqueAccel3(v.x * 1E+18f, v.y * 1E+18f, v.z * 1E+18f);

    public Vector3 ToMeganewtonsPerMegametersPerMillisecond() => new Vector3(x * 1E-15f, y * 1E-15f, z * 1E-15f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerMillisecond(float x, float y, float z) => new TorqueAccel3(x * 1E+15f, y * 1E+15f, z * 1E+15f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerMillisecond(Vector3 v) => new TorqueAccel3(v.x * 1E+15f, v.y * 1E+15f, v.z * 1E+15f);

    public Vector3 ToMeganewtonsPerMegametersPerSecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerSecond(float x, float y, float z) => new TorqueAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerSecond(Vector3 v) => new TorqueAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMeganewtonsPerMegametersPerMinute() => new Vector3(x * 6E-11f, y * 6E-11f, z * 6E-11f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerMinute(float x, float y, float z) => new TorqueAccel3(x * 1.666666667E+10f, y * 1.666666667E+10f, z * 1.666666667E+10f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerMinute(Vector3 v) => new TorqueAccel3(v.x * 1.666666667E+10f, v.y * 1.666666667E+10f, v.z * 1.666666667E+10f);

    public Vector3 ToMeganewtonsPerMegametersPerHour() => new Vector3(x * 3.6E-09f, y * 3.6E-09f, z * 3.6E-09f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerHour(float x, float y, float z) => new TorqueAccel3(x * 277777777.8f, y * 277777777.8f, z * 277777777.8f);
    public static TorqueAccel3 MeganewtonsPerMegametersPerHour(Vector3 v) => new TorqueAccel3(v.x * 277777777.8f, v.y * 277777777.8f, v.z * 277777777.8f);

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

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

    public float ToMillinewtonsPerMicrosecond() => x * 0.001f;
    public static TorqueAccel MillinewtonsPerMicrosecond(float x) => new TorqueAccel(x * 1000f);

    public float ToMillinewtonsPerMillisecond() => x * 1f;
    public static TorqueAccel MillinewtonsPerMillisecond(float x) => new TorqueAccel(x * 1f);

    public float ToMillinewtonsPerSecond() => x * 1000f;
    public static TorqueAccel MillinewtonsPerSecond(float x) => new TorqueAccel(x * 0.001f);

    public float ToMillinewtonsPerMinute() => x * 60000f;
    public static TorqueAccel MillinewtonsPerMinute(float x) => new TorqueAccel(x * 1.666666667E-05f);

    public float ToMillinewtonsPerHour() => x * 3600000f;
    public static TorqueAccel MillinewtonsPerHour(float x) => new TorqueAccel(x * 2.777777778E-07f);

    public float ToNewtonsPerMicrosecond() => x * 1E-06f;
    public static TorqueAccel NewtonsPerMicrosecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToNewtonsPerMillisecond() => x * 0.001f;
    public static TorqueAccel NewtonsPerMillisecond(float x) => new TorqueAccel(x * 1000f);

    public float ToNewtonsPerSecond() => x * 1f;
    public static TorqueAccel NewtonsPerSecond(float x) => new TorqueAccel(x * 1f);

    public float ToNewtonsPerMinute() => x * 60f;
    public static TorqueAccel NewtonsPerMinute(float x) => new TorqueAccel(x * 0.01666666667f);

    public float ToNewtonsPerHour() => x * 3600f;
    public static TorqueAccel NewtonsPerHour(float x) => new TorqueAccel(x * 0.0002777777778f);

    public float ToKilonewtonsPerMicrosecond() => x * 1E-09f;
    public static TorqueAccel KilonewtonsPerMicrosecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToKilonewtonsPerMillisecond() => x * 1E-06f;
    public static TorqueAccel KilonewtonsPerMillisecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToKilonewtonsPerSecond() => x * 0.001f;
    public static TorqueAccel KilonewtonsPerSecond(float x) => new TorqueAccel(x * 1000f);

    public float ToKilonewtonsPerMinute() => x * 0.06f;
    public static TorqueAccel KilonewtonsPerMinute(float x) => new TorqueAccel(x * 16.66666667f);

    public float ToKilonewtonsPerHour() => x * 3.6f;
    public static TorqueAccel KilonewtonsPerHour(float x) => new TorqueAccel(x * 0.2777777778f);

    public float ToMeganewtonsPerMicrosecond() => x * 1E-12f;
    public static TorqueAccel MeganewtonsPerMicrosecond(float x) => new TorqueAccel(x * 1E+12f);

    public float ToMeganewtonsPerMillisecond() => x * 1E-09f;
    public static TorqueAccel MeganewtonsPerMillisecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToMeganewtonsPerSecond() => x * 1E-06f;
    public static TorqueAccel MeganewtonsPerSecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToMeganewtonsPerMinute() => x * 6E-05f;
    public static TorqueAccel MeganewtonsPerMinute(float x) => new TorqueAccel(x * 16666.66667f);

    public float ToMeganewtonsPerHour() => x * 0.0036f;
    public static TorqueAccel MeganewtonsPerHour(float x) => new TorqueAccel(x * 277.7777778f);

    public float ToMillinewtonsPerFeetsPerMicrosecond() => x * 0.0003048f;
    public static TorqueAccel MillinewtonsPerFeetsPerMicrosecond(float x) => new TorqueAccel(x * 3280.839895f);

    public float ToMillinewtonsPerFeetsPerMillisecond() => x * 0.3048f;
    public static TorqueAccel MillinewtonsPerFeetsPerMillisecond(float x) => new TorqueAccel(x * 3.280839895f);

    public float ToMillinewtonsPerFeetsPerSecond() => x * 304.8f;
    public static TorqueAccel MillinewtonsPerFeetsPerSecond(float x) => new TorqueAccel(x * 0.003280839895f);

    public float ToMillinewtonsPerFeetsPerMinute() => x * 18288f;
    public static TorqueAccel MillinewtonsPerFeetsPerMinute(float x) => new TorqueAccel(x * 5.468066492E-05f);

    public float ToMillinewtonsPerFeetsPerHour() => x * 1097280f;
    public static TorqueAccel MillinewtonsPerFeetsPerHour(float x) => new TorqueAccel(x * 9.113444153E-07f);

    public float ToMillinewtonsPerMilesPerMicrosecond() => x * 6.213711922E-07f;
    public static TorqueAccel MillinewtonsPerMilesPerMicrosecond(float x) => new TorqueAccel(x * 1609344f);

    public float ToMillinewtonsPerMilesPerMillisecond() => x * 0.0006213711922f;
    public static TorqueAccel MillinewtonsPerMilesPerMillisecond(float x) => new TorqueAccel(x * 1609.344f);

    public float ToMillinewtonsPerMilesPerSecond() => x * 0.6213711922f;
    public static TorqueAccel MillinewtonsPerMilesPerSecond(float x) => new TorqueAccel(x * 1.609344f);

    public float ToMillinewtonsPerMilesPerMinute() => x * 37.28227153f;
    public static TorqueAccel MillinewtonsPerMilesPerMinute(float x) => new TorqueAccel(x * 0.0268224f);

    public float ToMillinewtonsPerMilesPerHour() => x * 2236.936292f;
    public static TorqueAccel MillinewtonsPerMilesPerHour(float x) => new TorqueAccel(x * 0.00044704f);

    public float ToMillinewtonsPerMillimetersPerMicrosecond() => x * 1f;
    public static TorqueAccel MillinewtonsPerMillimetersPerMicrosecond(float x) => new TorqueAccel(x * 1f);

    public float ToMillinewtonsPerMillimetersPerMillisecond() => x * 1000f;
    public static TorqueAccel MillinewtonsPerMillimetersPerMillisecond(float x) => new TorqueAccel(x * 0.001f);

    public float ToMillinewtonsPerMillimetersPerSecond() => x * 1000000f;
    public static TorqueAccel MillinewtonsPerMillimetersPerSecond(float x) => new TorqueAccel(x * 1E-06f);

    public float ToMillinewtonsPerMillimetersPerMinute() => x * 60000000f;
    public static TorqueAccel MillinewtonsPerMillimetersPerMinute(float x) => new TorqueAccel(x * 1.666666667E-08f);

    public float ToMillinewtonsPerMillimetersPerHour() => x * 3600000000f;
    public static TorqueAccel MillinewtonsPerMillimetersPerHour(float x) => new TorqueAccel(x * 2.777777778E-10f);

    public float ToMillinewtonsPerCentimetersPerMicrosecond() => x * 0.1f;
    public static TorqueAccel MillinewtonsPerCentimetersPerMicrosecond(float x) => new TorqueAccel(x * 10f);

    public float ToMillinewtonsPerCentimetersPerMillisecond() => x * 100f;
    public static TorqueAccel MillinewtonsPerCentimetersPerMillisecond(float x) => new TorqueAccel(x * 0.01f);

    public float ToMillinewtonsPerCentimetersPerSecond() => x * 100000f;
    public static TorqueAccel MillinewtonsPerCentimetersPerSecond(float x) => new TorqueAccel(x * 1E-05f);

    public float ToMillinewtonsPerCentimetersPerMinute() => x * 6000000f;
    public static TorqueAccel MillinewtonsPerCentimetersPerMinute(float x) => new TorqueAccel(x * 1.666666667E-07f);

    public float ToMillinewtonsPerCentimetersPerHour() => x * 360000000f;
    public static TorqueAccel MillinewtonsPerCentimetersPerHour(float x) => new TorqueAccel(x * 2.777777778E-09f);

    public float ToMillinewtonsPerMetersPerMicrosecond() => x * 0.001f;
    public static TorqueAccel MillinewtonsPerMetersPerMicrosecond(float x) => new TorqueAccel(x * 1000f);

    public float ToMillinewtonsPerMetersPerMillisecond() => x * 1f;
    public static TorqueAccel MillinewtonsPerMetersPerMillisecond(float x) => new TorqueAccel(x * 1f);

    public float ToMillinewtonsPerMetersPerSecond() => x * 1000f;
    public static TorqueAccel MillinewtonsPerMetersPerSecond(float x) => new TorqueAccel(x * 0.001f);

    public float ToMillinewtonsPerMetersPerMinute() => x * 60000f;
    public static TorqueAccel MillinewtonsPerMetersPerMinute(float x) => new TorqueAccel(x * 1.666666667E-05f);

    public float ToMillinewtonsPerMetersPerHour() => x * 3600000f;
    public static TorqueAccel MillinewtonsPerMetersPerHour(float x) => new TorqueAccel(x * 2.777777778E-07f);

    public float ToMillinewtonsPerKilometersPerMicrosecond() => x * 1E-06f;
    public static TorqueAccel MillinewtonsPerKilometersPerMicrosecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToMillinewtonsPerKilometersPerMillisecond() => x * 0.001f;
    public static TorqueAccel MillinewtonsPerKilometersPerMillisecond(float x) => new TorqueAccel(x * 1000f);

    public float ToMillinewtonsPerKilometersPerSecond() => x * 1f;
    public static TorqueAccel MillinewtonsPerKilometersPerSecond(float x) => new TorqueAccel(x * 1f);

    public float ToMillinewtonsPerKilometersPerMinute() => x * 60f;
    public static TorqueAccel MillinewtonsPerKilometersPerMinute(float x) => new TorqueAccel(x * 0.01666666667f);

    public float ToMillinewtonsPerKilometersPerHour() => x * 3600f;
    public static TorqueAccel MillinewtonsPerKilometersPerHour(float x) => new TorqueAccel(x * 0.0002777777778f);

    public float ToMillinewtonsPerMegametersPerMicrosecond() => x * 1E-09f;
    public static TorqueAccel MillinewtonsPerMegametersPerMicrosecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToMillinewtonsPerMegametersPerMillisecond() => x * 1E-06f;
    public static TorqueAccel MillinewtonsPerMegametersPerMillisecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToMillinewtonsPerMegametersPerSecond() => x * 0.001f;
    public static TorqueAccel MillinewtonsPerMegametersPerSecond(float x) => new TorqueAccel(x * 1000f);

    public float ToMillinewtonsPerMegametersPerMinute() => x * 0.06f;
    public static TorqueAccel MillinewtonsPerMegametersPerMinute(float x) => new TorqueAccel(x * 16.66666667f);

    public float ToMillinewtonsPerMegametersPerHour() => x * 3.6f;
    public static TorqueAccel MillinewtonsPerMegametersPerHour(float x) => new TorqueAccel(x * 0.2777777778f);

    public float ToNewtonsPerFeetsPerMicrosecond() => x * 3.048E-07f;
    public static TorqueAccel NewtonsPerFeetsPerMicrosecond(float x) => new TorqueAccel(x * 3280839.895f);

    public float ToNewtonsPerFeetsPerMillisecond() => x * 0.0003048f;
    public static TorqueAccel NewtonsPerFeetsPerMillisecond(float x) => new TorqueAccel(x * 3280.839895f);

    public float ToNewtonsPerFeetsPerSecond() => x * 0.3048f;
    public static TorqueAccel NewtonsPerFeetsPerSecond(float x) => new TorqueAccel(x * 3.280839895f);

    public float ToNewtonsPerFeetsPerMinute() => x * 18.288f;
    public static TorqueAccel NewtonsPerFeetsPerMinute(float x) => new TorqueAccel(x * 0.05468066492f);

    public float ToNewtonsPerFeetsPerHour() => x * 1097.28f;
    public static TorqueAccel NewtonsPerFeetsPerHour(float x) => new TorqueAccel(x * 0.0009113444153f);

    public float ToNewtonsPerMilesPerMicrosecond() => x * 6.213711922E-10f;
    public static TorqueAccel NewtonsPerMilesPerMicrosecond(float x) => new TorqueAccel(x * 1609344000f);

    public float ToNewtonsPerMilesPerMillisecond() => x * 6.213711922E-07f;
    public static TorqueAccel NewtonsPerMilesPerMillisecond(float x) => new TorqueAccel(x * 1609344f);

    public float ToNewtonsPerMilesPerSecond() => x * 0.0006213711922f;
    public static TorqueAccel NewtonsPerMilesPerSecond(float x) => new TorqueAccel(x * 1609.344f);

    public float ToNewtonsPerMilesPerMinute() => x * 0.03728227153f;
    public static TorqueAccel NewtonsPerMilesPerMinute(float x) => new TorqueAccel(x * 26.8224f);

    public float ToNewtonsPerMilesPerHour() => x * 2.236936292f;
    public static TorqueAccel NewtonsPerMilesPerHour(float x) => new TorqueAccel(x * 0.44704f);

    public float ToNewtonsPerMillimetersPerMicrosecond() => x * 0.001f;
    public static TorqueAccel NewtonsPerMillimetersPerMicrosecond(float x) => new TorqueAccel(x * 1000f);

    public float ToNewtonsPerMillimetersPerMillisecond() => x * 1f;
    public static TorqueAccel NewtonsPerMillimetersPerMillisecond(float x) => new TorqueAccel(x * 1f);

    public float ToNewtonsPerMillimetersPerSecond() => x * 1000f;
    public static TorqueAccel NewtonsPerMillimetersPerSecond(float x) => new TorqueAccel(x * 0.001f);

    public float ToNewtonsPerMillimetersPerMinute() => x * 60000f;
    public static TorqueAccel NewtonsPerMillimetersPerMinute(float x) => new TorqueAccel(x * 1.666666667E-05f);

    public float ToNewtonsPerMillimetersPerHour() => x * 3600000f;
    public static TorqueAccel NewtonsPerMillimetersPerHour(float x) => new TorqueAccel(x * 2.777777778E-07f);

    public float ToNewtonsPerCentimetersPerMicrosecond() => x * 0.0001f;
    public static TorqueAccel NewtonsPerCentimetersPerMicrosecond(float x) => new TorqueAccel(x * 10000f);

    public float ToNewtonsPerCentimetersPerMillisecond() => x * 0.1f;
    public static TorqueAccel NewtonsPerCentimetersPerMillisecond(float x) => new TorqueAccel(x * 10f);

    public float ToNewtonsPerCentimetersPerSecond() => x * 100f;
    public static TorqueAccel NewtonsPerCentimetersPerSecond(float x) => new TorqueAccel(x * 0.01f);

    public float ToNewtonsPerCentimetersPerMinute() => x * 6000f;
    public static TorqueAccel NewtonsPerCentimetersPerMinute(float x) => new TorqueAccel(x * 0.0001666666667f);

    public float ToNewtonsPerCentimetersPerHour() => x * 360000f;
    public static TorqueAccel NewtonsPerCentimetersPerHour(float x) => new TorqueAccel(x * 2.777777778E-06f);

    public float ToNewtonsPerMetersPerMicrosecond() => x * 1E-06f;
    public static TorqueAccel NewtonsPerMetersPerMicrosecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToNewtonsPerMetersPerMillisecond() => x * 0.001f;
    public static TorqueAccel NewtonsPerMetersPerMillisecond(float x) => new TorqueAccel(x * 1000f);

    public float ToNewtonsPerMetersPerSecond() => x * 1f;
    public static TorqueAccel NewtonsPerMetersPerSecond(float x) => new TorqueAccel(x * 1f);

    public float ToNewtonsPerMetersPerMinute() => x * 60f;
    public static TorqueAccel NewtonsPerMetersPerMinute(float x) => new TorqueAccel(x * 0.01666666667f);

    public float ToNewtonsPerMetersPerHour() => x * 3600f;
    public static TorqueAccel NewtonsPerMetersPerHour(float x) => new TorqueAccel(x * 0.0002777777778f);

    public float ToNewtonsPerKilometersPerMicrosecond() => x * 1E-09f;
    public static TorqueAccel NewtonsPerKilometersPerMicrosecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToNewtonsPerKilometersPerMillisecond() => x * 1E-06f;
    public static TorqueAccel NewtonsPerKilometersPerMillisecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToNewtonsPerKilometersPerSecond() => x * 0.001f;
    public static TorqueAccel NewtonsPerKilometersPerSecond(float x) => new TorqueAccel(x * 1000f);

    public float ToNewtonsPerKilometersPerMinute() => x * 0.06f;
    public static TorqueAccel NewtonsPerKilometersPerMinute(float x) => new TorqueAccel(x * 16.66666667f);

    public float ToNewtonsPerKilometersPerHour() => x * 3.6f;
    public static TorqueAccel NewtonsPerKilometersPerHour(float x) => new TorqueAccel(x * 0.2777777778f);

    public float ToNewtonsPerMegametersPerMicrosecond() => x * 1E-12f;
    public static TorqueAccel NewtonsPerMegametersPerMicrosecond(float x) => new TorqueAccel(x * 1E+12f);

    public float ToNewtonsPerMegametersPerMillisecond() => x * 1E-09f;
    public static TorqueAccel NewtonsPerMegametersPerMillisecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToNewtonsPerMegametersPerSecond() => x * 1E-06f;
    public static TorqueAccel NewtonsPerMegametersPerSecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToNewtonsPerMegametersPerMinute() => x * 6E-05f;
    public static TorqueAccel NewtonsPerMegametersPerMinute(float x) => new TorqueAccel(x * 16666.66667f);

    public float ToNewtonsPerMegametersPerHour() => x * 0.0036f;
    public static TorqueAccel NewtonsPerMegametersPerHour(float x) => new TorqueAccel(x * 277.7777778f);

    public float ToKilonewtonsPerFeetsPerMicrosecond() => x * 3.048E-10f;
    public static TorqueAccel KilonewtonsPerFeetsPerMicrosecond(float x) => new TorqueAccel(x * 3280839895f);

    public float ToKilonewtonsPerFeetsPerMillisecond() => x * 3.048E-07f;
    public static TorqueAccel KilonewtonsPerFeetsPerMillisecond(float x) => new TorqueAccel(x * 3280839.895f);

    public float ToKilonewtonsPerFeetsPerSecond() => x * 0.0003048f;
    public static TorqueAccel KilonewtonsPerFeetsPerSecond(float x) => new TorqueAccel(x * 3280.839895f);

    public float ToKilonewtonsPerFeetsPerMinute() => x * 0.018288f;
    public static TorqueAccel KilonewtonsPerFeetsPerMinute(float x) => new TorqueAccel(x * 54.68066492f);

    public float ToKilonewtonsPerFeetsPerHour() => x * 1.09728f;
    public static TorqueAccel KilonewtonsPerFeetsPerHour(float x) => new TorqueAccel(x * 0.9113444153f);

    public float ToKilonewtonsPerMilesPerMicrosecond() => x * 6.213711922E-13f;
    public static TorqueAccel KilonewtonsPerMilesPerMicrosecond(float x) => new TorqueAccel(x * 1.609344E+12f);

    public float ToKilonewtonsPerMilesPerMillisecond() => x * 6.213711922E-10f;
    public static TorqueAccel KilonewtonsPerMilesPerMillisecond(float x) => new TorqueAccel(x * 1609344000f);

    public float ToKilonewtonsPerMilesPerSecond() => x * 6.213711922E-07f;
    public static TorqueAccel KilonewtonsPerMilesPerSecond(float x) => new TorqueAccel(x * 1609344f);

    public float ToKilonewtonsPerMilesPerMinute() => x * 3.728227153E-05f;
    public static TorqueAccel KilonewtonsPerMilesPerMinute(float x) => new TorqueAccel(x * 26822.4f);

    public float ToKilonewtonsPerMilesPerHour() => x * 0.002236936292f;
    public static TorqueAccel KilonewtonsPerMilesPerHour(float x) => new TorqueAccel(x * 447.04f);

    public float ToKilonewtonsPerMillimetersPerMicrosecond() => x * 1E-06f;
    public static TorqueAccel KilonewtonsPerMillimetersPerMicrosecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToKilonewtonsPerMillimetersPerMillisecond() => x * 0.001f;
    public static TorqueAccel KilonewtonsPerMillimetersPerMillisecond(float x) => new TorqueAccel(x * 1000f);

    public float ToKilonewtonsPerMillimetersPerSecond() => x * 1f;
    public static TorqueAccel KilonewtonsPerMillimetersPerSecond(float x) => new TorqueAccel(x * 1f);

    public float ToKilonewtonsPerMillimetersPerMinute() => x * 60f;
    public static TorqueAccel KilonewtonsPerMillimetersPerMinute(float x) => new TorqueAccel(x * 0.01666666667f);

    public float ToKilonewtonsPerMillimetersPerHour() => x * 3600f;
    public static TorqueAccel KilonewtonsPerMillimetersPerHour(float x) => new TorqueAccel(x * 0.0002777777778f);

    public float ToKilonewtonsPerCentimetersPerMicrosecond() => x * 1E-07f;
    public static TorqueAccel KilonewtonsPerCentimetersPerMicrosecond(float x) => new TorqueAccel(x * 10000000f);

    public float ToKilonewtonsPerCentimetersPerMillisecond() => x * 0.0001f;
    public static TorqueAccel KilonewtonsPerCentimetersPerMillisecond(float x) => new TorqueAccel(x * 10000f);

    public float ToKilonewtonsPerCentimetersPerSecond() => x * 0.1f;
    public static TorqueAccel KilonewtonsPerCentimetersPerSecond(float x) => new TorqueAccel(x * 10f);

    public float ToKilonewtonsPerCentimetersPerMinute() => x * 6f;
    public static TorqueAccel KilonewtonsPerCentimetersPerMinute(float x) => new TorqueAccel(x * 0.1666666667f);

    public float ToKilonewtonsPerCentimetersPerHour() => x * 360f;
    public static TorqueAccel KilonewtonsPerCentimetersPerHour(float x) => new TorqueAccel(x * 0.002777777778f);

    public float ToKilonewtonsPerMetersPerMicrosecond() => x * 1E-09f;
    public static TorqueAccel KilonewtonsPerMetersPerMicrosecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToKilonewtonsPerMetersPerMillisecond() => x * 1E-06f;
    public static TorqueAccel KilonewtonsPerMetersPerMillisecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToKilonewtonsPerMetersPerSecond() => x * 0.001f;
    public static TorqueAccel KilonewtonsPerMetersPerSecond(float x) => new TorqueAccel(x * 1000f);

    public float ToKilonewtonsPerMetersPerMinute() => x * 0.06f;
    public static TorqueAccel KilonewtonsPerMetersPerMinute(float x) => new TorqueAccel(x * 16.66666667f);

    public float ToKilonewtonsPerMetersPerHour() => x * 3.6f;
    public static TorqueAccel KilonewtonsPerMetersPerHour(float x) => new TorqueAccel(x * 0.2777777778f);

    public float ToKilonewtonsPerKilometersPerMicrosecond() => x * 1E-12f;
    public static TorqueAccel KilonewtonsPerKilometersPerMicrosecond(float x) => new TorqueAccel(x * 1E+12f);

    public float ToKilonewtonsPerKilometersPerMillisecond() => x * 1E-09f;
    public static TorqueAccel KilonewtonsPerKilometersPerMillisecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToKilonewtonsPerKilometersPerSecond() => x * 1E-06f;
    public static TorqueAccel KilonewtonsPerKilometersPerSecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToKilonewtonsPerKilometersPerMinute() => x * 6E-05f;
    public static TorqueAccel KilonewtonsPerKilometersPerMinute(float x) => new TorqueAccel(x * 16666.66667f);

    public float ToKilonewtonsPerKilometersPerHour() => x * 0.0036f;
    public static TorqueAccel KilonewtonsPerKilometersPerHour(float x) => new TorqueAccel(x * 277.7777778f);

    public float ToKilonewtonsPerMegametersPerMicrosecond() => x * 1E-15f;
    public static TorqueAccel KilonewtonsPerMegametersPerMicrosecond(float x) => new TorqueAccel(x * 1E+15f);

    public float ToKilonewtonsPerMegametersPerMillisecond() => x * 1E-12f;
    public static TorqueAccel KilonewtonsPerMegametersPerMillisecond(float x) => new TorqueAccel(x * 1E+12f);

    public float ToKilonewtonsPerMegametersPerSecond() => x * 1E-09f;
    public static TorqueAccel KilonewtonsPerMegametersPerSecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToKilonewtonsPerMegametersPerMinute() => x * 6E-08f;
    public static TorqueAccel KilonewtonsPerMegametersPerMinute(float x) => new TorqueAccel(x * 16666666.67f);

    public float ToKilonewtonsPerMegametersPerHour() => x * 3.6E-06f;
    public static TorqueAccel KilonewtonsPerMegametersPerHour(float x) => new TorqueAccel(x * 277777.7778f);

    public float ToMeganewtonsPerFeetsPerMicrosecond() => x * 3.048E-13f;
    public static TorqueAccel MeganewtonsPerFeetsPerMicrosecond(float x) => new TorqueAccel(x * 3.280839895E+12f);

    public float ToMeganewtonsPerFeetsPerMillisecond() => x * 3.048E-10f;
    public static TorqueAccel MeganewtonsPerFeetsPerMillisecond(float x) => new TorqueAccel(x * 3280839895f);

    public float ToMeganewtonsPerFeetsPerSecond() => x * 3.048E-07f;
    public static TorqueAccel MeganewtonsPerFeetsPerSecond(float x) => new TorqueAccel(x * 3280839.895f);

    public float ToMeganewtonsPerFeetsPerMinute() => x * 1.8288E-05f;
    public static TorqueAccel MeganewtonsPerFeetsPerMinute(float x) => new TorqueAccel(x * 54680.66492f);

    public float ToMeganewtonsPerFeetsPerHour() => x * 0.00109728f;
    public static TorqueAccel MeganewtonsPerFeetsPerHour(float x) => new TorqueAccel(x * 911.3444153f);

    public float ToMeganewtonsPerMilesPerMicrosecond() => x * 6.213711922E-16f;
    public static TorqueAccel MeganewtonsPerMilesPerMicrosecond(float x) => new TorqueAccel(x * 1.609344E+15f);

    public float ToMeganewtonsPerMilesPerMillisecond() => x * 6.213711922E-13f;
    public static TorqueAccel MeganewtonsPerMilesPerMillisecond(float x) => new TorqueAccel(x * 1.609344E+12f);

    public float ToMeganewtonsPerMilesPerSecond() => x * 6.213711922E-10f;
    public static TorqueAccel MeganewtonsPerMilesPerSecond(float x) => new TorqueAccel(x * 1609344000f);

    public float ToMeganewtonsPerMilesPerMinute() => x * 3.728227153E-08f;
    public static TorqueAccel MeganewtonsPerMilesPerMinute(float x) => new TorqueAccel(x * 26822400f);

    public float ToMeganewtonsPerMilesPerHour() => x * 2.236936292E-06f;
    public static TorqueAccel MeganewtonsPerMilesPerHour(float x) => new TorqueAccel(x * 447040f);

    public float ToMeganewtonsPerMillimetersPerMicrosecond() => x * 1E-09f;
    public static TorqueAccel MeganewtonsPerMillimetersPerMicrosecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToMeganewtonsPerMillimetersPerMillisecond() => x * 1E-06f;
    public static TorqueAccel MeganewtonsPerMillimetersPerMillisecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToMeganewtonsPerMillimetersPerSecond() => x * 0.001f;
    public static TorqueAccel MeganewtonsPerMillimetersPerSecond(float x) => new TorqueAccel(x * 1000f);

    public float ToMeganewtonsPerMillimetersPerMinute() => x * 0.06f;
    public static TorqueAccel MeganewtonsPerMillimetersPerMinute(float x) => new TorqueAccel(x * 16.66666667f);

    public float ToMeganewtonsPerMillimetersPerHour() => x * 3.6f;
    public static TorqueAccel MeganewtonsPerMillimetersPerHour(float x) => new TorqueAccel(x * 0.2777777778f);

    public float ToMeganewtonsPerCentimetersPerMicrosecond() => x * 1E-10f;
    public static TorqueAccel MeganewtonsPerCentimetersPerMicrosecond(float x) => new TorqueAccel(x * 1E+10f);

    public float ToMeganewtonsPerCentimetersPerMillisecond() => x * 1E-07f;
    public static TorqueAccel MeganewtonsPerCentimetersPerMillisecond(float x) => new TorqueAccel(x * 10000000f);

    public float ToMeganewtonsPerCentimetersPerSecond() => x * 0.0001f;
    public static TorqueAccel MeganewtonsPerCentimetersPerSecond(float x) => new TorqueAccel(x * 10000f);

    public float ToMeganewtonsPerCentimetersPerMinute() => x * 0.006f;
    public static TorqueAccel MeganewtonsPerCentimetersPerMinute(float x) => new TorqueAccel(x * 166.6666667f);

    public float ToMeganewtonsPerCentimetersPerHour() => x * 0.36f;
    public static TorqueAccel MeganewtonsPerCentimetersPerHour(float x) => new TorqueAccel(x * 2.777777778f);

    public float ToMeganewtonsPerMetersPerMicrosecond() => x * 1E-12f;
    public static TorqueAccel MeganewtonsPerMetersPerMicrosecond(float x) => new TorqueAccel(x * 1E+12f);

    public float ToMeganewtonsPerMetersPerMillisecond() => x * 1E-09f;
    public static TorqueAccel MeganewtonsPerMetersPerMillisecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToMeganewtonsPerMetersPerSecond() => x * 1E-06f;
    public static TorqueAccel MeganewtonsPerMetersPerSecond(float x) => new TorqueAccel(x * 1000000f);

    public float ToMeganewtonsPerMetersPerMinute() => x * 6E-05f;
    public static TorqueAccel MeganewtonsPerMetersPerMinute(float x) => new TorqueAccel(x * 16666.66667f);

    public float ToMeganewtonsPerMetersPerHour() => x * 0.0036f;
    public static TorqueAccel MeganewtonsPerMetersPerHour(float x) => new TorqueAccel(x * 277.7777778f);

    public float ToMeganewtonsPerKilometersPerMicrosecond() => x * 1E-15f;
    public static TorqueAccel MeganewtonsPerKilometersPerMicrosecond(float x) => new TorqueAccel(x * 1E+15f);

    public float ToMeganewtonsPerKilometersPerMillisecond() => x * 1E-12f;
    public static TorqueAccel MeganewtonsPerKilometersPerMillisecond(float x) => new TorqueAccel(x * 1E+12f);

    public float ToMeganewtonsPerKilometersPerSecond() => x * 1E-09f;
    public static TorqueAccel MeganewtonsPerKilometersPerSecond(float x) => new TorqueAccel(x * 1000000000f);

    public float ToMeganewtonsPerKilometersPerMinute() => x * 6E-08f;
    public static TorqueAccel MeganewtonsPerKilometersPerMinute(float x) => new TorqueAccel(x * 16666666.67f);

    public float ToMeganewtonsPerKilometersPerHour() => x * 3.6E-06f;
    public static TorqueAccel MeganewtonsPerKilometersPerHour(float x) => new TorqueAccel(x * 277777.7778f);

    public float ToMeganewtonsPerMegametersPerMicrosecond() => x * 1E-18f;
    public static TorqueAccel MeganewtonsPerMegametersPerMicrosecond(float x) => new TorqueAccel(x * 1E+18f);

    public float ToMeganewtonsPerMegametersPerMillisecond() => x * 1E-15f;
    public static TorqueAccel MeganewtonsPerMegametersPerMillisecond(float x) => new TorqueAccel(x * 1E+15f);

    public float ToMeganewtonsPerMegametersPerSecond() => x * 1E-12f;
    public static TorqueAccel MeganewtonsPerMegametersPerSecond(float x) => new TorqueAccel(x * 1E+12f);

    public float ToMeganewtonsPerMegametersPerMinute() => x * 6E-11f;
    public static TorqueAccel MeganewtonsPerMegametersPerMinute(float x) => new TorqueAccel(x * 1.666666667E+10f);

    public float ToMeganewtonsPerMegametersPerHour() => x * 3.6E-09f;
    public static TorqueAccel MeganewtonsPerMegametersPerHour(float x) => new TorqueAccel(x * 277777777.8f);

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

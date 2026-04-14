using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Accel : IAutoUnit {
    public float x;
    
    public Accel(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(Accel v) => v.x;
    public Accel magnitude => new(x);

    public float ToFeetsPerMicrosecond2() => x * 3.048E-13f;
    public static Accel FeetsPerMicrosecond2(float x) => new Accel(x * 3.280839895E+12f);

    public float ToFeetsPerMicrosecondsPerMillisecond() => x * 3.048E-10f;
    public static Accel FeetsPerMicrosecondsPerMillisecond(float x) => new Accel(x * 3280839895f);

    public float ToFeetsPerMicrosecondsPerSecond() => x * 3.048E-07f;
    public static Accel FeetsPerMicrosecondsPerSecond(float x) => new Accel(x * 3280839.895f);

    public float ToFeetsPerMicrosecondsPerMinute() => x * 1.8288E-05f;
    public static Accel FeetsPerMicrosecondsPerMinute(float x) => new Accel(x * 54680.66492f);

    public float ToFeetsPerMicrosecondsPerHour() => x * 0.00109728f;
    public static Accel FeetsPerMicrosecondsPerHour(float x) => new Accel(x * 911.3444153f);

    public float ToFeetsPerMillisecondsPerMicrosecond() => x * 3.048E-10f;
    public static Accel FeetsPerMillisecondsPerMicrosecond(float x) => new Accel(x * 3280839895f);

    public float ToFeetsPerMillisecond2() => x * 3.048E-07f;
    public static Accel FeetsPerMillisecond2(float x) => new Accel(x * 3280839.895f);

    public float ToFeetsPerMillisecondsPerSecond() => x * 0.0003048f;
    public static Accel FeetsPerMillisecondsPerSecond(float x) => new Accel(x * 3280.839895f);

    public float ToFeetsPerMillisecondsPerMinute() => x * 0.018288f;
    public static Accel FeetsPerMillisecondsPerMinute(float x) => new Accel(x * 54.68066492f);

    public float ToFeetsPerMillisecondsPerHour() => x * 1.09728f;
    public static Accel FeetsPerMillisecondsPerHour(float x) => new Accel(x * 0.9113444153f);

    public float ToFeetsPerSecondsPerMicrosecond() => x * 3.048E-07f;
    public static Accel FeetsPerSecondsPerMicrosecond(float x) => new Accel(x * 3280839.895f);

    public float ToFeetsPerSecondsPerMillisecond() => x * 0.0003048f;
    public static Accel FeetsPerSecondsPerMillisecond(float x) => new Accel(x * 3280.839895f);

    public float ToFeetsPerSecond2() => x * 0.3048f;
    public static Accel FeetsPerSecond2(float x) => new Accel(x * 3.280839895f);

    public float ToFeetsPerSecondsPerMinute() => x * 18.288f;
    public static Accel FeetsPerSecondsPerMinute(float x) => new Accel(x * 0.05468066492f);

    public float ToFeetsPerSecondsPerHour() => x * 1097.28f;
    public static Accel FeetsPerSecondsPerHour(float x) => new Accel(x * 0.0009113444153f);

    public float ToFeetsPerMinutesPerMicrosecond() => x * 1.8288E-05f;
    public static Accel FeetsPerMinutesPerMicrosecond(float x) => new Accel(x * 54680.66492f);

    public float ToFeetsPerMinutesPerMillisecond() => x * 0.018288f;
    public static Accel FeetsPerMinutesPerMillisecond(float x) => new Accel(x * 54.68066492f);

    public float ToFeetsPerMinutesPerSecond() => x * 18.288f;
    public static Accel FeetsPerMinutesPerSecond(float x) => new Accel(x * 0.05468066492f);

    public float ToFeetsPerMinute2() => x * 1097.28f;
    public static Accel FeetsPerMinute2(float x) => new Accel(x * 0.0009113444153f);

    public float ToFeetsPerMinutesPerHour() => x * 65836.8f;
    public static Accel FeetsPerMinutesPerHour(float x) => new Accel(x * 1.518907359E-05f);

    public float ToFeetsPerHoursPerMicrosecond() => x * 0.00109728f;
    public static Accel FeetsPerHoursPerMicrosecond(float x) => new Accel(x * 911.3444153f);

    public float ToFeetsPerHoursPerMillisecond() => x * 1.09728f;
    public static Accel FeetsPerHoursPerMillisecond(float x) => new Accel(x * 0.9113444153f);

    public float ToFeetsPerHoursPerSecond() => x * 1097.28f;
    public static Accel FeetsPerHoursPerSecond(float x) => new Accel(x * 0.0009113444153f);

    public float ToFeetsPerHoursPerMinute() => x * 65836.8f;
    public static Accel FeetsPerHoursPerMinute(float x) => new Accel(x * 1.518907359E-05f);

    public float ToFeetsPerHour2() => x * 3950208f;
    public static Accel FeetsPerHour2(float x) => new Accel(x * 2.531512265E-07f);

    public float ToMilesPerMicrosecond2() => x * 6.213711922E-16f;
    public static Accel MilesPerMicrosecond2(float x) => new Accel(x * 1.609344E+15f);

    public float ToMilesPerMicrosecondsPerMillisecond() => x * 6.213711922E-13f;
    public static Accel MilesPerMicrosecondsPerMillisecond(float x) => new Accel(x * 1.609344E+12f);

    public float ToMilesPerMicrosecondsPerSecond() => x * 6.213711922E-10f;
    public static Accel MilesPerMicrosecondsPerSecond(float x) => new Accel(x * 1609344000f);

    public float ToMilesPerMicrosecondsPerMinute() => x * 3.728227153E-08f;
    public static Accel MilesPerMicrosecondsPerMinute(float x) => new Accel(x * 26822400f);

    public float ToMilesPerMicrosecondsPerHour() => x * 2.236936292E-06f;
    public static Accel MilesPerMicrosecondsPerHour(float x) => new Accel(x * 447040f);

    public float ToMilesPerMillisecondsPerMicrosecond() => x * 6.213711922E-13f;
    public static Accel MilesPerMillisecondsPerMicrosecond(float x) => new Accel(x * 1.609344E+12f);

    public float ToMilesPerMillisecond2() => x * 6.213711922E-10f;
    public static Accel MilesPerMillisecond2(float x) => new Accel(x * 1609344000f);

    public float ToMilesPerMillisecondsPerSecond() => x * 6.213711922E-07f;
    public static Accel MilesPerMillisecondsPerSecond(float x) => new Accel(x * 1609344f);

    public float ToMilesPerMillisecondsPerMinute() => x * 3.728227153E-05f;
    public static Accel MilesPerMillisecondsPerMinute(float x) => new Accel(x * 26822.4f);

    public float ToMilesPerMillisecondsPerHour() => x * 0.002236936292f;
    public static Accel MilesPerMillisecondsPerHour(float x) => new Accel(x * 447.04f);

    public float ToMilesPerSecondsPerMicrosecond() => x * 6.213711922E-10f;
    public static Accel MilesPerSecondsPerMicrosecond(float x) => new Accel(x * 1609344000f);

    public float ToMilesPerSecondsPerMillisecond() => x * 6.213711922E-07f;
    public static Accel MilesPerSecondsPerMillisecond(float x) => new Accel(x * 1609344f);

    public float ToMilesPerSecond2() => x * 0.0006213711922f;
    public static Accel MilesPerSecond2(float x) => new Accel(x * 1609.344f);

    public float ToMilesPerSecondsPerMinute() => x * 0.03728227153f;
    public static Accel MilesPerSecondsPerMinute(float x) => new Accel(x * 26.8224f);

    public float ToMilesPerSecondsPerHour() => x * 2.236936292f;
    public static Accel MilesPerSecondsPerHour(float x) => new Accel(x * 0.44704f);

    public float ToMilesPerMinutesPerMicrosecond() => x * 3.728227153E-08f;
    public static Accel MilesPerMinutesPerMicrosecond(float x) => new Accel(x * 26822400f);

    public float ToMilesPerMinutesPerMillisecond() => x * 3.728227153E-05f;
    public static Accel MilesPerMinutesPerMillisecond(float x) => new Accel(x * 26822.4f);

    public float ToMilesPerMinutesPerSecond() => x * 0.03728227153f;
    public static Accel MilesPerMinutesPerSecond(float x) => new Accel(x * 26.8224f);

    public float ToMilesPerMinute2() => x * 2.236936292f;
    public static Accel MilesPerMinute2(float x) => new Accel(x * 0.44704f);

    public float ToMilesPerMinutesPerHour() => x * 134.2161775f;
    public static Accel MilesPerMinutesPerHour(float x) => new Accel(x * 0.007450666667f);

    public float ToMilesPerHoursPerMicrosecond() => x * 2.236936292E-06f;
    public static Accel MilesPerHoursPerMicrosecond(float x) => new Accel(x * 447040f);

    public float ToMilesPerHoursPerMillisecond() => x * 0.002236936292f;
    public static Accel MilesPerHoursPerMillisecond(float x) => new Accel(x * 447.04f);

    public float ToMilesPerHoursPerSecond() => x * 2.236936292f;
    public static Accel MilesPerHoursPerSecond(float x) => new Accel(x * 0.44704f);

    public float ToMilesPerHoursPerMinute() => x * 134.2161775f;
    public static Accel MilesPerHoursPerMinute(float x) => new Accel(x * 0.007450666667f);

    public float ToMilesPerHour2() => x * 8052.970651f;
    public static Accel MilesPerHour2(float x) => new Accel(x * 0.0001241777778f);

    public float ToMillimetersPerMicrosecond2() => x * 1E-09f;
    public static Accel MillimetersPerMicrosecond2(float x) => new Accel(x * 1000000000f);

    public float ToMillimetersPerMicrosecondsPerMillisecond() => x * 1E-06f;
    public static Accel MillimetersPerMicrosecondsPerMillisecond(float x) => new Accel(x * 1000000f);

    public float ToMillimetersPerMicrosecondsPerSecond() => x * 0.001f;
    public static Accel MillimetersPerMicrosecondsPerSecond(float x) => new Accel(x * 1000f);

    public float ToMillimetersPerMicrosecondsPerMinute() => x * 0.06f;
    public static Accel MillimetersPerMicrosecondsPerMinute(float x) => new Accel(x * 16.66666667f);

    public float ToMillimetersPerMicrosecondsPerHour() => x * 3.6f;
    public static Accel MillimetersPerMicrosecondsPerHour(float x) => new Accel(x * 0.2777777778f);

    public float ToMillimetersPerMillisecondsPerMicrosecond() => x * 1E-06f;
    public static Accel MillimetersPerMillisecondsPerMicrosecond(float x) => new Accel(x * 1000000f);

    public float ToMillimetersPerMillisecond2() => x * 0.001f;
    public static Accel MillimetersPerMillisecond2(float x) => new Accel(x * 1000f);

    public float ToMillimetersPerMillisecondsPerSecond() => x * 1f;
    public static Accel MillimetersPerMillisecondsPerSecond(float x) => new Accel(x * 1f);

    public float ToMillimetersPerMillisecondsPerMinute() => x * 60f;
    public static Accel MillimetersPerMillisecondsPerMinute(float x) => new Accel(x * 0.01666666667f);

    public float ToMillimetersPerMillisecondsPerHour() => x * 3600f;
    public static Accel MillimetersPerMillisecondsPerHour(float x) => new Accel(x * 0.0002777777778f);

    public float ToMillimetersPerSecondsPerMicrosecond() => x * 0.001f;
    public static Accel MillimetersPerSecondsPerMicrosecond(float x) => new Accel(x * 1000f);

    public float ToMillimetersPerSecondsPerMillisecond() => x * 1f;
    public static Accel MillimetersPerSecondsPerMillisecond(float x) => new Accel(x * 1f);

    public float ToMillimetersPerSecond2() => x * 1000f;
    public static Accel MillimetersPerSecond2(float x) => new Accel(x * 0.001f);

    public float ToMillimetersPerSecondsPerMinute() => x * 60000f;
    public static Accel MillimetersPerSecondsPerMinute(float x) => new Accel(x * 1.666666667E-05f);

    public float ToMillimetersPerSecondsPerHour() => x * 3600000f;
    public static Accel MillimetersPerSecondsPerHour(float x) => new Accel(x * 2.777777778E-07f);

    public float ToMillimetersPerMinutesPerMicrosecond() => x * 0.06f;
    public static Accel MillimetersPerMinutesPerMicrosecond(float x) => new Accel(x * 16.66666667f);

    public float ToMillimetersPerMinutesPerMillisecond() => x * 60f;
    public static Accel MillimetersPerMinutesPerMillisecond(float x) => new Accel(x * 0.01666666667f);

    public float ToMillimetersPerMinutesPerSecond() => x * 60000f;
    public static Accel MillimetersPerMinutesPerSecond(float x) => new Accel(x * 1.666666667E-05f);

    public float ToMillimetersPerMinute2() => x * 3600000f;
    public static Accel MillimetersPerMinute2(float x) => new Accel(x * 2.777777778E-07f);

    public float ToMillimetersPerMinutesPerHour() => x * 216000000f;
    public static Accel MillimetersPerMinutesPerHour(float x) => new Accel(x * 4.62962963E-09f);

    public float ToMillimetersPerHoursPerMicrosecond() => x * 3.6f;
    public static Accel MillimetersPerHoursPerMicrosecond(float x) => new Accel(x * 0.2777777778f);

    public float ToMillimetersPerHoursPerMillisecond() => x * 3600f;
    public static Accel MillimetersPerHoursPerMillisecond(float x) => new Accel(x * 0.0002777777778f);

    public float ToMillimetersPerHoursPerSecond() => x * 3600000f;
    public static Accel MillimetersPerHoursPerSecond(float x) => new Accel(x * 2.777777778E-07f);

    public float ToMillimetersPerHoursPerMinute() => x * 216000000f;
    public static Accel MillimetersPerHoursPerMinute(float x) => new Accel(x * 4.62962963E-09f);

    public float ToMillimetersPerHour2() => x * 1.296E+10f;
    public static Accel MillimetersPerHour2(float x) => new Accel(x * 7.716049383E-11f);

    public float ToCentimetersPerMicrosecond2() => x * 1E-10f;
    public static Accel CentimetersPerMicrosecond2(float x) => new Accel(x * 1E+10f);

    public float ToCentimetersPerMicrosecondsPerMillisecond() => x * 1E-07f;
    public static Accel CentimetersPerMicrosecondsPerMillisecond(float x) => new Accel(x * 10000000f);

    public float ToCentimetersPerMicrosecondsPerSecond() => x * 0.0001f;
    public static Accel CentimetersPerMicrosecondsPerSecond(float x) => new Accel(x * 10000f);

    public float ToCentimetersPerMicrosecondsPerMinute() => x * 0.006f;
    public static Accel CentimetersPerMicrosecondsPerMinute(float x) => new Accel(x * 166.6666667f);

    public float ToCentimetersPerMicrosecondsPerHour() => x * 0.36f;
    public static Accel CentimetersPerMicrosecondsPerHour(float x) => new Accel(x * 2.777777778f);

    public float ToCentimetersPerMillisecondsPerMicrosecond() => x * 1E-07f;
    public static Accel CentimetersPerMillisecondsPerMicrosecond(float x) => new Accel(x * 10000000f);

    public float ToCentimetersPerMillisecond2() => x * 0.0001f;
    public static Accel CentimetersPerMillisecond2(float x) => new Accel(x * 10000f);

    public float ToCentimetersPerMillisecondsPerSecond() => x * 0.1f;
    public static Accel CentimetersPerMillisecondsPerSecond(float x) => new Accel(x * 10f);

    public float ToCentimetersPerMillisecondsPerMinute() => x * 6f;
    public static Accel CentimetersPerMillisecondsPerMinute(float x) => new Accel(x * 0.1666666667f);

    public float ToCentimetersPerMillisecondsPerHour() => x * 360f;
    public static Accel CentimetersPerMillisecondsPerHour(float x) => new Accel(x * 0.002777777778f);

    public float ToCentimetersPerSecondsPerMicrosecond() => x * 0.0001f;
    public static Accel CentimetersPerSecondsPerMicrosecond(float x) => new Accel(x * 10000f);

    public float ToCentimetersPerSecondsPerMillisecond() => x * 0.1f;
    public static Accel CentimetersPerSecondsPerMillisecond(float x) => new Accel(x * 10f);

    public float ToCentimetersPerSecond2() => x * 100f;
    public static Accel CentimetersPerSecond2(float x) => new Accel(x * 0.01f);

    public float ToCentimetersPerSecondsPerMinute() => x * 6000f;
    public static Accel CentimetersPerSecondsPerMinute(float x) => new Accel(x * 0.0001666666667f);

    public float ToCentimetersPerSecondsPerHour() => x * 360000f;
    public static Accel CentimetersPerSecondsPerHour(float x) => new Accel(x * 2.777777778E-06f);

    public float ToCentimetersPerMinutesPerMicrosecond() => x * 0.006f;
    public static Accel CentimetersPerMinutesPerMicrosecond(float x) => new Accel(x * 166.6666667f);

    public float ToCentimetersPerMinutesPerMillisecond() => x * 6f;
    public static Accel CentimetersPerMinutesPerMillisecond(float x) => new Accel(x * 0.1666666667f);

    public float ToCentimetersPerMinutesPerSecond() => x * 6000f;
    public static Accel CentimetersPerMinutesPerSecond(float x) => new Accel(x * 0.0001666666667f);

    public float ToCentimetersPerMinute2() => x * 360000f;
    public static Accel CentimetersPerMinute2(float x) => new Accel(x * 2.777777778E-06f);

    public float ToCentimetersPerMinutesPerHour() => x * 21600000f;
    public static Accel CentimetersPerMinutesPerHour(float x) => new Accel(x * 4.62962963E-08f);

    public float ToCentimetersPerHoursPerMicrosecond() => x * 0.36f;
    public static Accel CentimetersPerHoursPerMicrosecond(float x) => new Accel(x * 2.777777778f);

    public float ToCentimetersPerHoursPerMillisecond() => x * 360f;
    public static Accel CentimetersPerHoursPerMillisecond(float x) => new Accel(x * 0.002777777778f);

    public float ToCentimetersPerHoursPerSecond() => x * 360000f;
    public static Accel CentimetersPerHoursPerSecond(float x) => new Accel(x * 2.777777778E-06f);

    public float ToCentimetersPerHoursPerMinute() => x * 21600000f;
    public static Accel CentimetersPerHoursPerMinute(float x) => new Accel(x * 4.62962963E-08f);

    public float ToCentimetersPerHour2() => x * 1296000000f;
    public static Accel CentimetersPerHour2(float x) => new Accel(x * 7.716049383E-10f);

    public float ToMetersPerMicrosecond2() => x * 1E-12f;
    public static Accel MetersPerMicrosecond2(float x) => new Accel(x * 1E+12f);

    public float ToMetersPerMicrosecondsPerMillisecond() => x * 1E-09f;
    public static Accel MetersPerMicrosecondsPerMillisecond(float x) => new Accel(x * 1000000000f);

    public float ToMetersPerMicrosecondsPerSecond() => x * 1E-06f;
    public static Accel MetersPerMicrosecondsPerSecond(float x) => new Accel(x * 1000000f);

    public float ToMetersPerMicrosecondsPerMinute() => x * 6E-05f;
    public static Accel MetersPerMicrosecondsPerMinute(float x) => new Accel(x * 16666.66667f);

    public float ToMetersPerMicrosecondsPerHour() => x * 0.0036f;
    public static Accel MetersPerMicrosecondsPerHour(float x) => new Accel(x * 277.7777778f);

    public float ToMetersPerMillisecondsPerMicrosecond() => x * 1E-09f;
    public static Accel MetersPerMillisecondsPerMicrosecond(float x) => new Accel(x * 1000000000f);

    public float ToMetersPerMillisecond2() => x * 1E-06f;
    public static Accel MetersPerMillisecond2(float x) => new Accel(x * 1000000f);

    public float ToMetersPerMillisecondsPerSecond() => x * 0.001f;
    public static Accel MetersPerMillisecondsPerSecond(float x) => new Accel(x * 1000f);

    public float ToMetersPerMillisecondsPerMinute() => x * 0.06f;
    public static Accel MetersPerMillisecondsPerMinute(float x) => new Accel(x * 16.66666667f);

    public float ToMetersPerMillisecondsPerHour() => x * 3.6f;
    public static Accel MetersPerMillisecondsPerHour(float x) => new Accel(x * 0.2777777778f);

    public float ToMetersPerSecondsPerMicrosecond() => x * 1E-06f;
    public static Accel MetersPerSecondsPerMicrosecond(float x) => new Accel(x * 1000000f);

    public float ToMetersPerSecondsPerMillisecond() => x * 0.001f;
    public static Accel MetersPerSecondsPerMillisecond(float x) => new Accel(x * 1000f);

    public float ToMetersPerSecond2() => x * 1f;
    public static Accel MetersPerSecond2(float x) => new Accel(x * 1f);

    public float ToMetersPerSecondsPerMinute() => x * 60f;
    public static Accel MetersPerSecondsPerMinute(float x) => new Accel(x * 0.01666666667f);

    public float ToMetersPerSecondsPerHour() => x * 3600f;
    public static Accel MetersPerSecondsPerHour(float x) => new Accel(x * 0.0002777777778f);

    public float ToMetersPerMinutesPerMicrosecond() => x * 6E-05f;
    public static Accel MetersPerMinutesPerMicrosecond(float x) => new Accel(x * 16666.66667f);

    public float ToMetersPerMinutesPerMillisecond() => x * 0.06f;
    public static Accel MetersPerMinutesPerMillisecond(float x) => new Accel(x * 16.66666667f);

    public float ToMetersPerMinutesPerSecond() => x * 60f;
    public static Accel MetersPerMinutesPerSecond(float x) => new Accel(x * 0.01666666667f);

    public float ToMetersPerMinute2() => x * 3600f;
    public static Accel MetersPerMinute2(float x) => new Accel(x * 0.0002777777778f);

    public float ToMetersPerMinutesPerHour() => x * 216000f;
    public static Accel MetersPerMinutesPerHour(float x) => new Accel(x * 4.62962963E-06f);

    public float ToMetersPerHoursPerMicrosecond() => x * 0.0036f;
    public static Accel MetersPerHoursPerMicrosecond(float x) => new Accel(x * 277.7777778f);

    public float ToMetersPerHoursPerMillisecond() => x * 3.6f;
    public static Accel MetersPerHoursPerMillisecond(float x) => new Accel(x * 0.2777777778f);

    public float ToMetersPerHoursPerSecond() => x * 3600f;
    public static Accel MetersPerHoursPerSecond(float x) => new Accel(x * 0.0002777777778f);

    public float ToMetersPerHoursPerMinute() => x * 216000f;
    public static Accel MetersPerHoursPerMinute(float x) => new Accel(x * 4.62962963E-06f);

    public float ToMetersPerHour2() => x * 12960000f;
    public static Accel MetersPerHour2(float x) => new Accel(x * 7.716049383E-08f);

    public float ToKilometersPerMicrosecond2() => x * 1E-15f;
    public static Accel KilometersPerMicrosecond2(float x) => new Accel(x * 1E+15f);

    public float ToKilometersPerMicrosecondsPerMillisecond() => x * 1E-12f;
    public static Accel KilometersPerMicrosecondsPerMillisecond(float x) => new Accel(x * 1E+12f);

    public float ToKilometersPerMicrosecondsPerSecond() => x * 1E-09f;
    public static Accel KilometersPerMicrosecondsPerSecond(float x) => new Accel(x * 1000000000f);

    public float ToKilometersPerMicrosecondsPerMinute() => x * 6E-08f;
    public static Accel KilometersPerMicrosecondsPerMinute(float x) => new Accel(x * 16666666.67f);

    public float ToKilometersPerMicrosecondsPerHour() => x * 3.6E-06f;
    public static Accel KilometersPerMicrosecondsPerHour(float x) => new Accel(x * 277777.7778f);

    public float ToKilometersPerMillisecondsPerMicrosecond() => x * 1E-12f;
    public static Accel KilometersPerMillisecondsPerMicrosecond(float x) => new Accel(x * 1E+12f);

    public float ToKilometersPerMillisecond2() => x * 1E-09f;
    public static Accel KilometersPerMillisecond2(float x) => new Accel(x * 1000000000f);

    public float ToKilometersPerMillisecondsPerSecond() => x * 1E-06f;
    public static Accel KilometersPerMillisecondsPerSecond(float x) => new Accel(x * 1000000f);

    public float ToKilometersPerMillisecondsPerMinute() => x * 6E-05f;
    public static Accel KilometersPerMillisecondsPerMinute(float x) => new Accel(x * 16666.66667f);

    public float ToKilometersPerMillisecondsPerHour() => x * 0.0036f;
    public static Accel KilometersPerMillisecondsPerHour(float x) => new Accel(x * 277.7777778f);

    public float ToKilometersPerSecondsPerMicrosecond() => x * 1E-09f;
    public static Accel KilometersPerSecondsPerMicrosecond(float x) => new Accel(x * 1000000000f);

    public float ToKilometersPerSecondsPerMillisecond() => x * 1E-06f;
    public static Accel KilometersPerSecondsPerMillisecond(float x) => new Accel(x * 1000000f);

    public float ToKilometersPerSecond2() => x * 0.001f;
    public static Accel KilometersPerSecond2(float x) => new Accel(x * 1000f);

    public float ToKilometersPerSecondsPerMinute() => x * 0.06f;
    public static Accel KilometersPerSecondsPerMinute(float x) => new Accel(x * 16.66666667f);

    public float ToKilometersPerSecondsPerHour() => x * 3.6f;
    public static Accel KilometersPerSecondsPerHour(float x) => new Accel(x * 0.2777777778f);

    public float ToKilometersPerMinutesPerMicrosecond() => x * 6E-08f;
    public static Accel KilometersPerMinutesPerMicrosecond(float x) => new Accel(x * 16666666.67f);

    public float ToKilometersPerMinutesPerMillisecond() => x * 6E-05f;
    public static Accel KilometersPerMinutesPerMillisecond(float x) => new Accel(x * 16666.66667f);

    public float ToKilometersPerMinutesPerSecond() => x * 0.06f;
    public static Accel KilometersPerMinutesPerSecond(float x) => new Accel(x * 16.66666667f);

    public float ToKilometersPerMinute2() => x * 3.6f;
    public static Accel KilometersPerMinute2(float x) => new Accel(x * 0.2777777778f);

    public float ToKilometersPerMinutesPerHour() => x * 216f;
    public static Accel KilometersPerMinutesPerHour(float x) => new Accel(x * 0.00462962963f);

    public float ToKilometersPerHoursPerMicrosecond() => x * 3.6E-06f;
    public static Accel KilometersPerHoursPerMicrosecond(float x) => new Accel(x * 277777.7778f);

    public float ToKilometersPerHoursPerMillisecond() => x * 0.0036f;
    public static Accel KilometersPerHoursPerMillisecond(float x) => new Accel(x * 277.7777778f);

    public float ToKilometersPerHoursPerSecond() => x * 3.6f;
    public static Accel KilometersPerHoursPerSecond(float x) => new Accel(x * 0.2777777778f);

    public float ToKilometersPerHoursPerMinute() => x * 216f;
    public static Accel KilometersPerHoursPerMinute(float x) => new Accel(x * 0.00462962963f);

    public float ToKilometersPerHour2() => x * 12960f;
    public static Accel KilometersPerHour2(float x) => new Accel(x * 7.716049383E-05f);

    public float ToMegametersPerMicrosecond2() => x * 1E-18f;
    public static Accel MegametersPerMicrosecond2(float x) => new Accel(x * 1E+18f);

    public float ToMegametersPerMicrosecondsPerMillisecond() => x * 1E-15f;
    public static Accel MegametersPerMicrosecondsPerMillisecond(float x) => new Accel(x * 1E+15f);

    public float ToMegametersPerMicrosecondsPerSecond() => x * 1E-12f;
    public static Accel MegametersPerMicrosecondsPerSecond(float x) => new Accel(x * 1E+12f);

    public float ToMegametersPerMicrosecondsPerMinute() => x * 6E-11f;
    public static Accel MegametersPerMicrosecondsPerMinute(float x) => new Accel(x * 1.666666667E+10f);

    public float ToMegametersPerMicrosecondsPerHour() => x * 3.6E-09f;
    public static Accel MegametersPerMicrosecondsPerHour(float x) => new Accel(x * 277777777.8f);

    public float ToMegametersPerMillisecondsPerMicrosecond() => x * 1E-15f;
    public static Accel MegametersPerMillisecondsPerMicrosecond(float x) => new Accel(x * 1E+15f);

    public float ToMegametersPerMillisecond2() => x * 1E-12f;
    public static Accel MegametersPerMillisecond2(float x) => new Accel(x * 1E+12f);

    public float ToMegametersPerMillisecondsPerSecond() => x * 1E-09f;
    public static Accel MegametersPerMillisecondsPerSecond(float x) => new Accel(x * 1000000000f);

    public float ToMegametersPerMillisecondsPerMinute() => x * 6E-08f;
    public static Accel MegametersPerMillisecondsPerMinute(float x) => new Accel(x * 16666666.67f);

    public float ToMegametersPerMillisecondsPerHour() => x * 3.6E-06f;
    public static Accel MegametersPerMillisecondsPerHour(float x) => new Accel(x * 277777.7778f);

    public float ToMegametersPerSecondsPerMicrosecond() => x * 1E-12f;
    public static Accel MegametersPerSecondsPerMicrosecond(float x) => new Accel(x * 1E+12f);

    public float ToMegametersPerSecondsPerMillisecond() => x * 1E-09f;
    public static Accel MegametersPerSecondsPerMillisecond(float x) => new Accel(x * 1000000000f);

    public float ToMegametersPerSecond2() => x * 1E-06f;
    public static Accel MegametersPerSecond2(float x) => new Accel(x * 1000000f);

    public float ToMegametersPerSecondsPerMinute() => x * 6E-05f;
    public static Accel MegametersPerSecondsPerMinute(float x) => new Accel(x * 16666.66667f);

    public float ToMegametersPerSecondsPerHour() => x * 0.0036f;
    public static Accel MegametersPerSecondsPerHour(float x) => new Accel(x * 277.7777778f);

    public float ToMegametersPerMinutesPerMicrosecond() => x * 6E-11f;
    public static Accel MegametersPerMinutesPerMicrosecond(float x) => new Accel(x * 1.666666667E+10f);

    public float ToMegametersPerMinutesPerMillisecond() => x * 6E-08f;
    public static Accel MegametersPerMinutesPerMillisecond(float x) => new Accel(x * 16666666.67f);

    public float ToMegametersPerMinutesPerSecond() => x * 6E-05f;
    public static Accel MegametersPerMinutesPerSecond(float x) => new Accel(x * 16666.66667f);

    public float ToMegametersPerMinute2() => x * 0.0036f;
    public static Accel MegametersPerMinute2(float x) => new Accel(x * 277.7777778f);

    public float ToMegametersPerMinutesPerHour() => x * 0.216f;
    public static Accel MegametersPerMinutesPerHour(float x) => new Accel(x * 4.62962963f);

    public float ToMegametersPerHoursPerMicrosecond() => x * 3.6E-09f;
    public static Accel MegametersPerHoursPerMicrosecond(float x) => new Accel(x * 277777777.8f);

    public float ToMegametersPerHoursPerMillisecond() => x * 3.6E-06f;
    public static Accel MegametersPerHoursPerMillisecond(float x) => new Accel(x * 277777.7778f);

    public float ToMegametersPerHoursPerSecond() => x * 0.0036f;
    public static Accel MegametersPerHoursPerSecond(float x) => new Accel(x * 277.7777778f);

    public float ToMegametersPerHoursPerMinute() => x * 0.216f;
    public static Accel MegametersPerHoursPerMinute(float x) => new Accel(x * 4.62962963f);

    public float ToMegametersPerHour2() => x * 12.96f;
    public static Accel MegametersPerHour2(float x) => new Accel(x * 0.07716049383f);

    public float ToMillinewtonsPerMilligram() => x * 1000000000f;
    public static Accel MillinewtonsPerMilligram(float x) => new Accel(x * 1E-09f);

    public float ToMillinewtonsPerGram() => x * 1000000f;
    public static Accel MillinewtonsPerGram(float x) => new Accel(x * 1E-06f);

    public float ToMillinewtonsPerKilogram() => x * 1000f;
    public static Accel MillinewtonsPerKilogram(float x) => new Accel(x * 0.001f);

    public float ToMillinewtonsPerTon() => x * 1f;
    public static Accel MillinewtonsPerTon(float x) => new Accel(x * 1f);

    public float ToMillinewtonsPerKiloton() => x * 0.001f;
    public static Accel MillinewtonsPerKiloton(float x) => new Accel(x * 1000f);

    public float ToNewtonsPerMilligram() => x * 1000000f;
    public static Accel NewtonsPerMilligram(float x) => new Accel(x * 1E-06f);

    public float ToNewtonsPerGram() => x * 1000f;
    public static Accel NewtonsPerGram(float x) => new Accel(x * 0.001f);

    public float ToNewtonsPerKilogram() => x * 1f;
    public static Accel NewtonsPerKilogram(float x) => new Accel(x * 1f);

    public float ToNewtonsPerTon() => x * 0.001f;
    public static Accel NewtonsPerTon(float x) => new Accel(x * 1000f);

    public float ToNewtonsPerKiloton() => x * 1E-06f;
    public static Accel NewtonsPerKiloton(float x) => new Accel(x * 1000000f);

    public float ToKilonewtonsPerMilligram() => x * 1000f;
    public static Accel KilonewtonsPerMilligram(float x) => new Accel(x * 0.001f);

    public float ToKilonewtonsPerGram() => x * 1f;
    public static Accel KilonewtonsPerGram(float x) => new Accel(x * 1f);

    public float ToKilonewtonsPerKilogram() => x * 0.001f;
    public static Accel KilonewtonsPerKilogram(float x) => new Accel(x * 1000f);

    public float ToKilonewtonsPerTon() => x * 1E-06f;
    public static Accel KilonewtonsPerTon(float x) => new Accel(x * 1000000f);

    public float ToKilonewtonsPerKiloton() => x * 1E-09f;
    public static Accel KilonewtonsPerKiloton(float x) => new Accel(x * 1000000000f);

    public float ToMeganewtonsPerMilligram() => x * 1f;
    public static Accel MeganewtonsPerMilligram(float x) => new Accel(x * 1f);

    public float ToMeganewtonsPerGram() => x * 0.001f;
    public static Accel MeganewtonsPerGram(float x) => new Accel(x * 1000f);

    public float ToMeganewtonsPerKilogram() => x * 1E-06f;
    public static Accel MeganewtonsPerKilogram(float x) => new Accel(x * 1000000f);

    public float ToMeganewtonsPerTon() => x * 1E-09f;
    public static Accel MeganewtonsPerTon(float x) => new Accel(x * 1000000000f);

    public float ToMeganewtonsPerKiloton() => x * 1E-12f;
    public static Accel MeganewtonsPerKiloton(float x) => new Accel(x * 1E+12f);

    public static Accel operator +(Accel a, Accel b) => new(a.x + b.x);
    public static Accel operator -(Accel a, Accel b) => new(a.x - b.x);
    
    public static Accel operator *(Accel a, Accel b) => new(a.x * b.x);
    public static Accel operator /(Accel a, Accel b) => new(a.x / b.x);
    
    public Velocity Velocity(Time v) => new(v * x);
    public Time Time(Velocity v) => new(v / x);

    public Accel(Velocity a, Time b) => a.Accel(b);
    public Accel(Time b, Velocity a) => a.Accel(b);

    public Force Force(Mass v) => new(v * x);
    public Mass Mass(Force v) => new(v / x);

    public Accel(Force a, Mass b) => a.Accel(b);
    public Accel(Mass b, Force a) => a.Accel(b);

}
}

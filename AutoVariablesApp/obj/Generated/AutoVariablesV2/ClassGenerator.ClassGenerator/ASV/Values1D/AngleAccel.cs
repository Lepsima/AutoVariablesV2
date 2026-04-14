using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct AngleAccel : IAutoUnit {
    public float x;
    
    public AngleAccel(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(AngleAccel v) => v.x;
    public AngleAccel magnitude => new(x);

    public float ToDegreesPerMicrosecond2() => x * 1E-12f;
    public static AngleAccel DegreesPerMicrosecond2(float x) => new AngleAccel(x * 1E+12f);

    public float ToDegreesPerMicrosecondsPerMillisecond() => x * 1E-09f;
    public static AngleAccel DegreesPerMicrosecondsPerMillisecond(float x) => new AngleAccel(x * 1000000000f);

    public float ToDegreesPerMicrosecondsPerSecond() => x * 1E-06f;
    public static AngleAccel DegreesPerMicrosecondsPerSecond(float x) => new AngleAccel(x * 1000000f);

    public float ToDegreesPerMicrosecondsPerMinute() => x * 6E-05f;
    public static AngleAccel DegreesPerMicrosecondsPerMinute(float x) => new AngleAccel(x * 16666.66667f);

    public float ToDegreesPerMicrosecondsPerHour() => x * 0.0036f;
    public static AngleAccel DegreesPerMicrosecondsPerHour(float x) => new AngleAccel(x * 277.7777778f);

    public float ToDegreesPerMillisecondsPerMicrosecond() => x * 1E-09f;
    public static AngleAccel DegreesPerMillisecondsPerMicrosecond(float x) => new AngleAccel(x * 1000000000f);

    public float ToDegreesPerMillisecond2() => x * 1E-06f;
    public static AngleAccel DegreesPerMillisecond2(float x) => new AngleAccel(x * 1000000f);

    public float ToDegreesPerMillisecondsPerSecond() => x * 0.001f;
    public static AngleAccel DegreesPerMillisecondsPerSecond(float x) => new AngleAccel(x * 1000f);

    public float ToDegreesPerMillisecondsPerMinute() => x * 0.06f;
    public static AngleAccel DegreesPerMillisecondsPerMinute(float x) => new AngleAccel(x * 16.66666667f);

    public float ToDegreesPerMillisecondsPerHour() => x * 3.6f;
    public static AngleAccel DegreesPerMillisecondsPerHour(float x) => new AngleAccel(x * 0.2777777778f);

    public float ToDegreesPerSecondsPerMicrosecond() => x * 1E-06f;
    public static AngleAccel DegreesPerSecondsPerMicrosecond(float x) => new AngleAccel(x * 1000000f);

    public float ToDegreesPerSecondsPerMillisecond() => x * 0.001f;
    public static AngleAccel DegreesPerSecondsPerMillisecond(float x) => new AngleAccel(x * 1000f);

    public float ToDegreesPerSecond2() => x * 1f;
    public static AngleAccel DegreesPerSecond2(float x) => new AngleAccel(x * 1f);

    public float ToDegreesPerSecondsPerMinute() => x * 60f;
    public static AngleAccel DegreesPerSecondsPerMinute(float x) => new AngleAccel(x * 0.01666666667f);

    public float ToDegreesPerSecondsPerHour() => x * 3600f;
    public static AngleAccel DegreesPerSecondsPerHour(float x) => new AngleAccel(x * 0.0002777777778f);

    public float ToDegreesPerMinutesPerMicrosecond() => x * 6E-05f;
    public static AngleAccel DegreesPerMinutesPerMicrosecond(float x) => new AngleAccel(x * 16666.66667f);

    public float ToDegreesPerMinutesPerMillisecond() => x * 0.06f;
    public static AngleAccel DegreesPerMinutesPerMillisecond(float x) => new AngleAccel(x * 16.66666667f);

    public float ToDegreesPerMinutesPerSecond() => x * 60f;
    public static AngleAccel DegreesPerMinutesPerSecond(float x) => new AngleAccel(x * 0.01666666667f);

    public float ToDegreesPerMinute2() => x * 3600f;
    public static AngleAccel DegreesPerMinute2(float x) => new AngleAccel(x * 0.0002777777778f);

    public float ToDegreesPerMinutesPerHour() => x * 216000f;
    public static AngleAccel DegreesPerMinutesPerHour(float x) => new AngleAccel(x * 4.62962963E-06f);

    public float ToDegreesPerHoursPerMicrosecond() => x * 0.0036f;
    public static AngleAccel DegreesPerHoursPerMicrosecond(float x) => new AngleAccel(x * 277.7777778f);

    public float ToDegreesPerHoursPerMillisecond() => x * 3.6f;
    public static AngleAccel DegreesPerHoursPerMillisecond(float x) => new AngleAccel(x * 0.2777777778f);

    public float ToDegreesPerHoursPerSecond() => x * 3600f;
    public static AngleAccel DegreesPerHoursPerSecond(float x) => new AngleAccel(x * 0.0002777777778f);

    public float ToDegreesPerHoursPerMinute() => x * 216000f;
    public static AngleAccel DegreesPerHoursPerMinute(float x) => new AngleAccel(x * 4.62962963E-06f);

    public float ToDegreesPerHour2() => x * 12960000f;
    public static AngleAccel DegreesPerHour2(float x) => new AngleAccel(x * 7.716049383E-08f);

    public float ToRadiansPerMicrosecond2() => x * 5.729577996E-11f;
    public static AngleAccel RadiansPerMicrosecond2(float x) => new AngleAccel(x * 1.745329238E+10f);

    public float ToRadiansPerMicrosecondsPerMillisecond() => x * 5.729577996E-08f;
    public static AngleAccel RadiansPerMicrosecondsPerMillisecond(float x) => new AngleAccel(x * 17453292.38f);

    public float ToRadiansPerMicrosecondsPerSecond() => x * 5.729577996E-05f;
    public static AngleAccel RadiansPerMicrosecondsPerSecond(float x) => new AngleAccel(x * 17453.29238f);

    public float ToRadiansPerMicrosecondsPerMinute() => x * 0.003437746797f;
    public static AngleAccel RadiansPerMicrosecondsPerMinute(float x) => new AngleAccel(x * 290.8882064f);

    public float ToRadiansPerMicrosecondsPerHour() => x * 0.2062648078f;
    public static AngleAccel RadiansPerMicrosecondsPerHour(float x) => new AngleAccel(x * 4.848136774f);

    public float ToRadiansPerMillisecondsPerMicrosecond() => x * 5.729577996E-08f;
    public static AngleAccel RadiansPerMillisecondsPerMicrosecond(float x) => new AngleAccel(x * 17453292.38f);

    public float ToRadiansPerMillisecond2() => x * 5.729577996E-05f;
    public static AngleAccel RadiansPerMillisecond2(float x) => new AngleAccel(x * 17453.29238f);

    public float ToRadiansPerMillisecondsPerSecond() => x * 0.05729577996f;
    public static AngleAccel RadiansPerMillisecondsPerSecond(float x) => new AngleAccel(x * 17.45329238f);

    public float ToRadiansPerMillisecondsPerMinute() => x * 3.437746797f;
    public static AngleAccel RadiansPerMillisecondsPerMinute(float x) => new AngleAccel(x * 0.2908882064f);

    public float ToRadiansPerMillisecondsPerHour() => x * 206.2648078f;
    public static AngleAccel RadiansPerMillisecondsPerHour(float x) => new AngleAccel(x * 0.004848136774f);

    public float ToRadiansPerSecondsPerMicrosecond() => x * 5.729577996E-05f;
    public static AngleAccel RadiansPerSecondsPerMicrosecond(float x) => new AngleAccel(x * 17453.29238f);

    public float ToRadiansPerSecondsPerMillisecond() => x * 0.05729577996f;
    public static AngleAccel RadiansPerSecondsPerMillisecond(float x) => new AngleAccel(x * 17.45329238f);

    public float ToRadiansPerSecond2() => x * 57.29577996f;
    public static AngleAccel RadiansPerSecond2(float x) => new AngleAccel(x * 0.01745329238f);

    public float ToRadiansPerSecondsPerMinute() => x * 3437.746797f;
    public static AngleAccel RadiansPerSecondsPerMinute(float x) => new AngleAccel(x * 0.0002908882064f);

    public float ToRadiansPerSecondsPerHour() => x * 206264.8078f;
    public static AngleAccel RadiansPerSecondsPerHour(float x) => new AngleAccel(x * 4.848136774E-06f);

    public float ToRadiansPerMinutesPerMicrosecond() => x * 0.003437746797f;
    public static AngleAccel RadiansPerMinutesPerMicrosecond(float x) => new AngleAccel(x * 290.8882064f);

    public float ToRadiansPerMinutesPerMillisecond() => x * 3.437746797f;
    public static AngleAccel RadiansPerMinutesPerMillisecond(float x) => new AngleAccel(x * 0.2908882064f);

    public float ToRadiansPerMinutesPerSecond() => x * 3437.746797f;
    public static AngleAccel RadiansPerMinutesPerSecond(float x) => new AngleAccel(x * 0.0002908882064f);

    public float ToRadiansPerMinute2() => x * 206264.8078f;
    public static AngleAccel RadiansPerMinute2(float x) => new AngleAccel(x * 4.848136774E-06f);

    public float ToRadiansPerMinutesPerHour() => x * 12375888.47f;
    public static AngleAccel RadiansPerMinutesPerHour(float x) => new AngleAccel(x * 8.080227956E-08f);

    public float ToRadiansPerHoursPerMicrosecond() => x * 0.2062648078f;
    public static AngleAccel RadiansPerHoursPerMicrosecond(float x) => new AngleAccel(x * 4.848136774f);

    public float ToRadiansPerHoursPerMillisecond() => x * 206.2648078f;
    public static AngleAccel RadiansPerHoursPerMillisecond(float x) => new AngleAccel(x * 0.004848136774f);

    public float ToRadiansPerHoursPerSecond() => x * 206264.8078f;
    public static AngleAccel RadiansPerHoursPerSecond(float x) => new AngleAccel(x * 4.848136774E-06f);

    public float ToRadiansPerHoursPerMinute() => x * 12375888.47f;
    public static AngleAccel RadiansPerHoursPerMinute(float x) => new AngleAccel(x * 8.080227956E-08f);

    public float ToRadiansPerHour2() => x * 742553308.2f;
    public static AngleAccel RadiansPerHour2(float x) => new AngleAccel(x * 1.346704659E-09f);

    public float ToTurnsPerMicrosecond2() => x * 2.777777778E-15f;
    public static AngleAccel TurnsPerMicrosecond2(float x) => new AngleAccel(x * 3.6E+14f);

    public float ToTurnsPerMicrosecondsPerMillisecond() => x * 2.777777778E-12f;
    public static AngleAccel TurnsPerMicrosecondsPerMillisecond(float x) => new AngleAccel(x * 3.6E+11f);

    public float ToTurnsPerMicrosecondsPerSecond() => x * 2.777777778E-09f;
    public static AngleAccel TurnsPerMicrosecondsPerSecond(float x) => new AngleAccel(x * 360000000f);

    public float ToTurnsPerMicrosecondsPerMinute() => x * 1.666666667E-07f;
    public static AngleAccel TurnsPerMicrosecondsPerMinute(float x) => new AngleAccel(x * 6000000f);

    public float ToTurnsPerMicrosecondsPerHour() => x * 1E-05f;
    public static AngleAccel TurnsPerMicrosecondsPerHour(float x) => new AngleAccel(x * 100000f);

    public float ToTurnsPerMillisecondsPerMicrosecond() => x * 2.777777778E-12f;
    public static AngleAccel TurnsPerMillisecondsPerMicrosecond(float x) => new AngleAccel(x * 3.6E+11f);

    public float ToTurnsPerMillisecond2() => x * 2.777777778E-09f;
    public static AngleAccel TurnsPerMillisecond2(float x) => new AngleAccel(x * 360000000f);

    public float ToTurnsPerMillisecondsPerSecond() => x * 2.777777778E-06f;
    public static AngleAccel TurnsPerMillisecondsPerSecond(float x) => new AngleAccel(x * 360000f);

    public float ToTurnsPerMillisecondsPerMinute() => x * 0.0001666666667f;
    public static AngleAccel TurnsPerMillisecondsPerMinute(float x) => new AngleAccel(x * 6000f);

    public float ToTurnsPerMillisecondsPerHour() => x * 0.01f;
    public static AngleAccel TurnsPerMillisecondsPerHour(float x) => new AngleAccel(x * 100f);

    public float ToTurnsPerSecondsPerMicrosecond() => x * 2.777777778E-09f;
    public static AngleAccel TurnsPerSecondsPerMicrosecond(float x) => new AngleAccel(x * 360000000f);

    public float ToTurnsPerSecondsPerMillisecond() => x * 2.777777778E-06f;
    public static AngleAccel TurnsPerSecondsPerMillisecond(float x) => new AngleAccel(x * 360000f);

    public float ToTurnsPerSecond2() => x * 0.002777777778f;
    public static AngleAccel TurnsPerSecond2(float x) => new AngleAccel(x * 360f);

    public float ToTurnsPerSecondsPerMinute() => x * 0.1666666667f;
    public static AngleAccel TurnsPerSecondsPerMinute(float x) => new AngleAccel(x * 6f);

    public float ToTurnsPerSecondsPerHour() => x * 10f;
    public static AngleAccel TurnsPerSecondsPerHour(float x) => new AngleAccel(x * 0.1f);

    public float ToTurnsPerMinutesPerMicrosecond() => x * 1.666666667E-07f;
    public static AngleAccel TurnsPerMinutesPerMicrosecond(float x) => new AngleAccel(x * 6000000f);

    public float ToTurnsPerMinutesPerMillisecond() => x * 0.0001666666667f;
    public static AngleAccel TurnsPerMinutesPerMillisecond(float x) => new AngleAccel(x * 6000f);

    public float ToTurnsPerMinutesPerSecond() => x * 0.1666666667f;
    public static AngleAccel TurnsPerMinutesPerSecond(float x) => new AngleAccel(x * 6f);

    public float ToTurnsPerMinute2() => x * 10f;
    public static AngleAccel TurnsPerMinute2(float x) => new AngleAccel(x * 0.1f);

    public float ToTurnsPerMinutesPerHour() => x * 600f;
    public static AngleAccel TurnsPerMinutesPerHour(float x) => new AngleAccel(x * 0.001666666667f);

    public float ToTurnsPerHoursPerMicrosecond() => x * 1E-05f;
    public static AngleAccel TurnsPerHoursPerMicrosecond(float x) => new AngleAccel(x * 100000f);

    public float ToTurnsPerHoursPerMillisecond() => x * 0.01f;
    public static AngleAccel TurnsPerHoursPerMillisecond(float x) => new AngleAccel(x * 100f);

    public float ToTurnsPerHoursPerSecond() => x * 10f;
    public static AngleAccel TurnsPerHoursPerSecond(float x) => new AngleAccel(x * 0.1f);

    public float ToTurnsPerHoursPerMinute() => x * 600f;
    public static AngleAccel TurnsPerHoursPerMinute(float x) => new AngleAccel(x * 0.001666666667f);

    public float ToTurnsPerHour2() => x * 36000f;
    public static AngleAccel TurnsPerHour2(float x) => new AngleAccel(x * 2.777777778E-05f);

    public float ToMinuteDegreesPerMicrosecond2() => x * 6E-11f;
    public static AngleAccel MinuteDegreesPerMicrosecond2(float x) => new AngleAccel(x * 1.666666667E+10f);

    public float ToMinuteDegreesPerMicrosecondsPerMillisecond() => x * 6E-08f;
    public static AngleAccel MinuteDegreesPerMicrosecondsPerMillisecond(float x) => new AngleAccel(x * 16666666.67f);

    public float ToMinuteDegreesPerMicrosecondsPerSecond() => x * 6E-05f;
    public static AngleAccel MinuteDegreesPerMicrosecondsPerSecond(float x) => new AngleAccel(x * 16666.66667f);

    public float ToMinuteDegreesPerMicrosecondsPerMinute() => x * 0.0036f;
    public static AngleAccel MinuteDegreesPerMicrosecondsPerMinute(float x) => new AngleAccel(x * 277.7777778f);

    public float ToMinuteDegreesPerMicrosecondsPerHour() => x * 0.216f;
    public static AngleAccel MinuteDegreesPerMicrosecondsPerHour(float x) => new AngleAccel(x * 4.62962963f);

    public float ToMinuteDegreesPerMillisecondsPerMicrosecond() => x * 6E-08f;
    public static AngleAccel MinuteDegreesPerMillisecondsPerMicrosecond(float x) => new AngleAccel(x * 16666666.67f);

    public float ToMinuteDegreesPerMillisecond2() => x * 6E-05f;
    public static AngleAccel MinuteDegreesPerMillisecond2(float x) => new AngleAccel(x * 16666.66667f);

    public float ToMinuteDegreesPerMillisecondsPerSecond() => x * 0.06f;
    public static AngleAccel MinuteDegreesPerMillisecondsPerSecond(float x) => new AngleAccel(x * 16.66666667f);

    public float ToMinuteDegreesPerMillisecondsPerMinute() => x * 3.6f;
    public static AngleAccel MinuteDegreesPerMillisecondsPerMinute(float x) => new AngleAccel(x * 0.2777777778f);

    public float ToMinuteDegreesPerMillisecondsPerHour() => x * 216f;
    public static AngleAccel MinuteDegreesPerMillisecondsPerHour(float x) => new AngleAccel(x * 0.00462962963f);

    public float ToMinuteDegreesPerSecondsPerMicrosecond() => x * 6E-05f;
    public static AngleAccel MinuteDegreesPerSecondsPerMicrosecond(float x) => new AngleAccel(x * 16666.66667f);

    public float ToMinuteDegreesPerSecondsPerMillisecond() => x * 0.06f;
    public static AngleAccel MinuteDegreesPerSecondsPerMillisecond(float x) => new AngleAccel(x * 16.66666667f);

    public float ToMinuteDegreesPerSecond2() => x * 60f;
    public static AngleAccel MinuteDegreesPerSecond2(float x) => new AngleAccel(x * 0.01666666667f);

    public float ToMinuteDegreesPerSecondsPerMinute() => x * 3600f;
    public static AngleAccel MinuteDegreesPerSecondsPerMinute(float x) => new AngleAccel(x * 0.0002777777778f);

    public float ToMinuteDegreesPerSecondsPerHour() => x * 216000f;
    public static AngleAccel MinuteDegreesPerSecondsPerHour(float x) => new AngleAccel(x * 4.62962963E-06f);

    public float ToMinuteDegreesPerMinutesPerMicrosecond() => x * 0.0036f;
    public static AngleAccel MinuteDegreesPerMinutesPerMicrosecond(float x) => new AngleAccel(x * 277.7777778f);

    public float ToMinuteDegreesPerMinutesPerMillisecond() => x * 3.6f;
    public static AngleAccel MinuteDegreesPerMinutesPerMillisecond(float x) => new AngleAccel(x * 0.2777777778f);

    public float ToMinuteDegreesPerMinutesPerSecond() => x * 3600f;
    public static AngleAccel MinuteDegreesPerMinutesPerSecond(float x) => new AngleAccel(x * 0.0002777777778f);

    public float ToMinuteDegreesPerMinute2() => x * 216000f;
    public static AngleAccel MinuteDegreesPerMinute2(float x) => new AngleAccel(x * 4.62962963E-06f);

    public float ToMinuteDegreesPerMinutesPerHour() => x * 12960000f;
    public static AngleAccel MinuteDegreesPerMinutesPerHour(float x) => new AngleAccel(x * 7.716049383E-08f);

    public float ToMinuteDegreesPerHoursPerMicrosecond() => x * 0.216f;
    public static AngleAccel MinuteDegreesPerHoursPerMicrosecond(float x) => new AngleAccel(x * 4.62962963f);

    public float ToMinuteDegreesPerHoursPerMillisecond() => x * 216f;
    public static AngleAccel MinuteDegreesPerHoursPerMillisecond(float x) => new AngleAccel(x * 0.00462962963f);

    public float ToMinuteDegreesPerHoursPerSecond() => x * 216000f;
    public static AngleAccel MinuteDegreesPerHoursPerSecond(float x) => new AngleAccel(x * 4.62962963E-06f);

    public float ToMinuteDegreesPerHoursPerMinute() => x * 12960000f;
    public static AngleAccel MinuteDegreesPerHoursPerMinute(float x) => new AngleAccel(x * 7.716049383E-08f);

    public float ToMinuteDegreesPerHour2() => x * 777600000f;
    public static AngleAccel MinuteDegreesPerHour2(float x) => new AngleAccel(x * 1.28600823E-09f);

    public float ToSecondDegreesPerMicrosecond2() => x * 3.6E-09f;
    public static AngleAccel SecondDegreesPerMicrosecond2(float x) => new AngleAccel(x * 277777777.8f);

    public float ToSecondDegreesPerMicrosecondsPerMillisecond() => x * 3.6E-06f;
    public static AngleAccel SecondDegreesPerMicrosecondsPerMillisecond(float x) => new AngleAccel(x * 277777.7778f);

    public float ToSecondDegreesPerMicrosecondsPerSecond() => x * 0.0036f;
    public static AngleAccel SecondDegreesPerMicrosecondsPerSecond(float x) => new AngleAccel(x * 277.7777778f);

    public float ToSecondDegreesPerMicrosecondsPerMinute() => x * 0.216f;
    public static AngleAccel SecondDegreesPerMicrosecondsPerMinute(float x) => new AngleAccel(x * 4.62962963f);

    public float ToSecondDegreesPerMicrosecondsPerHour() => x * 12.96f;
    public static AngleAccel SecondDegreesPerMicrosecondsPerHour(float x) => new AngleAccel(x * 0.07716049383f);

    public float ToSecondDegreesPerMillisecondsPerMicrosecond() => x * 3.6E-06f;
    public static AngleAccel SecondDegreesPerMillisecondsPerMicrosecond(float x) => new AngleAccel(x * 277777.7778f);

    public float ToSecondDegreesPerMillisecond2() => x * 0.0036f;
    public static AngleAccel SecondDegreesPerMillisecond2(float x) => new AngleAccel(x * 277.7777778f);

    public float ToSecondDegreesPerMillisecondsPerSecond() => x * 3.6f;
    public static AngleAccel SecondDegreesPerMillisecondsPerSecond(float x) => new AngleAccel(x * 0.2777777778f);

    public float ToSecondDegreesPerMillisecondsPerMinute() => x * 216f;
    public static AngleAccel SecondDegreesPerMillisecondsPerMinute(float x) => new AngleAccel(x * 0.00462962963f);

    public float ToSecondDegreesPerMillisecondsPerHour() => x * 12960f;
    public static AngleAccel SecondDegreesPerMillisecondsPerHour(float x) => new AngleAccel(x * 7.716049383E-05f);

    public float ToSecondDegreesPerSecondsPerMicrosecond() => x * 0.0036f;
    public static AngleAccel SecondDegreesPerSecondsPerMicrosecond(float x) => new AngleAccel(x * 277.7777778f);

    public float ToSecondDegreesPerSecondsPerMillisecond() => x * 3.6f;
    public static AngleAccel SecondDegreesPerSecondsPerMillisecond(float x) => new AngleAccel(x * 0.2777777778f);

    public float ToSecondDegreesPerSecond2() => x * 3600f;
    public static AngleAccel SecondDegreesPerSecond2(float x) => new AngleAccel(x * 0.0002777777778f);

    public float ToSecondDegreesPerSecondsPerMinute() => x * 216000f;
    public static AngleAccel SecondDegreesPerSecondsPerMinute(float x) => new AngleAccel(x * 4.62962963E-06f);

    public float ToSecondDegreesPerSecondsPerHour() => x * 12960000f;
    public static AngleAccel SecondDegreesPerSecondsPerHour(float x) => new AngleAccel(x * 7.716049383E-08f);

    public float ToSecondDegreesPerMinutesPerMicrosecond() => x * 0.216f;
    public static AngleAccel SecondDegreesPerMinutesPerMicrosecond(float x) => new AngleAccel(x * 4.62962963f);

    public float ToSecondDegreesPerMinutesPerMillisecond() => x * 216f;
    public static AngleAccel SecondDegreesPerMinutesPerMillisecond(float x) => new AngleAccel(x * 0.00462962963f);

    public float ToSecondDegreesPerMinutesPerSecond() => x * 216000f;
    public static AngleAccel SecondDegreesPerMinutesPerSecond(float x) => new AngleAccel(x * 4.62962963E-06f);

    public float ToSecondDegreesPerMinute2() => x * 12960000f;
    public static AngleAccel SecondDegreesPerMinute2(float x) => new AngleAccel(x * 7.716049383E-08f);

    public float ToSecondDegreesPerMinutesPerHour() => x * 777600000f;
    public static AngleAccel SecondDegreesPerMinutesPerHour(float x) => new AngleAccel(x * 1.28600823E-09f);

    public float ToSecondDegreesPerHoursPerMicrosecond() => x * 12.96f;
    public static AngleAccel SecondDegreesPerHoursPerMicrosecond(float x) => new AngleAccel(x * 0.07716049383f);

    public float ToSecondDegreesPerHoursPerMillisecond() => x * 12960f;
    public static AngleAccel SecondDegreesPerHoursPerMillisecond(float x) => new AngleAccel(x * 7.716049383E-05f);

    public float ToSecondDegreesPerHoursPerSecond() => x * 12960000f;
    public static AngleAccel SecondDegreesPerHoursPerSecond(float x) => new AngleAccel(x * 7.716049383E-08f);

    public float ToSecondDegreesPerHoursPerMinute() => x * 777600000f;
    public static AngleAccel SecondDegreesPerHoursPerMinute(float x) => new AngleAccel(x * 1.28600823E-09f);

    public float ToSecondDegreesPerHour2() => x * 4.6656E+10f;
    public static AngleAccel SecondDegreesPerHour2(float x) => new AngleAccel(x * 2.143347051E-11f);

    public float ToMillinewtonsPerMilligram() => x * 1000000000f;
    public static AngleAccel MillinewtonsPerMilligram(float x) => new AngleAccel(x * 1E-09f);

    public float ToMillinewtonsPerGram() => x * 1000000f;
    public static AngleAccel MillinewtonsPerGram(float x) => new AngleAccel(x * 1E-06f);

    public float ToMillinewtonsPerKilogram() => x * 1000f;
    public static AngleAccel MillinewtonsPerKilogram(float x) => new AngleAccel(x * 0.001f);

    public float ToMillinewtonsPerTon() => x * 1f;
    public static AngleAccel MillinewtonsPerTon(float x) => new AngleAccel(x * 1f);

    public float ToMillinewtonsPerKiloton() => x * 0.001f;
    public static AngleAccel MillinewtonsPerKiloton(float x) => new AngleAccel(x * 1000f);

    public float ToNewtonsPerMilligram() => x * 1000000f;
    public static AngleAccel NewtonsPerMilligram(float x) => new AngleAccel(x * 1E-06f);

    public float ToNewtonsPerGram() => x * 1000f;
    public static AngleAccel NewtonsPerGram(float x) => new AngleAccel(x * 0.001f);

    public float ToNewtonsPerKilogram() => x * 1f;
    public static AngleAccel NewtonsPerKilogram(float x) => new AngleAccel(x * 1f);

    public float ToNewtonsPerTon() => x * 0.001f;
    public static AngleAccel NewtonsPerTon(float x) => new AngleAccel(x * 1000f);

    public float ToNewtonsPerKiloton() => x * 1E-06f;
    public static AngleAccel NewtonsPerKiloton(float x) => new AngleAccel(x * 1000000f);

    public float ToKilonewtonsPerMilligram() => x * 1000f;
    public static AngleAccel KilonewtonsPerMilligram(float x) => new AngleAccel(x * 0.001f);

    public float ToKilonewtonsPerGram() => x * 1f;
    public static AngleAccel KilonewtonsPerGram(float x) => new AngleAccel(x * 1f);

    public float ToKilonewtonsPerKilogram() => x * 0.001f;
    public static AngleAccel KilonewtonsPerKilogram(float x) => new AngleAccel(x * 1000f);

    public float ToKilonewtonsPerTon() => x * 1E-06f;
    public static AngleAccel KilonewtonsPerTon(float x) => new AngleAccel(x * 1000000f);

    public float ToKilonewtonsPerKiloton() => x * 1E-09f;
    public static AngleAccel KilonewtonsPerKiloton(float x) => new AngleAccel(x * 1000000000f);

    public float ToMeganewtonsPerMilligram() => x * 1f;
    public static AngleAccel MeganewtonsPerMilligram(float x) => new AngleAccel(x * 1f);

    public float ToMeganewtonsPerGram() => x * 0.001f;
    public static AngleAccel MeganewtonsPerGram(float x) => new AngleAccel(x * 1000f);

    public float ToMeganewtonsPerKilogram() => x * 1E-06f;
    public static AngleAccel MeganewtonsPerKilogram(float x) => new AngleAccel(x * 1000000f);

    public float ToMeganewtonsPerTon() => x * 1E-09f;
    public static AngleAccel MeganewtonsPerTon(float x) => new AngleAccel(x * 1000000000f);

    public float ToMeganewtonsPerKiloton() => x * 1E-12f;
    public static AngleAccel MeganewtonsPerKiloton(float x) => new AngleAccel(x * 1E+12f);

    public static AngleAccel operator +(AngleAccel a, AngleAccel b) => new(a.x + b.x);
    public static AngleAccel operator -(AngleAccel a, AngleAccel b) => new(a.x - b.x);
    
    public static AngleAccel operator *(AngleAccel a, AngleAccel b) => new(a.x * b.x);
    public static AngleAccel operator /(AngleAccel a, AngleAccel b) => new(a.x / b.x);
    
    public AngleVel AngleVel(Time v) => new(v * x);
    public Time Time(AngleVel v) => new(v / x);

    public AngleAccel(AngleVel a, Time b) => a.AngleAccel(b);
    public AngleAccel(Time b, AngleVel a) => a.AngleAccel(b);

    public Torque Torque(Mass v) => new(v * x);
    public Mass Mass(Torque v) => new(v / x);

    public AngleAccel(Torque a, Mass b) => a.AngleAccel(b);
    public AngleAccel(Mass b, Torque a) => a.AngleAccel(b);

}
}

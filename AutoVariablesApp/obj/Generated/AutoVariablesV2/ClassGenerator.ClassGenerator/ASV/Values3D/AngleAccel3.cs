using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct AngleAccel3 : IAutoUnit3 {
    public float x, y, z;
    
    public AngleAccel3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public AngleAccel3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    
    public static implicit operator Vector3(AngleAccel3 v) => new Vector3(v.x, v.y, v.z);
    public AngleAccel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToDegreesPerMicrosecond2() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static AngleAccel3 DegreesPerMicrosecond2(float x, float y, float z) => new AngleAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static AngleAccel3 DegreesPerMicrosecond2(Vector3 v) => new AngleAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToDegreesPerMicrosecondsPerMillisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static AngleAccel3 DegreesPerMicrosecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static AngleAccel3 DegreesPerMicrosecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToDegreesPerMicrosecondsPerSecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleAccel3 DegreesPerMicrosecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleAccel3 DegreesPerMicrosecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToDegreesPerMicrosecondsPerMinute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static AngleAccel3 DegreesPerMicrosecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static AngleAccel3 DegreesPerMicrosecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToDegreesPerMicrosecondsPerHour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static AngleAccel3 DegreesPerMicrosecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static AngleAccel3 DegreesPerMicrosecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToDegreesPerMillisecondsPerMicrosecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static AngleAccel3 DegreesPerMillisecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static AngleAccel3 DegreesPerMillisecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToDegreesPerMillisecond2() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleAccel3 DegreesPerMillisecond2(float x, float y, float z) => new AngleAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleAccel3 DegreesPerMillisecond2(Vector3 v) => new AngleAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToDegreesPerMillisecondsPerSecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 DegreesPerMillisecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 DegreesPerMillisecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToDegreesPerMillisecondsPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static AngleAccel3 DegreesPerMillisecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static AngleAccel3 DegreesPerMillisecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToDegreesPerMillisecondsPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static AngleAccel3 DegreesPerMillisecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static AngleAccel3 DegreesPerMillisecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToDegreesPerSecondsPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleAccel3 DegreesPerSecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleAccel3 DegreesPerSecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToDegreesPerSecondsPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 DegreesPerSecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 DegreesPerSecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToDegreesPerSecond2() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 DegreesPerSecond2(float x, float y, float z) => new AngleAccel3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 DegreesPerSecond2(Vector3 v) => new AngleAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToDegreesPerSecondsPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static AngleAccel3 DegreesPerSecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static AngleAccel3 DegreesPerSecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToDegreesPerSecondsPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleAccel3 DegreesPerSecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleAccel3 DegreesPerSecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToDegreesPerMinutesPerMicrosecond() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static AngleAccel3 DegreesPerMinutesPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static AngleAccel3 DegreesPerMinutesPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToDegreesPerMinutesPerMillisecond() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static AngleAccel3 DegreesPerMinutesPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static AngleAccel3 DegreesPerMinutesPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToDegreesPerMinutesPerSecond() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static AngleAccel3 DegreesPerMinutesPerSecond(float x, float y, float z) => new AngleAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static AngleAccel3 DegreesPerMinutesPerSecond(Vector3 v) => new AngleAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToDegreesPerMinute2() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleAccel3 DegreesPerMinute2(float x, float y, float z) => new AngleAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleAccel3 DegreesPerMinute2(Vector3 v) => new AngleAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToDegreesPerMinutesPerHour() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static AngleAccel3 DegreesPerMinutesPerHour(float x, float y, float z) => new AngleAccel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static AngleAccel3 DegreesPerMinutesPerHour(Vector3 v) => new AngleAccel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToDegreesPerHoursPerMicrosecond() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static AngleAccel3 DegreesPerHoursPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static AngleAccel3 DegreesPerHoursPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToDegreesPerHoursPerMillisecond() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static AngleAccel3 DegreesPerHoursPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static AngleAccel3 DegreesPerHoursPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToDegreesPerHoursPerSecond() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleAccel3 DegreesPerHoursPerSecond(float x, float y, float z) => new AngleAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleAccel3 DegreesPerHoursPerSecond(Vector3 v) => new AngleAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToDegreesPerHoursPerMinute() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static AngleAccel3 DegreesPerHoursPerMinute(float x, float y, float z) => new AngleAccel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static AngleAccel3 DegreesPerHoursPerMinute(Vector3 v) => new AngleAccel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToDegreesPerHour2() => new Vector3(x * 12960000f, y * 12960000f, z * 12960000f);
    public static AngleAccel3 DegreesPerHour2(float x, float y, float z) => new AngleAccel3(x * 7.716049383E-08f, y * 7.716049383E-08f, z * 7.716049383E-08f);
    public static AngleAccel3 DegreesPerHour2(Vector3 v) => new AngleAccel3(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f, v.z * 7.716049383E-08f);

    public Vector3 ToRadiansPerMicrosecond2() => new Vector3(x * 5.729577996E-11f, y * 5.729577996E-11f, z * 5.729577996E-11f);
    public static AngleAccel3 RadiansPerMicrosecond2(float x, float y, float z) => new AngleAccel3(x * 1.745329238E+10f, y * 1.745329238E+10f, z * 1.745329238E+10f);
    public static AngleAccel3 RadiansPerMicrosecond2(Vector3 v) => new AngleAccel3(v.x * 1.745329238E+10f, v.y * 1.745329238E+10f, v.z * 1.745329238E+10f);

    public Vector3 ToRadiansPerMicrosecondsPerMillisecond() => new Vector3(x * 5.729577996E-08f, y * 5.729577996E-08f, z * 5.729577996E-08f);
    public static AngleAccel3 RadiansPerMicrosecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 17453292.38f, y * 17453292.38f, z * 17453292.38f);
    public static AngleAccel3 RadiansPerMicrosecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 17453292.38f, v.y * 17453292.38f, v.z * 17453292.38f);

    public Vector3 ToRadiansPerMicrosecondsPerSecond() => new Vector3(x * 5.729577996E-05f, y * 5.729577996E-05f, z * 5.729577996E-05f);
    public static AngleAccel3 RadiansPerMicrosecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 17453.29238f, y * 17453.29238f, z * 17453.29238f);
    public static AngleAccel3 RadiansPerMicrosecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 17453.29238f, v.y * 17453.29238f, v.z * 17453.29238f);

    public Vector3 ToRadiansPerMicrosecondsPerMinute() => new Vector3(x * 0.003437746797f, y * 0.003437746797f, z * 0.003437746797f);
    public static AngleAccel3 RadiansPerMicrosecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 290.8882064f, y * 290.8882064f, z * 290.8882064f);
    public static AngleAccel3 RadiansPerMicrosecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 290.8882064f, v.y * 290.8882064f, v.z * 290.8882064f);

    public Vector3 ToRadiansPerMicrosecondsPerHour() => new Vector3(x * 0.2062648078f, y * 0.2062648078f, z * 0.2062648078f);
    public static AngleAccel3 RadiansPerMicrosecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 4.848136774f, y * 4.848136774f, z * 4.848136774f);
    public static AngleAccel3 RadiansPerMicrosecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 4.848136774f, v.y * 4.848136774f, v.z * 4.848136774f);

    public Vector3 ToRadiansPerMillisecondsPerMicrosecond() => new Vector3(x * 5.729577996E-08f, y * 5.729577996E-08f, z * 5.729577996E-08f);
    public static AngleAccel3 RadiansPerMillisecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 17453292.38f, y * 17453292.38f, z * 17453292.38f);
    public static AngleAccel3 RadiansPerMillisecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 17453292.38f, v.y * 17453292.38f, v.z * 17453292.38f);

    public Vector3 ToRadiansPerMillisecond2() => new Vector3(x * 5.729577996E-05f, y * 5.729577996E-05f, z * 5.729577996E-05f);
    public static AngleAccel3 RadiansPerMillisecond2(float x, float y, float z) => new AngleAccel3(x * 17453.29238f, y * 17453.29238f, z * 17453.29238f);
    public static AngleAccel3 RadiansPerMillisecond2(Vector3 v) => new AngleAccel3(v.x * 17453.29238f, v.y * 17453.29238f, v.z * 17453.29238f);

    public Vector3 ToRadiansPerMillisecondsPerSecond() => new Vector3(x * 0.05729577996f, y * 0.05729577996f, z * 0.05729577996f);
    public static AngleAccel3 RadiansPerMillisecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 17.45329238f, y * 17.45329238f, z * 17.45329238f);
    public static AngleAccel3 RadiansPerMillisecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 17.45329238f, v.y * 17.45329238f, v.z * 17.45329238f);

    public Vector3 ToRadiansPerMillisecondsPerMinute() => new Vector3(x * 3.437746797f, y * 3.437746797f, z * 3.437746797f);
    public static AngleAccel3 RadiansPerMillisecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 0.2908882064f, y * 0.2908882064f, z * 0.2908882064f);
    public static AngleAccel3 RadiansPerMillisecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 0.2908882064f, v.y * 0.2908882064f, v.z * 0.2908882064f);

    public Vector3 ToRadiansPerMillisecondsPerHour() => new Vector3(x * 206.2648078f, y * 206.2648078f, z * 206.2648078f);
    public static AngleAccel3 RadiansPerMillisecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 0.004848136774f, y * 0.004848136774f, z * 0.004848136774f);
    public static AngleAccel3 RadiansPerMillisecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 0.004848136774f, v.y * 0.004848136774f, v.z * 0.004848136774f);

    public Vector3 ToRadiansPerSecondsPerMicrosecond() => new Vector3(x * 5.729577996E-05f, y * 5.729577996E-05f, z * 5.729577996E-05f);
    public static AngleAccel3 RadiansPerSecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 17453.29238f, y * 17453.29238f, z * 17453.29238f);
    public static AngleAccel3 RadiansPerSecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 17453.29238f, v.y * 17453.29238f, v.z * 17453.29238f);

    public Vector3 ToRadiansPerSecondsPerMillisecond() => new Vector3(x * 0.05729577996f, y * 0.05729577996f, z * 0.05729577996f);
    public static AngleAccel3 RadiansPerSecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 17.45329238f, y * 17.45329238f, z * 17.45329238f);
    public static AngleAccel3 RadiansPerSecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 17.45329238f, v.y * 17.45329238f, v.z * 17.45329238f);

    public Vector3 ToRadiansPerSecond2() => new Vector3(x * 57.29577996f, y * 57.29577996f, z * 57.29577996f);
    public static AngleAccel3 RadiansPerSecond2(float x, float y, float z) => new AngleAccel3(x * 0.01745329238f, y * 0.01745329238f, z * 0.01745329238f);
    public static AngleAccel3 RadiansPerSecond2(Vector3 v) => new AngleAccel3(v.x * 0.01745329238f, v.y * 0.01745329238f, v.z * 0.01745329238f);

    public Vector3 ToRadiansPerSecondsPerMinute() => new Vector3(x * 3437.746797f, y * 3437.746797f, z * 3437.746797f);
    public static AngleAccel3 RadiansPerSecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 0.0002908882064f, y * 0.0002908882064f, z * 0.0002908882064f);
    public static AngleAccel3 RadiansPerSecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 0.0002908882064f, v.y * 0.0002908882064f, v.z * 0.0002908882064f);

    public Vector3 ToRadiansPerSecondsPerHour() => new Vector3(x * 206264.8078f, y * 206264.8078f, z * 206264.8078f);
    public static AngleAccel3 RadiansPerSecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 4.848136774E-06f, y * 4.848136774E-06f, z * 4.848136774E-06f);
    public static AngleAccel3 RadiansPerSecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 4.848136774E-06f, v.y * 4.848136774E-06f, v.z * 4.848136774E-06f);

    public Vector3 ToRadiansPerMinutesPerMicrosecond() => new Vector3(x * 0.003437746797f, y * 0.003437746797f, z * 0.003437746797f);
    public static AngleAccel3 RadiansPerMinutesPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 290.8882064f, y * 290.8882064f, z * 290.8882064f);
    public static AngleAccel3 RadiansPerMinutesPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 290.8882064f, v.y * 290.8882064f, v.z * 290.8882064f);

    public Vector3 ToRadiansPerMinutesPerMillisecond() => new Vector3(x * 3.437746797f, y * 3.437746797f, z * 3.437746797f);
    public static AngleAccel3 RadiansPerMinutesPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 0.2908882064f, y * 0.2908882064f, z * 0.2908882064f);
    public static AngleAccel3 RadiansPerMinutesPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 0.2908882064f, v.y * 0.2908882064f, v.z * 0.2908882064f);

    public Vector3 ToRadiansPerMinutesPerSecond() => new Vector3(x * 3437.746797f, y * 3437.746797f, z * 3437.746797f);
    public static AngleAccel3 RadiansPerMinutesPerSecond(float x, float y, float z) => new AngleAccel3(x * 0.0002908882064f, y * 0.0002908882064f, z * 0.0002908882064f);
    public static AngleAccel3 RadiansPerMinutesPerSecond(Vector3 v) => new AngleAccel3(v.x * 0.0002908882064f, v.y * 0.0002908882064f, v.z * 0.0002908882064f);

    public Vector3 ToRadiansPerMinute2() => new Vector3(x * 206264.8078f, y * 206264.8078f, z * 206264.8078f);
    public static AngleAccel3 RadiansPerMinute2(float x, float y, float z) => new AngleAccel3(x * 4.848136774E-06f, y * 4.848136774E-06f, z * 4.848136774E-06f);
    public static AngleAccel3 RadiansPerMinute2(Vector3 v) => new AngleAccel3(v.x * 4.848136774E-06f, v.y * 4.848136774E-06f, v.z * 4.848136774E-06f);

    public Vector3 ToRadiansPerMinutesPerHour() => new Vector3(x * 12375888.47f, y * 12375888.47f, z * 12375888.47f);
    public static AngleAccel3 RadiansPerMinutesPerHour(float x, float y, float z) => new AngleAccel3(x * 8.080227956E-08f, y * 8.080227956E-08f, z * 8.080227956E-08f);
    public static AngleAccel3 RadiansPerMinutesPerHour(Vector3 v) => new AngleAccel3(v.x * 8.080227956E-08f, v.y * 8.080227956E-08f, v.z * 8.080227956E-08f);

    public Vector3 ToRadiansPerHoursPerMicrosecond() => new Vector3(x * 0.2062648078f, y * 0.2062648078f, z * 0.2062648078f);
    public static AngleAccel3 RadiansPerHoursPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 4.848136774f, y * 4.848136774f, z * 4.848136774f);
    public static AngleAccel3 RadiansPerHoursPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 4.848136774f, v.y * 4.848136774f, v.z * 4.848136774f);

    public Vector3 ToRadiansPerHoursPerMillisecond() => new Vector3(x * 206.2648078f, y * 206.2648078f, z * 206.2648078f);
    public static AngleAccel3 RadiansPerHoursPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 0.004848136774f, y * 0.004848136774f, z * 0.004848136774f);
    public static AngleAccel3 RadiansPerHoursPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 0.004848136774f, v.y * 0.004848136774f, v.z * 0.004848136774f);

    public Vector3 ToRadiansPerHoursPerSecond() => new Vector3(x * 206264.8078f, y * 206264.8078f, z * 206264.8078f);
    public static AngleAccel3 RadiansPerHoursPerSecond(float x, float y, float z) => new AngleAccel3(x * 4.848136774E-06f, y * 4.848136774E-06f, z * 4.848136774E-06f);
    public static AngleAccel3 RadiansPerHoursPerSecond(Vector3 v) => new AngleAccel3(v.x * 4.848136774E-06f, v.y * 4.848136774E-06f, v.z * 4.848136774E-06f);

    public Vector3 ToRadiansPerHoursPerMinute() => new Vector3(x * 12375888.47f, y * 12375888.47f, z * 12375888.47f);
    public static AngleAccel3 RadiansPerHoursPerMinute(float x, float y, float z) => new AngleAccel3(x * 8.080227956E-08f, y * 8.080227956E-08f, z * 8.080227956E-08f);
    public static AngleAccel3 RadiansPerHoursPerMinute(Vector3 v) => new AngleAccel3(v.x * 8.080227956E-08f, v.y * 8.080227956E-08f, v.z * 8.080227956E-08f);

    public Vector3 ToRadiansPerHour2() => new Vector3(x * 742553308.2f, y * 742553308.2f, z * 742553308.2f);
    public static AngleAccel3 RadiansPerHour2(float x, float y, float z) => new AngleAccel3(x * 1.346704659E-09f, y * 1.346704659E-09f, z * 1.346704659E-09f);
    public static AngleAccel3 RadiansPerHour2(Vector3 v) => new AngleAccel3(v.x * 1.346704659E-09f, v.y * 1.346704659E-09f, v.z * 1.346704659E-09f);

    public Vector3 ToTurnsPerMicrosecond2() => new Vector3(x * 2.777777778E-15f, y * 2.777777778E-15f, z * 2.777777778E-15f);
    public static AngleAccel3 TurnsPerMicrosecond2(float x, float y, float z) => new AngleAccel3(x * 3.6E+14f, y * 3.6E+14f, z * 3.6E+14f);
    public static AngleAccel3 TurnsPerMicrosecond2(Vector3 v) => new AngleAccel3(v.x * 3.6E+14f, v.y * 3.6E+14f, v.z * 3.6E+14f);

    public Vector3 ToTurnsPerMicrosecondsPerMillisecond() => new Vector3(x * 2.777777778E-12f, y * 2.777777778E-12f, z * 2.777777778E-12f);
    public static AngleAccel3 TurnsPerMicrosecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 3.6E+11f, y * 3.6E+11f, z * 3.6E+11f);
    public static AngleAccel3 TurnsPerMicrosecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 3.6E+11f, v.y * 3.6E+11f, v.z * 3.6E+11f);

    public Vector3 ToTurnsPerMicrosecondsPerSecond() => new Vector3(x * 2.777777778E-09f, y * 2.777777778E-09f, z * 2.777777778E-09f);
    public static AngleAccel3 TurnsPerMicrosecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 360000000f, y * 360000000f, z * 360000000f);
    public static AngleAccel3 TurnsPerMicrosecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 360000000f, v.y * 360000000f, v.z * 360000000f);

    public Vector3 ToTurnsPerMicrosecondsPerMinute() => new Vector3(x * 1.666666667E-07f, y * 1.666666667E-07f, z * 1.666666667E-07f);
    public static AngleAccel3 TurnsPerMicrosecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 6000000f, y * 6000000f, z * 6000000f);
    public static AngleAccel3 TurnsPerMicrosecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 6000000f, v.y * 6000000f, v.z * 6000000f);

    public Vector3 ToTurnsPerMicrosecondsPerHour() => new Vector3(x * 1E-05f, y * 1E-05f, z * 1E-05f);
    public static AngleAccel3 TurnsPerMicrosecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 100000f, y * 100000f, z * 100000f);
    public static AngleAccel3 TurnsPerMicrosecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 100000f, v.y * 100000f, v.z * 100000f);

    public Vector3 ToTurnsPerMillisecondsPerMicrosecond() => new Vector3(x * 2.777777778E-12f, y * 2.777777778E-12f, z * 2.777777778E-12f);
    public static AngleAccel3 TurnsPerMillisecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 3.6E+11f, y * 3.6E+11f, z * 3.6E+11f);
    public static AngleAccel3 TurnsPerMillisecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 3.6E+11f, v.y * 3.6E+11f, v.z * 3.6E+11f);

    public Vector3 ToTurnsPerMillisecond2() => new Vector3(x * 2.777777778E-09f, y * 2.777777778E-09f, z * 2.777777778E-09f);
    public static AngleAccel3 TurnsPerMillisecond2(float x, float y, float z) => new AngleAccel3(x * 360000000f, y * 360000000f, z * 360000000f);
    public static AngleAccel3 TurnsPerMillisecond2(Vector3 v) => new AngleAccel3(v.x * 360000000f, v.y * 360000000f, v.z * 360000000f);

    public Vector3 ToTurnsPerMillisecondsPerSecond() => new Vector3(x * 2.777777778E-06f, y * 2.777777778E-06f, z * 2.777777778E-06f);
    public static AngleAccel3 TurnsPerMillisecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 360000f, y * 360000f, z * 360000f);
    public static AngleAccel3 TurnsPerMillisecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 360000f, v.y * 360000f, v.z * 360000f);

    public Vector3 ToTurnsPerMillisecondsPerMinute() => new Vector3(x * 0.0001666666667f, y * 0.0001666666667f, z * 0.0001666666667f);
    public static AngleAccel3 TurnsPerMillisecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 6000f, y * 6000f, z * 6000f);
    public static AngleAccel3 TurnsPerMillisecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 6000f, v.y * 6000f, v.z * 6000f);

    public Vector3 ToTurnsPerMillisecondsPerHour() => new Vector3(x * 0.01f, y * 0.01f, z * 0.01f);
    public static AngleAccel3 TurnsPerMillisecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 100f, y * 100f, z * 100f);
    public static AngleAccel3 TurnsPerMillisecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 100f, v.y * 100f, v.z * 100f);

    public Vector3 ToTurnsPerSecondsPerMicrosecond() => new Vector3(x * 2.777777778E-09f, y * 2.777777778E-09f, z * 2.777777778E-09f);
    public static AngleAccel3 TurnsPerSecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 360000000f, y * 360000000f, z * 360000000f);
    public static AngleAccel3 TurnsPerSecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 360000000f, v.y * 360000000f, v.z * 360000000f);

    public Vector3 ToTurnsPerSecondsPerMillisecond() => new Vector3(x * 2.777777778E-06f, y * 2.777777778E-06f, z * 2.777777778E-06f);
    public static AngleAccel3 TurnsPerSecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 360000f, y * 360000f, z * 360000f);
    public static AngleAccel3 TurnsPerSecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 360000f, v.y * 360000f, v.z * 360000f);

    public Vector3 ToTurnsPerSecond2() => new Vector3(x * 0.002777777778f, y * 0.002777777778f, z * 0.002777777778f);
    public static AngleAccel3 TurnsPerSecond2(float x, float y, float z) => new AngleAccel3(x * 360f, y * 360f, z * 360f);
    public static AngleAccel3 TurnsPerSecond2(Vector3 v) => new AngleAccel3(v.x * 360f, v.y * 360f, v.z * 360f);

    public Vector3 ToTurnsPerSecondsPerMinute() => new Vector3(x * 0.1666666667f, y * 0.1666666667f, z * 0.1666666667f);
    public static AngleAccel3 TurnsPerSecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 6f, y * 6f, z * 6f);
    public static AngleAccel3 TurnsPerSecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 6f, v.y * 6f, v.z * 6f);

    public Vector3 ToTurnsPerSecondsPerHour() => new Vector3(x * 10f, y * 10f, z * 10f);
    public static AngleAccel3 TurnsPerSecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static AngleAccel3 TurnsPerSecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 0.1f, v.y * 0.1f, v.z * 0.1f);

    public Vector3 ToTurnsPerMinutesPerMicrosecond() => new Vector3(x * 1.666666667E-07f, y * 1.666666667E-07f, z * 1.666666667E-07f);
    public static AngleAccel3 TurnsPerMinutesPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 6000000f, y * 6000000f, z * 6000000f);
    public static AngleAccel3 TurnsPerMinutesPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 6000000f, v.y * 6000000f, v.z * 6000000f);

    public Vector3 ToTurnsPerMinutesPerMillisecond() => new Vector3(x * 0.0001666666667f, y * 0.0001666666667f, z * 0.0001666666667f);
    public static AngleAccel3 TurnsPerMinutesPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 6000f, y * 6000f, z * 6000f);
    public static AngleAccel3 TurnsPerMinutesPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 6000f, v.y * 6000f, v.z * 6000f);

    public Vector3 ToTurnsPerMinutesPerSecond() => new Vector3(x * 0.1666666667f, y * 0.1666666667f, z * 0.1666666667f);
    public static AngleAccel3 TurnsPerMinutesPerSecond(float x, float y, float z) => new AngleAccel3(x * 6f, y * 6f, z * 6f);
    public static AngleAccel3 TurnsPerMinutesPerSecond(Vector3 v) => new AngleAccel3(v.x * 6f, v.y * 6f, v.z * 6f);

    public Vector3 ToTurnsPerMinute2() => new Vector3(x * 10f, y * 10f, z * 10f);
    public static AngleAccel3 TurnsPerMinute2(float x, float y, float z) => new AngleAccel3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static AngleAccel3 TurnsPerMinute2(Vector3 v) => new AngleAccel3(v.x * 0.1f, v.y * 0.1f, v.z * 0.1f);

    public Vector3 ToTurnsPerMinutesPerHour() => new Vector3(x * 600f, y * 600f, z * 600f);
    public static AngleAccel3 TurnsPerMinutesPerHour(float x, float y, float z) => new AngleAccel3(x * 0.001666666667f, y * 0.001666666667f, z * 0.001666666667f);
    public static AngleAccel3 TurnsPerMinutesPerHour(Vector3 v) => new AngleAccel3(v.x * 0.001666666667f, v.y * 0.001666666667f, v.z * 0.001666666667f);

    public Vector3 ToTurnsPerHoursPerMicrosecond() => new Vector3(x * 1E-05f, y * 1E-05f, z * 1E-05f);
    public static AngleAccel3 TurnsPerHoursPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 100000f, y * 100000f, z * 100000f);
    public static AngleAccel3 TurnsPerHoursPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 100000f, v.y * 100000f, v.z * 100000f);

    public Vector3 ToTurnsPerHoursPerMillisecond() => new Vector3(x * 0.01f, y * 0.01f, z * 0.01f);
    public static AngleAccel3 TurnsPerHoursPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 100f, y * 100f, z * 100f);
    public static AngleAccel3 TurnsPerHoursPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 100f, v.y * 100f, v.z * 100f);

    public Vector3 ToTurnsPerHoursPerSecond() => new Vector3(x * 10f, y * 10f, z * 10f);
    public static AngleAccel3 TurnsPerHoursPerSecond(float x, float y, float z) => new AngleAccel3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static AngleAccel3 TurnsPerHoursPerSecond(Vector3 v) => new AngleAccel3(v.x * 0.1f, v.y * 0.1f, v.z * 0.1f);

    public Vector3 ToTurnsPerHoursPerMinute() => new Vector3(x * 600f, y * 600f, z * 600f);
    public static AngleAccel3 TurnsPerHoursPerMinute(float x, float y, float z) => new AngleAccel3(x * 0.001666666667f, y * 0.001666666667f, z * 0.001666666667f);
    public static AngleAccel3 TurnsPerHoursPerMinute(Vector3 v) => new AngleAccel3(v.x * 0.001666666667f, v.y * 0.001666666667f, v.z * 0.001666666667f);

    public Vector3 ToTurnsPerHour2() => new Vector3(x * 36000f, y * 36000f, z * 36000f);
    public static AngleAccel3 TurnsPerHour2(float x, float y, float z) => new AngleAccel3(x * 2.777777778E-05f, y * 2.777777778E-05f, z * 2.777777778E-05f);
    public static AngleAccel3 TurnsPerHour2(Vector3 v) => new AngleAccel3(v.x * 2.777777778E-05f, v.y * 2.777777778E-05f, v.z * 2.777777778E-05f);

    public Vector3 ToMinuteDegreesPerMicrosecond2() => new Vector3(x * 6E-11f, y * 6E-11f, z * 6E-11f);
    public static AngleAccel3 MinuteDegreesPerMicrosecond2(float x, float y, float z) => new AngleAccel3(x * 1.666666667E+10f, y * 1.666666667E+10f, z * 1.666666667E+10f);
    public static AngleAccel3 MinuteDegreesPerMicrosecond2(Vector3 v) => new AngleAccel3(v.x * 1.666666667E+10f, v.y * 1.666666667E+10f, v.z * 1.666666667E+10f);

    public Vector3 ToMinuteDegreesPerMicrosecondsPerMillisecond() => new Vector3(x * 6E-08f, y * 6E-08f, z * 6E-08f);
    public static AngleAccel3 MinuteDegreesPerMicrosecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 16666666.67f, y * 16666666.67f, z * 16666666.67f);
    public static AngleAccel3 MinuteDegreesPerMicrosecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 16666666.67f, v.y * 16666666.67f, v.z * 16666666.67f);

    public Vector3 ToMinuteDegreesPerMicrosecondsPerSecond() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static AngleAccel3 MinuteDegreesPerMicrosecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static AngleAccel3 MinuteDegreesPerMicrosecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMinuteDegreesPerMicrosecondsPerMinute() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static AngleAccel3 MinuteDegreesPerMicrosecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static AngleAccel3 MinuteDegreesPerMicrosecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToMinuteDegreesPerMicrosecondsPerHour() => new Vector3(x * 0.216f, y * 0.216f, z * 0.216f);
    public static AngleAccel3 MinuteDegreesPerMicrosecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 4.62962963f, y * 4.62962963f, z * 4.62962963f);
    public static AngleAccel3 MinuteDegreesPerMicrosecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 4.62962963f, v.y * 4.62962963f, v.z * 4.62962963f);

    public Vector3 ToMinuteDegreesPerMillisecondsPerMicrosecond() => new Vector3(x * 6E-08f, y * 6E-08f, z * 6E-08f);
    public static AngleAccel3 MinuteDegreesPerMillisecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 16666666.67f, y * 16666666.67f, z * 16666666.67f);
    public static AngleAccel3 MinuteDegreesPerMillisecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 16666666.67f, v.y * 16666666.67f, v.z * 16666666.67f);

    public Vector3 ToMinuteDegreesPerMillisecond2() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static AngleAccel3 MinuteDegreesPerMillisecond2(float x, float y, float z) => new AngleAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static AngleAccel3 MinuteDegreesPerMillisecond2(Vector3 v) => new AngleAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMinuteDegreesPerMillisecondsPerSecond() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static AngleAccel3 MinuteDegreesPerMillisecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static AngleAccel3 MinuteDegreesPerMillisecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToMinuteDegreesPerMillisecondsPerMinute() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static AngleAccel3 MinuteDegreesPerMillisecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static AngleAccel3 MinuteDegreesPerMillisecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMinuteDegreesPerMillisecondsPerHour() => new Vector3(x * 216f, y * 216f, z * 216f);
    public static AngleAccel3 MinuteDegreesPerMillisecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 0.00462962963f, y * 0.00462962963f, z * 0.00462962963f);
    public static AngleAccel3 MinuteDegreesPerMillisecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 0.00462962963f, v.y * 0.00462962963f, v.z * 0.00462962963f);

    public Vector3 ToMinuteDegreesPerSecondsPerMicrosecond() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static AngleAccel3 MinuteDegreesPerSecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static AngleAccel3 MinuteDegreesPerSecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMinuteDegreesPerSecondsPerMillisecond() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static AngleAccel3 MinuteDegreesPerSecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static AngleAccel3 MinuteDegreesPerSecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToMinuteDegreesPerSecond2() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static AngleAccel3 MinuteDegreesPerSecond2(float x, float y, float z) => new AngleAccel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static AngleAccel3 MinuteDegreesPerSecond2(Vector3 v) => new AngleAccel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMinuteDegreesPerSecondsPerMinute() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleAccel3 MinuteDegreesPerSecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleAccel3 MinuteDegreesPerSecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMinuteDegreesPerSecondsPerHour() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static AngleAccel3 MinuteDegreesPerSecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static AngleAccel3 MinuteDegreesPerSecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToMinuteDegreesPerMinutesPerMicrosecond() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static AngleAccel3 MinuteDegreesPerMinutesPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static AngleAccel3 MinuteDegreesPerMinutesPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToMinuteDegreesPerMinutesPerMillisecond() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static AngleAccel3 MinuteDegreesPerMinutesPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static AngleAccel3 MinuteDegreesPerMinutesPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMinuteDegreesPerMinutesPerSecond() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleAccel3 MinuteDegreesPerMinutesPerSecond(float x, float y, float z) => new AngleAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleAccel3 MinuteDegreesPerMinutesPerSecond(Vector3 v) => new AngleAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMinuteDegreesPerMinute2() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static AngleAccel3 MinuteDegreesPerMinute2(float x, float y, float z) => new AngleAccel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static AngleAccel3 MinuteDegreesPerMinute2(Vector3 v) => new AngleAccel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToMinuteDegreesPerMinutesPerHour() => new Vector3(x * 12960000f, y * 12960000f, z * 12960000f);
    public static AngleAccel3 MinuteDegreesPerMinutesPerHour(float x, float y, float z) => new AngleAccel3(x * 7.716049383E-08f, y * 7.716049383E-08f, z * 7.716049383E-08f);
    public static AngleAccel3 MinuteDegreesPerMinutesPerHour(Vector3 v) => new AngleAccel3(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f, v.z * 7.716049383E-08f);

    public Vector3 ToMinuteDegreesPerHoursPerMicrosecond() => new Vector3(x * 0.216f, y * 0.216f, z * 0.216f);
    public static AngleAccel3 MinuteDegreesPerHoursPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 4.62962963f, y * 4.62962963f, z * 4.62962963f);
    public static AngleAccel3 MinuteDegreesPerHoursPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 4.62962963f, v.y * 4.62962963f, v.z * 4.62962963f);

    public Vector3 ToMinuteDegreesPerHoursPerMillisecond() => new Vector3(x * 216f, y * 216f, z * 216f);
    public static AngleAccel3 MinuteDegreesPerHoursPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 0.00462962963f, y * 0.00462962963f, z * 0.00462962963f);
    public static AngleAccel3 MinuteDegreesPerHoursPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 0.00462962963f, v.y * 0.00462962963f, v.z * 0.00462962963f);

    public Vector3 ToMinuteDegreesPerHoursPerSecond() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static AngleAccel3 MinuteDegreesPerHoursPerSecond(float x, float y, float z) => new AngleAccel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static AngleAccel3 MinuteDegreesPerHoursPerSecond(Vector3 v) => new AngleAccel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToMinuteDegreesPerHoursPerMinute() => new Vector3(x * 12960000f, y * 12960000f, z * 12960000f);
    public static AngleAccel3 MinuteDegreesPerHoursPerMinute(float x, float y, float z) => new AngleAccel3(x * 7.716049383E-08f, y * 7.716049383E-08f, z * 7.716049383E-08f);
    public static AngleAccel3 MinuteDegreesPerHoursPerMinute(Vector3 v) => new AngleAccel3(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f, v.z * 7.716049383E-08f);

    public Vector3 ToMinuteDegreesPerHour2() => new Vector3(x * 777600000f, y * 777600000f, z * 777600000f);
    public static AngleAccel3 MinuteDegreesPerHour2(float x, float y, float z) => new AngleAccel3(x * 1.28600823E-09f, y * 1.28600823E-09f, z * 1.28600823E-09f);
    public static AngleAccel3 MinuteDegreesPerHour2(Vector3 v) => new AngleAccel3(v.x * 1.28600823E-09f, v.y * 1.28600823E-09f, v.z * 1.28600823E-09f);

    public Vector3 ToSecondDegreesPerMicrosecond2() => new Vector3(x * 3.6E-09f, y * 3.6E-09f, z * 3.6E-09f);
    public static AngleAccel3 SecondDegreesPerMicrosecond2(float x, float y, float z) => new AngleAccel3(x * 277777777.8f, y * 277777777.8f, z * 277777777.8f);
    public static AngleAccel3 SecondDegreesPerMicrosecond2(Vector3 v) => new AngleAccel3(v.x * 277777777.8f, v.y * 277777777.8f, v.z * 277777777.8f);

    public Vector3 ToSecondDegreesPerMicrosecondsPerMillisecond() => new Vector3(x * 3.6E-06f, y * 3.6E-06f, z * 3.6E-06f);
    public static AngleAccel3 SecondDegreesPerMicrosecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 277777.7778f, y * 277777.7778f, z * 277777.7778f);
    public static AngleAccel3 SecondDegreesPerMicrosecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 277777.7778f, v.y * 277777.7778f, v.z * 277777.7778f);

    public Vector3 ToSecondDegreesPerMicrosecondsPerSecond() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static AngleAccel3 SecondDegreesPerMicrosecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static AngleAccel3 SecondDegreesPerMicrosecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToSecondDegreesPerMicrosecondsPerMinute() => new Vector3(x * 0.216f, y * 0.216f, z * 0.216f);
    public static AngleAccel3 SecondDegreesPerMicrosecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 4.62962963f, y * 4.62962963f, z * 4.62962963f);
    public static AngleAccel3 SecondDegreesPerMicrosecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 4.62962963f, v.y * 4.62962963f, v.z * 4.62962963f);

    public Vector3 ToSecondDegreesPerMicrosecondsPerHour() => new Vector3(x * 12.96f, y * 12.96f, z * 12.96f);
    public static AngleAccel3 SecondDegreesPerMicrosecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 0.07716049383f, y * 0.07716049383f, z * 0.07716049383f);
    public static AngleAccel3 SecondDegreesPerMicrosecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 0.07716049383f, v.y * 0.07716049383f, v.z * 0.07716049383f);

    public Vector3 ToSecondDegreesPerMillisecondsPerMicrosecond() => new Vector3(x * 3.6E-06f, y * 3.6E-06f, z * 3.6E-06f);
    public static AngleAccel3 SecondDegreesPerMillisecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 277777.7778f, y * 277777.7778f, z * 277777.7778f);
    public static AngleAccel3 SecondDegreesPerMillisecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 277777.7778f, v.y * 277777.7778f, v.z * 277777.7778f);

    public Vector3 ToSecondDegreesPerMillisecond2() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static AngleAccel3 SecondDegreesPerMillisecond2(float x, float y, float z) => new AngleAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static AngleAccel3 SecondDegreesPerMillisecond2(Vector3 v) => new AngleAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToSecondDegreesPerMillisecondsPerSecond() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static AngleAccel3 SecondDegreesPerMillisecondsPerSecond(float x, float y, float z) => new AngleAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static AngleAccel3 SecondDegreesPerMillisecondsPerSecond(Vector3 v) => new AngleAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToSecondDegreesPerMillisecondsPerMinute() => new Vector3(x * 216f, y * 216f, z * 216f);
    public static AngleAccel3 SecondDegreesPerMillisecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 0.00462962963f, y * 0.00462962963f, z * 0.00462962963f);
    public static AngleAccel3 SecondDegreesPerMillisecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 0.00462962963f, v.y * 0.00462962963f, v.z * 0.00462962963f);

    public Vector3 ToSecondDegreesPerMillisecondsPerHour() => new Vector3(x * 12960f, y * 12960f, z * 12960f);
    public static AngleAccel3 SecondDegreesPerMillisecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 7.716049383E-05f, y * 7.716049383E-05f, z * 7.716049383E-05f);
    public static AngleAccel3 SecondDegreesPerMillisecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 7.716049383E-05f, v.y * 7.716049383E-05f, v.z * 7.716049383E-05f);

    public Vector3 ToSecondDegreesPerSecondsPerMicrosecond() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static AngleAccel3 SecondDegreesPerSecondsPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static AngleAccel3 SecondDegreesPerSecondsPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToSecondDegreesPerSecondsPerMillisecond() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static AngleAccel3 SecondDegreesPerSecondsPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static AngleAccel3 SecondDegreesPerSecondsPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToSecondDegreesPerSecond2() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static AngleAccel3 SecondDegreesPerSecond2(float x, float y, float z) => new AngleAccel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static AngleAccel3 SecondDegreesPerSecond2(Vector3 v) => new AngleAccel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToSecondDegreesPerSecondsPerMinute() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static AngleAccel3 SecondDegreesPerSecondsPerMinute(float x, float y, float z) => new AngleAccel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static AngleAccel3 SecondDegreesPerSecondsPerMinute(Vector3 v) => new AngleAccel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToSecondDegreesPerSecondsPerHour() => new Vector3(x * 12960000f, y * 12960000f, z * 12960000f);
    public static AngleAccel3 SecondDegreesPerSecondsPerHour(float x, float y, float z) => new AngleAccel3(x * 7.716049383E-08f, y * 7.716049383E-08f, z * 7.716049383E-08f);
    public static AngleAccel3 SecondDegreesPerSecondsPerHour(Vector3 v) => new AngleAccel3(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f, v.z * 7.716049383E-08f);

    public Vector3 ToSecondDegreesPerMinutesPerMicrosecond() => new Vector3(x * 0.216f, y * 0.216f, z * 0.216f);
    public static AngleAccel3 SecondDegreesPerMinutesPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 4.62962963f, y * 4.62962963f, z * 4.62962963f);
    public static AngleAccel3 SecondDegreesPerMinutesPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 4.62962963f, v.y * 4.62962963f, v.z * 4.62962963f);

    public Vector3 ToSecondDegreesPerMinutesPerMillisecond() => new Vector3(x * 216f, y * 216f, z * 216f);
    public static AngleAccel3 SecondDegreesPerMinutesPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 0.00462962963f, y * 0.00462962963f, z * 0.00462962963f);
    public static AngleAccel3 SecondDegreesPerMinutesPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 0.00462962963f, v.y * 0.00462962963f, v.z * 0.00462962963f);

    public Vector3 ToSecondDegreesPerMinutesPerSecond() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static AngleAccel3 SecondDegreesPerMinutesPerSecond(float x, float y, float z) => new AngleAccel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static AngleAccel3 SecondDegreesPerMinutesPerSecond(Vector3 v) => new AngleAccel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToSecondDegreesPerMinute2() => new Vector3(x * 12960000f, y * 12960000f, z * 12960000f);
    public static AngleAccel3 SecondDegreesPerMinute2(float x, float y, float z) => new AngleAccel3(x * 7.716049383E-08f, y * 7.716049383E-08f, z * 7.716049383E-08f);
    public static AngleAccel3 SecondDegreesPerMinute2(Vector3 v) => new AngleAccel3(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f, v.z * 7.716049383E-08f);

    public Vector3 ToSecondDegreesPerMinutesPerHour() => new Vector3(x * 777600000f, y * 777600000f, z * 777600000f);
    public static AngleAccel3 SecondDegreesPerMinutesPerHour(float x, float y, float z) => new AngleAccel3(x * 1.28600823E-09f, y * 1.28600823E-09f, z * 1.28600823E-09f);
    public static AngleAccel3 SecondDegreesPerMinutesPerHour(Vector3 v) => new AngleAccel3(v.x * 1.28600823E-09f, v.y * 1.28600823E-09f, v.z * 1.28600823E-09f);

    public Vector3 ToSecondDegreesPerHoursPerMicrosecond() => new Vector3(x * 12.96f, y * 12.96f, z * 12.96f);
    public static AngleAccel3 SecondDegreesPerHoursPerMicrosecond(float x, float y, float z) => new AngleAccel3(x * 0.07716049383f, y * 0.07716049383f, z * 0.07716049383f);
    public static AngleAccel3 SecondDegreesPerHoursPerMicrosecond(Vector3 v) => new AngleAccel3(v.x * 0.07716049383f, v.y * 0.07716049383f, v.z * 0.07716049383f);

    public Vector3 ToSecondDegreesPerHoursPerMillisecond() => new Vector3(x * 12960f, y * 12960f, z * 12960f);
    public static AngleAccel3 SecondDegreesPerHoursPerMillisecond(float x, float y, float z) => new AngleAccel3(x * 7.716049383E-05f, y * 7.716049383E-05f, z * 7.716049383E-05f);
    public static AngleAccel3 SecondDegreesPerHoursPerMillisecond(Vector3 v) => new AngleAccel3(v.x * 7.716049383E-05f, v.y * 7.716049383E-05f, v.z * 7.716049383E-05f);

    public Vector3 ToSecondDegreesPerHoursPerSecond() => new Vector3(x * 12960000f, y * 12960000f, z * 12960000f);
    public static AngleAccel3 SecondDegreesPerHoursPerSecond(float x, float y, float z) => new AngleAccel3(x * 7.716049383E-08f, y * 7.716049383E-08f, z * 7.716049383E-08f);
    public static AngleAccel3 SecondDegreesPerHoursPerSecond(Vector3 v) => new AngleAccel3(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f, v.z * 7.716049383E-08f);

    public Vector3 ToSecondDegreesPerHoursPerMinute() => new Vector3(x * 777600000f, y * 777600000f, z * 777600000f);
    public static AngleAccel3 SecondDegreesPerHoursPerMinute(float x, float y, float z) => new AngleAccel3(x * 1.28600823E-09f, y * 1.28600823E-09f, z * 1.28600823E-09f);
    public static AngleAccel3 SecondDegreesPerHoursPerMinute(Vector3 v) => new AngleAccel3(v.x * 1.28600823E-09f, v.y * 1.28600823E-09f, v.z * 1.28600823E-09f);

    public Vector3 ToSecondDegreesPerHour2() => new Vector3(x * 4.6656E+10f, y * 4.6656E+10f, z * 4.6656E+10f);
    public static AngleAccel3 SecondDegreesPerHour2(float x, float y, float z) => new AngleAccel3(x * 2.143347051E-11f, y * 2.143347051E-11f, z * 2.143347051E-11f);
    public static AngleAccel3 SecondDegreesPerHour2(Vector3 v) => new AngleAccel3(v.x * 2.143347051E-11f, v.y * 2.143347051E-11f, v.z * 2.143347051E-11f);

    public Vector3 ToMillinewtonsPerMilligram() => new Vector3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static AngleAccel3 MillinewtonsPerMilligram(float x, float y, float z) => new AngleAccel3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static AngleAccel3 MillinewtonsPerMilligram(Vector3 v) => new AngleAccel3(v.x * 1E-09f, v.y * 1E-09f, v.z * 1E-09f);

    public Vector3 ToMillinewtonsPerGram() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleAccel3 MillinewtonsPerGram(float x, float y, float z) => new AngleAccel3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleAccel3 MillinewtonsPerGram(Vector3 v) => new AngleAccel3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToMillinewtonsPerKilogram() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 MillinewtonsPerKilogram(float x, float y, float z) => new AngleAccel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 MillinewtonsPerKilogram(Vector3 v) => new AngleAccel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillinewtonsPerTon() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 MillinewtonsPerTon(float x, float y, float z) => new AngleAccel3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 MillinewtonsPerTon(Vector3 v) => new AngleAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtonsPerKiloton() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 MillinewtonsPerKiloton(float x, float y, float z) => new AngleAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 MillinewtonsPerKiloton(Vector3 v) => new AngleAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerMilligram() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleAccel3 NewtonsPerMilligram(float x, float y, float z) => new AngleAccel3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleAccel3 NewtonsPerMilligram(Vector3 v) => new AngleAccel3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToNewtonsPerGram() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 NewtonsPerGram(float x, float y, float z) => new AngleAccel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 NewtonsPerGram(Vector3 v) => new AngleAccel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToNewtonsPerKilogram() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 NewtonsPerKilogram(float x, float y, float z) => new AngleAccel3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 NewtonsPerKilogram(Vector3 v) => new AngleAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToNewtonsPerTon() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 NewtonsPerTon(float x, float y, float z) => new AngleAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 NewtonsPerTon(Vector3 v) => new AngleAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerKiloton() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleAccel3 NewtonsPerKiloton(float x, float y, float z) => new AngleAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleAccel3 NewtonsPerKiloton(Vector3 v) => new AngleAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerMilligram() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 KilonewtonsPerMilligram(float x, float y, float z) => new AngleAccel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 KilonewtonsPerMilligram(Vector3 v) => new AngleAccel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToKilonewtonsPerGram() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 KilonewtonsPerGram(float x, float y, float z) => new AngleAccel3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 KilonewtonsPerGram(Vector3 v) => new AngleAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToKilonewtonsPerKilogram() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 KilonewtonsPerKilogram(float x, float y, float z) => new AngleAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 KilonewtonsPerKilogram(Vector3 v) => new AngleAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilonewtonsPerTon() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleAccel3 KilonewtonsPerTon(float x, float y, float z) => new AngleAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleAccel3 KilonewtonsPerTon(Vector3 v) => new AngleAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerKiloton() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static AngleAccel3 KilonewtonsPerKiloton(float x, float y, float z) => new AngleAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static AngleAccel3 KilonewtonsPerKiloton(Vector3 v) => new AngleAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerMilligram() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 MeganewtonsPerMilligram(float x, float y, float z) => new AngleAccel3(x * 1f, y * 1f, z * 1f);
    public static AngleAccel3 MeganewtonsPerMilligram(Vector3 v) => new AngleAccel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMeganewtonsPerGram() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static AngleAccel3 MeganewtonsPerGram(float x, float y, float z) => new AngleAccel3(x * 1000f, y * 1000f, z * 1000f);
    public static AngleAccel3 MeganewtonsPerGram(Vector3 v) => new AngleAccel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMeganewtonsPerKilogram() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static AngleAccel3 MeganewtonsPerKilogram(float x, float y, float z) => new AngleAccel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static AngleAccel3 MeganewtonsPerKilogram(Vector3 v) => new AngleAccel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeganewtonsPerTon() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static AngleAccel3 MeganewtonsPerTon(float x, float y, float z) => new AngleAccel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static AngleAccel3 MeganewtonsPerTon(Vector3 v) => new AngleAccel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerKiloton() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static AngleAccel3 MeganewtonsPerKiloton(float x, float y, float z) => new AngleAccel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static AngleAccel3 MeganewtonsPerKiloton(Vector3 v) => new AngleAccel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public static AngleAccel3 operator +(AngleAccel3 a, AngleAccel3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static AngleAccel3 operator -(AngleAccel3 a, AngleAccel3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    
    public static AngleAccel3 operator *(AngleAccel3 a, AngleAccel3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static AngleAccel3 operator /(AngleAccel3 a, AngleAccel3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    
    public AngleVel3 AngleVel3(Time v) => new(v * x, v * y, v * z);
    public Time Time(AngleVel3 v) => new(v.magnitude / magnitude);

    public AngleAccel3(AngleVel3 a, Time b) => a.AngleAccel3(b);
    public AngleAccel3(Time b, AngleVel3 a) => a.AngleAccel3(b);

    public Torque3 Torque3(Mass v) => new(v * x, v * y, v * z);
    public Mass Mass(Torque3 v) => new(v.magnitude / magnitude);

    public AngleAccel3(Torque3 a, Mass b) => a.AngleAccel3(b);
    public AngleAccel3(Mass b, Torque3 a) => a.AngleAccel3(b);

}
}

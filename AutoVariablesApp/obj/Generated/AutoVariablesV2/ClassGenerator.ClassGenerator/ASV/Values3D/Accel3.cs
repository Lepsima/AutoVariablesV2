using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Accel3 : IAutoUnit3 {
    public float x, y, z;
    
    public Accel3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public Accel3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    
    public static implicit operator Vector3(Accel3 v) => new Vector3(v.x, v.y, v.z);
    public Accel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToFeetsPerMicrosecond2() => new Vector3(x * 3.048E-13f, y * 3.048E-13f, z * 3.048E-13f);
    public static Accel3 FeetsPerMicrosecond2(float x, float y, float z) => new Accel3(x * 3.280839895E+12f, y * 3.280839895E+12f, z * 3.280839895E+12f);
    public static Accel3 FeetsPerMicrosecond2(Vector3 v) => new Accel3(v.x * 3.280839895E+12f, v.y * 3.280839895E+12f, v.z * 3.280839895E+12f);

    public Vector3 ToFeetsPerMicrosecondsPerMillisecond() => new Vector3(x * 3.048E-10f, y * 3.048E-10f, z * 3.048E-10f);
    public static Accel3 FeetsPerMicrosecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 3280839895f, y * 3280839895f, z * 3280839895f);
    public static Accel3 FeetsPerMicrosecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 3280839895f, v.y * 3280839895f, v.z * 3280839895f);

    public Vector3 ToFeetsPerMicrosecondsPerSecond() => new Vector3(x * 3.048E-07f, y * 3.048E-07f, z * 3.048E-07f);
    public static Accel3 FeetsPerMicrosecondsPerSecond(float x, float y, float z) => new Accel3(x * 3280839.895f, y * 3280839.895f, z * 3280839.895f);
    public static Accel3 FeetsPerMicrosecondsPerSecond(Vector3 v) => new Accel3(v.x * 3280839.895f, v.y * 3280839.895f, v.z * 3280839.895f);

    public Vector3 ToFeetsPerMicrosecondsPerMinute() => new Vector3(x * 1.8288E-05f, y * 1.8288E-05f, z * 1.8288E-05f);
    public static Accel3 FeetsPerMicrosecondsPerMinute(float x, float y, float z) => new Accel3(x * 54680.66492f, y * 54680.66492f, z * 54680.66492f);
    public static Accel3 FeetsPerMicrosecondsPerMinute(Vector3 v) => new Accel3(v.x * 54680.66492f, v.y * 54680.66492f, v.z * 54680.66492f);

    public Vector3 ToFeetsPerMicrosecondsPerHour() => new Vector3(x * 0.00109728f, y * 0.00109728f, z * 0.00109728f);
    public static Accel3 FeetsPerMicrosecondsPerHour(float x, float y, float z) => new Accel3(x * 911.3444153f, y * 911.3444153f, z * 911.3444153f);
    public static Accel3 FeetsPerMicrosecondsPerHour(Vector3 v) => new Accel3(v.x * 911.3444153f, v.y * 911.3444153f, v.z * 911.3444153f);

    public Vector3 ToFeetsPerMillisecondsPerMicrosecond() => new Vector3(x * 3.048E-10f, y * 3.048E-10f, z * 3.048E-10f);
    public static Accel3 FeetsPerMillisecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 3280839895f, y * 3280839895f, z * 3280839895f);
    public static Accel3 FeetsPerMillisecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 3280839895f, v.y * 3280839895f, v.z * 3280839895f);

    public Vector3 ToFeetsPerMillisecond2() => new Vector3(x * 3.048E-07f, y * 3.048E-07f, z * 3.048E-07f);
    public static Accel3 FeetsPerMillisecond2(float x, float y, float z) => new Accel3(x * 3280839.895f, y * 3280839.895f, z * 3280839.895f);
    public static Accel3 FeetsPerMillisecond2(Vector3 v) => new Accel3(v.x * 3280839.895f, v.y * 3280839.895f, v.z * 3280839.895f);

    public Vector3 ToFeetsPerMillisecondsPerSecond() => new Vector3(x * 0.0003048f, y * 0.0003048f, z * 0.0003048f);
    public static Accel3 FeetsPerMillisecondsPerSecond(float x, float y, float z) => new Accel3(x * 3280.839895f, y * 3280.839895f, z * 3280.839895f);
    public static Accel3 FeetsPerMillisecondsPerSecond(Vector3 v) => new Accel3(v.x * 3280.839895f, v.y * 3280.839895f, v.z * 3280.839895f);

    public Vector3 ToFeetsPerMillisecondsPerMinute() => new Vector3(x * 0.018288f, y * 0.018288f, z * 0.018288f);
    public static Accel3 FeetsPerMillisecondsPerMinute(float x, float y, float z) => new Accel3(x * 54.68066492f, y * 54.68066492f, z * 54.68066492f);
    public static Accel3 FeetsPerMillisecondsPerMinute(Vector3 v) => new Accel3(v.x * 54.68066492f, v.y * 54.68066492f, v.z * 54.68066492f);

    public Vector3 ToFeetsPerMillisecondsPerHour() => new Vector3(x * 1.09728f, y * 1.09728f, z * 1.09728f);
    public static Accel3 FeetsPerMillisecondsPerHour(float x, float y, float z) => new Accel3(x * 0.9113444153f, y * 0.9113444153f, z * 0.9113444153f);
    public static Accel3 FeetsPerMillisecondsPerHour(Vector3 v) => new Accel3(v.x * 0.9113444153f, v.y * 0.9113444153f, v.z * 0.9113444153f);

    public Vector3 ToFeetsPerSecondsPerMicrosecond() => new Vector3(x * 3.048E-07f, y * 3.048E-07f, z * 3.048E-07f);
    public static Accel3 FeetsPerSecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 3280839.895f, y * 3280839.895f, z * 3280839.895f);
    public static Accel3 FeetsPerSecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 3280839.895f, v.y * 3280839.895f, v.z * 3280839.895f);

    public Vector3 ToFeetsPerSecondsPerMillisecond() => new Vector3(x * 0.0003048f, y * 0.0003048f, z * 0.0003048f);
    public static Accel3 FeetsPerSecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 3280.839895f, y * 3280.839895f, z * 3280.839895f);
    public static Accel3 FeetsPerSecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 3280.839895f, v.y * 3280.839895f, v.z * 3280.839895f);

    public Vector3 ToFeetsPerSecond2() => new Vector3(x * 0.3048f, y * 0.3048f, z * 0.3048f);
    public static Accel3 FeetsPerSecond2(float x, float y, float z) => new Accel3(x * 3.280839895f, y * 3.280839895f, z * 3.280839895f);
    public static Accel3 FeetsPerSecond2(Vector3 v) => new Accel3(v.x * 3.280839895f, v.y * 3.280839895f, v.z * 3.280839895f);

    public Vector3 ToFeetsPerSecondsPerMinute() => new Vector3(x * 18.288f, y * 18.288f, z * 18.288f);
    public static Accel3 FeetsPerSecondsPerMinute(float x, float y, float z) => new Accel3(x * 0.05468066492f, y * 0.05468066492f, z * 0.05468066492f);
    public static Accel3 FeetsPerSecondsPerMinute(Vector3 v) => new Accel3(v.x * 0.05468066492f, v.y * 0.05468066492f, v.z * 0.05468066492f);

    public Vector3 ToFeetsPerSecondsPerHour() => new Vector3(x * 1097.28f, y * 1097.28f, z * 1097.28f);
    public static Accel3 FeetsPerSecondsPerHour(float x, float y, float z) => new Accel3(x * 0.0009113444153f, y * 0.0009113444153f, z * 0.0009113444153f);
    public static Accel3 FeetsPerSecondsPerHour(Vector3 v) => new Accel3(v.x * 0.0009113444153f, v.y * 0.0009113444153f, v.z * 0.0009113444153f);

    public Vector3 ToFeetsPerMinutesPerMicrosecond() => new Vector3(x * 1.8288E-05f, y * 1.8288E-05f, z * 1.8288E-05f);
    public static Accel3 FeetsPerMinutesPerMicrosecond(float x, float y, float z) => new Accel3(x * 54680.66492f, y * 54680.66492f, z * 54680.66492f);
    public static Accel3 FeetsPerMinutesPerMicrosecond(Vector3 v) => new Accel3(v.x * 54680.66492f, v.y * 54680.66492f, v.z * 54680.66492f);

    public Vector3 ToFeetsPerMinutesPerMillisecond() => new Vector3(x * 0.018288f, y * 0.018288f, z * 0.018288f);
    public static Accel3 FeetsPerMinutesPerMillisecond(float x, float y, float z) => new Accel3(x * 54.68066492f, y * 54.68066492f, z * 54.68066492f);
    public static Accel3 FeetsPerMinutesPerMillisecond(Vector3 v) => new Accel3(v.x * 54.68066492f, v.y * 54.68066492f, v.z * 54.68066492f);

    public Vector3 ToFeetsPerMinutesPerSecond() => new Vector3(x * 18.288f, y * 18.288f, z * 18.288f);
    public static Accel3 FeetsPerMinutesPerSecond(float x, float y, float z) => new Accel3(x * 0.05468066492f, y * 0.05468066492f, z * 0.05468066492f);
    public static Accel3 FeetsPerMinutesPerSecond(Vector3 v) => new Accel3(v.x * 0.05468066492f, v.y * 0.05468066492f, v.z * 0.05468066492f);

    public Vector3 ToFeetsPerMinute2() => new Vector3(x * 1097.28f, y * 1097.28f, z * 1097.28f);
    public static Accel3 FeetsPerMinute2(float x, float y, float z) => new Accel3(x * 0.0009113444153f, y * 0.0009113444153f, z * 0.0009113444153f);
    public static Accel3 FeetsPerMinute2(Vector3 v) => new Accel3(v.x * 0.0009113444153f, v.y * 0.0009113444153f, v.z * 0.0009113444153f);

    public Vector3 ToFeetsPerMinutesPerHour() => new Vector3(x * 65836.8f, y * 65836.8f, z * 65836.8f);
    public static Accel3 FeetsPerMinutesPerHour(float x, float y, float z) => new Accel3(x * 1.518907359E-05f, y * 1.518907359E-05f, z * 1.518907359E-05f);
    public static Accel3 FeetsPerMinutesPerHour(Vector3 v) => new Accel3(v.x * 1.518907359E-05f, v.y * 1.518907359E-05f, v.z * 1.518907359E-05f);

    public Vector3 ToFeetsPerHoursPerMicrosecond() => new Vector3(x * 0.00109728f, y * 0.00109728f, z * 0.00109728f);
    public static Accel3 FeetsPerHoursPerMicrosecond(float x, float y, float z) => new Accel3(x * 911.3444153f, y * 911.3444153f, z * 911.3444153f);
    public static Accel3 FeetsPerHoursPerMicrosecond(Vector3 v) => new Accel3(v.x * 911.3444153f, v.y * 911.3444153f, v.z * 911.3444153f);

    public Vector3 ToFeetsPerHoursPerMillisecond() => new Vector3(x * 1.09728f, y * 1.09728f, z * 1.09728f);
    public static Accel3 FeetsPerHoursPerMillisecond(float x, float y, float z) => new Accel3(x * 0.9113444153f, y * 0.9113444153f, z * 0.9113444153f);
    public static Accel3 FeetsPerHoursPerMillisecond(Vector3 v) => new Accel3(v.x * 0.9113444153f, v.y * 0.9113444153f, v.z * 0.9113444153f);

    public Vector3 ToFeetsPerHoursPerSecond() => new Vector3(x * 1097.28f, y * 1097.28f, z * 1097.28f);
    public static Accel3 FeetsPerHoursPerSecond(float x, float y, float z) => new Accel3(x * 0.0009113444153f, y * 0.0009113444153f, z * 0.0009113444153f);
    public static Accel3 FeetsPerHoursPerSecond(Vector3 v) => new Accel3(v.x * 0.0009113444153f, v.y * 0.0009113444153f, v.z * 0.0009113444153f);

    public Vector3 ToFeetsPerHoursPerMinute() => new Vector3(x * 65836.8f, y * 65836.8f, z * 65836.8f);
    public static Accel3 FeetsPerHoursPerMinute(float x, float y, float z) => new Accel3(x * 1.518907359E-05f, y * 1.518907359E-05f, z * 1.518907359E-05f);
    public static Accel3 FeetsPerHoursPerMinute(Vector3 v) => new Accel3(v.x * 1.518907359E-05f, v.y * 1.518907359E-05f, v.z * 1.518907359E-05f);

    public Vector3 ToFeetsPerHour2() => new Vector3(x * 3950208f, y * 3950208f, z * 3950208f);
    public static Accel3 FeetsPerHour2(float x, float y, float z) => new Accel3(x * 2.531512265E-07f, y * 2.531512265E-07f, z * 2.531512265E-07f);
    public static Accel3 FeetsPerHour2(Vector3 v) => new Accel3(v.x * 2.531512265E-07f, v.y * 2.531512265E-07f, v.z * 2.531512265E-07f);

    public Vector3 ToMilesPerMicrosecond2() => new Vector3(x * 6.213711922E-16f, y * 6.213711922E-16f, z * 6.213711922E-16f);
    public static Accel3 MilesPerMicrosecond2(float x, float y, float z) => new Accel3(x * 1.609344E+15f, y * 1.609344E+15f, z * 1.609344E+15f);
    public static Accel3 MilesPerMicrosecond2(Vector3 v) => new Accel3(v.x * 1.609344E+15f, v.y * 1.609344E+15f, v.z * 1.609344E+15f);

    public Vector3 ToMilesPerMicrosecondsPerMillisecond() => new Vector3(x * 6.213711922E-13f, y * 6.213711922E-13f, z * 6.213711922E-13f);
    public static Accel3 MilesPerMicrosecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1.609344E+12f, y * 1.609344E+12f, z * 1.609344E+12f);
    public static Accel3 MilesPerMicrosecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1.609344E+12f, v.y * 1.609344E+12f, v.z * 1.609344E+12f);

    public Vector3 ToMilesPerMicrosecondsPerSecond() => new Vector3(x * 6.213711922E-10f, y * 6.213711922E-10f, z * 6.213711922E-10f);
    public static Accel3 MilesPerMicrosecondsPerSecond(float x, float y, float z) => new Accel3(x * 1609344000f, y * 1609344000f, z * 1609344000f);
    public static Accel3 MilesPerMicrosecondsPerSecond(Vector3 v) => new Accel3(v.x * 1609344000f, v.y * 1609344000f, v.z * 1609344000f);

    public Vector3 ToMilesPerMicrosecondsPerMinute() => new Vector3(x * 3.728227153E-08f, y * 3.728227153E-08f, z * 3.728227153E-08f);
    public static Accel3 MilesPerMicrosecondsPerMinute(float x, float y, float z) => new Accel3(x * 26822400f, y * 26822400f, z * 26822400f);
    public static Accel3 MilesPerMicrosecondsPerMinute(Vector3 v) => new Accel3(v.x * 26822400f, v.y * 26822400f, v.z * 26822400f);

    public Vector3 ToMilesPerMicrosecondsPerHour() => new Vector3(x * 2.236936292E-06f, y * 2.236936292E-06f, z * 2.236936292E-06f);
    public static Accel3 MilesPerMicrosecondsPerHour(float x, float y, float z) => new Accel3(x * 447040f, y * 447040f, z * 447040f);
    public static Accel3 MilesPerMicrosecondsPerHour(Vector3 v) => new Accel3(v.x * 447040f, v.y * 447040f, v.z * 447040f);

    public Vector3 ToMilesPerMillisecondsPerMicrosecond() => new Vector3(x * 6.213711922E-13f, y * 6.213711922E-13f, z * 6.213711922E-13f);
    public static Accel3 MilesPerMillisecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1.609344E+12f, y * 1.609344E+12f, z * 1.609344E+12f);
    public static Accel3 MilesPerMillisecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1.609344E+12f, v.y * 1.609344E+12f, v.z * 1.609344E+12f);

    public Vector3 ToMilesPerMillisecond2() => new Vector3(x * 6.213711922E-10f, y * 6.213711922E-10f, z * 6.213711922E-10f);
    public static Accel3 MilesPerMillisecond2(float x, float y, float z) => new Accel3(x * 1609344000f, y * 1609344000f, z * 1609344000f);
    public static Accel3 MilesPerMillisecond2(Vector3 v) => new Accel3(v.x * 1609344000f, v.y * 1609344000f, v.z * 1609344000f);

    public Vector3 ToMilesPerMillisecondsPerSecond() => new Vector3(x * 6.213711922E-07f, y * 6.213711922E-07f, z * 6.213711922E-07f);
    public static Accel3 MilesPerMillisecondsPerSecond(float x, float y, float z) => new Accel3(x * 1609344f, y * 1609344f, z * 1609344f);
    public static Accel3 MilesPerMillisecondsPerSecond(Vector3 v) => new Accel3(v.x * 1609344f, v.y * 1609344f, v.z * 1609344f);

    public Vector3 ToMilesPerMillisecondsPerMinute() => new Vector3(x * 3.728227153E-05f, y * 3.728227153E-05f, z * 3.728227153E-05f);
    public static Accel3 MilesPerMillisecondsPerMinute(float x, float y, float z) => new Accel3(x * 26822.4f, y * 26822.4f, z * 26822.4f);
    public static Accel3 MilesPerMillisecondsPerMinute(Vector3 v) => new Accel3(v.x * 26822.4f, v.y * 26822.4f, v.z * 26822.4f);

    public Vector3 ToMilesPerMillisecondsPerHour() => new Vector3(x * 0.002236936292f, y * 0.002236936292f, z * 0.002236936292f);
    public static Accel3 MilesPerMillisecondsPerHour(float x, float y, float z) => new Accel3(x * 447.04f, y * 447.04f, z * 447.04f);
    public static Accel3 MilesPerMillisecondsPerHour(Vector3 v) => new Accel3(v.x * 447.04f, v.y * 447.04f, v.z * 447.04f);

    public Vector3 ToMilesPerSecondsPerMicrosecond() => new Vector3(x * 6.213711922E-10f, y * 6.213711922E-10f, z * 6.213711922E-10f);
    public static Accel3 MilesPerSecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1609344000f, y * 1609344000f, z * 1609344000f);
    public static Accel3 MilesPerSecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1609344000f, v.y * 1609344000f, v.z * 1609344000f);

    public Vector3 ToMilesPerSecondsPerMillisecond() => new Vector3(x * 6.213711922E-07f, y * 6.213711922E-07f, z * 6.213711922E-07f);
    public static Accel3 MilesPerSecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1609344f, y * 1609344f, z * 1609344f);
    public static Accel3 MilesPerSecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1609344f, v.y * 1609344f, v.z * 1609344f);

    public Vector3 ToMilesPerSecond2() => new Vector3(x * 0.0006213711922f, y * 0.0006213711922f, z * 0.0006213711922f);
    public static Accel3 MilesPerSecond2(float x, float y, float z) => new Accel3(x * 1609.344f, y * 1609.344f, z * 1609.344f);
    public static Accel3 MilesPerSecond2(Vector3 v) => new Accel3(v.x * 1609.344f, v.y * 1609.344f, v.z * 1609.344f);

    public Vector3 ToMilesPerSecondsPerMinute() => new Vector3(x * 0.03728227153f, y * 0.03728227153f, z * 0.03728227153f);
    public static Accel3 MilesPerSecondsPerMinute(float x, float y, float z) => new Accel3(x * 26.8224f, y * 26.8224f, z * 26.8224f);
    public static Accel3 MilesPerSecondsPerMinute(Vector3 v) => new Accel3(v.x * 26.8224f, v.y * 26.8224f, v.z * 26.8224f);

    public Vector3 ToMilesPerSecondsPerHour() => new Vector3(x * 2.236936292f, y * 2.236936292f, z * 2.236936292f);
    public static Accel3 MilesPerSecondsPerHour(float x, float y, float z) => new Accel3(x * 0.44704f, y * 0.44704f, z * 0.44704f);
    public static Accel3 MilesPerSecondsPerHour(Vector3 v) => new Accel3(v.x * 0.44704f, v.y * 0.44704f, v.z * 0.44704f);

    public Vector3 ToMilesPerMinutesPerMicrosecond() => new Vector3(x * 3.728227153E-08f, y * 3.728227153E-08f, z * 3.728227153E-08f);
    public static Accel3 MilesPerMinutesPerMicrosecond(float x, float y, float z) => new Accel3(x * 26822400f, y * 26822400f, z * 26822400f);
    public static Accel3 MilesPerMinutesPerMicrosecond(Vector3 v) => new Accel3(v.x * 26822400f, v.y * 26822400f, v.z * 26822400f);

    public Vector3 ToMilesPerMinutesPerMillisecond() => new Vector3(x * 3.728227153E-05f, y * 3.728227153E-05f, z * 3.728227153E-05f);
    public static Accel3 MilesPerMinutesPerMillisecond(float x, float y, float z) => new Accel3(x * 26822.4f, y * 26822.4f, z * 26822.4f);
    public static Accel3 MilesPerMinutesPerMillisecond(Vector3 v) => new Accel3(v.x * 26822.4f, v.y * 26822.4f, v.z * 26822.4f);

    public Vector3 ToMilesPerMinutesPerSecond() => new Vector3(x * 0.03728227153f, y * 0.03728227153f, z * 0.03728227153f);
    public static Accel3 MilesPerMinutesPerSecond(float x, float y, float z) => new Accel3(x * 26.8224f, y * 26.8224f, z * 26.8224f);
    public static Accel3 MilesPerMinutesPerSecond(Vector3 v) => new Accel3(v.x * 26.8224f, v.y * 26.8224f, v.z * 26.8224f);

    public Vector3 ToMilesPerMinute2() => new Vector3(x * 2.236936292f, y * 2.236936292f, z * 2.236936292f);
    public static Accel3 MilesPerMinute2(float x, float y, float z) => new Accel3(x * 0.44704f, y * 0.44704f, z * 0.44704f);
    public static Accel3 MilesPerMinute2(Vector3 v) => new Accel3(v.x * 0.44704f, v.y * 0.44704f, v.z * 0.44704f);

    public Vector3 ToMilesPerMinutesPerHour() => new Vector3(x * 134.2161775f, y * 134.2161775f, z * 134.2161775f);
    public static Accel3 MilesPerMinutesPerHour(float x, float y, float z) => new Accel3(x * 0.007450666667f, y * 0.007450666667f, z * 0.007450666667f);
    public static Accel3 MilesPerMinutesPerHour(Vector3 v) => new Accel3(v.x * 0.007450666667f, v.y * 0.007450666667f, v.z * 0.007450666667f);

    public Vector3 ToMilesPerHoursPerMicrosecond() => new Vector3(x * 2.236936292E-06f, y * 2.236936292E-06f, z * 2.236936292E-06f);
    public static Accel3 MilesPerHoursPerMicrosecond(float x, float y, float z) => new Accel3(x * 447040f, y * 447040f, z * 447040f);
    public static Accel3 MilesPerHoursPerMicrosecond(Vector3 v) => new Accel3(v.x * 447040f, v.y * 447040f, v.z * 447040f);

    public Vector3 ToMilesPerHoursPerMillisecond() => new Vector3(x * 0.002236936292f, y * 0.002236936292f, z * 0.002236936292f);
    public static Accel3 MilesPerHoursPerMillisecond(float x, float y, float z) => new Accel3(x * 447.04f, y * 447.04f, z * 447.04f);
    public static Accel3 MilesPerHoursPerMillisecond(Vector3 v) => new Accel3(v.x * 447.04f, v.y * 447.04f, v.z * 447.04f);

    public Vector3 ToMilesPerHoursPerSecond() => new Vector3(x * 2.236936292f, y * 2.236936292f, z * 2.236936292f);
    public static Accel3 MilesPerHoursPerSecond(float x, float y, float z) => new Accel3(x * 0.44704f, y * 0.44704f, z * 0.44704f);
    public static Accel3 MilesPerHoursPerSecond(Vector3 v) => new Accel3(v.x * 0.44704f, v.y * 0.44704f, v.z * 0.44704f);

    public Vector3 ToMilesPerHoursPerMinute() => new Vector3(x * 134.2161775f, y * 134.2161775f, z * 134.2161775f);
    public static Accel3 MilesPerHoursPerMinute(float x, float y, float z) => new Accel3(x * 0.007450666667f, y * 0.007450666667f, z * 0.007450666667f);
    public static Accel3 MilesPerHoursPerMinute(Vector3 v) => new Accel3(v.x * 0.007450666667f, v.y * 0.007450666667f, v.z * 0.007450666667f);

    public Vector3 ToMilesPerHour2() => new Vector3(x * 8052.970651f, y * 8052.970651f, z * 8052.970651f);
    public static Accel3 MilesPerHour2(float x, float y, float z) => new Accel3(x * 0.0001241777778f, y * 0.0001241777778f, z * 0.0001241777778f);
    public static Accel3 MilesPerHour2(Vector3 v) => new Accel3(v.x * 0.0001241777778f, v.y * 0.0001241777778f, v.z * 0.0001241777778f);

    public Vector3 ToMillimetersPerMicrosecond2() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 MillimetersPerMicrosecond2(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 MillimetersPerMicrosecond2(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMillimetersPerMicrosecondsPerMillisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MillimetersPerMicrosecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MillimetersPerMicrosecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMillimetersPerMicrosecondsPerSecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MillimetersPerMicrosecondsPerSecond(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MillimetersPerMicrosecondsPerSecond(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillimetersPerMicrosecondsPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static Accel3 MillimetersPerMicrosecondsPerMinute(float x, float y, float z) => new Accel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static Accel3 MillimetersPerMicrosecondsPerMinute(Vector3 v) => new Accel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToMillimetersPerMicrosecondsPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static Accel3 MillimetersPerMicrosecondsPerHour(float x, float y, float z) => new Accel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static Accel3 MillimetersPerMicrosecondsPerHour(Vector3 v) => new Accel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMillimetersPerMillisecondsPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MillimetersPerMillisecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MillimetersPerMillisecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMillimetersPerMillisecond2() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MillimetersPerMillisecond2(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MillimetersPerMillisecond2(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillimetersPerMillisecondsPerSecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MillimetersPerMillisecondsPerSecond(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MillimetersPerMillisecondsPerSecond(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillimetersPerMillisecondsPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static Accel3 MillimetersPerMillisecondsPerMinute(float x, float y, float z) => new Accel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static Accel3 MillimetersPerMillisecondsPerMinute(Vector3 v) => new Accel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMillimetersPerMillisecondsPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static Accel3 MillimetersPerMillisecondsPerHour(float x, float y, float z) => new Accel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static Accel3 MillimetersPerMillisecondsPerHour(Vector3 v) => new Accel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMillimetersPerSecondsPerMicrosecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MillimetersPerSecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MillimetersPerSecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillimetersPerSecondsPerMillisecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MillimetersPerSecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MillimetersPerSecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillimetersPerSecond2() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MillimetersPerSecond2(float x, float y, float z) => new Accel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MillimetersPerSecond2(Vector3 v) => new Accel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillimetersPerSecondsPerMinute() => new Vector3(x * 60000f, y * 60000f, z * 60000f);
    public static Accel3 MillimetersPerSecondsPerMinute(float x, float y, float z) => new Accel3(x * 1.666666667E-05f, y * 1.666666667E-05f, z * 1.666666667E-05f);
    public static Accel3 MillimetersPerSecondsPerMinute(Vector3 v) => new Accel3(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f, v.z * 1.666666667E-05f);

    public Vector3 ToMillimetersPerSecondsPerHour() => new Vector3(x * 3600000f, y * 3600000f, z * 3600000f);
    public static Accel3 MillimetersPerSecondsPerHour(float x, float y, float z) => new Accel3(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static Accel3 MillimetersPerSecondsPerHour(Vector3 v) => new Accel3(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToMillimetersPerMinutesPerMicrosecond() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static Accel3 MillimetersPerMinutesPerMicrosecond(float x, float y, float z) => new Accel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static Accel3 MillimetersPerMinutesPerMicrosecond(Vector3 v) => new Accel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToMillimetersPerMinutesPerMillisecond() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static Accel3 MillimetersPerMinutesPerMillisecond(float x, float y, float z) => new Accel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static Accel3 MillimetersPerMinutesPerMillisecond(Vector3 v) => new Accel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMillimetersPerMinutesPerSecond() => new Vector3(x * 60000f, y * 60000f, z * 60000f);
    public static Accel3 MillimetersPerMinutesPerSecond(float x, float y, float z) => new Accel3(x * 1.666666667E-05f, y * 1.666666667E-05f, z * 1.666666667E-05f);
    public static Accel3 MillimetersPerMinutesPerSecond(Vector3 v) => new Accel3(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f, v.z * 1.666666667E-05f);

    public Vector3 ToMillimetersPerMinute2() => new Vector3(x * 3600000f, y * 3600000f, z * 3600000f);
    public static Accel3 MillimetersPerMinute2(float x, float y, float z) => new Accel3(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static Accel3 MillimetersPerMinute2(Vector3 v) => new Accel3(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToMillimetersPerMinutesPerHour() => new Vector3(x * 216000000f, y * 216000000f, z * 216000000f);
    public static Accel3 MillimetersPerMinutesPerHour(float x, float y, float z) => new Accel3(x * 4.62962963E-09f, y * 4.62962963E-09f, z * 4.62962963E-09f);
    public static Accel3 MillimetersPerMinutesPerHour(Vector3 v) => new Accel3(v.x * 4.62962963E-09f, v.y * 4.62962963E-09f, v.z * 4.62962963E-09f);

    public Vector3 ToMillimetersPerHoursPerMicrosecond() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static Accel3 MillimetersPerHoursPerMicrosecond(float x, float y, float z) => new Accel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static Accel3 MillimetersPerHoursPerMicrosecond(Vector3 v) => new Accel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMillimetersPerHoursPerMillisecond() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static Accel3 MillimetersPerHoursPerMillisecond(float x, float y, float z) => new Accel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static Accel3 MillimetersPerHoursPerMillisecond(Vector3 v) => new Accel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMillimetersPerHoursPerSecond() => new Vector3(x * 3600000f, y * 3600000f, z * 3600000f);
    public static Accel3 MillimetersPerHoursPerSecond(float x, float y, float z) => new Accel3(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static Accel3 MillimetersPerHoursPerSecond(Vector3 v) => new Accel3(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToMillimetersPerHoursPerMinute() => new Vector3(x * 216000000f, y * 216000000f, z * 216000000f);
    public static Accel3 MillimetersPerHoursPerMinute(float x, float y, float z) => new Accel3(x * 4.62962963E-09f, y * 4.62962963E-09f, z * 4.62962963E-09f);
    public static Accel3 MillimetersPerHoursPerMinute(Vector3 v) => new Accel3(v.x * 4.62962963E-09f, v.y * 4.62962963E-09f, v.z * 4.62962963E-09f);

    public Vector3 ToMillimetersPerHour2() => new Vector3(x * 1.296E+10f, y * 1.296E+10f, z * 1.296E+10f);
    public static Accel3 MillimetersPerHour2(float x, float y, float z) => new Accel3(x * 7.716049383E-11f, y * 7.716049383E-11f, z * 7.716049383E-11f);
    public static Accel3 MillimetersPerHour2(Vector3 v) => new Accel3(v.x * 7.716049383E-11f, v.y * 7.716049383E-11f, v.z * 7.716049383E-11f);

    public Vector3 ToCentimetersPerMicrosecond2() => new Vector3(x * 1E-10f, y * 1E-10f, z * 1E-10f);
    public static Accel3 CentimetersPerMicrosecond2(float x, float y, float z) => new Accel3(x * 1E+10f, y * 1E+10f, z * 1E+10f);
    public static Accel3 CentimetersPerMicrosecond2(Vector3 v) => new Accel3(v.x * 1E+10f, v.y * 1E+10f, v.z * 1E+10f);

    public Vector3 ToCentimetersPerMicrosecondsPerMillisecond() => new Vector3(x * 1E-07f, y * 1E-07f, z * 1E-07f);
    public static Accel3 CentimetersPerMicrosecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 10000000f, y * 10000000f, z * 10000000f);
    public static Accel3 CentimetersPerMicrosecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 10000000f, v.y * 10000000f, v.z * 10000000f);

    public Vector3 ToCentimetersPerMicrosecondsPerSecond() => new Vector3(x * 0.0001f, y * 0.0001f, z * 0.0001f);
    public static Accel3 CentimetersPerMicrosecondsPerSecond(float x, float y, float z) => new Accel3(x * 10000f, y * 10000f, z * 10000f);
    public static Accel3 CentimetersPerMicrosecondsPerSecond(Vector3 v) => new Accel3(v.x * 10000f, v.y * 10000f, v.z * 10000f);

    public Vector3 ToCentimetersPerMicrosecondsPerMinute() => new Vector3(x * 0.006f, y * 0.006f, z * 0.006f);
    public static Accel3 CentimetersPerMicrosecondsPerMinute(float x, float y, float z) => new Accel3(x * 166.6666667f, y * 166.6666667f, z * 166.6666667f);
    public static Accel3 CentimetersPerMicrosecondsPerMinute(Vector3 v) => new Accel3(v.x * 166.6666667f, v.y * 166.6666667f, v.z * 166.6666667f);

    public Vector3 ToCentimetersPerMicrosecondsPerHour() => new Vector3(x * 0.36f, y * 0.36f, z * 0.36f);
    public static Accel3 CentimetersPerMicrosecondsPerHour(float x, float y, float z) => new Accel3(x * 2.777777778f, y * 2.777777778f, z * 2.777777778f);
    public static Accel3 CentimetersPerMicrosecondsPerHour(Vector3 v) => new Accel3(v.x * 2.777777778f, v.y * 2.777777778f, v.z * 2.777777778f);

    public Vector3 ToCentimetersPerMillisecondsPerMicrosecond() => new Vector3(x * 1E-07f, y * 1E-07f, z * 1E-07f);
    public static Accel3 CentimetersPerMillisecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 10000000f, y * 10000000f, z * 10000000f);
    public static Accel3 CentimetersPerMillisecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 10000000f, v.y * 10000000f, v.z * 10000000f);

    public Vector3 ToCentimetersPerMillisecond2() => new Vector3(x * 0.0001f, y * 0.0001f, z * 0.0001f);
    public static Accel3 CentimetersPerMillisecond2(float x, float y, float z) => new Accel3(x * 10000f, y * 10000f, z * 10000f);
    public static Accel3 CentimetersPerMillisecond2(Vector3 v) => new Accel3(v.x * 10000f, v.y * 10000f, v.z * 10000f);

    public Vector3 ToCentimetersPerMillisecondsPerSecond() => new Vector3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static Accel3 CentimetersPerMillisecondsPerSecond(float x, float y, float z) => new Accel3(x * 10f, y * 10f, z * 10f);
    public static Accel3 CentimetersPerMillisecondsPerSecond(Vector3 v) => new Accel3(v.x * 10f, v.y * 10f, v.z * 10f);

    public Vector3 ToCentimetersPerMillisecondsPerMinute() => new Vector3(x * 6f, y * 6f, z * 6f);
    public static Accel3 CentimetersPerMillisecondsPerMinute(float x, float y, float z) => new Accel3(x * 0.1666666667f, y * 0.1666666667f, z * 0.1666666667f);
    public static Accel3 CentimetersPerMillisecondsPerMinute(Vector3 v) => new Accel3(v.x * 0.1666666667f, v.y * 0.1666666667f, v.z * 0.1666666667f);

    public Vector3 ToCentimetersPerMillisecondsPerHour() => new Vector3(x * 360f, y * 360f, z * 360f);
    public static Accel3 CentimetersPerMillisecondsPerHour(float x, float y, float z) => new Accel3(x * 0.002777777778f, y * 0.002777777778f, z * 0.002777777778f);
    public static Accel3 CentimetersPerMillisecondsPerHour(Vector3 v) => new Accel3(v.x * 0.002777777778f, v.y * 0.002777777778f, v.z * 0.002777777778f);

    public Vector3 ToCentimetersPerSecondsPerMicrosecond() => new Vector3(x * 0.0001f, y * 0.0001f, z * 0.0001f);
    public static Accel3 CentimetersPerSecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 10000f, y * 10000f, z * 10000f);
    public static Accel3 CentimetersPerSecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 10000f, v.y * 10000f, v.z * 10000f);

    public Vector3 ToCentimetersPerSecondsPerMillisecond() => new Vector3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static Accel3 CentimetersPerSecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 10f, y * 10f, z * 10f);
    public static Accel3 CentimetersPerSecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 10f, v.y * 10f, v.z * 10f);

    public Vector3 ToCentimetersPerSecond2() => new Vector3(x * 100f, y * 100f, z * 100f);
    public static Accel3 CentimetersPerSecond2(float x, float y, float z) => new Accel3(x * 0.01f, y * 0.01f, z * 0.01f);
    public static Accel3 CentimetersPerSecond2(Vector3 v) => new Accel3(v.x * 0.01f, v.y * 0.01f, v.z * 0.01f);

    public Vector3 ToCentimetersPerSecondsPerMinute() => new Vector3(x * 6000f, y * 6000f, z * 6000f);
    public static Accel3 CentimetersPerSecondsPerMinute(float x, float y, float z) => new Accel3(x * 0.0001666666667f, y * 0.0001666666667f, z * 0.0001666666667f);
    public static Accel3 CentimetersPerSecondsPerMinute(Vector3 v) => new Accel3(v.x * 0.0001666666667f, v.y * 0.0001666666667f, v.z * 0.0001666666667f);

    public Vector3 ToCentimetersPerSecondsPerHour() => new Vector3(x * 360000f, y * 360000f, z * 360000f);
    public static Accel3 CentimetersPerSecondsPerHour(float x, float y, float z) => new Accel3(x * 2.777777778E-06f, y * 2.777777778E-06f, z * 2.777777778E-06f);
    public static Accel3 CentimetersPerSecondsPerHour(Vector3 v) => new Accel3(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f, v.z * 2.777777778E-06f);

    public Vector3 ToCentimetersPerMinutesPerMicrosecond() => new Vector3(x * 0.006f, y * 0.006f, z * 0.006f);
    public static Accel3 CentimetersPerMinutesPerMicrosecond(float x, float y, float z) => new Accel3(x * 166.6666667f, y * 166.6666667f, z * 166.6666667f);
    public static Accel3 CentimetersPerMinutesPerMicrosecond(Vector3 v) => new Accel3(v.x * 166.6666667f, v.y * 166.6666667f, v.z * 166.6666667f);

    public Vector3 ToCentimetersPerMinutesPerMillisecond() => new Vector3(x * 6f, y * 6f, z * 6f);
    public static Accel3 CentimetersPerMinutesPerMillisecond(float x, float y, float z) => new Accel3(x * 0.1666666667f, y * 0.1666666667f, z * 0.1666666667f);
    public static Accel3 CentimetersPerMinutesPerMillisecond(Vector3 v) => new Accel3(v.x * 0.1666666667f, v.y * 0.1666666667f, v.z * 0.1666666667f);

    public Vector3 ToCentimetersPerMinutesPerSecond() => new Vector3(x * 6000f, y * 6000f, z * 6000f);
    public static Accel3 CentimetersPerMinutesPerSecond(float x, float y, float z) => new Accel3(x * 0.0001666666667f, y * 0.0001666666667f, z * 0.0001666666667f);
    public static Accel3 CentimetersPerMinutesPerSecond(Vector3 v) => new Accel3(v.x * 0.0001666666667f, v.y * 0.0001666666667f, v.z * 0.0001666666667f);

    public Vector3 ToCentimetersPerMinute2() => new Vector3(x * 360000f, y * 360000f, z * 360000f);
    public static Accel3 CentimetersPerMinute2(float x, float y, float z) => new Accel3(x * 2.777777778E-06f, y * 2.777777778E-06f, z * 2.777777778E-06f);
    public static Accel3 CentimetersPerMinute2(Vector3 v) => new Accel3(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f, v.z * 2.777777778E-06f);

    public Vector3 ToCentimetersPerMinutesPerHour() => new Vector3(x * 21600000f, y * 21600000f, z * 21600000f);
    public static Accel3 CentimetersPerMinutesPerHour(float x, float y, float z) => new Accel3(x * 4.62962963E-08f, y * 4.62962963E-08f, z * 4.62962963E-08f);
    public static Accel3 CentimetersPerMinutesPerHour(Vector3 v) => new Accel3(v.x * 4.62962963E-08f, v.y * 4.62962963E-08f, v.z * 4.62962963E-08f);

    public Vector3 ToCentimetersPerHoursPerMicrosecond() => new Vector3(x * 0.36f, y * 0.36f, z * 0.36f);
    public static Accel3 CentimetersPerHoursPerMicrosecond(float x, float y, float z) => new Accel3(x * 2.777777778f, y * 2.777777778f, z * 2.777777778f);
    public static Accel3 CentimetersPerHoursPerMicrosecond(Vector3 v) => new Accel3(v.x * 2.777777778f, v.y * 2.777777778f, v.z * 2.777777778f);

    public Vector3 ToCentimetersPerHoursPerMillisecond() => new Vector3(x * 360f, y * 360f, z * 360f);
    public static Accel3 CentimetersPerHoursPerMillisecond(float x, float y, float z) => new Accel3(x * 0.002777777778f, y * 0.002777777778f, z * 0.002777777778f);
    public static Accel3 CentimetersPerHoursPerMillisecond(Vector3 v) => new Accel3(v.x * 0.002777777778f, v.y * 0.002777777778f, v.z * 0.002777777778f);

    public Vector3 ToCentimetersPerHoursPerSecond() => new Vector3(x * 360000f, y * 360000f, z * 360000f);
    public static Accel3 CentimetersPerHoursPerSecond(float x, float y, float z) => new Accel3(x * 2.777777778E-06f, y * 2.777777778E-06f, z * 2.777777778E-06f);
    public static Accel3 CentimetersPerHoursPerSecond(Vector3 v) => new Accel3(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f, v.z * 2.777777778E-06f);

    public Vector3 ToCentimetersPerHoursPerMinute() => new Vector3(x * 21600000f, y * 21600000f, z * 21600000f);
    public static Accel3 CentimetersPerHoursPerMinute(float x, float y, float z) => new Accel3(x * 4.62962963E-08f, y * 4.62962963E-08f, z * 4.62962963E-08f);
    public static Accel3 CentimetersPerHoursPerMinute(Vector3 v) => new Accel3(v.x * 4.62962963E-08f, v.y * 4.62962963E-08f, v.z * 4.62962963E-08f);

    public Vector3 ToCentimetersPerHour2() => new Vector3(x * 1296000000f, y * 1296000000f, z * 1296000000f);
    public static Accel3 CentimetersPerHour2(float x, float y, float z) => new Accel3(x * 7.716049383E-10f, y * 7.716049383E-10f, z * 7.716049383E-10f);
    public static Accel3 CentimetersPerHour2(Vector3 v) => new Accel3(v.x * 7.716049383E-10f, v.y * 7.716049383E-10f, v.z * 7.716049383E-10f);

    public Vector3 ToMetersPerMicrosecond2() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Accel3 MetersPerMicrosecond2(float x, float y, float z) => new Accel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Accel3 MetersPerMicrosecond2(Vector3 v) => new Accel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMetersPerMicrosecondsPerMillisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 MetersPerMicrosecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 MetersPerMicrosecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMetersPerMicrosecondsPerSecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MetersPerMicrosecondsPerSecond(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MetersPerMicrosecondsPerSecond(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMetersPerMicrosecondsPerMinute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static Accel3 MetersPerMicrosecondsPerMinute(float x, float y, float z) => new Accel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static Accel3 MetersPerMicrosecondsPerMinute(Vector3 v) => new Accel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMetersPerMicrosecondsPerHour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static Accel3 MetersPerMicrosecondsPerHour(float x, float y, float z) => new Accel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static Accel3 MetersPerMicrosecondsPerHour(Vector3 v) => new Accel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToMetersPerMillisecondsPerMicrosecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 MetersPerMillisecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 MetersPerMillisecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMetersPerMillisecond2() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MetersPerMillisecond2(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MetersPerMillisecond2(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMetersPerMillisecondsPerSecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MetersPerMillisecondsPerSecond(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MetersPerMillisecondsPerSecond(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMetersPerMillisecondsPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static Accel3 MetersPerMillisecondsPerMinute(float x, float y, float z) => new Accel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static Accel3 MetersPerMillisecondsPerMinute(Vector3 v) => new Accel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToMetersPerMillisecondsPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static Accel3 MetersPerMillisecondsPerHour(float x, float y, float z) => new Accel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static Accel3 MetersPerMillisecondsPerHour(Vector3 v) => new Accel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMetersPerSecondsPerMicrosecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MetersPerSecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MetersPerSecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMetersPerSecondsPerMillisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MetersPerSecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MetersPerSecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMetersPerSecond2() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MetersPerSecond2(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MetersPerSecond2(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMetersPerSecondsPerMinute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static Accel3 MetersPerSecondsPerMinute(float x, float y, float z) => new Accel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static Accel3 MetersPerSecondsPerMinute(Vector3 v) => new Accel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMetersPerSecondsPerHour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static Accel3 MetersPerSecondsPerHour(float x, float y, float z) => new Accel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static Accel3 MetersPerSecondsPerHour(Vector3 v) => new Accel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMetersPerMinutesPerMicrosecond() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static Accel3 MetersPerMinutesPerMicrosecond(float x, float y, float z) => new Accel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static Accel3 MetersPerMinutesPerMicrosecond(Vector3 v) => new Accel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMetersPerMinutesPerMillisecond() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static Accel3 MetersPerMinutesPerMillisecond(float x, float y, float z) => new Accel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static Accel3 MetersPerMinutesPerMillisecond(Vector3 v) => new Accel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToMetersPerMinutesPerSecond() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static Accel3 MetersPerMinutesPerSecond(float x, float y, float z) => new Accel3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static Accel3 MetersPerMinutesPerSecond(Vector3 v) => new Accel3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMetersPerMinute2() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static Accel3 MetersPerMinute2(float x, float y, float z) => new Accel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static Accel3 MetersPerMinute2(Vector3 v) => new Accel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMetersPerMinutesPerHour() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static Accel3 MetersPerMinutesPerHour(float x, float y, float z) => new Accel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static Accel3 MetersPerMinutesPerHour(Vector3 v) => new Accel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToMetersPerHoursPerMicrosecond() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static Accel3 MetersPerHoursPerMicrosecond(float x, float y, float z) => new Accel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static Accel3 MetersPerHoursPerMicrosecond(Vector3 v) => new Accel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToMetersPerHoursPerMillisecond() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static Accel3 MetersPerHoursPerMillisecond(float x, float y, float z) => new Accel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static Accel3 MetersPerHoursPerMillisecond(Vector3 v) => new Accel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMetersPerHoursPerSecond() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static Accel3 MetersPerHoursPerSecond(float x, float y, float z) => new Accel3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static Accel3 MetersPerHoursPerSecond(Vector3 v) => new Accel3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToMetersPerHoursPerMinute() => new Vector3(x * 216000f, y * 216000f, z * 216000f);
    public static Accel3 MetersPerHoursPerMinute(float x, float y, float z) => new Accel3(x * 4.62962963E-06f, y * 4.62962963E-06f, z * 4.62962963E-06f);
    public static Accel3 MetersPerHoursPerMinute(Vector3 v) => new Accel3(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f, v.z * 4.62962963E-06f);

    public Vector3 ToMetersPerHour2() => new Vector3(x * 12960000f, y * 12960000f, z * 12960000f);
    public static Accel3 MetersPerHour2(float x, float y, float z) => new Accel3(x * 7.716049383E-08f, y * 7.716049383E-08f, z * 7.716049383E-08f);
    public static Accel3 MetersPerHour2(Vector3 v) => new Accel3(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f, v.z * 7.716049383E-08f);

    public Vector3 ToKilometersPerMicrosecond2() => new Vector3(x * 1E-15f, y * 1E-15f, z * 1E-15f);
    public static Accel3 KilometersPerMicrosecond2(float x, float y, float z) => new Accel3(x * 1E+15f, y * 1E+15f, z * 1E+15f);
    public static Accel3 KilometersPerMicrosecond2(Vector3 v) => new Accel3(v.x * 1E+15f, v.y * 1E+15f, v.z * 1E+15f);

    public Vector3 ToKilometersPerMicrosecondsPerMillisecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Accel3 KilometersPerMicrosecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Accel3 KilometersPerMicrosecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToKilometersPerMicrosecondsPerSecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 KilometersPerMicrosecondsPerSecond(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 KilometersPerMicrosecondsPerSecond(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilometersPerMicrosecondsPerMinute() => new Vector3(x * 6E-08f, y * 6E-08f, z * 6E-08f);
    public static Accel3 KilometersPerMicrosecondsPerMinute(float x, float y, float z) => new Accel3(x * 16666666.67f, y * 16666666.67f, z * 16666666.67f);
    public static Accel3 KilometersPerMicrosecondsPerMinute(Vector3 v) => new Accel3(v.x * 16666666.67f, v.y * 16666666.67f, v.z * 16666666.67f);

    public Vector3 ToKilometersPerMicrosecondsPerHour() => new Vector3(x * 3.6E-06f, y * 3.6E-06f, z * 3.6E-06f);
    public static Accel3 KilometersPerMicrosecondsPerHour(float x, float y, float z) => new Accel3(x * 277777.7778f, y * 277777.7778f, z * 277777.7778f);
    public static Accel3 KilometersPerMicrosecondsPerHour(Vector3 v) => new Accel3(v.x * 277777.7778f, v.y * 277777.7778f, v.z * 277777.7778f);

    public Vector3 ToKilometersPerMillisecondsPerMicrosecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Accel3 KilometersPerMillisecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Accel3 KilometersPerMillisecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToKilometersPerMillisecond2() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 KilometersPerMillisecond2(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 KilometersPerMillisecond2(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilometersPerMillisecondsPerSecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 KilometersPerMillisecondsPerSecond(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 KilometersPerMillisecondsPerSecond(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilometersPerMillisecondsPerMinute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static Accel3 KilometersPerMillisecondsPerMinute(float x, float y, float z) => new Accel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static Accel3 KilometersPerMillisecondsPerMinute(Vector3 v) => new Accel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToKilometersPerMillisecondsPerHour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static Accel3 KilometersPerMillisecondsPerHour(float x, float y, float z) => new Accel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static Accel3 KilometersPerMillisecondsPerHour(Vector3 v) => new Accel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToKilometersPerSecondsPerMicrosecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 KilometersPerSecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 KilometersPerSecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilometersPerSecondsPerMillisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 KilometersPerSecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 KilometersPerSecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilometersPerSecond2() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 KilometersPerSecond2(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 KilometersPerSecond2(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilometersPerSecondsPerMinute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static Accel3 KilometersPerSecondsPerMinute(float x, float y, float z) => new Accel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static Accel3 KilometersPerSecondsPerMinute(Vector3 v) => new Accel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToKilometersPerSecondsPerHour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static Accel3 KilometersPerSecondsPerHour(float x, float y, float z) => new Accel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static Accel3 KilometersPerSecondsPerHour(Vector3 v) => new Accel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToKilometersPerMinutesPerMicrosecond() => new Vector3(x * 6E-08f, y * 6E-08f, z * 6E-08f);
    public static Accel3 KilometersPerMinutesPerMicrosecond(float x, float y, float z) => new Accel3(x * 16666666.67f, y * 16666666.67f, z * 16666666.67f);
    public static Accel3 KilometersPerMinutesPerMicrosecond(Vector3 v) => new Accel3(v.x * 16666666.67f, v.y * 16666666.67f, v.z * 16666666.67f);

    public Vector3 ToKilometersPerMinutesPerMillisecond() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static Accel3 KilometersPerMinutesPerMillisecond(float x, float y, float z) => new Accel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static Accel3 KilometersPerMinutesPerMillisecond(Vector3 v) => new Accel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToKilometersPerMinutesPerSecond() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static Accel3 KilometersPerMinutesPerSecond(float x, float y, float z) => new Accel3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static Accel3 KilometersPerMinutesPerSecond(Vector3 v) => new Accel3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToKilometersPerMinute2() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static Accel3 KilometersPerMinute2(float x, float y, float z) => new Accel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static Accel3 KilometersPerMinute2(Vector3 v) => new Accel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToKilometersPerMinutesPerHour() => new Vector3(x * 216f, y * 216f, z * 216f);
    public static Accel3 KilometersPerMinutesPerHour(float x, float y, float z) => new Accel3(x * 0.00462962963f, y * 0.00462962963f, z * 0.00462962963f);
    public static Accel3 KilometersPerMinutesPerHour(Vector3 v) => new Accel3(v.x * 0.00462962963f, v.y * 0.00462962963f, v.z * 0.00462962963f);

    public Vector3 ToKilometersPerHoursPerMicrosecond() => new Vector3(x * 3.6E-06f, y * 3.6E-06f, z * 3.6E-06f);
    public static Accel3 KilometersPerHoursPerMicrosecond(float x, float y, float z) => new Accel3(x * 277777.7778f, y * 277777.7778f, z * 277777.7778f);
    public static Accel3 KilometersPerHoursPerMicrosecond(Vector3 v) => new Accel3(v.x * 277777.7778f, v.y * 277777.7778f, v.z * 277777.7778f);

    public Vector3 ToKilometersPerHoursPerMillisecond() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static Accel3 KilometersPerHoursPerMillisecond(float x, float y, float z) => new Accel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static Accel3 KilometersPerHoursPerMillisecond(Vector3 v) => new Accel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToKilometersPerHoursPerSecond() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static Accel3 KilometersPerHoursPerSecond(float x, float y, float z) => new Accel3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static Accel3 KilometersPerHoursPerSecond(Vector3 v) => new Accel3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToKilometersPerHoursPerMinute() => new Vector3(x * 216f, y * 216f, z * 216f);
    public static Accel3 KilometersPerHoursPerMinute(float x, float y, float z) => new Accel3(x * 0.00462962963f, y * 0.00462962963f, z * 0.00462962963f);
    public static Accel3 KilometersPerHoursPerMinute(Vector3 v) => new Accel3(v.x * 0.00462962963f, v.y * 0.00462962963f, v.z * 0.00462962963f);

    public Vector3 ToKilometersPerHour2() => new Vector3(x * 12960f, y * 12960f, z * 12960f);
    public static Accel3 KilometersPerHour2(float x, float y, float z) => new Accel3(x * 7.716049383E-05f, y * 7.716049383E-05f, z * 7.716049383E-05f);
    public static Accel3 KilometersPerHour2(Vector3 v) => new Accel3(v.x * 7.716049383E-05f, v.y * 7.716049383E-05f, v.z * 7.716049383E-05f);

    public Vector3 ToMegametersPerMicrosecond2() => new Vector3(x * 1E-18f, y * 1E-18f, z * 1E-18f);
    public static Accel3 MegametersPerMicrosecond2(float x, float y, float z) => new Accel3(x * 1E+18f, y * 1E+18f, z * 1E+18f);
    public static Accel3 MegametersPerMicrosecond2(Vector3 v) => new Accel3(v.x * 1E+18f, v.y * 1E+18f, v.z * 1E+18f);

    public Vector3 ToMegametersPerMicrosecondsPerMillisecond() => new Vector3(x * 1E-15f, y * 1E-15f, z * 1E-15f);
    public static Accel3 MegametersPerMicrosecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1E+15f, y * 1E+15f, z * 1E+15f);
    public static Accel3 MegametersPerMicrosecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1E+15f, v.y * 1E+15f, v.z * 1E+15f);

    public Vector3 ToMegametersPerMicrosecondsPerSecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Accel3 MegametersPerMicrosecondsPerSecond(float x, float y, float z) => new Accel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Accel3 MegametersPerMicrosecondsPerSecond(Vector3 v) => new Accel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMegametersPerMicrosecondsPerMinute() => new Vector3(x * 6E-11f, y * 6E-11f, z * 6E-11f);
    public static Accel3 MegametersPerMicrosecondsPerMinute(float x, float y, float z) => new Accel3(x * 1.666666667E+10f, y * 1.666666667E+10f, z * 1.666666667E+10f);
    public static Accel3 MegametersPerMicrosecondsPerMinute(Vector3 v) => new Accel3(v.x * 1.666666667E+10f, v.y * 1.666666667E+10f, v.z * 1.666666667E+10f);

    public Vector3 ToMegametersPerMicrosecondsPerHour() => new Vector3(x * 3.6E-09f, y * 3.6E-09f, z * 3.6E-09f);
    public static Accel3 MegametersPerMicrosecondsPerHour(float x, float y, float z) => new Accel3(x * 277777777.8f, y * 277777777.8f, z * 277777777.8f);
    public static Accel3 MegametersPerMicrosecondsPerHour(Vector3 v) => new Accel3(v.x * 277777777.8f, v.y * 277777777.8f, v.z * 277777777.8f);

    public Vector3 ToMegametersPerMillisecondsPerMicrosecond() => new Vector3(x * 1E-15f, y * 1E-15f, z * 1E-15f);
    public static Accel3 MegametersPerMillisecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1E+15f, y * 1E+15f, z * 1E+15f);
    public static Accel3 MegametersPerMillisecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1E+15f, v.y * 1E+15f, v.z * 1E+15f);

    public Vector3 ToMegametersPerMillisecond2() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Accel3 MegametersPerMillisecond2(float x, float y, float z) => new Accel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Accel3 MegametersPerMillisecond2(Vector3 v) => new Accel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMegametersPerMillisecondsPerSecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 MegametersPerMillisecondsPerSecond(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 MegametersPerMillisecondsPerSecond(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMegametersPerMillisecondsPerMinute() => new Vector3(x * 6E-08f, y * 6E-08f, z * 6E-08f);
    public static Accel3 MegametersPerMillisecondsPerMinute(float x, float y, float z) => new Accel3(x * 16666666.67f, y * 16666666.67f, z * 16666666.67f);
    public static Accel3 MegametersPerMillisecondsPerMinute(Vector3 v) => new Accel3(v.x * 16666666.67f, v.y * 16666666.67f, v.z * 16666666.67f);

    public Vector3 ToMegametersPerMillisecondsPerHour() => new Vector3(x * 3.6E-06f, y * 3.6E-06f, z * 3.6E-06f);
    public static Accel3 MegametersPerMillisecondsPerHour(float x, float y, float z) => new Accel3(x * 277777.7778f, y * 277777.7778f, z * 277777.7778f);
    public static Accel3 MegametersPerMillisecondsPerHour(Vector3 v) => new Accel3(v.x * 277777.7778f, v.y * 277777.7778f, v.z * 277777.7778f);

    public Vector3 ToMegametersPerSecondsPerMicrosecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Accel3 MegametersPerSecondsPerMicrosecond(float x, float y, float z) => new Accel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Accel3 MegametersPerSecondsPerMicrosecond(Vector3 v) => new Accel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMegametersPerSecondsPerMillisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 MegametersPerSecondsPerMillisecond(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 MegametersPerSecondsPerMillisecond(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMegametersPerSecond2() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MegametersPerSecond2(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MegametersPerSecond2(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMegametersPerSecondsPerMinute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static Accel3 MegametersPerSecondsPerMinute(float x, float y, float z) => new Accel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static Accel3 MegametersPerSecondsPerMinute(Vector3 v) => new Accel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMegametersPerSecondsPerHour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static Accel3 MegametersPerSecondsPerHour(float x, float y, float z) => new Accel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static Accel3 MegametersPerSecondsPerHour(Vector3 v) => new Accel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToMegametersPerMinutesPerMicrosecond() => new Vector3(x * 6E-11f, y * 6E-11f, z * 6E-11f);
    public static Accel3 MegametersPerMinutesPerMicrosecond(float x, float y, float z) => new Accel3(x * 1.666666667E+10f, y * 1.666666667E+10f, z * 1.666666667E+10f);
    public static Accel3 MegametersPerMinutesPerMicrosecond(Vector3 v) => new Accel3(v.x * 1.666666667E+10f, v.y * 1.666666667E+10f, v.z * 1.666666667E+10f);

    public Vector3 ToMegametersPerMinutesPerMillisecond() => new Vector3(x * 6E-08f, y * 6E-08f, z * 6E-08f);
    public static Accel3 MegametersPerMinutesPerMillisecond(float x, float y, float z) => new Accel3(x * 16666666.67f, y * 16666666.67f, z * 16666666.67f);
    public static Accel3 MegametersPerMinutesPerMillisecond(Vector3 v) => new Accel3(v.x * 16666666.67f, v.y * 16666666.67f, v.z * 16666666.67f);

    public Vector3 ToMegametersPerMinutesPerSecond() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static Accel3 MegametersPerMinutesPerSecond(float x, float y, float z) => new Accel3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static Accel3 MegametersPerMinutesPerSecond(Vector3 v) => new Accel3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMegametersPerMinute2() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static Accel3 MegametersPerMinute2(float x, float y, float z) => new Accel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static Accel3 MegametersPerMinute2(Vector3 v) => new Accel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToMegametersPerMinutesPerHour() => new Vector3(x * 0.216f, y * 0.216f, z * 0.216f);
    public static Accel3 MegametersPerMinutesPerHour(float x, float y, float z) => new Accel3(x * 4.62962963f, y * 4.62962963f, z * 4.62962963f);
    public static Accel3 MegametersPerMinutesPerHour(Vector3 v) => new Accel3(v.x * 4.62962963f, v.y * 4.62962963f, v.z * 4.62962963f);

    public Vector3 ToMegametersPerHoursPerMicrosecond() => new Vector3(x * 3.6E-09f, y * 3.6E-09f, z * 3.6E-09f);
    public static Accel3 MegametersPerHoursPerMicrosecond(float x, float y, float z) => new Accel3(x * 277777777.8f, y * 277777777.8f, z * 277777777.8f);
    public static Accel3 MegametersPerHoursPerMicrosecond(Vector3 v) => new Accel3(v.x * 277777777.8f, v.y * 277777777.8f, v.z * 277777777.8f);

    public Vector3 ToMegametersPerHoursPerMillisecond() => new Vector3(x * 3.6E-06f, y * 3.6E-06f, z * 3.6E-06f);
    public static Accel3 MegametersPerHoursPerMillisecond(float x, float y, float z) => new Accel3(x * 277777.7778f, y * 277777.7778f, z * 277777.7778f);
    public static Accel3 MegametersPerHoursPerMillisecond(Vector3 v) => new Accel3(v.x * 277777.7778f, v.y * 277777.7778f, v.z * 277777.7778f);

    public Vector3 ToMegametersPerHoursPerSecond() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static Accel3 MegametersPerHoursPerSecond(float x, float y, float z) => new Accel3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static Accel3 MegametersPerHoursPerSecond(Vector3 v) => new Accel3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public Vector3 ToMegametersPerHoursPerMinute() => new Vector3(x * 0.216f, y * 0.216f, z * 0.216f);
    public static Accel3 MegametersPerHoursPerMinute(float x, float y, float z) => new Accel3(x * 4.62962963f, y * 4.62962963f, z * 4.62962963f);
    public static Accel3 MegametersPerHoursPerMinute(Vector3 v) => new Accel3(v.x * 4.62962963f, v.y * 4.62962963f, v.z * 4.62962963f);

    public Vector3 ToMegametersPerHour2() => new Vector3(x * 12.96f, y * 12.96f, z * 12.96f);
    public static Accel3 MegametersPerHour2(float x, float y, float z) => new Accel3(x * 0.07716049383f, y * 0.07716049383f, z * 0.07716049383f);
    public static Accel3 MegametersPerHour2(Vector3 v) => new Accel3(v.x * 0.07716049383f, v.y * 0.07716049383f, v.z * 0.07716049383f);

    public Vector3 ToMillinewtonsPerMilligram() => new Vector3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 MillinewtonsPerMilligram(float x, float y, float z) => new Accel3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 MillinewtonsPerMilligram(Vector3 v) => new Accel3(v.x * 1E-09f, v.y * 1E-09f, v.z * 1E-09f);

    public Vector3 ToMillinewtonsPerGram() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MillinewtonsPerGram(float x, float y, float z) => new Accel3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MillinewtonsPerGram(Vector3 v) => new Accel3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToMillinewtonsPerKilogram() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MillinewtonsPerKilogram(float x, float y, float z) => new Accel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MillinewtonsPerKilogram(Vector3 v) => new Accel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillinewtonsPerTon() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MillinewtonsPerTon(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MillinewtonsPerTon(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtonsPerKiloton() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MillinewtonsPerKiloton(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MillinewtonsPerKiloton(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerMilligram() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 NewtonsPerMilligram(float x, float y, float z) => new Accel3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 NewtonsPerMilligram(Vector3 v) => new Accel3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToNewtonsPerGram() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 NewtonsPerGram(float x, float y, float z) => new Accel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 NewtonsPerGram(Vector3 v) => new Accel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToNewtonsPerKilogram() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 NewtonsPerKilogram(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 NewtonsPerKilogram(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToNewtonsPerTon() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 NewtonsPerTon(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 NewtonsPerTon(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerKiloton() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 NewtonsPerKiloton(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 NewtonsPerKiloton(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerMilligram() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 KilonewtonsPerMilligram(float x, float y, float z) => new Accel3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 KilonewtonsPerMilligram(Vector3 v) => new Accel3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToKilonewtonsPerGram() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 KilonewtonsPerGram(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 KilonewtonsPerGram(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToKilonewtonsPerKilogram() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 KilonewtonsPerKilogram(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 KilonewtonsPerKilogram(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilonewtonsPerTon() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 KilonewtonsPerTon(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 KilonewtonsPerTon(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerKiloton() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 KilonewtonsPerKiloton(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 KilonewtonsPerKiloton(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerMilligram() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MeganewtonsPerMilligram(float x, float y, float z) => new Accel3(x * 1f, y * 1f, z * 1f);
    public static Accel3 MeganewtonsPerMilligram(Vector3 v) => new Accel3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMeganewtonsPerGram() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Accel3 MeganewtonsPerGram(float x, float y, float z) => new Accel3(x * 1000f, y * 1000f, z * 1000f);
    public static Accel3 MeganewtonsPerGram(Vector3 v) => new Accel3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMeganewtonsPerKilogram() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Accel3 MeganewtonsPerKilogram(float x, float y, float z) => new Accel3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Accel3 MeganewtonsPerKilogram(Vector3 v) => new Accel3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeganewtonsPerTon() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Accel3 MeganewtonsPerTon(float x, float y, float z) => new Accel3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Accel3 MeganewtonsPerTon(Vector3 v) => new Accel3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerKiloton() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Accel3 MeganewtonsPerKiloton(float x, float y, float z) => new Accel3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Accel3 MeganewtonsPerKiloton(Vector3 v) => new Accel3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public static Accel3 operator +(Accel3 a, Accel3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static Accel3 operator -(Accel3 a, Accel3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    
    public static Accel3 operator *(Accel3 a, Accel3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static Accel3 operator /(Accel3 a, Accel3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    
    public Velocity3 Velocity3(Time v) => new(v * x, v * y, v * z);
    public Time Time(Velocity3 v) => new(v.magnitude / magnitude);

    public Accel3(Velocity3 a, Time b) => a.Accel3(b);
    public Accel3(Time b, Velocity3 a) => a.Accel3(b);

    public Force3 Force3(Mass v) => new(v * x, v * y, v * z);
    public Mass Mass(Force3 v) => new(v.magnitude / magnitude);

    public Accel3(Force3 a, Mass b) => a.Accel3(b);
    public Accel3(Mass b, Force3 a) => a.Accel3(b);

}
}

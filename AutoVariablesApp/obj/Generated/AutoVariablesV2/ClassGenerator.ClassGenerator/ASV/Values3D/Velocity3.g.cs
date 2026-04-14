using System;
using AutoVariablesApp;
namespace Generated.Units {
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
    
    public static implicit operator Vector3(Velocity3 v) => new Vector3(v.x, v.y, v.z);
    public Velocity magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToFeets_Microsecond() => new Vector3(x * 3.047999977E-07f, y * 3.047999977E-07f, z * 3.047999977E-07f);
    public static Velocity3 Feets_Microsecond(float x, float y, float z) => new Velocity3(x * 3280839.92f, y * 3280839.92f, z * 3280839.92f);
    public static Velocity3 Feets_Microsecond(Vector3 v) => new Velocity3(v.x * 3280839.92f, v.y * 3280839.92f, v.z * 3280839.92f);

    public Vector3 ToFeets_Millisecond() => new Vector3(x * 0.0003047999977f, y * 0.0003047999977f, z * 0.0003047999977f);
    public static Velocity3 Feets_Millisecond(float x, float y, float z) => new Velocity3(x * 3280.83992f, y * 3280.83992f, z * 3280.83992f);
    public static Velocity3 Feets_Millisecond(Vector3 v) => new Velocity3(v.x * 3280.83992f, v.y * 3280.83992f, v.z * 3280.83992f);

    public Vector3 ToFeets_Second() => new Vector3(x * 0.3047999977f, y * 0.3047999977f, z * 0.3047999977f);
    public static Velocity3 Feets_Second(float x, float y, float z) => new Velocity3(x * 3.28083992f, y * 3.28083992f, z * 3.28083992f);
    public static Velocity3 Feets_Second(Vector3 v) => new Velocity3(v.x * 3.28083992f, v.y * 3.28083992f, v.z * 3.28083992f);

    public Vector3 ToFeets_Minute() => new Vector3(x * 18.28799986f, y * 18.28799986f, z * 18.28799986f);
    public static Velocity3 Feets_Minute(float x, float y, float z) => new Velocity3(x * 0.05468066533f, y * 0.05468066533f, z * 0.05468066533f);
    public static Velocity3 Feets_Minute(Vector3 v) => new Velocity3(v.x * 0.05468066533f, v.y * 0.05468066533f, v.z * 0.05468066533f);

    public Vector3 ToFeets_Hour() => new Vector3(x * 1097.279992f, y * 1097.279992f, z * 1097.279992f);
    public static Velocity3 Feets_Hour(float x, float y, float z) => new Velocity3(x * 0.0009113444222f, y * 0.0009113444222f, z * 0.0009113444222f);
    public static Velocity3 Feets_Hour(Vector3 v) => new Velocity3(v.x * 0.0009113444222f, v.y * 0.0009113444222f, v.z * 0.0009113444222f);

    public Vector3 ToMiles_Microsecond() => new Vector3(x * 6.213711945E-10f, y * 6.213711945E-10f, z * 6.213711945E-10f);
    public static Velocity3 Miles_Microsecond(float x, float y, float z) => new Velocity3(x * 1609343994f, y * 1609343994f, z * 1609343994f);
    public static Velocity3 Miles_Microsecond(Vector3 v) => new Velocity3(v.x * 1609343994f, v.y * 1609343994f, v.z * 1609343994f);

    public Vector3 ToMiles_Millisecond() => new Vector3(x * 6.213711945E-07f, y * 6.213711945E-07f, z * 6.213711945E-07f);
    public static Velocity3 Miles_Millisecond(float x, float y, float z) => new Velocity3(x * 1609343.994f, y * 1609343.994f, z * 1609343.994f);
    public static Velocity3 Miles_Millisecond(Vector3 v) => new Velocity3(v.x * 1609343.994f, v.y * 1609343.994f, v.z * 1609343.994f);

    public Vector3 ToMiles_Second() => new Vector3(x * 0.0006213711945f, y * 0.0006213711945f, z * 0.0006213711945f);
    public static Velocity3 Miles_Second(float x, float y, float z) => new Velocity3(x * 1609.343994f, y * 1609.343994f, z * 1609.343994f);
    public static Velocity3 Miles_Second(Vector3 v) => new Velocity3(v.x * 1609.343994f, v.y * 1609.343994f, v.z * 1609.343994f);

    public Vector3 ToMiles_Minute() => new Vector3(x * 0.03728227167f, y * 0.03728227167f, z * 0.03728227167f);
    public static Velocity3 Miles_Minute(float x, float y, float z) => new Velocity3(x * 26.8223999f, y * 26.8223999f, z * 26.8223999f);
    public static Velocity3 Miles_Minute(Vector3 v) => new Velocity3(v.x * 26.8223999f, v.y * 26.8223999f, v.z * 26.8223999f);

    public Vector3 ToMiles_Hour() => new Vector3(x * 2.2369363f, y * 2.2369363f, z * 2.2369363f);
    public static Velocity3 Miles_Hour(float x, float y, float z) => new Velocity3(x * 0.4470399984f, y * 0.4470399984f, z * 0.4470399984f);
    public static Velocity3 Miles_Hour(Vector3 v) => new Velocity3(v.x * 0.4470399984f, v.y * 0.4470399984f, v.z * 0.4470399984f);

    public Vector3 ToMillimeters_Microsecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Velocity3 Millimeters_Microsecond(float x, float y, float z) => new Velocity3(x * 1000f, y * 1000f, z * 1000f);
    public static Velocity3 Millimeters_Microsecond(Vector3 v) => new Velocity3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillimeters_Millisecond() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Velocity3 Millimeters_Millisecond(float x, float y, float z) => new Velocity3(x * 1f, y * 1f, z * 1f);
    public static Velocity3 Millimeters_Millisecond(Vector3 v) => new Velocity3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillimeters_Second() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Velocity3 Millimeters_Second(float x, float y, float z) => new Velocity3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Velocity3 Millimeters_Second(Vector3 v) => new Velocity3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillimeters_Minute() => new Vector3(x * 60000f, y * 60000f, z * 60000f);
    public static Velocity3 Millimeters_Minute(float x, float y, float z) => new Velocity3(x * 1.666666667E-05f, y * 1.666666667E-05f, z * 1.666666667E-05f);
    public static Velocity3 Millimeters_Minute(Vector3 v) => new Velocity3(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f, v.z * 1.666666667E-05f);

    public Vector3 ToMillimeters_Hour() => new Vector3(x * 3600000f, y * 3600000f, z * 3600000f);
    public static Velocity3 Millimeters_Hour(float x, float y, float z) => new Velocity3(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static Velocity3 Millimeters_Hour(Vector3 v) => new Velocity3(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToCentimeters_Microsecond() => new Vector3(x * 0.0001f, y * 0.0001f, z * 0.0001f);
    public static Velocity3 Centimeters_Microsecond(float x, float y, float z) => new Velocity3(x * 10000f, y * 10000f, z * 10000f);
    public static Velocity3 Centimeters_Microsecond(Vector3 v) => new Velocity3(v.x * 10000f, v.y * 10000f, v.z * 10000f);

    public Vector3 ToCentimeters_Millisecond() => new Vector3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static Velocity3 Centimeters_Millisecond(float x, float y, float z) => new Velocity3(x * 10f, y * 10f, z * 10f);
    public static Velocity3 Centimeters_Millisecond(Vector3 v) => new Velocity3(v.x * 10f, v.y * 10f, v.z * 10f);

    public Vector3 ToCentimeters_Second() => new Vector3(x * 100f, y * 100f, z * 100f);
    public static Velocity3 Centimeters_Second(float x, float y, float z) => new Velocity3(x * 0.01f, y * 0.01f, z * 0.01f);
    public static Velocity3 Centimeters_Second(Vector3 v) => new Velocity3(v.x * 0.01f, v.y * 0.01f, v.z * 0.01f);

    public Vector3 ToCentimeters_Minute() => new Vector3(x * 6000f, y * 6000f, z * 6000f);
    public static Velocity3 Centimeters_Minute(float x, float y, float z) => new Velocity3(x * 0.0001666666667f, y * 0.0001666666667f, z * 0.0001666666667f);
    public static Velocity3 Centimeters_Minute(Vector3 v) => new Velocity3(v.x * 0.0001666666667f, v.y * 0.0001666666667f, v.z * 0.0001666666667f);

    public Vector3 ToCentimeters_Hour() => new Vector3(x * 360000f, y * 360000f, z * 360000f);
    public static Velocity3 Centimeters_Hour(float x, float y, float z) => new Velocity3(x * 2.777777778E-06f, y * 2.777777778E-06f, z * 2.777777778E-06f);
    public static Velocity3 Centimeters_Hour(Vector3 v) => new Velocity3(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f, v.z * 2.777777778E-06f);

    public Vector3 ToMeters_Microsecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Velocity3 Meters_Microsecond(float x, float y, float z) => new Velocity3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Velocity3 Meters_Microsecond(Vector3 v) => new Velocity3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeters_Millisecond() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Velocity3 Meters_Millisecond(float x, float y, float z) => new Velocity3(x * 1000f, y * 1000f, z * 1000f);
    public static Velocity3 Meters_Millisecond(Vector3 v) => new Velocity3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMeters_Second() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Velocity3 Meters_Second(float x, float y, float z) => new Velocity3(x * 1f, y * 1f, z * 1f);
    public static Velocity3 Meters_Second(Vector3 v) => new Velocity3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMeters_Minute() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static Velocity3 Meters_Minute(float x, float y, float z) => new Velocity3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static Velocity3 Meters_Minute(Vector3 v) => new Velocity3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToMeters_Hour() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static Velocity3 Meters_Hour(float x, float y, float z) => new Velocity3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static Velocity3 Meters_Hour(Vector3 v) => new Velocity3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToKilometers_Microsecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Velocity3 Kilometers_Microsecond(float x, float y, float z) => new Velocity3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Velocity3 Kilometers_Microsecond(Vector3 v) => new Velocity3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilometers_Millisecond() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Velocity3 Kilometers_Millisecond(float x, float y, float z) => new Velocity3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Velocity3 Kilometers_Millisecond(Vector3 v) => new Velocity3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilometers_Second() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Velocity3 Kilometers_Second(float x, float y, float z) => new Velocity3(x * 1000f, y * 1000f, z * 1000f);
    public static Velocity3 Kilometers_Second(Vector3 v) => new Velocity3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilometers_Minute() => new Vector3(x * 0.06f, y * 0.06f, z * 0.06f);
    public static Velocity3 Kilometers_Minute(float x, float y, float z) => new Velocity3(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static Velocity3 Kilometers_Minute(Vector3 v) => new Velocity3(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToKilometers_Hour() => new Vector3(x * 3.6f, y * 3.6f, z * 3.6f);
    public static Velocity3 Kilometers_Hour(float x, float y, float z) => new Velocity3(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static Velocity3 Kilometers_Hour(Vector3 v) => new Velocity3(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMegameters_Microsecond() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Velocity3 Megameters_Microsecond(float x, float y, float z) => new Velocity3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Velocity3 Megameters_Microsecond(Vector3 v) => new Velocity3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMegameters_Millisecond() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Velocity3 Megameters_Millisecond(float x, float y, float z) => new Velocity3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Velocity3 Megameters_Millisecond(Vector3 v) => new Velocity3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMegameters_Second() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Velocity3 Megameters_Second(float x, float y, float z) => new Velocity3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Velocity3 Megameters_Second(Vector3 v) => new Velocity3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMegameters_Minute() => new Vector3(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static Velocity3 Megameters_Minute(float x, float y, float z) => new Velocity3(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static Velocity3 Megameters_Minute(Vector3 v) => new Velocity3(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMegameters_Hour() => new Vector3(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static Velocity3 Megameters_Hour(float x, float y, float z) => new Velocity3(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static Velocity3 Megameters_Hour(Vector3 v) => new Velocity3(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

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

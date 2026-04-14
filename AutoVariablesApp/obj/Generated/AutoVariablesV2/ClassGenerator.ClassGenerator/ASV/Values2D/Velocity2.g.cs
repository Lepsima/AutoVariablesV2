using System;
using AutoVariablesApp;
namespace Generated.Units {
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

    public static implicit operator Vector2(Velocity2 v) => new Vector2(v.x, v.y);
    public Velocity magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToFeets_Microsecond() => new Vector2(x * 3.047999977E-07f, y * 3.047999977E-07f);
    public static Velocity2 Feets_Microsecond(float x, float y) => new Velocity2(x * 3280839.92f, y * 3280839.92f);
    public static Velocity2 Feets_Microsecond(Vector2 v) => new Velocity2(v.x * 3280839.92f, v.y * 3280839.92f);

    public Vector2 ToFeets_Millisecond() => new Vector2(x * 0.0003047999977f, y * 0.0003047999977f);
    public static Velocity2 Feets_Millisecond(float x, float y) => new Velocity2(x * 3280.83992f, y * 3280.83992f);
    public static Velocity2 Feets_Millisecond(Vector2 v) => new Velocity2(v.x * 3280.83992f, v.y * 3280.83992f);

    public Vector2 ToFeets_Second() => new Vector2(x * 0.3047999977f, y * 0.3047999977f);
    public static Velocity2 Feets_Second(float x, float y) => new Velocity2(x * 3.28083992f, y * 3.28083992f);
    public static Velocity2 Feets_Second(Vector2 v) => new Velocity2(v.x * 3.28083992f, v.y * 3.28083992f);

    public Vector2 ToFeets_Minute() => new Vector2(x * 18.28799986f, y * 18.28799986f);
    public static Velocity2 Feets_Minute(float x, float y) => new Velocity2(x * 0.05468066533f, y * 0.05468066533f);
    public static Velocity2 Feets_Minute(Vector2 v) => new Velocity2(v.x * 0.05468066533f, v.y * 0.05468066533f);

    public Vector2 ToFeets_Hour() => new Vector2(x * 1097.279992f, y * 1097.279992f);
    public static Velocity2 Feets_Hour(float x, float y) => new Velocity2(x * 0.0009113444222f, y * 0.0009113444222f);
    public static Velocity2 Feets_Hour(Vector2 v) => new Velocity2(v.x * 0.0009113444222f, v.y * 0.0009113444222f);

    public Vector2 ToMiles_Microsecond() => new Vector2(x * 6.213711945E-10f, y * 6.213711945E-10f);
    public static Velocity2 Miles_Microsecond(float x, float y) => new Velocity2(x * 1609343994f, y * 1609343994f);
    public static Velocity2 Miles_Microsecond(Vector2 v) => new Velocity2(v.x * 1609343994f, v.y * 1609343994f);

    public Vector2 ToMiles_Millisecond() => new Vector2(x * 6.213711945E-07f, y * 6.213711945E-07f);
    public static Velocity2 Miles_Millisecond(float x, float y) => new Velocity2(x * 1609343.994f, y * 1609343.994f);
    public static Velocity2 Miles_Millisecond(Vector2 v) => new Velocity2(v.x * 1609343.994f, v.y * 1609343.994f);

    public Vector2 ToMiles_Second() => new Vector2(x * 0.0006213711945f, y * 0.0006213711945f);
    public static Velocity2 Miles_Second(float x, float y) => new Velocity2(x * 1609.343994f, y * 1609.343994f);
    public static Velocity2 Miles_Second(Vector2 v) => new Velocity2(v.x * 1609.343994f, v.y * 1609.343994f);

    public Vector2 ToMiles_Minute() => new Vector2(x * 0.03728227167f, y * 0.03728227167f);
    public static Velocity2 Miles_Minute(float x, float y) => new Velocity2(x * 26.8223999f, y * 26.8223999f);
    public static Velocity2 Miles_Minute(Vector2 v) => new Velocity2(v.x * 26.8223999f, v.y * 26.8223999f);

    public Vector2 ToMiles_Hour() => new Vector2(x * 2.2369363f, y * 2.2369363f);
    public static Velocity2 Miles_Hour(float x, float y) => new Velocity2(x * 0.4470399984f, y * 0.4470399984f);
    public static Velocity2 Miles_Hour(Vector2 v) => new Velocity2(v.x * 0.4470399984f, v.y * 0.4470399984f);

    public Vector2 ToMillimeters_Microsecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static Velocity2 Millimeters_Microsecond(float x, float y) => new Velocity2(x * 1000f, y * 1000f);
    public static Velocity2 Millimeters_Microsecond(Vector2 v) => new Velocity2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillimeters_Millisecond() => new Vector2(x * 1f, y * 1f);
    public static Velocity2 Millimeters_Millisecond(float x, float y) => new Velocity2(x * 1f, y * 1f);
    public static Velocity2 Millimeters_Millisecond(Vector2 v) => new Velocity2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillimeters_Second() => new Vector2(x * 1000f, y * 1000f);
    public static Velocity2 Millimeters_Second(float x, float y) => new Velocity2(x * 0.001f, y * 0.001f);
    public static Velocity2 Millimeters_Second(Vector2 v) => new Velocity2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillimeters_Minute() => new Vector2(x * 60000f, y * 60000f);
    public static Velocity2 Millimeters_Minute(float x, float y) => new Velocity2(x * 1.666666667E-05f, y * 1.666666667E-05f);
    public static Velocity2 Millimeters_Minute(Vector2 v) => new Velocity2(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f);

    public Vector2 ToMillimeters_Hour() => new Vector2(x * 3600000f, y * 3600000f);
    public static Velocity2 Millimeters_Hour(float x, float y) => new Velocity2(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static Velocity2 Millimeters_Hour(Vector2 v) => new Velocity2(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToCentimeters_Microsecond() => new Vector2(x * 0.0001f, y * 0.0001f);
    public static Velocity2 Centimeters_Microsecond(float x, float y) => new Velocity2(x * 10000f, y * 10000f);
    public static Velocity2 Centimeters_Microsecond(Vector2 v) => new Velocity2(v.x * 10000f, v.y * 10000f);

    public Vector2 ToCentimeters_Millisecond() => new Vector2(x * 0.1f, y * 0.1f);
    public static Velocity2 Centimeters_Millisecond(float x, float y) => new Velocity2(x * 10f, y * 10f);
    public static Velocity2 Centimeters_Millisecond(Vector2 v) => new Velocity2(v.x * 10f, v.y * 10f);

    public Vector2 ToCentimeters_Second() => new Vector2(x * 100f, y * 100f);
    public static Velocity2 Centimeters_Second(float x, float y) => new Velocity2(x * 0.01f, y * 0.01f);
    public static Velocity2 Centimeters_Second(Vector2 v) => new Velocity2(v.x * 0.01f, v.y * 0.01f);

    public Vector2 ToCentimeters_Minute() => new Vector2(x * 6000f, y * 6000f);
    public static Velocity2 Centimeters_Minute(float x, float y) => new Velocity2(x * 0.0001666666667f, y * 0.0001666666667f);
    public static Velocity2 Centimeters_Minute(Vector2 v) => new Velocity2(v.x * 0.0001666666667f, v.y * 0.0001666666667f);

    public Vector2 ToCentimeters_Hour() => new Vector2(x * 360000f, y * 360000f);
    public static Velocity2 Centimeters_Hour(float x, float y) => new Velocity2(x * 2.777777778E-06f, y * 2.777777778E-06f);
    public static Velocity2 Centimeters_Hour(Vector2 v) => new Velocity2(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f);

    public Vector2 ToMeters_Microsecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Velocity2 Meters_Microsecond(float x, float y) => new Velocity2(x * 1000000f, y * 1000000f);
    public static Velocity2 Meters_Microsecond(Vector2 v) => new Velocity2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeters_Millisecond() => new Vector2(x * 0.001f, y * 0.001f);
    public static Velocity2 Meters_Millisecond(float x, float y) => new Velocity2(x * 1000f, y * 1000f);
    public static Velocity2 Meters_Millisecond(Vector2 v) => new Velocity2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeters_Second() => new Vector2(x * 1f, y * 1f);
    public static Velocity2 Meters_Second(float x, float y) => new Velocity2(x * 1f, y * 1f);
    public static Velocity2 Meters_Second(Vector2 v) => new Velocity2(v.x * 1f, v.y * 1f);

    public Vector2 ToMeters_Minute() => new Vector2(x * 60f, y * 60f);
    public static Velocity2 Meters_Minute(float x, float y) => new Velocity2(x * 0.01666666667f, y * 0.01666666667f);
    public static Velocity2 Meters_Minute(Vector2 v) => new Velocity2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMeters_Hour() => new Vector2(x * 3600f, y * 3600f);
    public static Velocity2 Meters_Hour(float x, float y) => new Velocity2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Velocity2 Meters_Hour(Vector2 v) => new Velocity2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToKilometers_Microsecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Velocity2 Kilometers_Microsecond(float x, float y) => new Velocity2(x * 1000000000f, y * 1000000000f);
    public static Velocity2 Kilometers_Microsecond(Vector2 v) => new Velocity2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilometers_Millisecond() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Velocity2 Kilometers_Millisecond(float x, float y) => new Velocity2(x * 1000000f, y * 1000000f);
    public static Velocity2 Kilometers_Millisecond(Vector2 v) => new Velocity2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilometers_Second() => new Vector2(x * 0.001f, y * 0.001f);
    public static Velocity2 Kilometers_Second(float x, float y) => new Velocity2(x * 1000f, y * 1000f);
    public static Velocity2 Kilometers_Second(Vector2 v) => new Velocity2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilometers_Minute() => new Vector2(x * 0.06f, y * 0.06f);
    public static Velocity2 Kilometers_Minute(float x, float y) => new Velocity2(x * 16.66666667f, y * 16.66666667f);
    public static Velocity2 Kilometers_Minute(Vector2 v) => new Velocity2(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToKilometers_Hour() => new Vector2(x * 3.6f, y * 3.6f);
    public static Velocity2 Kilometers_Hour(float x, float y) => new Velocity2(x * 0.2777777778f, y * 0.2777777778f);
    public static Velocity2 Kilometers_Hour(Vector2 v) => new Velocity2(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMegameters_Microsecond() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static Velocity2 Megameters_Microsecond(float x, float y) => new Velocity2(x * 1E+12f, y * 1E+12f);
    public static Velocity2 Megameters_Microsecond(Vector2 v) => new Velocity2(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMegameters_Millisecond() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Velocity2 Megameters_Millisecond(float x, float y) => new Velocity2(x * 1000000000f, y * 1000000000f);
    public static Velocity2 Megameters_Millisecond(Vector2 v) => new Velocity2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMegameters_Second() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Velocity2 Megameters_Second(float x, float y) => new Velocity2(x * 1000000f, y * 1000000f);
    public static Velocity2 Megameters_Second(Vector2 v) => new Velocity2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMegameters_Minute() => new Vector2(x * 6E-05f, y * 6E-05f);
    public static Velocity2 Megameters_Minute(float x, float y) => new Velocity2(x * 16666.66667f, y * 16666.66667f);
    public static Velocity2 Megameters_Minute(Vector2 v) => new Velocity2(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMegameters_Hour() => new Vector2(x * 0.0036f, y * 0.0036f);
    public static Velocity2 Megameters_Hour(float x, float y) => new Velocity2(x * 277.7777778f, y * 277.7777778f);
    public static Velocity2 Megameters_Hour(Vector2 v) => new Velocity2(v.x * 277.7777778f, v.y * 277.7777778f);

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

using System;
using AutoVariablesApp;
namespace Generated.Units {
public struct Velocity : IAutoUnit {
    public float x;
    
    public Velocity(float x) {
        this.x = x;
    }
    public static implicit operator float(Velocity v) => v.x;
    public Velocity magnitude => new(x);

    public float ToFeets_Microsecond() => x * 3.047999977E-07f;
    public static Velocity Feets_Microsecond(float x) => new Velocity(x * 3280839.92f);

    public float ToFeets_Millisecond() => x * 0.0003047999977f;
    public static Velocity Feets_Millisecond(float x) => new Velocity(x * 3280.83992f);

    public float ToFeets_Second() => x * 0.3047999977f;
    public static Velocity Feets_Second(float x) => new Velocity(x * 3.28083992f);

    public float ToFeets_Minute() => x * 18.28799986f;
    public static Velocity Feets_Minute(float x) => new Velocity(x * 0.05468066533f);

    public float ToFeets_Hour() => x * 1097.279992f;
    public static Velocity Feets_Hour(float x) => new Velocity(x * 0.0009113444222f);

    public float ToMiles_Microsecond() => x * 6.213711945E-10f;
    public static Velocity Miles_Microsecond(float x) => new Velocity(x * 1609343994f);

    public float ToMiles_Millisecond() => x * 6.213711945E-07f;
    public static Velocity Miles_Millisecond(float x) => new Velocity(x * 1609343.994f);

    public float ToMiles_Second() => x * 0.0006213711945f;
    public static Velocity Miles_Second(float x) => new Velocity(x * 1609.343994f);

    public float ToMiles_Minute() => x * 0.03728227167f;
    public static Velocity Miles_Minute(float x) => new Velocity(x * 26.8223999f);

    public float ToMiles_Hour() => x * 2.2369363f;
    public static Velocity Miles_Hour(float x) => new Velocity(x * 0.4470399984f);

    public float ToMillimeters_Microsecond() => x * 0.001f;
    public static Velocity Millimeters_Microsecond(float x) => new Velocity(x * 1000f);

    public float ToMillimeters_Millisecond() => x * 1f;
    public static Velocity Millimeters_Millisecond(float x) => new Velocity(x * 1f);

    public float ToMillimeters_Second() => x * 1000f;
    public static Velocity Millimeters_Second(float x) => new Velocity(x * 0.001f);

    public float ToMillimeters_Minute() => x * 60000f;
    public static Velocity Millimeters_Minute(float x) => new Velocity(x * 1.666666667E-05f);

    public float ToMillimeters_Hour() => x * 3600000f;
    public static Velocity Millimeters_Hour(float x) => new Velocity(x * 2.777777778E-07f);

    public float ToCentimeters_Microsecond() => x * 0.0001f;
    public static Velocity Centimeters_Microsecond(float x) => new Velocity(x * 10000f);

    public float ToCentimeters_Millisecond() => x * 0.1f;
    public static Velocity Centimeters_Millisecond(float x) => new Velocity(x * 10f);

    public float ToCentimeters_Second() => x * 100f;
    public static Velocity Centimeters_Second(float x) => new Velocity(x * 0.01f);

    public float ToCentimeters_Minute() => x * 6000f;
    public static Velocity Centimeters_Minute(float x) => new Velocity(x * 0.0001666666667f);

    public float ToCentimeters_Hour() => x * 360000f;
    public static Velocity Centimeters_Hour(float x) => new Velocity(x * 2.777777778E-06f);

    public float ToMeters_Microsecond() => x * 1E-06f;
    public static Velocity Meters_Microsecond(float x) => new Velocity(x * 1000000f);

    public float ToMeters_Millisecond() => x * 0.001f;
    public static Velocity Meters_Millisecond(float x) => new Velocity(x * 1000f);

    public float ToMeters_Second() => x * 1f;
    public static Velocity Meters_Second(float x) => new Velocity(x * 1f);

    public float ToMeters_Minute() => x * 60f;
    public static Velocity Meters_Minute(float x) => new Velocity(x * 0.01666666667f);

    public float ToMeters_Hour() => x * 3600f;
    public static Velocity Meters_Hour(float x) => new Velocity(x * 0.0002777777778f);

    public float ToKilometers_Microsecond() => x * 1E-09f;
    public static Velocity Kilometers_Microsecond(float x) => new Velocity(x * 1000000000f);

    public float ToKilometers_Millisecond() => x * 1E-06f;
    public static Velocity Kilometers_Millisecond(float x) => new Velocity(x * 1000000f);

    public float ToKilometers_Second() => x * 0.001f;
    public static Velocity Kilometers_Second(float x) => new Velocity(x * 1000f);

    public float ToKilometers_Minute() => x * 0.06f;
    public static Velocity Kilometers_Minute(float x) => new Velocity(x * 16.66666667f);

    public float ToKilometers_Hour() => x * 3.6f;
    public static Velocity Kilometers_Hour(float x) => new Velocity(x * 0.2777777778f);

    public float ToMegameters_Microsecond() => x * 1E-12f;
    public static Velocity Megameters_Microsecond(float x) => new Velocity(x * 1E+12f);

    public float ToMegameters_Millisecond() => x * 1E-09f;
    public static Velocity Megameters_Millisecond(float x) => new Velocity(x * 1000000000f);

    public float ToMegameters_Second() => x * 1E-06f;
    public static Velocity Megameters_Second(float x) => new Velocity(x * 1000000f);

    public float ToMegameters_Minute() => x * 6E-05f;
    public static Velocity Megameters_Minute(float x) => new Velocity(x * 16666.66667f);

    public float ToMegameters_Hour() => x * 0.0036f;
    public static Velocity Megameters_Hour(float x) => new Velocity(x * 277.7777778f);

    public static Velocity operator +(Velocity a, Velocity b) => new(a.x + b.x);
    public static Velocity operator -(Velocity a, Velocity b) => new(a.x - b.x);
    public static Velocity operator *(Velocity a, Velocity b) => new(a.x * b.x);
    public static Velocity operator /(Velocity a, Velocity b) => new(a.x / b.x);
    public Position Position(Time v) => new(v * x);
    public Time Time(Position v) => new(v / x);
    public Velocity(Position a, Time b) => a.Velocity(b);
    public Velocity(Time b, Position a) => a.Velocity(b);

    public static Velocity operator +(Accel a, Velocity b) => b + a.Velocity(VTime.deltaTime);
    public static Velocity operator +(Velocity b, Accel a) => b + a.Velocity(VTime.deltaTime);
    public static Velocity operator -(Accel a, Velocity b) => a.Velocity(VTime.deltaTime) - b;
    public static Velocity operator -(Velocity b, Accel a) => b - a.Velocity(VTime.deltaTime);
    
    public Accel Accel(Time v) => new(x / v);
    public Time Time(Accel v) => new(x / v);
    public Velocity(Accel a, Time b) => a.Velocity(b);
    public Velocity(Time b, Accel a) => a.Velocity(b);
}
}

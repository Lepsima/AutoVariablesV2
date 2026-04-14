using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Torque2 : IAutoUnit2 {
    public float x, y;
    
    public Torque2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Torque2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;

    public static implicit operator Vector2(Torque2 v) => new Vector2(v.x, v.y);
    public Torque magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToFeetsPerMillinewton() => new Vector2(x * 0.0003048f, y * 0.0003048f);
    public static Torque2 FeetsPerMillinewton(float x, float y) => new Torque2(x * 3280.839895f, y * 3280.839895f);
    public static Torque2 FeetsPerMillinewton(Vector2 v) => new Torque2(v.x * 3280.839895f, v.y * 3280.839895f);

    public Vector2 ToFeetsPerNewton() => new Vector2(x * 0.3048f, y * 0.3048f);
    public static Torque2 FeetsPerNewton(float x, float y) => new Torque2(x * 3.280839895f, y * 3.280839895f);
    public static Torque2 FeetsPerNewton(Vector2 v) => new Torque2(v.x * 3.280839895f, v.y * 3.280839895f);

    public Vector2 ToFeetsPerKilonewton() => new Vector2(x * 304.8f, y * 304.8f);
    public static Torque2 FeetsPerKilonewton(float x, float y) => new Torque2(x * 0.003280839895f, y * 0.003280839895f);
    public static Torque2 FeetsPerKilonewton(Vector2 v) => new Torque2(v.x * 0.003280839895f, v.y * 0.003280839895f);

    public Vector2 ToFeetsPerMeganewton() => new Vector2(x * 304800f, y * 304800f);
    public static Torque2 FeetsPerMeganewton(float x, float y) => new Torque2(x * 3.280839895E-06f, y * 3.280839895E-06f);
    public static Torque2 FeetsPerMeganewton(Vector2 v) => new Torque2(v.x * 3.280839895E-06f, v.y * 3.280839895E-06f);

    public Vector2 ToMilesPerMillinewton() => new Vector2(x * 6.213711922E-07f, y * 6.213711922E-07f);
    public static Torque2 MilesPerMillinewton(float x, float y) => new Torque2(x * 1609344f, y * 1609344f);
    public static Torque2 MilesPerMillinewton(Vector2 v) => new Torque2(v.x * 1609344f, v.y * 1609344f);

    public Vector2 ToMilesPerNewton() => new Vector2(x * 0.0006213711922f, y * 0.0006213711922f);
    public static Torque2 MilesPerNewton(float x, float y) => new Torque2(x * 1609.344f, y * 1609.344f);
    public static Torque2 MilesPerNewton(Vector2 v) => new Torque2(v.x * 1609.344f, v.y * 1609.344f);

    public Vector2 ToMilesPerKilonewton() => new Vector2(x * 0.6213711922f, y * 0.6213711922f);
    public static Torque2 MilesPerKilonewton(float x, float y) => new Torque2(x * 1.609344f, y * 1.609344f);
    public static Torque2 MilesPerKilonewton(Vector2 v) => new Torque2(v.x * 1.609344f, v.y * 1.609344f);

    public Vector2 ToMilesPerMeganewton() => new Vector2(x * 621.3711922f, y * 621.3711922f);
    public static Torque2 MilesPerMeganewton(float x, float y) => new Torque2(x * 0.001609344f, y * 0.001609344f);
    public static Torque2 MilesPerMeganewton(Vector2 v) => new Torque2(v.x * 0.001609344f, v.y * 0.001609344f);

    public Vector2 ToMillimetersPerMillinewton() => new Vector2(x * 1f, y * 1f);
    public static Torque2 MillimetersPerMillinewton(float x, float y) => new Torque2(x * 1f, y * 1f);
    public static Torque2 MillimetersPerMillinewton(Vector2 v) => new Torque2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillimetersPerNewton() => new Vector2(x * 1000f, y * 1000f);
    public static Torque2 MillimetersPerNewton(float x, float y) => new Torque2(x * 0.001f, y * 0.001f);
    public static Torque2 MillimetersPerNewton(Vector2 v) => new Torque2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillimetersPerKilonewton() => new Vector2(x * 1000000f, y * 1000000f);
    public static Torque2 MillimetersPerKilonewton(float x, float y) => new Torque2(x * 1E-06f, y * 1E-06f);
    public static Torque2 MillimetersPerKilonewton(Vector2 v) => new Torque2(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToMillimetersPerMeganewton() => new Vector2(x * 1000000000f, y * 1000000000f);
    public static Torque2 MillimetersPerMeganewton(float x, float y) => new Torque2(x * 1E-09f, y * 1E-09f);
    public static Torque2 MillimetersPerMeganewton(Vector2 v) => new Torque2(v.x * 1E-09f, v.y * 1E-09f);

    public Vector2 ToCentimetersPerMillinewton() => new Vector2(x * 0.1f, y * 0.1f);
    public static Torque2 CentimetersPerMillinewton(float x, float y) => new Torque2(x * 10f, y * 10f);
    public static Torque2 CentimetersPerMillinewton(Vector2 v) => new Torque2(v.x * 10f, v.y * 10f);

    public Vector2 ToCentimetersPerNewton() => new Vector2(x * 100f, y * 100f);
    public static Torque2 CentimetersPerNewton(float x, float y) => new Torque2(x * 0.01f, y * 0.01f);
    public static Torque2 CentimetersPerNewton(Vector2 v) => new Torque2(v.x * 0.01f, v.y * 0.01f);

    public Vector2 ToCentimetersPerKilonewton() => new Vector2(x * 100000f, y * 100000f);
    public static Torque2 CentimetersPerKilonewton(float x, float y) => new Torque2(x * 1E-05f, y * 1E-05f);
    public static Torque2 CentimetersPerKilonewton(Vector2 v) => new Torque2(v.x * 1E-05f, v.y * 1E-05f);

    public Vector2 ToCentimetersPerMeganewton() => new Vector2(x * 100000000f, y * 100000000f);
    public static Torque2 CentimetersPerMeganewton(float x, float y) => new Torque2(x * 1E-08f, y * 1E-08f);
    public static Torque2 CentimetersPerMeganewton(Vector2 v) => new Torque2(v.x * 1E-08f, v.y * 1E-08f);

    public Vector2 ToMetersPerMillinewton() => new Vector2(x * 0.001f, y * 0.001f);
    public static Torque2 MetersPerMillinewton(float x, float y) => new Torque2(x * 1000f, y * 1000f);
    public static Torque2 MetersPerMillinewton(Vector2 v) => new Torque2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMetersPerNewton() => new Vector2(x * 1f, y * 1f);
    public static Torque2 MetersPerNewton(float x, float y) => new Torque2(x * 1f, y * 1f);
    public static Torque2 MetersPerNewton(Vector2 v) => new Torque2(v.x * 1f, v.y * 1f);

    public Vector2 ToMetersPerKilonewton() => new Vector2(x * 1000f, y * 1000f);
    public static Torque2 MetersPerKilonewton(float x, float y) => new Torque2(x * 0.001f, y * 0.001f);
    public static Torque2 MetersPerKilonewton(Vector2 v) => new Torque2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMetersPerMeganewton() => new Vector2(x * 1000000f, y * 1000000f);
    public static Torque2 MetersPerMeganewton(float x, float y) => new Torque2(x * 1E-06f, y * 1E-06f);
    public static Torque2 MetersPerMeganewton(Vector2 v) => new Torque2(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToKilometersPerMillinewton() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Torque2 KilometersPerMillinewton(float x, float y) => new Torque2(x * 1000000f, y * 1000000f);
    public static Torque2 KilometersPerMillinewton(Vector2 v) => new Torque2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilometersPerNewton() => new Vector2(x * 0.001f, y * 0.001f);
    public static Torque2 KilometersPerNewton(float x, float y) => new Torque2(x * 1000f, y * 1000f);
    public static Torque2 KilometersPerNewton(Vector2 v) => new Torque2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilometersPerKilonewton() => new Vector2(x * 1f, y * 1f);
    public static Torque2 KilometersPerKilonewton(float x, float y) => new Torque2(x * 1f, y * 1f);
    public static Torque2 KilometersPerKilonewton(Vector2 v) => new Torque2(v.x * 1f, v.y * 1f);

    public Vector2 ToKilometersPerMeganewton() => new Vector2(x * 1000f, y * 1000f);
    public static Torque2 KilometersPerMeganewton(float x, float y) => new Torque2(x * 0.001f, y * 0.001f);
    public static Torque2 KilometersPerMeganewton(Vector2 v) => new Torque2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMegametersPerMillinewton() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Torque2 MegametersPerMillinewton(float x, float y) => new Torque2(x * 1000000000f, y * 1000000000f);
    public static Torque2 MegametersPerMillinewton(Vector2 v) => new Torque2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMegametersPerNewton() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Torque2 MegametersPerNewton(float x, float y) => new Torque2(x * 1000000f, y * 1000000f);
    public static Torque2 MegametersPerNewton(Vector2 v) => new Torque2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMegametersPerKilonewton() => new Vector2(x * 0.001f, y * 0.001f);
    public static Torque2 MegametersPerKilonewton(float x, float y) => new Torque2(x * 1000f, y * 1000f);
    public static Torque2 MegametersPerKilonewton(Vector2 v) => new Torque2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMegametersPerMeganewton() => new Vector2(x * 1f, y * 1f);
    public static Torque2 MegametersPerMeganewton(float x, float y) => new Torque2(x * 1f, y * 1f);
    public static Torque2 MegametersPerMeganewton(Vector2 v) => new Torque2(v.x * 1f, v.y * 1f);

    public static Torque2 operator +(Torque2 a, Torque2 b) => new(a.x + b.x, a.y + b.y);
    public static Torque2 operator -(Torque2 a, Torque2 b) => new(a.x - b.x, a.y - b.y);
    public static Torque2 operator *(Torque2 a, Torque2 b) => new(a.x * b.x, a.y * b.y);
    public static Torque2 operator /(Torque2 a, Torque2 b) => new(a.x / b.x, a.y / b.y);
    public AngleAccel2 AngleAccel2(Mass v) => new(x / v, y / v);
    public Mass Mass(AngleAccel2 v) => new(magnitude / v.magnitude);
    public Torque2(AngleAccel2 a, Mass b) => a.Torque2(b);
    public Torque2(Mass b, AngleAccel2 a) => a.Torque2(b);

    public static Torque2 operator +(TorqueAccel2 a, Torque2 b) => b + a.Torque2(VTime.deltaTime);
    public static Torque2 operator +(Torque2 b, TorqueAccel2 a) => b + a.Torque2(VTime.deltaTime);
    public static Torque2 operator -(TorqueAccel2 a, Torque2 b) => a.Torque2(VTime.deltaTime) - b;
    public static Torque2 operator -(Torque2 b, TorqueAccel2 a) => b - a.Torque2(VTime.deltaTime);
    
    public TorqueAccel2 TorqueAccel2(Time v) => new(x / v, y / v);
    public Time Time(TorqueAccel2 v) => new(magnitude / v.magnitude);
    public Torque2(TorqueAccel2 a, Time b) => a.Torque2(b);
    public Torque2(Time b, TorqueAccel2 a) => a.Torque2(b);
    public Force2 Force2(Position v) => new(v.x * x, v.y * y);
    public Position Position(Force2 v) => new(v.x / x, v.y / y);
    public Torque2(Force2 a, Position b) => a.Torque2(b);
    public Torque2(Position b, Force2 a) => a.Torque2(b);
}
}

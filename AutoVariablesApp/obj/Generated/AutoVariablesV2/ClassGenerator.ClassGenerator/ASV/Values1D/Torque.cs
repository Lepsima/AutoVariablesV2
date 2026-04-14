using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Torque : IAutoUnit {
    public float x;
    
    public Torque(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(Torque v) => v.x;
    public Torque magnitude => new(x);

    public float ToFeetsPerMillinewton() => x * 0.0003048f;
    public static Torque FeetsPerMillinewton(float x) => new Torque(x * 3280.839895f);

    public float ToFeetsPerNewton() => x * 0.3048f;
    public static Torque FeetsPerNewton(float x) => new Torque(x * 3.280839895f);

    public float ToFeetsPerKilonewton() => x * 304.8f;
    public static Torque FeetsPerKilonewton(float x) => new Torque(x * 0.003280839895f);

    public float ToFeetsPerMeganewton() => x * 304800f;
    public static Torque FeetsPerMeganewton(float x) => new Torque(x * 3.280839895E-06f);

    public float ToMilesPerMillinewton() => x * 6.213711922E-07f;
    public static Torque MilesPerMillinewton(float x) => new Torque(x * 1609344f);

    public float ToMilesPerNewton() => x * 0.0006213711922f;
    public static Torque MilesPerNewton(float x) => new Torque(x * 1609.344f);

    public float ToMilesPerKilonewton() => x * 0.6213711922f;
    public static Torque MilesPerKilonewton(float x) => new Torque(x * 1.609344f);

    public float ToMilesPerMeganewton() => x * 621.3711922f;
    public static Torque MilesPerMeganewton(float x) => new Torque(x * 0.001609344f);

    public float ToMillimetersPerMillinewton() => x * 1f;
    public static Torque MillimetersPerMillinewton(float x) => new Torque(x * 1f);

    public float ToMillimetersPerNewton() => x * 1000f;
    public static Torque MillimetersPerNewton(float x) => new Torque(x * 0.001f);

    public float ToMillimetersPerKilonewton() => x * 1000000f;
    public static Torque MillimetersPerKilonewton(float x) => new Torque(x * 1E-06f);

    public float ToMillimetersPerMeganewton() => x * 1000000000f;
    public static Torque MillimetersPerMeganewton(float x) => new Torque(x * 1E-09f);

    public float ToCentimetersPerMillinewton() => x * 0.1f;
    public static Torque CentimetersPerMillinewton(float x) => new Torque(x * 10f);

    public float ToCentimetersPerNewton() => x * 100f;
    public static Torque CentimetersPerNewton(float x) => new Torque(x * 0.01f);

    public float ToCentimetersPerKilonewton() => x * 100000f;
    public static Torque CentimetersPerKilonewton(float x) => new Torque(x * 1E-05f);

    public float ToCentimetersPerMeganewton() => x * 100000000f;
    public static Torque CentimetersPerMeganewton(float x) => new Torque(x * 1E-08f);

    public float ToMetersPerMillinewton() => x * 0.001f;
    public static Torque MetersPerMillinewton(float x) => new Torque(x * 1000f);

    public float ToMetersPerNewton() => x * 1f;
    public static Torque MetersPerNewton(float x) => new Torque(x * 1f);

    public float ToMetersPerKilonewton() => x * 1000f;
    public static Torque MetersPerKilonewton(float x) => new Torque(x * 0.001f);

    public float ToMetersPerMeganewton() => x * 1000000f;
    public static Torque MetersPerMeganewton(float x) => new Torque(x * 1E-06f);

    public float ToKilometersPerMillinewton() => x * 1E-06f;
    public static Torque KilometersPerMillinewton(float x) => new Torque(x * 1000000f);

    public float ToKilometersPerNewton() => x * 0.001f;
    public static Torque KilometersPerNewton(float x) => new Torque(x * 1000f);

    public float ToKilometersPerKilonewton() => x * 1f;
    public static Torque KilometersPerKilonewton(float x) => new Torque(x * 1f);

    public float ToKilometersPerMeganewton() => x * 1000f;
    public static Torque KilometersPerMeganewton(float x) => new Torque(x * 0.001f);

    public float ToMegametersPerMillinewton() => x * 1E-09f;
    public static Torque MegametersPerMillinewton(float x) => new Torque(x * 1000000000f);

    public float ToMegametersPerNewton() => x * 1E-06f;
    public static Torque MegametersPerNewton(float x) => new Torque(x * 1000000f);

    public float ToMegametersPerKilonewton() => x * 0.001f;
    public static Torque MegametersPerKilonewton(float x) => new Torque(x * 1000f);

    public float ToMegametersPerMeganewton() => x * 1f;
    public static Torque MegametersPerMeganewton(float x) => new Torque(x * 1f);

    public static Torque operator +(Torque a, Torque b) => new(a.x + b.x);
    public static Torque operator -(Torque a, Torque b) => new(a.x - b.x);
    public static Torque operator *(Torque a, Torque b) => new(a.x * b.x);
    public static Torque operator /(Torque a, Torque b) => new(a.x / b.x);
    public AngleAccel AngleAccel(Mass v) => new(x / v);
    public Mass Mass(AngleAccel v) => new(x / v);
    public Torque(AngleAccel a, Mass b) => a.Torque(b);
    public Torque(Mass b, AngleAccel a) => a.Torque(b);

    public static Torque operator +(TorqueAccel a, Torque b) => b + a.Torque(VTime.deltaTime);
    public static Torque operator +(Torque b, TorqueAccel a) => b + a.Torque(VTime.deltaTime);
    public static Torque operator -(TorqueAccel a, Torque b) => a.Torque(VTime.deltaTime) - b;
    public static Torque operator -(Torque b, TorqueAccel a) => b - a.Torque(VTime.deltaTime);
    
    public TorqueAccel TorqueAccel(Time v) => new(x / v);
    public Time Time(TorqueAccel v) => new(x / v);
    public Torque(TorqueAccel a, Time b) => a.Torque(b);
    public Torque(Time b, TorqueAccel a) => a.Torque(b);
    public Force Force(Position v) => new(v.x * x);
    public Position Position(Force v) => new(v.x / x);
    public Torque(Force a, Position b) => a.Torque(b);
    public Torque(Position b, Force a) => a.Torque(b);
}
}

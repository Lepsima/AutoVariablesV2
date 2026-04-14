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

    public float ToMillinewton() => x * 1000f;
    public static Torque Millinewton(float x) => new Torque(x * 0.001f);

    public float ToNewton() => x * 1f;
    public static Torque Newton(float x) => new Torque(x * 1f);

    public float ToKilonewton() => x * 0.001f;
    public static Torque Kilonewton(float x) => new Torque(x * 1000f);

    public float ToMeganewton() => x * 1E-06f;
    public static Torque Meganewton(float x) => new Torque(x * 1000000f);

    public float ToMillinewtonsPerFeet() => x * 304.8f;
    public static Torque MillinewtonsPerFeet(float x) => new Torque(x * 0.003280839895f);

    public float ToMillinewtonsPerMile() => x * 0.6213711922f;
    public static Torque MillinewtonsPerMile(float x) => new Torque(x * 1.609344f);

    public float ToMillinewtonsPerMillimeter() => x * 1000000f;
    public static Torque MillinewtonsPerMillimeter(float x) => new Torque(x * 1E-06f);

    public float ToMillinewtonsPerCentimeter() => x * 100000f;
    public static Torque MillinewtonsPerCentimeter(float x) => new Torque(x * 1E-05f);

    public float ToMillinewtonsPerMeter() => x * 1000f;
    public static Torque MillinewtonsPerMeter(float x) => new Torque(x * 0.001f);

    public float ToMillinewtonsPerKilometer() => x * 1f;
    public static Torque MillinewtonsPerKilometer(float x) => new Torque(x * 1f);

    public float ToMillinewtonsPerMegameter() => x * 0.001f;
    public static Torque MillinewtonsPerMegameter(float x) => new Torque(x * 1000f);

    public float ToNewtonsPerFeet() => x * 0.3048f;
    public static Torque NewtonsPerFeet(float x) => new Torque(x * 3.280839895f);

    public float ToNewtonsPerMile() => x * 0.0006213711922f;
    public static Torque NewtonsPerMile(float x) => new Torque(x * 1609.344f);

    public float ToNewtonsPerMillimeter() => x * 1000f;
    public static Torque NewtonsPerMillimeter(float x) => new Torque(x * 0.001f);

    public float ToNewtonsPerCentimeter() => x * 100f;
    public static Torque NewtonsPerCentimeter(float x) => new Torque(x * 0.01f);

    public float ToNewtonsPerMeter() => x * 1f;
    public static Torque NewtonsPerMeter(float x) => new Torque(x * 1f);

    public float ToNewtonsPerKilometer() => x * 0.001f;
    public static Torque NewtonsPerKilometer(float x) => new Torque(x * 1000f);

    public float ToNewtonsPerMegameter() => x * 1E-06f;
    public static Torque NewtonsPerMegameter(float x) => new Torque(x * 1000000f);

    public float ToKilonewtonsPerFeet() => x * 0.0003048f;
    public static Torque KilonewtonsPerFeet(float x) => new Torque(x * 3280.839895f);

    public float ToKilonewtonsPerMile() => x * 6.213711922E-07f;
    public static Torque KilonewtonsPerMile(float x) => new Torque(x * 1609344f);

    public float ToKilonewtonsPerMillimeter() => x * 1f;
    public static Torque KilonewtonsPerMillimeter(float x) => new Torque(x * 1f);

    public float ToKilonewtonsPerCentimeter() => x * 0.1f;
    public static Torque KilonewtonsPerCentimeter(float x) => new Torque(x * 10f);

    public float ToKilonewtonsPerMeter() => x * 0.001f;
    public static Torque KilonewtonsPerMeter(float x) => new Torque(x * 1000f);

    public float ToKilonewtonsPerKilometer() => x * 1E-06f;
    public static Torque KilonewtonsPerKilometer(float x) => new Torque(x * 1000000f);

    public float ToKilonewtonsPerMegameter() => x * 1E-09f;
    public static Torque KilonewtonsPerMegameter(float x) => new Torque(x * 1000000000f);

    public float ToMeganewtonsPerFeet() => x * 3.048E-07f;
    public static Torque MeganewtonsPerFeet(float x) => new Torque(x * 3280839.895f);

    public float ToMeganewtonsPerMile() => x * 6.213711922E-10f;
    public static Torque MeganewtonsPerMile(float x) => new Torque(x * 1609344000f);

    public float ToMeganewtonsPerMillimeter() => x * 0.001f;
    public static Torque MeganewtonsPerMillimeter(float x) => new Torque(x * 1000f);

    public float ToMeganewtonsPerCentimeter() => x * 0.0001f;
    public static Torque MeganewtonsPerCentimeter(float x) => new Torque(x * 10000f);

    public float ToMeganewtonsPerMeter() => x * 1E-06f;
    public static Torque MeganewtonsPerMeter(float x) => new Torque(x * 1000000f);

    public float ToMeganewtonsPerKilometer() => x * 1E-09f;
    public static Torque MeganewtonsPerKilometer(float x) => new Torque(x * 1000000000f);

    public float ToMeganewtonsPerMegameter() => x * 1E-12f;
    public static Torque MeganewtonsPerMegameter(float x) => new Torque(x * 1E+12f);

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

    public Force Force(Position v) => new(x / v.x);
    public Position Position(Force v) => new(x / v.x);

    public Torque(Force a, Position b) => a.Torque(b);
    public Torque(Position b, Force a) => a.Torque(b);

}
}

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

    public Vector2 ToMillinewton() => new Vector2(x * 1000f, y * 1000f);
    public static Torque2 Millinewton(float x, float y) => new Torque2(x * 0.001f, y * 0.001f);
    public static Torque2 Millinewton(Vector2 v) => new Torque2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToNewton() => new Vector2(x * 1f, y * 1f);
    public static Torque2 Newton(float x, float y) => new Torque2(x * 1f, y * 1f);
    public static Torque2 Newton(Vector2 v) => new Torque2(v.x * 1f, v.y * 1f);

    public Vector2 ToKilonewton() => new Vector2(x * 0.001f, y * 0.001f);
    public static Torque2 Kilonewton(float x, float y) => new Torque2(x * 1000f, y * 1000f);
    public static Torque2 Kilonewton(Vector2 v) => new Torque2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeganewton() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Torque2 Meganewton(float x, float y) => new Torque2(x * 1000000f, y * 1000000f);
    public static Torque2 Meganewton(Vector2 v) => new Torque2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMillinewtonsPerFeet() => new Vector2(x * 304.8f, y * 304.8f);
    public static Torque2 MillinewtonsPerFeet(float x, float y) => new Torque2(x * 0.003280839895f, y * 0.003280839895f);
    public static Torque2 MillinewtonsPerFeet(Vector2 v) => new Torque2(v.x * 0.003280839895f, v.y * 0.003280839895f);

    public Vector2 ToMillinewtonsPerMile() => new Vector2(x * 0.6213711922f, y * 0.6213711922f);
    public static Torque2 MillinewtonsPerMile(float x, float y) => new Torque2(x * 1.609344f, y * 1.609344f);
    public static Torque2 MillinewtonsPerMile(Vector2 v) => new Torque2(v.x * 1.609344f, v.y * 1.609344f);

    public Vector2 ToMillinewtonsPerMillimeter() => new Vector2(x * 1000000f, y * 1000000f);
    public static Torque2 MillinewtonsPerMillimeter(float x, float y) => new Torque2(x * 1E-06f, y * 1E-06f);
    public static Torque2 MillinewtonsPerMillimeter(Vector2 v) => new Torque2(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToMillinewtonsPerCentimeter() => new Vector2(x * 100000f, y * 100000f);
    public static Torque2 MillinewtonsPerCentimeter(float x, float y) => new Torque2(x * 1E-05f, y * 1E-05f);
    public static Torque2 MillinewtonsPerCentimeter(Vector2 v) => new Torque2(v.x * 1E-05f, v.y * 1E-05f);

    public Vector2 ToMillinewtonsPerMeter() => new Vector2(x * 1000f, y * 1000f);
    public static Torque2 MillinewtonsPerMeter(float x, float y) => new Torque2(x * 0.001f, y * 0.001f);
    public static Torque2 MillinewtonsPerMeter(Vector2 v) => new Torque2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtonsPerKilometer() => new Vector2(x * 1f, y * 1f);
    public static Torque2 MillinewtonsPerKilometer(float x, float y) => new Torque2(x * 1f, y * 1f);
    public static Torque2 MillinewtonsPerKilometer(Vector2 v) => new Torque2(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtonsPerMegameter() => new Vector2(x * 0.001f, y * 0.001f);
    public static Torque2 MillinewtonsPerMegameter(float x, float y) => new Torque2(x * 1000f, y * 1000f);
    public static Torque2 MillinewtonsPerMegameter(Vector2 v) => new Torque2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerFeet() => new Vector2(x * 0.3048f, y * 0.3048f);
    public static Torque2 NewtonsPerFeet(float x, float y) => new Torque2(x * 3.280839895f, y * 3.280839895f);
    public static Torque2 NewtonsPerFeet(Vector2 v) => new Torque2(v.x * 3.280839895f, v.y * 3.280839895f);

    public Vector2 ToNewtonsPerMile() => new Vector2(x * 0.0006213711922f, y * 0.0006213711922f);
    public static Torque2 NewtonsPerMile(float x, float y) => new Torque2(x * 1609.344f, y * 1609.344f);
    public static Torque2 NewtonsPerMile(Vector2 v) => new Torque2(v.x * 1609.344f, v.y * 1609.344f);

    public Vector2 ToNewtonsPerMillimeter() => new Vector2(x * 1000f, y * 1000f);
    public static Torque2 NewtonsPerMillimeter(float x, float y) => new Torque2(x * 0.001f, y * 0.001f);
    public static Torque2 NewtonsPerMillimeter(Vector2 v) => new Torque2(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToNewtonsPerCentimeter() => new Vector2(x * 100f, y * 100f);
    public static Torque2 NewtonsPerCentimeter(float x, float y) => new Torque2(x * 0.01f, y * 0.01f);
    public static Torque2 NewtonsPerCentimeter(Vector2 v) => new Torque2(v.x * 0.01f, v.y * 0.01f);

    public Vector2 ToNewtonsPerMeter() => new Vector2(x * 1f, y * 1f);
    public static Torque2 NewtonsPerMeter(float x, float y) => new Torque2(x * 1f, y * 1f);
    public static Torque2 NewtonsPerMeter(Vector2 v) => new Torque2(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtonsPerKilometer() => new Vector2(x * 0.001f, y * 0.001f);
    public static Torque2 NewtonsPerKilometer(float x, float y) => new Torque2(x * 1000f, y * 1000f);
    public static Torque2 NewtonsPerKilometer(Vector2 v) => new Torque2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerMegameter() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Torque2 NewtonsPerMegameter(float x, float y) => new Torque2(x * 1000000f, y * 1000000f);
    public static Torque2 NewtonsPerMegameter(Vector2 v) => new Torque2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerFeet() => new Vector2(x * 0.0003048f, y * 0.0003048f);
    public static Torque2 KilonewtonsPerFeet(float x, float y) => new Torque2(x * 3280.839895f, y * 3280.839895f);
    public static Torque2 KilonewtonsPerFeet(Vector2 v) => new Torque2(v.x * 3280.839895f, v.y * 3280.839895f);

    public Vector2 ToKilonewtonsPerMile() => new Vector2(x * 6.213711922E-07f, y * 6.213711922E-07f);
    public static Torque2 KilonewtonsPerMile(float x, float y) => new Torque2(x * 1609344f, y * 1609344f);
    public static Torque2 KilonewtonsPerMile(Vector2 v) => new Torque2(v.x * 1609344f, v.y * 1609344f);

    public Vector2 ToKilonewtonsPerMillimeter() => new Vector2(x * 1f, y * 1f);
    public static Torque2 KilonewtonsPerMillimeter(float x, float y) => new Torque2(x * 1f, y * 1f);
    public static Torque2 KilonewtonsPerMillimeter(Vector2 v) => new Torque2(v.x * 1f, v.y * 1f);

    public Vector2 ToKilonewtonsPerCentimeter() => new Vector2(x * 0.1f, y * 0.1f);
    public static Torque2 KilonewtonsPerCentimeter(float x, float y) => new Torque2(x * 10f, y * 10f);
    public static Torque2 KilonewtonsPerCentimeter(Vector2 v) => new Torque2(v.x * 10f, v.y * 10f);

    public Vector2 ToKilonewtonsPerMeter() => new Vector2(x * 0.001f, y * 0.001f);
    public static Torque2 KilonewtonsPerMeter(float x, float y) => new Torque2(x * 1000f, y * 1000f);
    public static Torque2 KilonewtonsPerMeter(Vector2 v) => new Torque2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtonsPerKilometer() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Torque2 KilonewtonsPerKilometer(float x, float y) => new Torque2(x * 1000000f, y * 1000000f);
    public static Torque2 KilonewtonsPerKilometer(Vector2 v) => new Torque2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerMegameter() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Torque2 KilonewtonsPerMegameter(float x, float y) => new Torque2(x * 1000000000f, y * 1000000000f);
    public static Torque2 KilonewtonsPerMegameter(Vector2 v) => new Torque2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerFeet() => new Vector2(x * 3.048E-07f, y * 3.048E-07f);
    public static Torque2 MeganewtonsPerFeet(float x, float y) => new Torque2(x * 3280839.895f, y * 3280839.895f);
    public static Torque2 MeganewtonsPerFeet(Vector2 v) => new Torque2(v.x * 3280839.895f, v.y * 3280839.895f);

    public Vector2 ToMeganewtonsPerMile() => new Vector2(x * 6.213711922E-10f, y * 6.213711922E-10f);
    public static Torque2 MeganewtonsPerMile(float x, float y) => new Torque2(x * 1609344000f, y * 1609344000f);
    public static Torque2 MeganewtonsPerMile(Vector2 v) => new Torque2(v.x * 1609344000f, v.y * 1609344000f);

    public Vector2 ToMeganewtonsPerMillimeter() => new Vector2(x * 0.001f, y * 0.001f);
    public static Torque2 MeganewtonsPerMillimeter(float x, float y) => new Torque2(x * 1000f, y * 1000f);
    public static Torque2 MeganewtonsPerMillimeter(Vector2 v) => new Torque2(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeganewtonsPerCentimeter() => new Vector2(x * 0.0001f, y * 0.0001f);
    public static Torque2 MeganewtonsPerCentimeter(float x, float y) => new Torque2(x * 10000f, y * 10000f);
    public static Torque2 MeganewtonsPerCentimeter(Vector2 v) => new Torque2(v.x * 10000f, v.y * 10000f);

    public Vector2 ToMeganewtonsPerMeter() => new Vector2(x * 1E-06f, y * 1E-06f);
    public static Torque2 MeganewtonsPerMeter(float x, float y) => new Torque2(x * 1000000f, y * 1000000f);
    public static Torque2 MeganewtonsPerMeter(Vector2 v) => new Torque2(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtonsPerKilometer() => new Vector2(x * 1E-09f, y * 1E-09f);
    public static Torque2 MeganewtonsPerKilometer(float x, float y) => new Torque2(x * 1000000000f, y * 1000000000f);
    public static Torque2 MeganewtonsPerKilometer(Vector2 v) => new Torque2(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerMegameter() => new Vector2(x * 1E-12f, y * 1E-12f);
    public static Torque2 MeganewtonsPerMegameter(float x, float y) => new Torque2(x * 1E+12f, y * 1E+12f);
    public static Torque2 MeganewtonsPerMegameter(Vector2 v) => new Torque2(v.x * 1E+12f, v.y * 1E+12f);

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

    public Force2 Force2(Position2 v) => new(x / v.x, y / v.y);
    public Position2 Position2(Force2 v) => new(x / v.x, y / v.y);

    public Torque2(Force2 a, Position2 b) => a.Torque2(b);
    public Torque2(Position2 b, Force2 a) => a.Torque2(b);

}
}

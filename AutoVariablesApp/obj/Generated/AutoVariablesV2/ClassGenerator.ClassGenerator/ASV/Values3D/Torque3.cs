using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Torque3 : IAutoUnit3 {
    public float x, y, z;
    
    public Torque3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public Torque3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    
    public static implicit operator Vector3(Torque3 v) => new Vector3(v.x, v.y, v.z);
    public Torque magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToMillinewton() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 Millinewton(float x, float y, float z) => new Torque3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 Millinewton(Vector3 v) => new Torque3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToNewton() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Torque3 Newton(float x, float y, float z) => new Torque3(x * 1f, y * 1f, z * 1f);
    public static Torque3 Newton(Vector3 v) => new Torque3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToKilonewton() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 Kilonewton(float x, float y, float z) => new Torque3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 Kilonewton(Vector3 v) => new Torque3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMeganewton() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Torque3 Meganewton(float x, float y, float z) => new Torque3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Torque3 Meganewton(Vector3 v) => new Torque3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMillinewtonsPerFeet() => new Vector3(x * 304.8f, y * 304.8f, z * 304.8f);
    public static Torque3 MillinewtonsPerFeet(float x, float y, float z) => new Torque3(x * 0.003280839895f, y * 0.003280839895f, z * 0.003280839895f);
    public static Torque3 MillinewtonsPerFeet(Vector3 v) => new Torque3(v.x * 0.003280839895f, v.y * 0.003280839895f, v.z * 0.003280839895f);

    public Vector3 ToMillinewtonsPerMile() => new Vector3(x * 0.6213711922f, y * 0.6213711922f, z * 0.6213711922f);
    public static Torque3 MillinewtonsPerMile(float x, float y, float z) => new Torque3(x * 1.609344f, y * 1.609344f, z * 1.609344f);
    public static Torque3 MillinewtonsPerMile(Vector3 v) => new Torque3(v.x * 1.609344f, v.y * 1.609344f, v.z * 1.609344f);

    public Vector3 ToMillinewtonsPerMillimeter() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Torque3 MillinewtonsPerMillimeter(float x, float y, float z) => new Torque3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Torque3 MillinewtonsPerMillimeter(Vector3 v) => new Torque3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToMillinewtonsPerCentimeter() => new Vector3(x * 100000f, y * 100000f, z * 100000f);
    public static Torque3 MillinewtonsPerCentimeter(float x, float y, float z) => new Torque3(x * 1E-05f, y * 1E-05f, z * 1E-05f);
    public static Torque3 MillinewtonsPerCentimeter(Vector3 v) => new Torque3(v.x * 1E-05f, v.y * 1E-05f, v.z * 1E-05f);

    public Vector3 ToMillinewtonsPerMeter() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 MillinewtonsPerMeter(float x, float y, float z) => new Torque3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 MillinewtonsPerMeter(Vector3 v) => new Torque3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillinewtonsPerKilometer() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Torque3 MillinewtonsPerKilometer(float x, float y, float z) => new Torque3(x * 1f, y * 1f, z * 1f);
    public static Torque3 MillinewtonsPerKilometer(Vector3 v) => new Torque3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtonsPerMegameter() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 MillinewtonsPerMegameter(float x, float y, float z) => new Torque3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 MillinewtonsPerMegameter(Vector3 v) => new Torque3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerFeet() => new Vector3(x * 0.3048f, y * 0.3048f, z * 0.3048f);
    public static Torque3 NewtonsPerFeet(float x, float y, float z) => new Torque3(x * 3.280839895f, y * 3.280839895f, z * 3.280839895f);
    public static Torque3 NewtonsPerFeet(Vector3 v) => new Torque3(v.x * 3.280839895f, v.y * 3.280839895f, v.z * 3.280839895f);

    public Vector3 ToNewtonsPerMile() => new Vector3(x * 0.0006213711922f, y * 0.0006213711922f, z * 0.0006213711922f);
    public static Torque3 NewtonsPerMile(float x, float y, float z) => new Torque3(x * 1609.344f, y * 1609.344f, z * 1609.344f);
    public static Torque3 NewtonsPerMile(Vector3 v) => new Torque3(v.x * 1609.344f, v.y * 1609.344f, v.z * 1609.344f);

    public Vector3 ToNewtonsPerMillimeter() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 NewtonsPerMillimeter(float x, float y, float z) => new Torque3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 NewtonsPerMillimeter(Vector3 v) => new Torque3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToNewtonsPerCentimeter() => new Vector3(x * 100f, y * 100f, z * 100f);
    public static Torque3 NewtonsPerCentimeter(float x, float y, float z) => new Torque3(x * 0.01f, y * 0.01f, z * 0.01f);
    public static Torque3 NewtonsPerCentimeter(Vector3 v) => new Torque3(v.x * 0.01f, v.y * 0.01f, v.z * 0.01f);

    public Vector3 ToNewtonsPerMeter() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Torque3 NewtonsPerMeter(float x, float y, float z) => new Torque3(x * 1f, y * 1f, z * 1f);
    public static Torque3 NewtonsPerMeter(Vector3 v) => new Torque3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToNewtonsPerKilometer() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 NewtonsPerKilometer(float x, float y, float z) => new Torque3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 NewtonsPerKilometer(Vector3 v) => new Torque3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerMegameter() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Torque3 NewtonsPerMegameter(float x, float y, float z) => new Torque3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Torque3 NewtonsPerMegameter(Vector3 v) => new Torque3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerFeet() => new Vector3(x * 0.0003048f, y * 0.0003048f, z * 0.0003048f);
    public static Torque3 KilonewtonsPerFeet(float x, float y, float z) => new Torque3(x * 3280.839895f, y * 3280.839895f, z * 3280.839895f);
    public static Torque3 KilonewtonsPerFeet(Vector3 v) => new Torque3(v.x * 3280.839895f, v.y * 3280.839895f, v.z * 3280.839895f);

    public Vector3 ToKilonewtonsPerMile() => new Vector3(x * 6.213711922E-07f, y * 6.213711922E-07f, z * 6.213711922E-07f);
    public static Torque3 KilonewtonsPerMile(float x, float y, float z) => new Torque3(x * 1609344f, y * 1609344f, z * 1609344f);
    public static Torque3 KilonewtonsPerMile(Vector3 v) => new Torque3(v.x * 1609344f, v.y * 1609344f, v.z * 1609344f);

    public Vector3 ToKilonewtonsPerMillimeter() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Torque3 KilonewtonsPerMillimeter(float x, float y, float z) => new Torque3(x * 1f, y * 1f, z * 1f);
    public static Torque3 KilonewtonsPerMillimeter(Vector3 v) => new Torque3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToKilonewtonsPerCentimeter() => new Vector3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static Torque3 KilonewtonsPerCentimeter(float x, float y, float z) => new Torque3(x * 10f, y * 10f, z * 10f);
    public static Torque3 KilonewtonsPerCentimeter(Vector3 v) => new Torque3(v.x * 10f, v.y * 10f, v.z * 10f);

    public Vector3 ToKilonewtonsPerMeter() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 KilonewtonsPerMeter(float x, float y, float z) => new Torque3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 KilonewtonsPerMeter(Vector3 v) => new Torque3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilonewtonsPerKilometer() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Torque3 KilonewtonsPerKilometer(float x, float y, float z) => new Torque3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Torque3 KilonewtonsPerKilometer(Vector3 v) => new Torque3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerMegameter() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Torque3 KilonewtonsPerMegameter(float x, float y, float z) => new Torque3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Torque3 KilonewtonsPerMegameter(Vector3 v) => new Torque3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerFeet() => new Vector3(x * 3.048E-07f, y * 3.048E-07f, z * 3.048E-07f);
    public static Torque3 MeganewtonsPerFeet(float x, float y, float z) => new Torque3(x * 3280839.895f, y * 3280839.895f, z * 3280839.895f);
    public static Torque3 MeganewtonsPerFeet(Vector3 v) => new Torque3(v.x * 3280839.895f, v.y * 3280839.895f, v.z * 3280839.895f);

    public Vector3 ToMeganewtonsPerMile() => new Vector3(x * 6.213711922E-10f, y * 6.213711922E-10f, z * 6.213711922E-10f);
    public static Torque3 MeganewtonsPerMile(float x, float y, float z) => new Torque3(x * 1609344000f, y * 1609344000f, z * 1609344000f);
    public static Torque3 MeganewtonsPerMile(Vector3 v) => new Torque3(v.x * 1609344000f, v.y * 1609344000f, v.z * 1609344000f);

    public Vector3 ToMeganewtonsPerMillimeter() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 MeganewtonsPerMillimeter(float x, float y, float z) => new Torque3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 MeganewtonsPerMillimeter(Vector3 v) => new Torque3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMeganewtonsPerCentimeter() => new Vector3(x * 0.0001f, y * 0.0001f, z * 0.0001f);
    public static Torque3 MeganewtonsPerCentimeter(float x, float y, float z) => new Torque3(x * 10000f, y * 10000f, z * 10000f);
    public static Torque3 MeganewtonsPerCentimeter(Vector3 v) => new Torque3(v.x * 10000f, v.y * 10000f, v.z * 10000f);

    public Vector3 ToMeganewtonsPerMeter() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Torque3 MeganewtonsPerMeter(float x, float y, float z) => new Torque3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Torque3 MeganewtonsPerMeter(Vector3 v) => new Torque3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeganewtonsPerKilometer() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Torque3 MeganewtonsPerKilometer(float x, float y, float z) => new Torque3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Torque3 MeganewtonsPerKilometer(Vector3 v) => new Torque3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerMegameter() => new Vector3(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static Torque3 MeganewtonsPerMegameter(float x, float y, float z) => new Torque3(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static Torque3 MeganewtonsPerMegameter(Vector3 v) => new Torque3(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public static Torque3 operator +(Torque3 a, Torque3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static Torque3 operator -(Torque3 a, Torque3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    
    public static Torque3 operator *(Torque3 a, Torque3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static Torque3 operator /(Torque3 a, Torque3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    
    public AngleAccel3 AngleAccel3(Mass v) => new(x / v, y / v, z / v);
    public Mass Mass(AngleAccel3 v) => new(magnitude / v.magnitude);

    public Torque3(AngleAccel3 a, Mass b) => a.Torque3(b);
    public Torque3(Mass b, AngleAccel3 a) => a.Torque3(b);

    public static Torque3 operator +(TorqueAccel3 a, Torque3 b) => b + a.Torque3(VTime.deltaTime);
    public static Torque3 operator +(Torque3 b, TorqueAccel3 a) => b + a.Torque3(VTime.deltaTime);
    public static Torque3 operator -(TorqueAccel3 a, Torque3 b) => a.Torque3(VTime.deltaTime) - b;
    public static Torque3 operator -(Torque3 b, TorqueAccel3 a) => b - a.Torque3(VTime.deltaTime);
    
    public TorqueAccel3 TorqueAccel3(Time v) => new(x / v, y / v, z / v);
    public Time Time(TorqueAccel3 v) => new(magnitude / v.magnitude);

    public Torque3(TorqueAccel3 a, Time b) => a.Torque3(b);
    public Torque3(Time b, TorqueAccel3 a) => a.Torque3(b);

    public Force3 Force3(Position3 v) => new(x / v.x, y / v.y, z / v.z);
    public Position3 Position3(Force3 v) => new(x / v.x, y / v.y, z / v.z);

    public Torque3(Force3 a, Position3 b) => a.Torque3(b);
    public Torque3(Position3 b, Force3 a) => a.Torque3(b);

}
}

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

    public Vector3 ToFeetsPerMillinewton() => new Vector3(x * 0.0003048f, y * 0.0003048f, z * 0.0003048f);
    public static Torque3 FeetsPerMillinewton(float x, float y, float z) => new Torque3(x * 3280.839895f, y * 3280.839895f, z * 3280.839895f);
    public static Torque3 FeetsPerMillinewton(Vector3 v) => new Torque3(v.x * 3280.839895f, v.y * 3280.839895f, v.z * 3280.839895f);

    public Vector3 ToFeetsPerNewton() => new Vector3(x * 0.3048f, y * 0.3048f, z * 0.3048f);
    public static Torque3 FeetsPerNewton(float x, float y, float z) => new Torque3(x * 3.280839895f, y * 3.280839895f, z * 3.280839895f);
    public static Torque3 FeetsPerNewton(Vector3 v) => new Torque3(v.x * 3.280839895f, v.y * 3.280839895f, v.z * 3.280839895f);

    public Vector3 ToFeetsPerKilonewton() => new Vector3(x * 304.8f, y * 304.8f, z * 304.8f);
    public static Torque3 FeetsPerKilonewton(float x, float y, float z) => new Torque3(x * 0.003280839895f, y * 0.003280839895f, z * 0.003280839895f);
    public static Torque3 FeetsPerKilonewton(Vector3 v) => new Torque3(v.x * 0.003280839895f, v.y * 0.003280839895f, v.z * 0.003280839895f);

    public Vector3 ToFeetsPerMeganewton() => new Vector3(x * 304800f, y * 304800f, z * 304800f);
    public static Torque3 FeetsPerMeganewton(float x, float y, float z) => new Torque3(x * 3.280839895E-06f, y * 3.280839895E-06f, z * 3.280839895E-06f);
    public static Torque3 FeetsPerMeganewton(Vector3 v) => new Torque3(v.x * 3.280839895E-06f, v.y * 3.280839895E-06f, v.z * 3.280839895E-06f);

    public Vector3 ToMilesPerMillinewton() => new Vector3(x * 6.213711922E-07f, y * 6.213711922E-07f, z * 6.213711922E-07f);
    public static Torque3 MilesPerMillinewton(float x, float y, float z) => new Torque3(x * 1609344f, y * 1609344f, z * 1609344f);
    public static Torque3 MilesPerMillinewton(Vector3 v) => new Torque3(v.x * 1609344f, v.y * 1609344f, v.z * 1609344f);

    public Vector3 ToMilesPerNewton() => new Vector3(x * 0.0006213711922f, y * 0.0006213711922f, z * 0.0006213711922f);
    public static Torque3 MilesPerNewton(float x, float y, float z) => new Torque3(x * 1609.344f, y * 1609.344f, z * 1609.344f);
    public static Torque3 MilesPerNewton(Vector3 v) => new Torque3(v.x * 1609.344f, v.y * 1609.344f, v.z * 1609.344f);

    public Vector3 ToMilesPerKilonewton() => new Vector3(x * 0.6213711922f, y * 0.6213711922f, z * 0.6213711922f);
    public static Torque3 MilesPerKilonewton(float x, float y, float z) => new Torque3(x * 1.609344f, y * 1.609344f, z * 1.609344f);
    public static Torque3 MilesPerKilonewton(Vector3 v) => new Torque3(v.x * 1.609344f, v.y * 1.609344f, v.z * 1.609344f);

    public Vector3 ToMilesPerMeganewton() => new Vector3(x * 621.3711922f, y * 621.3711922f, z * 621.3711922f);
    public static Torque3 MilesPerMeganewton(float x, float y, float z) => new Torque3(x * 0.001609344f, y * 0.001609344f, z * 0.001609344f);
    public static Torque3 MilesPerMeganewton(Vector3 v) => new Torque3(v.x * 0.001609344f, v.y * 0.001609344f, v.z * 0.001609344f);

    public Vector3 ToMillimetersPerMillinewton() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Torque3 MillimetersPerMillinewton(float x, float y, float z) => new Torque3(x * 1f, y * 1f, z * 1f);
    public static Torque3 MillimetersPerMillinewton(Vector3 v) => new Torque3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillimetersPerNewton() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 MillimetersPerNewton(float x, float y, float z) => new Torque3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 MillimetersPerNewton(Vector3 v) => new Torque3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillimetersPerKilonewton() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Torque3 MillimetersPerKilonewton(float x, float y, float z) => new Torque3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Torque3 MillimetersPerKilonewton(Vector3 v) => new Torque3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToMillimetersPerMeganewton() => new Vector3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Torque3 MillimetersPerMeganewton(float x, float y, float z) => new Torque3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Torque3 MillimetersPerMeganewton(Vector3 v) => new Torque3(v.x * 1E-09f, v.y * 1E-09f, v.z * 1E-09f);

    public Vector3 ToCentimetersPerMillinewton() => new Vector3(x * 0.1f, y * 0.1f, z * 0.1f);
    public static Torque3 CentimetersPerMillinewton(float x, float y, float z) => new Torque3(x * 10f, y * 10f, z * 10f);
    public static Torque3 CentimetersPerMillinewton(Vector3 v) => new Torque3(v.x * 10f, v.y * 10f, v.z * 10f);

    public Vector3 ToCentimetersPerNewton() => new Vector3(x * 100f, y * 100f, z * 100f);
    public static Torque3 CentimetersPerNewton(float x, float y, float z) => new Torque3(x * 0.01f, y * 0.01f, z * 0.01f);
    public static Torque3 CentimetersPerNewton(Vector3 v) => new Torque3(v.x * 0.01f, v.y * 0.01f, v.z * 0.01f);

    public Vector3 ToCentimetersPerKilonewton() => new Vector3(x * 100000f, y * 100000f, z * 100000f);
    public static Torque3 CentimetersPerKilonewton(float x, float y, float z) => new Torque3(x * 1E-05f, y * 1E-05f, z * 1E-05f);
    public static Torque3 CentimetersPerKilonewton(Vector3 v) => new Torque3(v.x * 1E-05f, v.y * 1E-05f, v.z * 1E-05f);

    public Vector3 ToCentimetersPerMeganewton() => new Vector3(x * 100000000f, y * 100000000f, z * 100000000f);
    public static Torque3 CentimetersPerMeganewton(float x, float y, float z) => new Torque3(x * 1E-08f, y * 1E-08f, z * 1E-08f);
    public static Torque3 CentimetersPerMeganewton(Vector3 v) => new Torque3(v.x * 1E-08f, v.y * 1E-08f, v.z * 1E-08f);

    public Vector3 ToMetersPerMillinewton() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 MetersPerMillinewton(float x, float y, float z) => new Torque3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 MetersPerMillinewton(Vector3 v) => new Torque3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMetersPerNewton() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Torque3 MetersPerNewton(float x, float y, float z) => new Torque3(x * 1f, y * 1f, z * 1f);
    public static Torque3 MetersPerNewton(Vector3 v) => new Torque3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMetersPerKilonewton() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 MetersPerKilonewton(float x, float y, float z) => new Torque3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 MetersPerKilonewton(Vector3 v) => new Torque3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMetersPerMeganewton() => new Vector3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Torque3 MetersPerMeganewton(float x, float y, float z) => new Torque3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Torque3 MetersPerMeganewton(Vector3 v) => new Torque3(v.x * 1E-06f, v.y * 1E-06f, v.z * 1E-06f);

    public Vector3 ToKilometersPerMillinewton() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Torque3 KilometersPerMillinewton(float x, float y, float z) => new Torque3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Torque3 KilometersPerMillinewton(Vector3 v) => new Torque3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilometersPerNewton() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 KilometersPerNewton(float x, float y, float z) => new Torque3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 KilometersPerNewton(Vector3 v) => new Torque3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilometersPerKilonewton() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Torque3 KilometersPerKilonewton(float x, float y, float z) => new Torque3(x * 1f, y * 1f, z * 1f);
    public static Torque3 KilometersPerKilonewton(Vector3 v) => new Torque3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToKilometersPerMeganewton() => new Vector3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 KilometersPerMeganewton(float x, float y, float z) => new Torque3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 KilometersPerMeganewton(Vector3 v) => new Torque3(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMegametersPerMillinewton() => new Vector3(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static Torque3 MegametersPerMillinewton(float x, float y, float z) => new Torque3(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static Torque3 MegametersPerMillinewton(Vector3 v) => new Torque3(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMegametersPerNewton() => new Vector3(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static Torque3 MegametersPerNewton(float x, float y, float z) => new Torque3(x * 1000000f, y * 1000000f, z * 1000000f);
    public static Torque3 MegametersPerNewton(Vector3 v) => new Torque3(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMegametersPerKilonewton() => new Vector3(x * 0.001f, y * 0.001f, z * 0.001f);
    public static Torque3 MegametersPerKilonewton(float x, float y, float z) => new Torque3(x * 1000f, y * 1000f, z * 1000f);
    public static Torque3 MegametersPerKilonewton(Vector3 v) => new Torque3(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMegametersPerMeganewton() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Torque3 MegametersPerMeganewton(float x, float y, float z) => new Torque3(x * 1f, y * 1f, z * 1f);
    public static Torque3 MegametersPerMeganewton(Vector3 v) => new Torque3(v.x * 1f, v.y * 1f, v.z * 1f);

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
    public Force3 Force3(Position v) => new(v.x * x, v.y * y, v.z * z);
    public Position Position(Force3 v) => new(v.x / x, v.y / y, v.z / z);
    public Torque3(Force3 a, Position b) => a.Torque3(b);
    public Torque3(Position b, Force3 a) => a.Torque3(b);
}
}

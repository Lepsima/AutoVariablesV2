using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Angle3 : IAutoUnit3 {
    public float x, y, z;
    
    public Angle3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public Angle3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    
    public static implicit operator Vector3(Angle3 v) => new Vector3(v.x, v.y, v.z);
    public Angle magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));

    public Vector3 ToDegree() => new Vector3(x * 1f, y * 1f, z * 1f);
    public static Angle3 Degree(float x, float y, float z) => new Angle3(x * 1f, y * 1f, z * 1f);
    public static Angle3 Degree(Vector3 v) => new Angle3(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToRadian() => new Vector3(x * 57.29577996f, y * 57.29577996f, z * 57.29577996f);
    public static Angle3 Radian(float x, float y, float z) => new Angle3(x * 0.01745329238f, y * 0.01745329238f, z * 0.01745329238f);
    public static Angle3 Radian(Vector3 v) => new Angle3(v.x * 0.01745329238f, v.y * 0.01745329238f, v.z * 0.01745329238f);

    public Vector3 ToTurn() => new Vector3(x * 0.002777777778f, y * 0.002777777778f, z * 0.002777777778f);
    public static Angle3 Turn(float x, float y, float z) => new Angle3(x * 360f, y * 360f, z * 360f);
    public static Angle3 Turn(Vector3 v) => new Angle3(v.x * 360f, v.y * 360f, v.z * 360f);

    public Vector3 ToMinuteDegree() => new Vector3(x * 60f, y * 60f, z * 60f);
    public static Angle3 MinuteDegree(float x, float y, float z) => new Angle3(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static Angle3 MinuteDegree(Vector3 v) => new Angle3(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToSecondDegree() => new Vector3(x * 3600f, y * 3600f, z * 3600f);
    public static Angle3 SecondDegree(float x, float y, float z) => new Angle3(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static Angle3 SecondDegree(Vector3 v) => new Angle3(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public static Angle3 operator +(Angle3 a, Angle3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static Angle3 operator -(Angle3 a, Angle3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    
    public static Angle3 operator *(Angle3 a, Angle3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static Angle3 operator /(Angle3 a, Angle3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    
    public static Angle3 operator +(AngleVel3 a, Angle3 b) => b + a.Angle3(VTime.deltaTime);
    public static Angle3 operator +(Angle3 b, AngleVel3 a) => b + a.Angle3(VTime.deltaTime);
    public static Angle3 operator -(AngleVel3 a, Angle3 b) => a.Angle3(VTime.deltaTime) - b;
    public static Angle3 operator -(Angle3 b, AngleVel3 a) => b - a.Angle3(VTime.deltaTime);
    
    public AngleVel3 AngleVel3(Time v) => new(x / v, y / v, z / v);
    public Time Time(AngleVel3 v) => new(magnitude / v.magnitude);

    public Angle3(AngleVel3 a, Time b) => a.Angle3(b);
    public Angle3(Time b, AngleVel3 a) => a.Angle3(b);

}
}

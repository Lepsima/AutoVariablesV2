using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Angle2 : IAutoUnit2 {
    public float x, y;
    
    public Angle2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Angle2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;

    public static implicit operator Vector2(Angle2 v) => new Vector2(v.x, v.y);
    public Angle magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToDegree() => new Vector2(x * 1f, y * 1f);
    public static Angle2 Degree(float x, float y) => new Angle2(x * 1f, y * 1f);
    public static Angle2 Degree(Vector2 v) => new Angle2(v.x * 1f, v.y * 1f);

    public Vector2 ToRadian() => new Vector2(x * 57.29577996f, y * 57.29577996f);
    public static Angle2 Radian(float x, float y) => new Angle2(x * 0.01745329238f, y * 0.01745329238f);
    public static Angle2 Radian(Vector2 v) => new Angle2(v.x * 0.01745329238f, v.y * 0.01745329238f);

    public Vector2 ToTurn() => new Vector2(x * 0.002777777778f, y * 0.002777777778f);
    public static Angle2 Turn(float x, float y) => new Angle2(x * 360f, y * 360f);
    public static Angle2 Turn(Vector2 v) => new Angle2(v.x * 360f, v.y * 360f);

    public Vector2 ToMinuteDegree() => new Vector2(x * 60f, y * 60f);
    public static Angle2 MinuteDegree(float x, float y) => new Angle2(x * 0.01666666667f, y * 0.01666666667f);
    public static Angle2 MinuteDegree(Vector2 v) => new Angle2(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToSecondDegree() => new Vector2(x * 3600f, y * 3600f);
    public static Angle2 SecondDegree(float x, float y) => new Angle2(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Angle2 SecondDegree(Vector2 v) => new Angle2(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public static Angle2 operator +(Angle2 a, Angle2 b) => new(a.x + b.x, a.y + b.y);
    public static Angle2 operator -(Angle2 a, Angle2 b) => new(a.x - b.x, a.y - b.y);
    
    public static Angle2 operator *(Angle2 a, Angle2 b) => new(a.x * b.x, a.y * b.y);
    public static Angle2 operator /(Angle2 a, Angle2 b) => new(a.x / b.x, a.y / b.y);
    
    public static Angle2 operator +(AngleVel2 a, Angle2 b) => b + a.Angle2(VTime.deltaTime);
    public static Angle2 operator +(Angle2 b, AngleVel2 a) => b + a.Angle2(VTime.deltaTime);
    public static Angle2 operator -(AngleVel2 a, Angle2 b) => a.Angle2(VTime.deltaTime) - b;
    public static Angle2 operator -(Angle2 b, AngleVel2 a) => b - a.Angle2(VTime.deltaTime);
    
    public AngleVel2 AngleVel2(Time v) => new(x / v, y / v);
    public Time Time(AngleVel2 v) => new(magnitude / v.magnitude);

    public Angle2(AngleVel2 a, Time b) => a.Angle2(b);
    public Angle2(Time b, AngleVel2 a) => a.Angle2(b);

}
}

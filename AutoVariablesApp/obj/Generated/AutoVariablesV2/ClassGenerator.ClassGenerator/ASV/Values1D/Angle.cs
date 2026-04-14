using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Angle : IAutoUnit {
    public float x;
    
    public Angle(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(Angle v) => v.x;
    public Angle magnitude => new(x);

    public float ToDegree() => x * 1f;
    public static Angle Degree(float x) => new Angle(x * 1f);

    public float ToRadian() => x * 57.29577996f;
    public static Angle Radian(float x) => new Angle(x * 0.01745329238f);

    public float ToTurn() => x * 0.002777777778f;
    public static Angle Turn(float x) => new Angle(x * 360f);

    public float ToMinuteDegree() => x * 60f;
    public static Angle MinuteDegree(float x) => new Angle(x * 0.01666666667f);

    public float ToSecondDegree() => x * 3600f;
    public static Angle SecondDegree(float x) => new Angle(x * 0.0002777777778f);

    public static Angle operator +(Angle a, Angle b) => new(a.x + b.x);
    public static Angle operator -(Angle a, Angle b) => new(a.x - b.x);
    
    public static Angle operator *(Angle a, Angle b) => new(a.x * b.x);
    public static Angle operator /(Angle a, Angle b) => new(a.x / b.x);
    
    public static Angle operator +(AngleVel a, Angle b) => b + a.Angle(VTime.deltaTime);
    public static Angle operator +(Angle b, AngleVel a) => b + a.Angle(VTime.deltaTime);
    public static Angle operator -(AngleVel a, Angle b) => a.Angle(VTime.deltaTime) - b;
    public static Angle operator -(Angle b, AngleVel a) => b - a.Angle(VTime.deltaTime);
    
    public AngleVel AngleVel(Time v) => new(x / v);
    public Time Time(AngleVel v) => new(x / v);

    public Angle(AngleVel a, Time b) => a.Angle(b);
    public Angle(Time b, AngleVel a) => a.Angle(b);

}
}

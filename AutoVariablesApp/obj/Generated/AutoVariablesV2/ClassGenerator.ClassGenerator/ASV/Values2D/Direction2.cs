using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Direction2 : IAutoUnit2 {
    public float x, y;
    
    public Direction2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Direction2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;

    public static implicit operator Vector2(Direction2 v) => new Vector2(v.x, v.y);
    public Direction magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));

    public Vector2 ToNormal() => new Vector2(x * 1f, y * 1f);
    public static Direction2 Normal(float x, float y) => new Direction2(x * 1f, y * 1f);
    public static Direction2 Normal(Vector2 v) => new Direction2(v.x * 1f, v.y * 1f);

    public static Direction2 operator +(Direction2 a, Direction2 b) => new(a.x + b.x, a.y + b.y);
    public static Direction2 operator -(Direction2 a, Direction2 b) => new(a.x - b.x, a.y - b.y);
    public static Direction2 operator *(Direction2 a, Direction2 b) => new(a.x * b.x, a.y * b.y);
    public static Direction2 operator /(Direction2 a, Direction2 b) => new(a.x / b.x, a.y / b.y);
}
}

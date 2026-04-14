using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Direction : IAutoUnit {
    public float x;
    
    public Direction(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(Direction v) => v.x;
    public Direction magnitude => new(x);

    public float ToNormal() => x * 1f;
    public static Direction Normal(float x) => new Direction(x * 1f);

    public static Direction operator +(Direction a, Direction b) => new(a.x + b.x);
    public static Direction operator -(Direction a, Direction b) => new(a.x - b.x);
    public static Direction operator *(Direction a, Direction b) => new(a.x * b.x);
    public static Direction operator /(Direction a, Direction b) => new(a.x / b.x);
}
}

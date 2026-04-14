using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct PositionUI : IAutoUnitUI {
    public float x;
    public PositionUIType type;
    
    public Position Value => this;
    
    public PositionUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(PositionUI v) => v.x;
    public static implicit operator Position(PositionUI v) => new(v.x);
    public Position magnitude => new(x);
}

[System.Serializable]
public struct Position2UI : IAutoUnitUI2 {
    public float x, y;
    public PositionUIType type;
    
    public Position2 Value => this;
    
    public Position2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Position2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(Position2UI v) => new(v.x, v.y);
    public static implicit operator Position2(Position2UI v) => new(v.x, v.y);
    public Position magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct Position3UI : IAutoUnitUI3 {
    public float x, y, z;
    public PositionUIType type;
    
    public Position3 Value => this;
    
    public Position3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Position3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(Position3UI v) => new(v.x, v.y, v.z);
    public static implicit operator Position3(Position3UI v) => new(v.x, v.y, v.z);
    public Position magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum PositionUIType {
    [InspectorName("ft")]
    Feet,
    [InspectorName("mi")]
    Mile,
    [InspectorName("cm")]
    Centimeter,
    [InspectorName("m")]
    Meter,
    [InspectorName("km")]
    Kilometer,

}
}

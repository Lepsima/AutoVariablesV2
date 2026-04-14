using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AngleVelUI : IAutoUnitUI {
    public float x;
    public AngleVelUIType type;
    
    public AngleVel Value => this;
    
    public AngleVelUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(AngleVelUI v) => v.x;
    public static implicit operator AngleVel(AngleVelUI v) => new(v.x);
    public AngleVel magnitude => new(x);
}

[System.Serializable]
public struct AngleVel2UI : IAutoUnitUI2 {
    public float x, y;
    public AngleVelUIType type;
    
    public AngleVel2 Value => this;
    
    public AngleVel2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public AngleVel2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(AngleVel2UI v) => new(v.x, v.y);
    public static implicit operator AngleVel2(AngleVel2UI v) => new(v.x, v.y);
    public AngleVel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct AngleVel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public AngleVelUIType type;
    
    public AngleVel3 Value => this;
    
    public AngleVel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public AngleVel3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(AngleVel3UI v) => new(v.x, v.y, v.z);
    public static implicit operator AngleVel3(AngleVel3UI v) => new(v.x, v.y, v.z);
    public AngleVel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum AngleVelUIType {
    [InspectorName("deg/s")]
    DegreesPerSecond,
    [InspectorName("deg/m")]
    DegreesPerMinute,
    [InspectorName("rad/s")]
    RadiansPerSecond,
    [InspectorName("rad/m")]
    RadiansPerMinute,

}
}

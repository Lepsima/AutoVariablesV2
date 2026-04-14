using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AngleVel_UI : IAutoUnitUI {
    public float x;
    public AngleVel_UIType type;
    
    public AngleVel Value => this;
    
    public AngleVel_UI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(AngleVel_UI v) => v.x;
    public static implicit operator AngleVel(AngleVel_UI v) => new(v.x);
    public AngleVel magnitude => new(x);
}

[System.Serializable]
public struct AngleVel2_UI : IAutoUnitUI2 {
    public float x, y;
    public AngleVel_UIType type;
    
    public AngleVel2 Value => this;
    
    public AngleVel2_UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public AngleVel2_UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(AngleVel2_UI v) => new(v.x, v.y);
    public static implicit operator AngleVel2(AngleVel2_UI v) => new(v.x, v.y);
    public AngleVel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct AngleVel3_UI : IAutoUnitUI3 {
    public float x, y, z;
    public AngleVel_UIType type;
    
    public AngleVel3 Value => this;
    
    public AngleVel3_UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public AngleVel3_UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(AngleVel3_UI v) => new(v.x, v.y, v.z);
    public static implicit operator AngleVel3(AngleVel3_UI v) => new(v.x, v.y, v.z);
    public AngleVel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum AngleVel_UIType {
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

using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AngleUI : IAutoUnitUI {
    public float x;
    public AngleUIType type;
    
    public Angle Value => this;
    
    public AngleUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(AngleUI v) => v.x;
    public static implicit operator Angle(AngleUI v) => new(v.x);
    public Angle magnitude => new(x);
}

[System.Serializable]
public struct Angle2UI : IAutoUnitUI2 {
    public float x, y;
    public AngleUIType type;
    
    public Angle2 Value => this;
    
    public Angle2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Angle2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(Angle2UI v) => new(v.x, v.y);
    public static implicit operator Angle2(Angle2UI v) => new(v.x, v.y);
    public Angle magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct Angle3UI : IAutoUnitUI3 {
    public float x, y, z;
    public AngleUIType type;
    
    public Angle3 Value => this;
    
    public Angle3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Angle3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(Angle3UI v) => new(v.x, v.y, v.z);
    public static implicit operator Angle3(Angle3UI v) => new(v.x, v.y, v.z);
    public Angle magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum AngleUIType {
    [InspectorName("deg")]
    Degree,
    [InspectorName("rad")]
    Radian,

}
}

using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct Angle_UI : IAutoUnitUI {
    public float x;
    public Angle_UIType type;
    
    public Angle Value => this;
    
    public Angle_UI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(Angle_UI v) => v.x;
    public static implicit operator Angle(Angle_UI v) => new(v.x);
    public Angle magnitude => new(x);
}

[System.Serializable]
public struct Angle2_UI : IAutoUnitUI2 {
    public float x, y;
    public Angle_UIType type;
    
    public Angle2 Value => this;
    
    public Angle2_UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Angle2_UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(Angle2_UI v) => new(v.x, v.y);
    public static implicit operator Angle2(Angle2_UI v) => new(v.x, v.y);
    public Angle magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct Angle3_UI : IAutoUnitUI3 {
    public float x, y, z;
    public Angle_UIType type;
    
    public Angle3 Value => this;
    
    public Angle3_UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Angle3_UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(Angle3_UI v) => new(v.x, v.y, v.z);
    public static implicit operator Angle3(Angle3_UI v) => new(v.x, v.y, v.z);
    public Angle magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum Angle_UIType {
    [InspectorName("deg")]
    Degree,
    [InspectorName("rad")]
    Radian,

}
}

using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AngleAccel_UI : IAutoUnitUI {
    public float x;
    public AngleAccel_UIType type;
    
    public AngleAccel Value => this;
    
    public AngleAccel_UI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(AngleAccel_UI v) => v.x;
    public static implicit operator AngleAccel(AngleAccel_UI v) => new(v.x);
    public AngleAccel magnitude => new(x);
}

[System.Serializable]
public struct AngleAccel2_UI : IAutoUnitUI2 {
    public float x, y;
    public AngleAccel_UIType type;
    
    public AngleAccel2 Value => this;
    
    public AngleAccel2_UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public AngleAccel2_UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(AngleAccel2_UI v) => new(v.x, v.y);
    public static implicit operator AngleAccel2(AngleAccel2_UI v) => new(v.x, v.y);
    public AngleAccel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct AngleAccel3_UI : IAutoUnitUI3 {
    public float x, y, z;
    public AngleAccel_UIType type;
    
    public AngleAccel3 Value => this;
    
    public AngleAccel3_UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public AngleAccel3_UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(AngleAccel3_UI v) => new(v.x, v.y, v.z);
    public static implicit operator AngleAccel3(AngleAccel3_UI v) => new(v.x, v.y, v.z);
    public AngleAccel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum AngleAccel_UIType {

}
}

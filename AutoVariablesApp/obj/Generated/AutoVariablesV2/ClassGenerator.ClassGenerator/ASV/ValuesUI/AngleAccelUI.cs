using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AngleAccelUI : IAutoUnitUI {
    public float x;
    public AngleAccelUIType type;
    
    public AngleAccel Value => this;
    
    public AngleAccelUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(AngleAccelUI v) => v.x;
    public static implicit operator AngleAccel(AngleAccelUI v) => new(v.x);
    public AngleAccel magnitude => new(x);
}

[System.Serializable]
public struct AngleAccel2UI : IAutoUnitUI2 {
    public float x, y;
    public AngleAccelUIType type;
    
    public AngleAccel2 Value => this;
    
    public AngleAccel2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public AngleAccel2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(AngleAccel2UI v) => new(v.x, v.y);
    public static implicit operator AngleAccel2(AngleAccel2UI v) => new(v.x, v.y);
    public AngleAccel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct AngleAccel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public AngleAccelUIType type;
    
    public AngleAccel3 Value => this;
    
    public AngleAccel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public AngleAccel3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(AngleAccel3UI v) => new(v.x, v.y, v.z);
    public static implicit operator AngleAccel3(AngleAccel3UI v) => new(v.x, v.y, v.z);
    public AngleAccel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum AngleAccelUIType {

}
}

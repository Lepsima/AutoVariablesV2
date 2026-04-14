using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AccelUI : IAutoUnitUI {
    public float x;
    public AccelUIType type;
    
    public Accel Value => this;
    
    public AccelUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(AccelUI v) => v.x;
    public static implicit operator Accel(AccelUI v) => new(v.x);
    public Accel magnitude => new(x);
}

[System.Serializable]
public struct Accel2UI : IAutoUnitUI2 {
    public float x, y;
    public AccelUIType type;
    
    public Accel2 Value => this;
    
    public Accel2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Accel2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(Accel2UI v) => new(v.x, v.y);
    public static implicit operator Accel2(Accel2UI v) => new(v.x, v.y);
    public Accel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct Accel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public AccelUIType type;
    
    public Accel3 Value => this;
    
    public Accel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Accel3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(Accel3UI v) => new(v.x, v.y, v.z);
    public static implicit operator Accel3(Accel3UI v) => new(v.x, v.y, v.z);
    public Accel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum AccelUIType {

}
}

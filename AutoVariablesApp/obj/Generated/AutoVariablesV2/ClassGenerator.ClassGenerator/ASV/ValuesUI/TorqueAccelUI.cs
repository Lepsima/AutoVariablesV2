using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct TorqueAccelUI : IAutoUnitUI {
    public float x;
    public TorqueAccelUIType type;
    
    public TorqueAccel Value => this;
    
    public TorqueAccelUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(TorqueAccelUI v) => v.x;
    public static implicit operator TorqueAccel(TorqueAccelUI v) => new(v.x);
    public TorqueAccel magnitude => new(x);
}

[System.Serializable]
public struct TorqueAccel2UI : IAutoUnitUI2 {
    public float x, y;
    public TorqueAccelUIType type;
    
    public TorqueAccel2 Value => this;
    
    public TorqueAccel2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public TorqueAccel2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(TorqueAccel2UI v) => new(v.x, v.y);
    public static implicit operator TorqueAccel2(TorqueAccel2UI v) => new(v.x, v.y);
    public TorqueAccel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct TorqueAccel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public TorqueAccelUIType type;
    
    public TorqueAccel3 Value => this;
    
    public TorqueAccel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public TorqueAccel3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(TorqueAccel3UI v) => new(v.x, v.y, v.z);
    public static implicit operator TorqueAccel3(TorqueAccel3UI v) => new(v.x, v.y, v.z);
    public TorqueAccel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum TorqueAccelUIType {

}
}

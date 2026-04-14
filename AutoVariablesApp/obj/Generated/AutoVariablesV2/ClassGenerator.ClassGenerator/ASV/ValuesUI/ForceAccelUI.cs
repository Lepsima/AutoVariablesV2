using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct ForceAccelUI : IAutoUnitUI {
    public float x;
    public ForceAccelUIType type;
    
    public ForceAccel Value => this;
    
    public ForceAccelUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(ForceAccelUI v) => v.x;
    public static implicit operator ForceAccel(ForceAccelUI v) => new(v.x);
    public ForceAccel magnitude => new(x);
}

[System.Serializable]
public struct ForceAccel2UI : IAutoUnitUI2 {
    public float x, y;
    public ForceAccelUIType type;
    
    public ForceAccel2 Value => this;
    
    public ForceAccel2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public ForceAccel2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(ForceAccel2UI v) => new(v.x, v.y);
    public static implicit operator ForceAccel2(ForceAccel2UI v) => new(v.x, v.y);
    public ForceAccel magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct ForceAccel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public ForceAccelUIType type;
    
    public ForceAccel3 Value => this;
    
    public ForceAccel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public ForceAccel3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(ForceAccel3UI v) => new(v.x, v.y, v.z);
    public static implicit operator ForceAccel3(ForceAccel3UI v) => new(v.x, v.y, v.z);
    public ForceAccel magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum ForceAccelUIType {
    [InspectorName("N/s")]
    NewtonsPerSecond,
    [InspectorName("kN/s")]
    KilonewtonsPerSecond,

}
}

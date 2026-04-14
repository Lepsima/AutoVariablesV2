using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct TorqueUI : IAutoUnitUI {
    public float x;
    public TorqueUIType type;
    
    public Torque Value => this;
    
    public TorqueUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(TorqueUI v) => v.x;
    public static implicit operator Torque(TorqueUI v) => new(v.x);
    public Torque magnitude => new(x);
}

[System.Serializable]
public struct Torque2UI : IAutoUnitUI2 {
    public float x, y;
    public TorqueUIType type;
    
    public Torque2 Value => this;
    
    public Torque2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Torque2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(Torque2UI v) => new(v.x, v.y);
    public static implicit operator Torque2(Torque2UI v) => new(v.x, v.y);
    public Torque magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct Torque3UI : IAutoUnitUI3 {
    public float x, y, z;
    public TorqueUIType type;
    
    public Torque3 Value => this;
    
    public Torque3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Torque3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(Torque3UI v) => new(v.x, v.y, v.z);
    public static implicit operator Torque3(Torque3UI v) => new(v.x, v.y, v.z);
    public Torque magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum TorqueUIType {

}
}

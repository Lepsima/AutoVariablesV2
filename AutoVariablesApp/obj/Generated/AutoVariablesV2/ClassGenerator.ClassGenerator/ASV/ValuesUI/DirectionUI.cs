using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct Direction2UI : IAutoUnitUI2 {
    public float x, y;
    public DirectionUIType type;
    
    public Direction2 Value => this;
    
    public Direction2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Direction2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(Direction2UI v) => new(v.x, v.y);
    public static implicit operator Direction2(Direction2UI v) => new(v.x, v.y);
    public Magnitude magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct Direction3UI : IAutoUnitUI3 {
    public float x, y, z;
    public DirectionUIType type;
    
    public Direction3 Value => this;
    
    public Direction3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Direction3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(Direction3UI v) => new(v.x, v.y, v.z);
    public static implicit operator Direction3(Direction3UI v) => new(v.x, v.y, v.z);
    public Magnitude magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum DirectionUIType {
    [InspectorName("dir")]
    Normal,

}
}

using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct Direction_UI : IAutoUnitUI {
    public float x;
    public Direction_UIType type;
    
    public Direction Value => this;
    
    public Direction_UI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(Direction_UI v) => v.x;
    public static implicit operator Direction(Direction_UI v) => new(v.x);
    public Direction magnitude => new(x);
}

[System.Serializable]
public struct Direction2_UI : IAutoUnitUI2 {
    public float x, y;
    public Direction_UIType type;
    
    public Direction2 Value => this;
    
    public Direction2_UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Direction2_UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(Direction2_UI v) => new(v.x, v.y);
    public static implicit operator Direction2(Direction2_UI v) => new(v.x, v.y);
    public Direction magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct Direction3_UI : IAutoUnitUI3 {
    public float x, y, z;
    public Direction_UIType type;
    
    public Direction3 Value => this;
    
    public Direction3_UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Direction3_UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(Direction3_UI v) => new(v.x, v.y, v.z);
    public static implicit operator Direction3(Direction3_UI v) => new(v.x, v.y, v.z);
    public Direction magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum Direction_UIType {
    [InspectorName("dir")]
    Normal,

}
}

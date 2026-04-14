using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct VelocityUI : IAutoUnitUI {
    public float x;
    public VelocityUIType type;
    
    public Velocity Value => this;
    
    public VelocityUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(VelocityUI v) => v.x;
    public static implicit operator Velocity(VelocityUI v) => new(v.x);
    public Velocity magnitude => new(x);
}

[System.Serializable]
public struct Velocity2UI : IAutoUnitUI2 {
    public float x, y;
    public VelocityUIType type;
    
    public Velocity2 Value => this;
    
    public Velocity2UI(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Velocity2UI(Vector2 v2) {
      x = v2.x;
      y = v2.y;
    }
  
    public static implicit operator Vector2(Velocity2UI v) => new(v.x, v.y);
    public static implicit operator Velocity2(Velocity2UI v) => new(v.x, v.y);
    public Velocity magnitude => new((float)Math.Sqrt((double)x * x + (double)y * y));
}

[System.Serializable]
public struct Velocity3UI : IAutoUnitUI3 {
    public float x, y, z;
    public VelocityUIType type;
    
    public Velocity3 Value => this;
    
    public Velocity3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Velocity3UI(Vector3 v3) {
      x = v3.x;
      y = v3.y;
      z = v3.z;
    }

    public static implicit operator Vector3(Velocity3UI v) => new(v.x, v.y, v.z);
    public static implicit operator Velocity3(Velocity3UI v) => new(v.x, v.y, v.z);
    public Velocity magnitude => new((float)Math.Sqrt((double)x*x + (double)y*y + (double)z*z));
}

public enum VelocityUIType {
    [InspectorName("m/s")]
    MetersPerSecond,
    [InspectorName("km/h")]
    KilometersPerHour,
    [InspectorName("ft/s")]
    FeetsPerSecond,
    [InspectorName("mi/h")]
    MilesPerHour,

}
}

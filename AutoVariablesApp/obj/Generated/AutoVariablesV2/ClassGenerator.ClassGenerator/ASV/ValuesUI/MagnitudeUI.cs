using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct MagnitudeUI : IAutoUnitUI {
    public float x;
    public MagnitudeUIType type;
    
    public Magnitude Value => this;
    
    public MagnitudeUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(MagnitudeUI v) => v.x;
    public static implicit operator Magnitude(MagnitudeUI v) => new(v.x);
    public Magnitude magnitude => new(x);
}


public enum MagnitudeUIType {
    [InspectorName("mag")]
    Number,

}
}

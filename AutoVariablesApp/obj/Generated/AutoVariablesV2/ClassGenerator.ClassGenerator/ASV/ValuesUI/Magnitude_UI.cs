using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct Magnitude_UI : IAutoUnitUI {
    public float x;
    public Magnitude_UIType type;
    
    public Magnitude Value => this;
    
    public Magnitude_UI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(Magnitude_UI v) => v.x;
    public static implicit operator Magnitude(Magnitude_UI v) => new(v.x);
    public Magnitude magnitude => new(x);
}

public enum Magnitude_UIType {
    [InspectorName("mag")]
    Number,

}
}

using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct MassUI : IAutoUnitUI {
    public float x;
    public MassUIType type;
    
    public Mass Value => this;
    
    public MassUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(MassUI v) => v.x;
    public static implicit operator Mass(MassUI v) => new(v.x);
    public Mass magnitude => new(x);
}


public enum MassUIType {
    [InspectorName("g")]
    Gram,
    [InspectorName("kg")]
    Kilogram,
    [InspectorName("t")]
    Ton,

}
}

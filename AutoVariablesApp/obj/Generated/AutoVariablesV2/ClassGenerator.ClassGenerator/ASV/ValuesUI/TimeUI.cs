using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct TimeUI : IAutoUnitUI {
    public float x;
    public TimeUIType type;
    
    public Time Value => this;
    
    public TimeUI(float x) {
        this.x = x;
    }
    
    public static implicit operator float(TimeUI v) => v.x;
    public static implicit operator Time(TimeUI v) => new(v.x);
    public Time magnitude => new(x);
}


public enum TimeUIType {
    [InspectorName("ms")]
    Millisecond,
    [InspectorName("s")]
    Second,
    [InspectorName("m")]
    Minute,
    [InspectorName("h")]
    Hour,

}
}

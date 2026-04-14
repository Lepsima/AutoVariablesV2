
using System.Collections.Generic;
using System.Linq;

namespace ClassGenerator {
public class UnitInfo(string name, string standardUnit, int dimensions) {
	public string name = name;
	public string standardUnit = standardUnit;
	public int dimensions = dimensions;
		
	public List<string> inspectorUnits = [];
	public List<string> compoundInputs = [];
	public List<(string, string)> conversions = [];
	public List<(string, string, double)> scales = [];
	
	public string unitName = "";
	public List<(string, bool, string)> conversionData = [];
	

	public void Init() {
		if (scales.Count > 0) {
			unitName = GetScaleName(standardUnit);
		}
		else if (compoundInputs.Count > 0 ) {
			string[] parts = compoundInputs[0].Split(' ');
			unitName = GetInfo(parts[0]).unitName + GetInfo(parts[2]).unitName;
		}
		
		foreach ((string a, string b) in conversions) {
			AddConversion(a, true, b);
			GetInfo(a).AddConversion(name, false, b);
			GetInfo(b).AddConversion(name, false, a);
		}

		foreach (string[] parts in compoundInputs.Select(str => str.Split(' '))) {
			AddComplexInput(parts[0], parts[1] == "*", parts[2]);
		}
	}

	public static UnitInfo GetInfo(string name) {
		return ClassGenerator.units[name];
	}

	public string GetScaleName(string unit) {
		return scales.FirstOrDefault(t => t.Item1 == unit).Item2;
	}
	
	public string GetName(int dim) {
		return name + ClassGenerator.GetVectorFloatDimension(dim);
	}

	public void AddComplexInput(string a, bool isMultiplication, string b) {
		List<(string, string, double)> scalesA = GetInfo(a).GetScales();
		List<(string, string, double)> scalesB = GetInfo(b).GetScales();
		List<(string, string, double)> newScales = [];

		foreach ((string unitA, string nameA, double valueA) in scalesA) {
			foreach ((string unitB, string nameB, double valueB) in scalesB) {
				double scale = isMultiplication 
					? valueA * valueB 
					: valueA / valueB;

				string symbol = isMultiplication ? "*" : "/";
				string unit = $"{unitA}{symbol}{unitB}";
				string unitFull = nameA.EndsWith(nameB) ? nameA + "2" : $"{nameA}sPer{nameB}";
					
				newScales.Add((unit, unitFull, scale));
			}	
		}
			
		AddScales(newScales);
	}

	public bool IsSpecialUnit() { 
		return name.Equals("Magnitude") || name.Equals("Direction");
	}

	private List<(string, string, double)> GetScales() {
		return scales.Count > 0 ? scales : [(standardUnit, unitName, 1f)];
	}

	private void AddConversion(string a, bool isMultiplication, string b) {
		if (!conversionData.Contains((a, isMultiplication, b))) {
			conversionData.Add((a, isMultiplication, b));
		}
	}

	private void AddScales(List<(string, string, double)> newScales) {
		scales.AddRange(newScales);
	}
}
}
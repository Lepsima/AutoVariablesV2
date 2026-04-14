using System;
using Lepsima.ASV;

namespace Lepsima.ASV {
internal abstract class Program {
	private static void Main() {
		Position3 pos = Position3.Centimeter(10, 5, 12);
		Velocity3 vel = new(1, 2, 3);
		Accel3 accel = new(1, 5, 2);
		Accel a = new(1);
		
		pos = pos + vel;
		vel = vel + accel;

		Position distance = Position.Millimeter(62_865);
		float km = distance.ToKilometer();
	}
}
}

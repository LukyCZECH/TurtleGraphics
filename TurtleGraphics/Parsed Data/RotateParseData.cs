﻿using System;
using System.Threading.Tasks;

namespace TurtleGraphics {
	public class RotateParseData : ParsedData {

		private readonly MainWindow _window;

		public RotateParseData(MainWindow w) {
			_window = w;
		}

		public double Angle { get; set; }

		public override Task Execute() {
			Angle = Convert.ToDouble(Exp.Evaluate());
			_window.Rotate(Angle);
			return Task.CompletedTask;
		}
	}
}

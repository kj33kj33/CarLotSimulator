﻿using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
			CarLot.numberOfCars++;
		}

		public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
		{
			Year = year;
			Make = make;
			Model = model;
			EngineNoise = engineNoise;
			HonkNoise = honkNoise;
			IsDriveable = isDriveable;
            CarLot.numberOfCars++;
        }

        public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDriveable { get; set; }

		public void MakeEngineNoise()
		{
			Console.WriteLine($"The {Make} {Model}'s engine sounds like '{EngineNoise}'");
		}
		public void MakeHonkNoise()
		{
			Console.WriteLine($"The horn on this {Year} {Make} {Model} sounds like '{HonkNoise}'");
		}
		public void print()
		{
			Console.WriteLine("C#");
		}
	}
}


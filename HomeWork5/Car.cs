﻿using System.Collections.Generic;

namespace HomeWork5
{
    public class Car : Detail
    {
        public List<Detail> Details { get; private set; }
        public string Model { get; private set; }
        public override int Weight { get; set; }
        public override string Name { get; set; }

        public Car(int countDoors, int countWheels, string model)
        {
            Details = new List<Detail>();

            for (int i = 0; i < countDoors; i++)
            {
                Details.Add(new Door(i, this));
            }

            for (int i = 0; i < countWheels; i++)
            {
                Details.Add(new Wheel(i, this));
            }

            Details.Add(new Body(this));

            this.Model = model ?? string.Empty;
        }
    }
}

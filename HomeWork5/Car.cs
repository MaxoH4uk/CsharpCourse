using System.Collections.Generic;

namespace HomeWork5
{
    class Car : Detail
    {
        private uint _doorsCount { get; set; }
        private uint _wheelsCount { get; set; }
        private uint _doorNumber { get; set; }
        private string _carName { get; set; }
        private List<object> obj = new List<object>();

        public Car(uint doorsCount, uint wheelsCount, uint doorNumber, string carName)
        {
            _doorsCount = doorsCount;
            _wheelsCount = wheelsCount;
            _doorNumber = doorNumber;
            _carName = carName;
            if (Form1.buttonIsPressed == "Move")
            {
                for (uint i = 1; i <= wheelsCount; i++)
                {
                    Wheel whl = new Wheel(i);
                    obj.Add(whl);
                    whl.Move(_carName);
                }
                Body body = new Body();
                obj.Add(body);
                body.Move(_carName);
            }
            if (Form1.buttonIsPressed == "Open")
            {
                if(doorNumber == 0)
                {
                    Body body = new Body();
                    body.Open(_carName);
                }
                else
                {
                    Door dr = new Door(doorNumber);
                    obj.Add(dr);
                    dr.Open(_carName);
                }                
            }            
        }        

        public override string Name
        {
            get; set;
        }

        public override float Weight
        {
            get; set;
        }

        public string Model
        {
            set
            {
                _carName = value;
            }
        }
    }
}

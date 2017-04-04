namespace HomeWork5
{
    class Wheel : Detail, IRotatable
    {
        private uint _number { get; set; }

        public Wheel(uint number) 
            
        {
            _number = number;
        }

        public void Move(string model)
        {
            Form1.main.Status = ($"Колесо №{Number} машины {model} вращается");
        }

        public override float Weight { get; set; }

        public override string Name { get; set; }

        public uint Number
        {
            get
            {
                return _number;
            }            
        }
    }
}

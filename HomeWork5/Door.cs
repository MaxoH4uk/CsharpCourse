namespace HomeWork5
{
    class Door : Detail, IDoor
    {
        private uint _number;

        public Door(uint number)
        {
            _number = number;
        }

        public void Open(string model)
        {            
            if (!Form1.isOpenedDoor[(int)(Number - 1)])
            {
                Form1.main.Status = ($"Дверь №{Number} машины {model} открыта");
                Form1.isOpenedDoor[(int)(Number - 1)] = true;
            }
            else
            {
                Form1.main.Status = ($"Дверь №{_number} машины {model} закрыта");
                Form1.isOpenedDoor[(int)(Number - 1)] = false;
            }
            
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

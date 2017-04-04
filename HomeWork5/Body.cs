namespace HomeWork5
{
    class Body : Detail, IRotatable, IDoor
    {
        public void Open(string model)
        {
            Form1.main.Status = ("Увы, это не дверь");
        }

        public void Move(string model)
        {
            Form1.main.Status = ($"Машина {model} едет");

        }

        public override float Weight { get; set; }

        public override string Name { get; set; }
    }
}

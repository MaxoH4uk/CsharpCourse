namespace HomeWork7
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Human(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}

namespace HomeWork7
{
    public abstract class Human
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Human(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}

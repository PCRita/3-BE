namespace E03_InterfacePerson_v2
{

    internal class Itern:Employee
    {
        #region Properties
        public string IntershipHours { get; set; }
        #endregion

        #region Methods
        public string ListIntershipHours(string intershiphours)
        {
            IntershipHours = intershiphours;
            System.Console.WriteLine($"O estagiario realizou {IntershipHours} horas de estagio. ");
            return IntershipHours;
        }
        #endregion

    }
}
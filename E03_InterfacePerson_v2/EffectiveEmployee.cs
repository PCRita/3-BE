using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_InterfacePerson_v2
{

    class EffectiveEmployee: Employee
    {
        #region Properties
        public string WorkedHours { get; set; }
        public string Vacancies { get; set; }
        #endregion

        #region Properties
        
        public string ListWorkedHours(string workedhours)
        {
            WorkedHours = workedhours;
            Console.WriteLine($"O funcionario trabalhou {WorkedHours} horas. ");
            return WorkedHours;
        }

        public string ListVancacies(string vacancies)
        {
            Vacancies = vacancies;
            Console.WriteLine($"O funcionario tem direito {Vacancies}. ");
            return Vacancies;
        }
        #endregion
    }
    
}

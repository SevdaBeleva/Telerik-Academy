using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesI
{
  public class Teachers : People     // Teachers inherits people
    {
        private List<Disciplines> listDisciplines;      // Define field list of disciplines

        public List<Disciplines> ListDisciplines       // Deifne properties for list of disciplines
        {
            get { return this.listDisciplines; }
            set { this.listDisciplines = value; }
        }

        public Teachers(string name, string textBox, List<Disciplines> listDisciplines)   // Constructor using optional text box
            : base(name, textBox)
        {
            this.listDisciplines = listDisciplines;
        }
        public Teachers(string name, List<Disciplines> listDisciplines)            // Constructor without optional text box 
            : base(name)
        {
            this.listDisciplines = listDisciplines;
        }

        public override string ToString()             // Print information on the console
        {
            StringBuilder disciplinesBuilder = new StringBuilder();
            disciplinesBuilder.AppendFormat("\n" + "Name: {0} " + "\n" + "Optional text: {1}" + "\n" + "\n", this.name, this.textBox);
            foreach (Disciplines discipline in listDisciplines)        // loop for printing list of disciplines
            {
                disciplinesBuilder.AppendFormat("Discipline: {0}", discipline);
            }
            return disciplinesBuilder.ToString();
        }
        public static string PrintList(List<Disciplines> list)
        {
            StringBuilder listBuilder = new StringBuilder();
            foreach (Disciplines discipline in list)        // loop for printing list of disciplines
            {
                listBuilder.AppendFormat("Discipline: {0}", discipline);
            }
            return listBuilder.ToString();
        }
    }
}

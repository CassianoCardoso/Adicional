

namespace Adicional.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Houer  { get; set; }
        public double ValuePerHouer { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int houer, double valuePerHouer)
        {
            Name = name;
            Houer = houer;
            ValuePerHouer = valuePerHouer;
        }

        public virtual double Payment() //libera para ser sobreescrita"virtual"
        {
            return Houer * ValuePerHouer;
        }
    }
}



namespace Adicional.Entities
{
    internal class outsorcedEmproyee : Employee
    {

        public double AdditionalCharge { get; set; }

        public outsorcedEmproyee()
        {
        }

        public outsorcedEmproyee(string name, int houer, double valuePerHouer, double additionalCharge) : base(name, houer, valuePerHouer)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}

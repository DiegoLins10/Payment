
namespace Payment.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double additionalCharge  { get; set; }

        public OutsourcedEmployee()
        {

        }
        // reaproveitando construtor da super classe
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base (name, hours, valuePerHour)
        {
            this.additionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (1.1 * additionalCharge);
        }
    }
}

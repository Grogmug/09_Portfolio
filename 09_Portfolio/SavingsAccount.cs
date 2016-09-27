namespace _09_Portfolio
{
    internal class SavingsAccount : IAsset
    {
        string name;
        double value, interestRate;
        public SavingsAccount(string name, double value,double interestRate)
        {
            this.name = name;
            this.value = value;
            this.interestRate = interestRate;
        }

        public double GetValue()
        {
            return value;
        }

        public double InterestRate
        {
            get { return interestRate; }
        }

        public override string ToString()
        {
            return "SavingsAccount[value=" + value + ".0,interestRate=" + interestRate.ToString().Replace(',','.')+ "]";
        }

        public void ApplyInterest()
        {
            value *= 1 + (interestRate / 100);
        }
    }
}
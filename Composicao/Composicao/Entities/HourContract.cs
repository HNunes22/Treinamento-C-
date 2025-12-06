namespace Composicao.Entities
{
    internal class HourContract
    {
        public DateTime DateContract { get; set;}
        public double ValuePerHour {  get; set;}
        public int Hours { get; set;}

        public HourContract() { }
        public HourContract(DateTime dateContract, double valuePerHour, int hours)
        {
            DateContract = dateContract;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}

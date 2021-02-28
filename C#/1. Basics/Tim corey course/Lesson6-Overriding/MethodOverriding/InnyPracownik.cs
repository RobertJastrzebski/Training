namespace MethodOverriding
{
    public class InnyPracownik : Employee
    {
        public decimal premia { get; set; }

        public override decimal Wypłata(int godzinPrzepracowanych)
        {
            decimal wypłataBazowa=  base.Wypłata(godzinPrzepracowanych);
            return wypłataBazowa + premia;
        }
    }
}
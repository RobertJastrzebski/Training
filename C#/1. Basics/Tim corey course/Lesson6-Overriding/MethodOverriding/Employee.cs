namespace MethodOverriding
{
    public class Employee : PersonModel
    {
        public decimal GodzinowaStawka { get; set; }

        public virtual decimal Wypłata(int godzinPrzepracowanych)
        {
            return GodzinowaStawka * godzinPrzepracowanych;
        }
    }
}
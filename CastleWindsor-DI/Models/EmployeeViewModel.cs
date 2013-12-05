namespace CastleWindsor_DI.Models
{
    public class EmployeeViewModel
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string FullName
        {
            get { return string.Format("{0} {1}", Forename, Surname); }
        }
    }
}
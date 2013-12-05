using System.Linq;

namespace LinqExamples
{
    public static class LetKeyword
    {
        public static void RangeVariablesWithTheLetKeyword()
        {
            var employees = EmployeesRepository.GetAllEmployees();

            var result = from e in employees
                         let lname = e.Surname.ToLower()
                         where lname == "smith"
                         select lname;
        }

    }
}

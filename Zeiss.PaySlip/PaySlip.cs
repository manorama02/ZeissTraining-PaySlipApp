using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.BL;
namespace Zeiss.PaySlip
{
    internal class PaySlip
    {
        string EmpID;
        string EmpFirstName;
        string EmpLastName;
        string Department;
        DateTime DOJ;
        short Month;
        short Year;
        int BasicPay;
        int DA;
        int HRA;
        int LTA;
        int PF;
        int ProfTax;
        int IncomeTax;
        int Loan;

        public void PrintPaySlip(string empID, short Month, short Year)
        {
            Console.WriteLine("PaySlip for "+Year.ToString()+" - "+Month.ToString());
            

            EmployeeBL empBl = new EmployeeBL();
            empBl = empBl.GetEmpDetails("M100232");
            Console.WriteLine(empBl.empID + "  " + empBl.FirstName+" "+empBl.LastName);
            Console.WriteLine("Date of joining " + empBl.DOJ);

            Console.WriteLine("Basic Pay: ");

        }

    }
}

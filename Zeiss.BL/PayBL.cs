using Zeiss.DataAccess;

namespace Zeiss.BL
{
    public class PayBL
    {
        int GetBasicPay(string empID, Int16 Month, Int16 Year)
        {
            PayDA payDA = new PayDA();
            int basicPay = payDA.GetBasicPay(empID, Month, Year);
            return basicPay;
        }

        public int CalculateDA(string empID, Int16 Month, Int16 Year)
        {
            int basicPay = GetBasicPay(empID, Month, Year);
            int da = 0;
            if(basicPay > 25000)
                da = basicPay * 12 / 100;
            else
                da= basicPay * 40 / 100;
            return da;
        }
    }

    public class EmployeeBL
    {
        public string empID;
        public string FirstName;
        public string LastName;
        //string Department;
        public string DOJ;

        public EmployeeBL GetEmpDetails(string empID)
        {
            // get emp details in DA object
            EmployeeDA empD1 = new EmployeeDA();
            empD1 = empD1.GetEmpDetails(empID);

            //Populate BL object from DA object
            EmployeeBL empB1=new EmployeeBL();
            empB1.empID = empD1.empID;
            empB1.FirstName=empD1.FirstName;
            empB1.LastName = empD1.LastName;
            empB1.DOJ = empD1.DOJ;
            return empB1;
        }

    }
}

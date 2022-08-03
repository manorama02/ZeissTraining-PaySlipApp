namespace Zeiss.DataAccess
{
    public class PayDA
    {
       public int  GetBasicPay(string empID,Int16 Month,Int16 Year)
        {
            // Connect to the database
            // Execute stored procedure/query
            // Get Basic Pay
            // Close connection
            return 20000;
        }
    }
    public class EmployeeDA
    {
        public string empID;
        public string FirstName;
        public string LastName;
        //string Department;
        public string DOJ;

        public EmployeeDA GetEmpDetails(string empID)
        {
            EmployeeDA emp = new EmployeeDA();
            // Connect to the database
            // Execute stored procedure/query
            //get employee details in emp instance and return emp instance
            emp.FirstName = "Raj";
            emp.LastName = "Kumar";
            emp.DOJ = "5-5-2015";
            //close connection
            return emp;
        }

    }
}
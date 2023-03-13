using System.Collections;
public class EmployeeManage : Employee
{
    public EmployeeManage()
    {
    }
    public string arrayList() {
        ArrayList arr = new ArrayList();
        return "0";
    }
    override public string Info(){
        return StaffInformation();
    }
    override public string FullName() {
            return $"{FirstName} {MiddleName} {LastName}".Trim();
    }
    override public string StaffInformation() {
            return $"Name: {FullName()} \nAge:{Age} \nSalary: {Salary}$".Trim();
            // return $"| %-25 | %-3 | %-10 |" + FullName() + Age + Salary ;
    }
}


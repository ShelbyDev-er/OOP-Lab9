using System.Collections;
        EmployeeManage em = new EmployeeManage();
        int choice;
        ArrayList employeeList = new ArrayList();

        do{
            Console.WriteLine("================================================================");
            Console.WriteLine("                              MENU                              ");
            Console.WriteLine("================================================================");
            Console.WriteLine("1. Add new Employee");
            Console.WriteLine("2. Update Employee");
            Console.WriteLine("3. Delete Employee");
            Console.WriteLine("4. View Employee");
            Console.WriteLine("5. Exit");
            Console.WriteLine("================================================================");
            Console.Write("Enter your choice: ");
            string a = Console.ReadLine()?? "";//CheckChoice();
            choice = int.Parse(a);
            // for (int i = 0; i < 1; i++){
            //     if (char.IsDigit(a[i]) == true){

            // }
            // Employee Contact = new EmployeeManage();
            switch (choice)
            {
                case 1:
                    // string str =EnterContact();
                    // Console.WriteLine(str);
                    employeeList.Add(EnterContact());
                    break;
                case 2:
                    Console.WriteLine("Enter  Contact");
                    int num1 = int.Parse(Console.ReadLine()?? "");
                    Console.WriteLine(employeeList[num1-1]);
                    Console.WriteLine("Update confirmation \n(Press Y to confirm)");
                    string Confirmation1 = Console.ReadLine()?? "";
                    if (Confirmation1 == "Y" || Confirmation1 == "y")
                    {
                        employeeList.RemoveAt(num1-1);
                        employeeList.Insert(num1-1, EnterContact() );
                    }
                    Console.WriteLine("Complete update");
                    break;
                case 3:
                    Console.WriteLine("Enter  Contact");
                    int num2 = int.Parse(Console.ReadLine()?? "");
                    Console.WriteLine(employeeList[num2-1]);
                    Console.WriteLine("Delete confirmation \n(Press Y to confirm)");
                    string Confirmation2 = Console.ReadLine()?? "";
                    if (Confirmation2 == "Y" || Confirmation2 == "y")
                    {
                        employeeList.RemoveAt(num2-1);
                    }
                    Console.WriteLine("Complete update");
                    break;
                case 4:
                    // Console.WriteLine("Enter  Contact");
                    // int n = int.Parse(Console.ReadLine()?? "");
                    // Console.WriteLine(employeeList[n-1]);
                    int num=1;
                    foreach(string e in employeeList){
                        
                        Console.WriteLine("#{0}",num);
                        Console.WriteLine("{0}", e);
                        num++;
                        // Console.WriteLine("checked2");
                    }
                    // Console.WriteLine("checked3");
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                
                default:
                    Console.WriteLine("[ERROR!] Please Enter again.");
                    break;
            }
            }while (choice !=5);


static string EnterContact(){
    Console.WriteLine("Add a new employee.");
    Employee Contact = new EmployeeManage();
    Console.Write("Enter First Name: ");
    Contact.FirstName = Console.ReadLine()?? "";
    Console.Write("Enter Middle Name: ");
    Contact.MiddleName = Console.ReadLine()?? "";
    Console.Write("Enter Last Name: ");
    Contact.LastName = Console.ReadLine()?? "";
    int i=0;
    while (i<1)
    {
        Console.Write("Enter Age: ");
        string B = Console.ReadLine()?? "";
        
        if(char.IsDigit(B[i]) == true && int.Parse(B) < 255){
            byte b = byte.Parse(B);
            Contact.Age = b;
        }else
        {
            Console.WriteLine("[ERROR!] Please Enter a valid age.");
            i--;
        }
        i++;
    }
    int j =0;
    while (j<1)
    {
        Console.Write("Enter Salary: ");
        string C = Console.ReadLine()?? "";
        
        if(char.IsDigit(C[j]) == true){
            int c = int.Parse(C);
            Contact.Salary = c;
        }else
        {
            Console.WriteLine("[ERROR] Please Enter a valid salary.");
            j--;
        }
        j++;
    }
    return Contact.Info();
    
}


// static string CheckChoice(){
//     int i=0;
//     string b;
//     while(i <1){
//         string B= Console.ReadLine()?? "";
//         if(char.IsDigit(B[i]) == true){
//                 b = B;
//                 return b;
//             }else
//             {
//                 Console.WriteLine("[ERROR!] Please Enter a valid number.");
//                 i--;
//             }
//             i++;
//     }
// }

// static string EnterName(){
//     Employee Contact = new EmployeeManage();
//     Console.Write("Enter First Name: ");
//     Contact.FirstName = Console.ReadLine()?? "";
//     Console.Write("Enter Middle Name: ");
//     Contact.MiddleName = Console.ReadLine()?? "";
//     Console.Write("Enter Last Name: ");
//     Contact.LastName = Console.ReadLine()?? "";
//     return Contact.FullName();
// }
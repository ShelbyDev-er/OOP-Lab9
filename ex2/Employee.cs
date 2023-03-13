public abstract class Employee
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public byte? Age  { get; set; }
        public int? Salary   { get; set; }
        
        public Employee(){
            // FirstName = Console.ReadLine()?? "";
            // MiddleName = Console.ReadLine()?? "";
            // LastName = Console.ReadLine()?? "";
            // Age = byte.Parse(Console.ReadLine()?? "");
            // Salary = int.Parse(Console.ReadLine()?? "");
        }

        public abstract string Info();
        public abstract string FullName();
        public abstract string StaffInformation();

        public void Input() {
            Console.WriteLine("Enter First Name: ");
            FirstName = Console.ReadLine();

            Console.WriteLine("Enter Middle Name: ");
            MiddleName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            LastName = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            Age = byte.Parse(Console.ReadLine()?? "");

            Console.WriteLine("Enter Salary: ");
            Salary = int.Parse(Console.ReadLine()?? "");

        }

        public void display() {
            Console.WriteLine("First Name: {0}\nLast Name: {1}\nMiddleName: {2}\nAge: {3}\nSalary: {4}", FirstName, MiddleName, LastName, Age, Salary);
        }
    }
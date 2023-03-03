namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.Write("Enter The Mobile Number : ");
            String MobileNumber = Console.ReadLine();

            if (DetailCheck.Validate(MobileNumber))
            {
                Console.WriteLine("Valid Mobile Number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile number");
            }
        }
    }
}

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.Write("Enter the Password : ");
            String Password = Console.ReadLine();

            if (DetailCheck.Validate(Password))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}

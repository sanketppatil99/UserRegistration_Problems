namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("Enter the Last name");
            String LName = Console.ReadLine();

            if (DetailCheck.Validate(LName))
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
    }
}

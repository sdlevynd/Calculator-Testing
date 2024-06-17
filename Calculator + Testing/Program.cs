namespace Calculator___Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Calculator 
    { 
        public Calculator()
        {

        }
        public void Menu()
        {
            Console.WriteLine("Choose an option (A, S, M, D)");

        }
        public int add(int num1, int num2)
        {
            int ans = num1 + num2;
            return ans;
        }
        public int subtract(int num1, int num2)
        {
            int ans = num1 - num2;
            return ans;
        }
        public int mutliply(int num1, int num2)
        {
            int ans = num1 * num2;
            return ans;
        }
        public int divide(int num1, int num2)
        {
            int ans = num1 / num2;
            return ans;
        }
    }

}
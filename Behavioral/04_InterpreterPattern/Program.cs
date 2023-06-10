namespace _04_InterpreterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var leftExp = new NumberExpression(2);
            var rightExp = new NumberExpression(3);
            var addExp = new AddExpression(leftExp, rightExp);
            var result = addExp.Interpret(new CustomContext());


            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
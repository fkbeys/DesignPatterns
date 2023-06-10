namespace _04_InterpreterPattern
{
    public class CustomContext
    {
        //required props etc..
    }

    public abstract class CustomExpression
    {
        public abstract int Interpret(CustomContext context);
    }

    //terminal expression
    public class NumberExpression : CustomExpression
    {
        public int Number { get; }
        public NumberExpression(int number)
        {
            Number = number;
        }

        public void addexp()
        {

        }

        public override int Interpret(CustomContext context)
        {
            return Number;
        }
    }

    public class AddExpression : CustomExpression
    {
        private readonly CustomExpression leftExpression;
        private readonly CustomExpression righExpression;

        public AddExpression(CustomExpression leftExpression, CustomExpression righExpression)
        {
            this.leftExpression = leftExpression;
            this.righExpression = righExpression;
        }


        public override int Interpret(CustomContext context)
        {
            var result = leftExpression.Interpret(context) + righExpression.Interpret(context);
            return result;
        }
    }

}

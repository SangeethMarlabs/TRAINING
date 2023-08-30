namespace Marlabs_Arithemetic_Operation_Delegates
{
    public class ArithemeticOperations
    {
        public T Addition<T>(T a, T b)
        {
            return (dynamic)a + b;
        }
        public T Subtraction<T>(T a, T b)
        {
            return (dynamic)a - b;
        }
        public T Multiplication<T>(T a, T b)
        {
            return (dynamic)a * b;
        }
        public T Division<T>(T a, T b)
        {
            return (dynamic)a / b;
        }
    }
}

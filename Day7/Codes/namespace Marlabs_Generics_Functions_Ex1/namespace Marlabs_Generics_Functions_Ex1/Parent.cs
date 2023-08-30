using System;

namespace namespace_Marlabs_Generics_Functions_Ex1
{
    public class Parent
    {
        public void show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}

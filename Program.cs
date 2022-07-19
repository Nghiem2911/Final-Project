using System;

namespace c_
{
class Lop3 {
    public void ActionC() => Console.WriteLine("Action in Lop3");
}

class Lop2 {
    Lop3 c_dependency;

    public Lop2(Lop3 class3) => c_dependency = class3;
    public void ActionB()
    {
        Console.WriteLine("Action in Lop2");
        c_dependency.ActionC();
    }
}

class Lop1 {

    Lop2 b_dependency;

    public Lop1(Lop2 class2) => b_dependency = class2;
    public void ActionA()
    {
        Console.WriteLine("Action in Lop1");
        b_dependency.ActionB();
    }
}

    class Program
    {
        static void Main(string[] args)
        {
             Lop3 objectC = new Lop3();
             Lop2 objectB = new Lop2(objectC);
             Lop1 objectA = new Lop1(objectB);

objectA.ActionA();

        }
    }
}


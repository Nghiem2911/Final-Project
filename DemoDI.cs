using System;
namespace c_
{
    interface ILop2 {
    public void ActionB();
}
interface ILop3 {
    public void ActionC();
}
class Lop3 : ILop3{
    public void ActionC() => Console.WriteLine("Action in Lop3");
}

class Lop2: ILop2 {
    ILop3 c_dependency;
    public Lop2(ILop3 class3) => c_dependency = class3;
    public void ActionB(){
        Console.WriteLine("Action in Lop2");
        c_dependency.ActionC();
    }
}

class Lop1 {
    ILop2 b_dependency;
    public Lop1(ILop2 class2) => b_dependency = class2;
    public void ActionA(){
        Console.WriteLine("Action in Lop1");
        b_dependency.ActionB();
    }
}
class LopC1 : ILop3{
    public LopC1() => Console.WriteLine ("LopC1 is created");
    public void ActionC(){
        Console.WriteLine("Action in C1");
    }
}
    class Program{
        static void Main(string[] args){
             ILop3 objectC = new LopC1();
             ILop2 objectB = new Lop2(objectC);
             Lop1 objectA = new Lop1(objectB);

objectA.ActionA();

        }
    }
}
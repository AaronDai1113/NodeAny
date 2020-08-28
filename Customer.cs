using System;

public class Customer{
    public static Food Cook(string type){
        Food food=null;
        if(type.Equals("A")){
            food=new TomatoScrambledEggs();
        }
        else if(type.Equals("B")){
            food=new Shreddedportk();
        }
        return food;
    }
}

public abstract class Food{
    public abstract void Print();
}

public class TomatoScrambledEggs:Food{
    public override void Print(){
        Console.WriteLine("one tomato");
    }
}

public class Shreddedportk:Food{
    public override void Print(){
        Console.WriteLine("on potato");
    }
}
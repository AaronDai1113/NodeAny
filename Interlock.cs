using System;

public class Singleton1{
    private static Singleton1 uniqueInstance;
    private static readonly object locker =new object();

    private Singleton1(){        
    }

    public static Singleton1 GetInstance(){
        lock(locker){
            if(uniqueInstance==null){
                uniqueInstance=new Singleton1();
            }
        }
        return uniqueInstance;
    }
}
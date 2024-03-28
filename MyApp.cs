using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

abstract class User{
  public abstract void SayHi();
}

class Japanese: User{
    public override void SayHi(){
      Console.WriteLine("こんにちは");
    }
}

class American: User{
    public override void SayHi(){
      Console.WriteLine("Hello");
    }
}

class MyApp{
  static void Main(){
    Japanese aki = new Japanese();
    aki.SayHi();
    American tom = new American();
    tom.SayHi();
  }
}




using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

class User {
  public string name;
  public User(string name) {
    this.name = name;
  }
  public User(): this("nobody"){
  }
  public virtual void SayHi() => Console.WriteLine($"Hi! {this.name}");
}

class AdminUser: User {
  public AdminUser(string name): base(name){
  }
  public void SayHello() => Console.WriteLine($"Hello! {this.name}");
  public override void SayHi() => Console.WriteLine($"[admin] Hi! {this.name}");
}

class MyApp { 
  static void Main() {
  User tom = new User("Tom");
  tom.SayHi();
  AdminUser bob = new AdminUser("Bob");
  bob.SayHi();
  bob.SayHello();
  }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualBasic;



class MyApp {
  static void Main() {
    List<double> prices = new List<double>() {53.2,48.2,32.8};

    // SQL
    // var results = from price in prices
    //   where price * 1.08 > 50.0
    //   select price * 1.08;

    // Method
    var results = prices
      .Select(n => n * 1.08)
      .Where(n => n > 50.0);
   foreach(var result in results){
    Console.WriteLine(result);
   }

   
  }
}









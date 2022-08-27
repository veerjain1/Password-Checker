using System;

class Program {
  public static void Main (string[] args) {

    //declare variable for password and ask user to input a password
    string pw;
    Console.WriteLine("Please enter a password with 8-12 characters");

    //save password as pw
    pw=Console.ReadLine();
    //declare variable for pin and ask user to input a pin
    string pinstring;
    Console.WriteLine("Please enter a pin with 4 digits");
    
    //save pin as pin
    pinstring=Console.ReadLine();


    //declare integer for user input of the pin
    int pin;

    //parse the string into an into

    pin = int.Parse(pinstring);


    //if password length AND pin both meet requirements
    if(pw.Length>=8 && pin>=1000 && pin<=9999)
      Console.WriteLine("OK");
      //if its not true then prompt the user to rest
    else
      Console.WriteLine("Reset your password and pin number!");
      
  }
}
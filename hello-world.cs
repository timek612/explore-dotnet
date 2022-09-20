
// Console.WriteLine("Hello world!");
// Console.WriteLine("The current time is: " + DateTime.Now);

// string myName = "AJ Timek";
// var name = "AJ Timek";
// Console.WriteLine(myName);
// Console.WriteLine(myName.Length);

// var temp = "I'm still a strongly-typed System.String!";
// Console.WriteLine(temp + name);

// char[] letters = {'A', 'B', 'C'};
// string alphabet = new string(letters);
// Console.WriteLine(alphabet);

// int num1 = 7;
// double num2 = 9.5;
// Console.WriteLine(num1 + num2);

// bool isAJCool = true;
// Console.WriteLine(isAJCool ? "Yuh he's cool" : "Nah he lame");

// if (isAJCool == true) {
//     Console.WriteLine("He's the coolest");
// }
// else if (num1 == 8) {
//     Console.WriteLine("This seems accurate");
// }
// else {
//     Console.WriteLine("This lame ahh boy lame as hell");
// }


// switch (num1 + num2) {
//     case 7:
//         Console.WriteLine("The number is 7");
//         break;
//     case 8: 
//         Console.WriteLine("The number is 8");
//         break;
//     case 9:
//         Console.WriteLine("The number is 9");
//         break;
//     case 16.5:
//         Console.WriteLine("Goteem");
//         break;

// }


// string[] names = {"AJ", "Justin", "Matt"};
// for (int i = 0; i < names.Length; i++) {
//     Console.WriteLine(names[i]);
// }

// namespace MyApp
// {
//     class Book//class
//     {
//         string name = "Red Rising";
//         // int numInSeries = 1;

//         static int MyMethod(int x)
//         {
//             return 5 + x;
//         }
//         static void Main(string[] args)//method
//         {
//             Console.ForegroundColor = ConsoleColor.DarkMagenta;
//             Console.WriteLine(MyMethod(5));
//             Book myObj = new Book();//object
//             Console.WriteLine(myObj.name);
//             string firstName = Console.ReadLine();
//             Console.WriteLine("Hello " + firstName);
//         }
//     }
// }

// namespace secondApp
// {
//     class Car
//     {
//         string name = "Audi";

//         static void Method()
//         {
//             Car carObject = new Car();
//             Console.WriteLine(carObject.name);
//         }
//     }

// }

// make instances of markers (variables)
// new creates an instance
Marker redMarker = new Marker();
// redMarker.color = "Red";
Console.WriteLine(redMarker.color);


//class
public class Marker
{
    //properties
    public string material;
    public string color;
    public int inkLevel = 100;

    //methods

    //setter
    public void changeColor(string newColor) {
        if(newColor != null) {
            this.color = newColor;
        }
    }
    //getter
    public string getColor() {
        return this.color;
    }
}




//In C#, an object(JS) is a Class. Each class will be its own file. 
//In classes you make instances: objects of that class.

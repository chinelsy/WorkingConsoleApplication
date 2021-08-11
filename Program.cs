using System;
using System.Text;
using System.Collections;

namespace LearningWithBob
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //BuildingGames.Games();
            //var buildingGames = new BuildingGames();
            //buildingGames.Games();
            //var buildingGames = new BuildingGames();
            //buildingGames.MoreGames();
            //var buildingGames = new BuildingGames();
            //buildingGames.LocalGames();
            // var buildingGames = new BuildingGames();
            //buildingGames.LondonGames();
            //BuildingGames.PrintNumbers();
            // BuildingGames.GuessingGames();

            //string myCurrency = string.Format("{0:C}", 2000);
            //Console.WriteLine( myCurrency);
            //string myString = "";
            //string sb = "";
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < 100; i++)
            //{
            //    sb.Append("--");
            //    sb.Append(i);

            //} 
            //Console.WriteLine(sb);
            //Console.ReadLine();
            //DateTime myDate = DateTime.Now;
            //Console.WriteLine(myDate.ToString());
            //Console.WriteLine(myDate.Month);//interger
            //DateTime myBirthday = new DateTime();
            //Console.WriteLine("Enter your birthday");
            //BuildingGames.ParseFromStringWithTryParse();
            // Call instance method.

            //Console.WriteLine("what is your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("how old are you now");
            //string age = Console.ReadLine();
            //var student = new Student();
            //student.StudentInfo(name, age);

            //var call = new PhoneCall();
            //call.MakeFilm
            //Create a myCar object
            // Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            //myCar.honk();
            //myCar.Move();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            //Console.WriteLine(myCar.brand + " " + myCar.modelName);
            //Console.WriteLine($"The brand of my car is {myCar.brand}  and the model is {myCar.modelName}");
            //Console.WriteLine($"{myCar.brand} {myCar.modelName}");
            PhoneCall phoneCall = new PhoneCall();
            phoneCall.MakeCall();
            phoneCall.ShootFilm();
            StoreInfo storeInfo = new StoreInfo();
            storeInfo.GetData();
            Console.WriteLine(storeInfo.GetName());
           // storeInfo.GetName();
            storeInfo.PlayVideo();
            StoreInfo.Information();


            var sammyStuff = new Sammy();
            Console.WriteLine(sammyStuff.money);
            Console.WriteLine(sammyStuff.headphone);

            var daraStuff = new Dara();
            Console.WriteLine(daraStuff.money);// commented out new Dara


            var TochukwuStuff = new Tochukwu();
            Console.WriteLine(TochukwuStuff.GetMoney()); 
            Console.WriteLine(TochukwuStuff.money);
            Console.WriteLine(TochukwuStuff.Name);
            Console.WriteLine(TochukwuStuff.computer);

            //var sunny = new Sunday();
            //Console.WriteLine(sunny.myName);
            //sunny.GetName();

            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });
            // Show number of items in ArrayList.
            Console.WriteLine("This collection has {0} items.", strArray.Count);
            Console.WriteLine();
            // Add a new item and display current count.
            strArray.Add("Fourth!");
            Console.WriteLine("This collection has {0} items.", strArray.Count);
            // Display contents.
            foreach (string s in strArray)
            {
                Console.WriteLine("Entry: {0}", s);
            }
            Console.WriteLine();
        }

    } 





    
}


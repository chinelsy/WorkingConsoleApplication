using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWithBob
{

    public class Chikki
    {
        public string money = "100";
        public int GetMoney()
        {
            return 9000000;
            //Console.WriteLine("i am rich");
        }
    }

    public class Dara : Chikki
    {
        public string computer = "Dell";
    }

    public class Sammy : Chikki
    {
        public string headphone = "Sony";
    }

    public class Tochukwu : Dara
    {
        public string Name = "Terrible";
    }
    interface IComputer
    { 
        void GetData();
        int GetName();

        //string GetName = "I am a computer";

    }

    interface IVideo
    {
        void PlayVideo();
    }

    class StoreInfo : IComputer, IVideo
    {

      public  static void Information()
        {
            Console.WriteLine("i store info so call on me!!");
        }
     
       public void GetData()
        {
            Console.WriteLine("getting data");
        }
        
        public int GetName()
        {
            return 4;
        }

        public void PlayVideo()
        {
            Console.WriteLine("You Win");
        }

    }


    public abstract class PhoneMake 
    {
      public abstract void MakeCall();

        public void ShootFilm()
        {
            Console.WriteLine("I like it");
        }
    }  
        
    public class  PhoneCall:PhoneMake
    {
        public override void MakeCall()
        {
            Console.WriteLine("make call as low as 1 naira per seconds"); 
        }
    }
}

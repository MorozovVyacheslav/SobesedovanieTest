
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface irealise
    {
        string Realise();
    }
 


    class BasaMethods
    {
        public void Show(List<string> massivedinamic)
        {
            int i = 1;
            foreach (var item in massivedinamic)
            {

                Console.WriteLine("{0} {1}", i, item);
                i++;
            }


        }

        public void Remove(List<string> massivedinamic, int x)
        {

            massivedinamic.RemoveAt(x - 1);



        }
        public virtual string Realise() 
        {
            return null;
        }



    }

    class Person : irealise
    {
        string FirstName;
        string LastName;
        int AgeProduct;

        public Person(string FirstName,
        string LastName,
        int AgeProduct)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AgeProduct = AgeProduct;


        }
        public string Realise ()
        {

            return String.Format("[{0}] [{1}] {2} {3} {4}", DateTime.Now, GetType().Name, FirstName, LastName, AgeProduct);
        }
    }

    class Car : irealise
    {
        string Marka; int AgeProduct;

        public Car(string Marka, int AgeProduct)
        {
            this.Marka = Marka;
            this.AgeProduct = AgeProduct;


        }


        public  string Realise()
        {
            return String.Format("[{0}] [{1}] {2} {3}", DateTime.Now, GetType().Name, Marka, AgeProduct);


        }
    }

    class Message : irealise
    {
        string message;

        public Message(string message)
        {
            this.message = message;
        }




        public string Realise()
        {


            return String.Format("[{0}] [{1}] {2} ", DateTime.Now, GetType().Name, message);


        }


    }



}















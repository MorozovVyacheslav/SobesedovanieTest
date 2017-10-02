using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace ConsoleApp1
{

    delegate void bobr();

    class Program
    {
        static void Main(string[] args)
        {
            List<string> spisok = new List<string>();
            string chose = null;
            string tire = new string('-', 30);
            BasaMethods show = new BasaMethods();
           
         
            do
                {
             





             Console.WriteLine("\n1 .Print data \n2 .Add item \n3 .Remove item \nQ .Exit \n");

            chose =  Console.ReadLine();

             switch (chose)
        {
            case "1":
                        Console.WriteLine("{0}", tire);
                        show.Show(spisok);

                        break;

            case "2":
                        Console.WriteLine("{0}", tire);
                        string swatch;
                        do
                        {
                            Console.WriteLine("\n1 .ADD Message \n2 .ADD Car \n3 .ADD person \nQ .Exit \n");
                      swatch = Console.ReadLine();

                            switch (swatch)
                            {
                                case "1":

                                    Console.WriteLine("{0}\n Введите сообщение \n{1}", tire, tire);
                                    
                                    
                                    spisok.Add(new Message(Console.ReadLine()).Realise());
                                    Console.WriteLine("{0}\n Сообщение добавлено \n{1}", tire, tire);

                                    break;


                                case "2":
                                    try
                                    {
                                        Console.WriteLine("{0}\n Введите Марку машины \n{1}", tire, tire);
                                        string firstname1 = Console.ReadLine();
                                        Console.WriteLine("{0}\n Дату производства \n{1}", tire, tire);
                                        int age1 = int.Parse(Console.ReadLine());


                                         spisok.Add(new Car(firstname1, age1).Realise())
                                        ;

                                        Console.WriteLine("{0}\n Марка , дата производства добавлены\n{1}", tire, tire);
                                   

                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Неправильный тип данных!!!!");
                                        Console.WriteLine("{0}", tire);
                                    }

                                    break;






                                case "3":

                                    Console.WriteLine("{0}\n Введите First Name \n{1}", tire, tire);
                                    string firstname = Console.ReadLine();
                                    Console.WriteLine("{0}\n Введите Last Name \n{1}", tire, tire);
                                    string LaseName = Console.ReadLine();
                                    Console.WriteLine("{0}\n Введите возраст \n{1}", tire, tire);
                                    try
                                    {
                                        int age = int.Parse(Console.ReadLine());
                                        //spisok.Add(person.Realise(firstname, LaseName, age));
                                       ;
                                        spisok.Add(new Person(firstname, LaseName, age).Realise());



                                        Console.WriteLine("{0}\n Имя , Фамилия , Возраст добавлены\n{1}", tire, tire);

                                    }
                                    catch (FormatException)
                                    {

                                        Console.WriteLine("Неправильный тип данных!!!!");
                                        Console.WriteLine("{0}", tire);
                                    }
                                    

                                   

                                    break;



                                default:

                                    Console.WriteLine("{0}\n Введите корректное значение \n{1}", tire, tire);
                                    break;
                            }
                        } while (swatch != "Q");



                        break;




                    case "3":
                        Console.WriteLine("{0}", tire);
                        Console.WriteLine("Для удаления записи выберите индекс");
                        show.Show(spisok);
                        show.Remove(spisok, int.Parse(Console.ReadLine()));
                        Console.WriteLine("Запись удалена");
                        Console.WriteLine("{0}", tire);


                        break;



                 default:
                     
                     Console.WriteLine("{0}\n Введите корректное значение \n{1}", tire , tire); 
                 break;

             }


                 


    } while (chose !="Q");






















        }
    }

}



    




    
    


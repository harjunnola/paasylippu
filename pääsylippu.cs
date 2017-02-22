using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iffi
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;
            Console.WriteLine("Anna ikäsi: ");
            age = int.Parse(Console.ReadLine());

           

            float ticketPrice = 16.0F;
            float discount = 0.0F;

            if (age >= 7 && age <= 15)
            {
                Console.WriteLine("Olet 7-15 vuotias ja lippusi maksaa {0} € ",ticketPrice / 2);
            }

            else if (age >= 65)
            {
                Console.WriteLine("lippusi maksaa {0} € ",ticketPrice / 2);
            }

            else if (age < 7)
            {
                Console.WriteLine("lippusi maksaa 0 € ");
            }

            else
            {
                bool isStudent = false;
                Console.WriteLine("Oletko opiskelija: K / E");

                string Student = Console.ReadLine().ToUpper();
                if (Student == "K")
                {
                    isStudent = true;
                    discount = 0.45F;
                }
                bool isMTK = false;
                Console.WriteLine("Oletko MTK-jäsen: K / E");

                string MTK = Console.ReadLine().ToUpper();
                if (MTK == "K")
                {
                    isMTK = true;
                    discount = discount+0.15F;
                }
                if (isStudent==false)
                {
                    bool isMilitary = false;
                    Console.WriteLine("Oletko varusmies: K / E");

                    string Military = Console.ReadLine().ToUpper();
                    if (Military == "K")
                    {
                        isMilitary = true;
                        discount = 0.5F;
                    }
                }



                Console.WriteLine("lippusi maksaa {0} e ",ticketPrice *(1-discount ));
            }


            Console.ReadKey();
           

           

        }
            
           


          
              







        }
    }


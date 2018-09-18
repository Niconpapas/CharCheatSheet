using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inPutString = null;

            Console.WriteLine("Ingrese Texto:");
            inPutString = Console.ReadLine();

            Manipulacion(inPutString);
            Console.ReadKey();

        }

        public static void Manipulacion(string inPut)
        {
            //string outPut= null;
            char[] charArray = null;
            int arrayLenght;
            int index = 0;
            string str = null;

            //string a Array
            charArray = inPut.ToCharArray();
            arrayLenght = charArray.Length;

            //Invertir
            Array.Reverse(charArray);
            Console.WriteLine(charArray);

            //Cambiar mayusculas por minusculas
            while(index<arrayLenght)
            {
                if(charArray[index]==char.ToUpper(charArray[index]))
                {
                    charArray[index]=char.ToLower(charArray[index]);
                }
                else
                {
                    charArray[index]=char.ToUpper(charArray[index]);
                }
                index++;
            }
            Console.WriteLine(charArray);

            //Agregar un simbolo entre caracteres y cambiar espacios por numero de posicion
            index = 0;

            while(index<arrayLenght)
            {
                if(charArray[index]==' ')
                {
                    str += index + "-";
                    index++;
                }
                else
                {
                    str += charArray[index] + "-";
                    index++;
                }
               
            }

            Console.WriteLine(str);

        }
    }

    
}

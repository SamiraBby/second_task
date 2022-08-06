using System;

namespace secondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region dersde yaziilanlar
            //   DateTime dt=DateTime.Now; 
            //   Console.WriteLine(dt);

            //Console.WriteLine(dt.ToString("dd-mm-yyyy hh:mm:ss"));
            //int a =(int)months.Jan;
            //Console.WriteLine(a);
            //Console.WriteLine(Topla(5,6));
            //string name = Console.ReadLine(); 
            //string strAge = Console.ReadLine(); 
            //int intAge = int.Parse(strAge); 

            //Welcoming(name, intAge);

            //Console.WriteLine(Vurma(6, 6));

            //Console.WriteLine(Nun("Tural",409,4));
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(Ret(numbers));
            #endregion
            #region  taskin internetden tapdigim helli 
            //string str = " djkasdk jadnka jan  " ;
            //Console.WriteLine(SpaceCount(str));
            #endregion
            #region taskin men dushunduyum helli
            //string sentence = "  bhbj   ";

            //countSpace(sentence);
            #endregion
        }
        #region dersde yazilanlar
        //enum months
        //{
        //    Jan,
        //    Feb,
        //    March
        //}
        //static int Topla(int a,int b)
        //{
        //    return a + b;   
        //}

        // static public void Welcoming(string a, int age)
        //{
        //    Console.WriteLine($"Welcome {a} , maybe ur {age} y.o");
        //}
        //static public int Vurma(int a, int b)
        //{
        //    return a * b;   
        //}

        //static public string Nun(string name,int groupe,int experience=0)
        //{
        //    if (experience == 0)
        //    {
        //        return $"{name} adli telebe  {groupe} sinfinde oxuyur";

        //    }
        //    else
        //    {
        //        return $"{name} adli telebe  {groupe} sinfinde oxuyur {experience} il tecrubesi var";

        //    }
        //}
        //public static int Ret(int[] numbers)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % 2 == 1)
        //        {
        //            sum += numbers[i];
        //        }
        //    }
        //    return sum;

        //}
        #endregion
        //Write a function in C# Sharp to create a function to input a string and count number of spaces are in the string.
        //Test Data : Please input a string : This is a test string.
        //Expected Output : "This is a test string." contains 4 spaces

        #region Taskin internetden tapdigim helli :)
        //public static int SpaceCount(string str)
        //{
        //    int spcctr = 0;
        //    string str1;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        str1 = str.Substring(i, 1);
        //        if (str1 == " ")
        //            spcctr++;
        //    }
        //    return spcctr;
        //}
        #endregion

        #region Taskin ozumun dushunduyu helli
        static public void countSpace(string sentence)
        {   int count = 0;
            
            for (int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i] == ' ')
                {
                    count ++;
                }
            }
            Console.WriteLine(count);
        }
        #endregion




    }
}

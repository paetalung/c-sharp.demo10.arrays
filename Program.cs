using System;

namespace demo10.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // กำหนดขนาด อาร์เรย์
            Console.Write("How much number for arg : ");
            int index = int.Parse(Console.ReadLine());

            // ประกาศ อาร์เรย์
            double[] numbers = new double[index];

            // วนรับค่า
            for (int j = 0; j < index; j++)
            {
                Console.Write("Insert value to position "+j+" of arrays : ");
                numbers[j] = double.Parse(Console.ReadLine());
            }

            //กำหนดตัวแปร ที่ใช้ในการหาร 
            double avg = 0;

            // วน บวก เท่ากับจำนวน ที่รับมา
            for (int i = 0 ; i < numbers.Length ; i++){
                avg += numbers[i];
            }

            // เอาผลที่ได้ มาหารด้วย จำนวน(ความยาว) ของอาร์เรย์
            double answers = avg / numbers.Length;
            Console.WriteLine("Average : " + answers);
        }
    }
}

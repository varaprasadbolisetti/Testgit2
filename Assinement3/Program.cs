using System.Text;
//using StringTokenizer;
namespace Assinement
{
    class Program
    {

        public void Demo()
        {
            Console.Write("Enter the float numbers: ");
            float value = float.Parse(Console.ReadLine());

            int n = (int)value;
            double f1 = (value - n) * 100;
            //f1 = (int)f1;

            Console.WriteLine(n + " " + f1);
            int[] a = new int[10];
            String s1 = " ";
            String s2 = " ";
            //String s5 = " ";
            int r = 0;
            float d = 0;
            float e = 0;
            float g = 0;
            //int i = 0;
            while (n > 0)
            {
                r = n % 2;
                s1 = s1 + r;
                n = n / 2;

            }
            // char[] ch = s1.ToCharArray();
            //for(int i=ch.Length-1;i>0; i--)
            //{
            //  Console.Write(ch[i]);

            //}
            String str = new String(s1.Reverse().ToArray());

            Console.WriteLine(str = str + ('.'));
            int maxDigits = 5;
            //string ConvertFractionalPart(double x, int maxDigits)
            //{
            var sb = new StringBuilder();
            while (f1 > 0 && sb.Length < maxDigits)
            {
                if (f1 >= 0.5)
                {
                    sb.Append("1");
                    f1 -= 0.5;
                }
                else
                {
                    sb.Append("0");
                }
                f1 = 2 * f1;
            }
            Console.WriteLine(sb.ToString());
        }



        //Console.WriteLine(str=str+s2);
        //return str;
        //int[] a1 = new int[10];
        // char[] ch2 = s2.ToCharArray();
        // for(int i = 0; i < ch2.Length; i++)
        //{
        //Console.Write(a[i] =ch2[i]);
        //}

        //ch[i]= ch[i] + ch2[i];
        //Console.WriteLine(s1);


    }

    public void Test()
    {
        Console.Write("Enter the float numbers: ");
        float value = float.Parse(Console.ReadLine());


        int m = (int)value;
        float f2 = (value - m) * 100;
        f2 = (int)f2;

        Console.WriteLine(m + " " + f2);
        String s3 = " ";
        String s4 = " ";
        //int[] ar = new int[10];
        int a = 0;
        float c = 0;
        float t = 0;
        //float j = 0;
        while (m > 0)
        {
            a = m % 2;
            s3 = s3 + a;
            m = m / 2;

        }

        String str1 = new string(s3.Reverse().ToArray());

        Console.WriteLine(str1 = str1 + ('.'));
        // char[] ch = s3.ToCharArray();
        //for(int k=ch.Length-1;k>=0;k--)
        //{
        //  Console.Write(ch[k]);

        //}
        for (int i = 0; i < 6; i++)
        {
            f2 = f2 * 2;//float number
            int h = (int)f2;//convereted float into integer
                            // Console.Write(h);
            while (h >= 0)
            {
                if (h == 0 || h == 1)
                {
                    s4 = s4 + h;//h=0||1 add to string

                    break;
                }

                c = h % 10;//c is reminder
                t = c + t * 10;//t is sum
                h = h / 10;


            }

            //Console.WriteLine(s4);
            float k = 0;
            float l = 0;
            int w = (int)t;
            while (w > 0)
            {
                k = w % 10;
                l = k + l * 10;
                w = w / 10;
            }
            f2 = l;
            //s3 = s3 + s4;
        }
        str1 = str1 + s4;
        //Console.WriteLine(s4);
        Console.WriteLine(str1);
        //return str1;

        //.Console.WriteLine(s6);




    }



    public static void Main(String[] args)
    {

        Program p = new Program();
        p.Demo();
        // p.Test();
        String s3 = ",";
        String st = " ";
        string s2 = "";
        char[] ch1 = s3.ToCharArray();
        char[] ch2 = s2.ToCharArray();
        int c = 0, length = ch1.Length, i = 0;

        while (i < length)
        {
            int sumcarry = ch1[i] + ch2[i] + c;
            if (sumcarry == 0)
            {
                c = 0;
                st = "0" + st;

            }
            else if (sumcarry == 1)
            {
                c = 0;
                st = "1" + st;
            }
            else if (sumcarry == 2)
            {
                c = 1;
                st = "0" + st;
            }
            else
            {
                c = 1;
                st = "1" + st;
            }
            i++;

        }
        st = c.ToString() + st;




        Console.WriteLine(st);
    }
    
    }








﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.CodeLean.AP_16
//{
//    delegate int NumberChanger(int n);
//    class DelegateAppl
//    {
//        class TestDelegate
//        {
//            static int num = 10;
//            public static int AddNum(int p)
//            {
//                num += p;
//                return num;
//            }
//            public static int MultNum(int q)
//            {
//                num *= q;
//                return num;
//            }
//            public static int getNum()
//            {
//                return num;
//            }
//            static void Main(string[] args)
//            {
//                NumberChanger nc1 = new NumberChanger(AddNum);
//                NumberChanger nc2 = new NumberChanger(MultNum);
//                nc1(25);
//                Console.WriteLine("Value of num: {0}",getNum());
//                nc2(5);
//                Console.WriteLine("Value of num: {0}",getNum());
//                Console.ReadKey();
//            }
//        }
//    }
//}

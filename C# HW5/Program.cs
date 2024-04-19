using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C__HW5
{


    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionHw01();
            FunctionHw02();
            FunctionHw03();
            FunctionHw04();
            FunctionHw05();
            FunctionHw06();
            FunctionHw07();
            FunctionHw08();
            FunctionHw09();
            FunctionHw10();

            StringHw01();
            StringHw02();
            StringHw03();
            StringHw04();
            StringHw05();
            StringHw06();
            StringHw07();

            StringHw_additional01();
            StringHw_additional02();
            StringHw_additional03();
            StringHw_additional04();
            StringHw_additional05();
            StringHw_additional06();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw01()
        {
            Console.WriteLine(@"Function-1. 寫一個function 可以把一般對話框的文字轉成HTML。");
            Console.WriteLine(@"> 轉成 &gt; ");
            Console.WriteLine(@"< 轉成 &lt; ");
            Console.WriteLine(@"\r\n 轉成 <br> ;");
            Console.WriteLine(@"| 轉成 &brvbar; ");
            Console.WriteLine(@"空白 轉成 &nbsp;");
            Console.WriteLine();
            //題目敘述結束

            Console.Write("請輸入要轉成HTML的文字：");
            string input = Console.ReadLine();
            Console.WriteLine($"\n轉成HTML如下：");
            Console.WriteLine(FunctionHw01_textToHTML(input));

            //結尾排版
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static string FunctionHw01_textToHTML(string input)
        {
            string input_new = input;
            input_new = input_new.Insert(0, "<p>");
            input_new = input_new.Insert(input_new.Length, "</p>");
            input_new = input_new.Replace(">", "&gt");
            input_new = input_new.Replace("<", "&lt");
            input_new = input_new.Replace(@"\r\n", "<br>");
            input_new = input_new.Replace("|", "&brvbar");
            input_new = input_new.Replace(" ", "&nbsp");


            return input_new;
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw02()
        {
            Console.WriteLine("Function-2. 寫一個function，回傳輸入的值是否數字\n");

            Console.Write("請輸入內容，我會判斷輸入內容是否為數字：");
            string input = Console.ReadLine();

            FunctionHw02_IsNumber(input);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void FunctionHw02_IsNumber(string input)
        {
            string pattern = @"^\d+$";
            Regex RegOj = new Regex(pattern);
            if (RegOj.IsMatch(input))
            {
                Console.WriteLine("\n輸入內容為數字");
            }
            else
            {
                Console.WriteLine("\n輸入內容不是數字");
            }
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw03()
        {
            Console.WriteLine("Function-3. 寫一個function，回傳輸入的值是否符合E-mail格式\n");
            Console.Write("請輸入內容，我會判斷輸入內容是否為E-mail格式：");
            string input = Console.ReadLine();

            FunctionHw03_IsEmail(input);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void FunctionHw03_IsEmail(string input)
        {
            string pattern = @"^\w+@\w+[.]\w+$";
            Regex RegOj = new Regex(pattern);
            if (RegOj.IsMatch(input))
            {
                Console.WriteLine("\n輸入內容為E-mail格式");
            }
            else
            {
                Console.WriteLine("\n輸入內容不是E-mail格式");
            }
        }


        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw04()
        {
            Console.WriteLine("Function-4. 寫一個function，回傳輸入的值是否符合手機格式\n");
            Console.Write("請輸入內容，我會判斷輸入內容是否手機號碼格式(09開頭的10位數字)：");
            string input = Console.ReadLine();

            FunctionHw04_IsPhoneNumber(input);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void FunctionHw04_IsPhoneNumber(string input)
        {
            string pattern = @"^09[0-9]{8}";
            Regex RegOj = new Regex(pattern);
            if (RegOj.IsMatch(input))
            {
                Console.WriteLine("\n輸入內容為手機格式");
            }
            else
            {
                Console.WriteLine("\n輸入內容不是手機格式");
            }
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw05()
        {
            Console.WriteLine("Function-5. 寫一個function，回傳輸入的值是否符合身分證字號格式\n");
            Console.Write("請輸入內容，我會判斷輸入內容是否身份證字號格式：");
            string input = Console.ReadLine();

            FunctionHw05_IsId(input);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void FunctionHw05_IsId(string input)
        {
            string pattern = @"^[a-zA-Z][1-2]\d{8}";
            Regex RegOj = new Regex(pattern);
            if (RegOj.IsMatch(input))
            {
                Console.WriteLine("\n輸入內容為身分證字號格式");
            }
            else
            {
                Console.WriteLine("\n輸入內容不是身分證字號格式");
            }
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw06()
        {
            Console.WriteLine("Function-6. 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點\n");
            Console.WriteLine("請輸入N與文字內容，我會判斷輸入內容是否大於N個字：\n");
            Console.Write("請輸入N：");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入文字內容：");
            string input = Console.ReadLine();

            FunctionHw06_IsMoreN(input, N);



            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void FunctionHw06_IsMoreN(string input, int N)
        {
            string input_new = input;
            int input_Length = input_new.Length;
            if (input_new.Length > N)
            {
                input_new = input_new.Remove(N);
                for (int i = N; i < input_Length; i++)
                {
                    input_new += '.';
                }
            }

            Console.WriteLine($"\n轉換後的內容為：{input_new}");
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw07()
        {
            Console.WriteLine("Function-7. 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式\n");
            Console.Write("請輸入一個日期(yyyy/mm/dd)，我會把該日期轉成民國年.月.日格式：");
            string input = Console.ReadLine();

            FunctionHw07_ToYearRepublic(input);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void FunctionHw07_ToYearRepublic(string input)
        {
            string pattern = @"^\d{4}/\d{1,2}/\d{1,2}$";
            Regex RegOj = new Regex(pattern);
            if (!RegOj.IsMatch(input))
            {
                Console.WriteLine("輸入錯誤");
                return;
            }
            int[] Dates = new int[3];
            Dates = input.Split('/').Select(int.Parse).ToArray();
            if (1911 < Dates[0])
            {
                Dates[0] -= 1911;
            }
            else
            {
                Console.WriteLine("年份輸入錯誤");
                return;
            }


            Console.WriteLine($"\n輸出內容如下：{Dates[0]}/{Dates[1]}/{Dates[2]}");


        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw08()
        {
            Console.WriteLine("Function-8. 寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式\n");
            Console.Write("請輸入一個西元年的日期(yyyy/mm/dd)：");
            string input = Console.ReadLine();

            FunctionHw08_ToYearRepublic(input);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void FunctionHw08_ToYearRepublic(string input)
        {
            string pattern = @"^\d{4}/\d{1,2}/\d{1,2}$";
            Regex RegOj = new Regex(pattern);
            if (!RegOj.IsMatch(input))
            {
                Console.WriteLine("輸入錯誤");
                return;
            }
            int[] DateValue = new int[3];
            DateValue = input.Split('/').Select(int.Parse).ToArray();
            DateTime Date = new DateTime(DateValue[0], DateValue[1], DateValue[2]);

            string[] Days = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };

            if (1911 < DateValue[0])
            {
                DateValue[0] -= 1911;
            }
            else
            {
                Console.WriteLine("年份輸入錯誤");
                return;
            }



            Console.WriteLine($"\n輸出內容如下：");
            Console.WriteLine($"民國{DateValue[0]}年{DateValue[1]}月{DateValue[2]}日 {Days[(int)Date.DayOfWeek]}");


        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw09()
        {
            Console.WriteLine("Function-9. 寫一個function，回傳輸入的年是否閏年\n");
            Console.Write("請輸入一個西元年：");
            int year = Convert.ToInt32(Console.ReadLine());

            FunctionHw09_IsLeapYear(year);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void FunctionHw09_IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year}年是閏年");
            }
            else
            {
                Console.WriteLine($"{year}年不是閏年");
            }

        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        public static void FunctionHw10()
        {
            Console.WriteLine("Function-10. 寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)\n");
            Console.Write("請輸入手機號碼(10位數字)：");
            string PhoneNumner = Console.ReadLine();

            FunctionHw10_Lucky(PhoneNumner);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void FunctionHw10_Lucky(string PhoneNumner)
        {
            string pattern = @"09[0-9]{8}$";
            Regex RegOj = new Regex(pattern);
            if (!RegOj.IsMatch(PhoneNumner))
            {
                Console.WriteLine("輸入錯誤");
                return;
            }
            double luckynumber = Convert.ToDouble(PhoneNumner.Substring(6));

            luckynumber /= 80;
            luckynumber -= (int)luckynumber;
            luckynumber *= 80;

            Console.WriteLine($"\n你代表吉凶的數字為{luckynumber}。");
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------

        public static void StringHw01()
        {
            Console.WriteLine("字串-1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。\n");
            Console.Write("請輸入姓名：");
            string name = Console.ReadLine();
            string output = name;
            output = output.Insert(0, "Hi~");
            Console.WriteLine();
            Console.WriteLine(output);



            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------

        public static void StringHw02()
        {
            Console.WriteLine("字串-2.請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。\n");

            Console.Write("請輸入要搜尋的字：");

            string search = Console.ReadLine();
            Console.WriteLine();


            if ("人人為我，我為人人、饒人不癡漢，癡漢不饒人".Contains(search))
            {
                Console.WriteLine($"\"{search}\"有包含在這個字串中");
            }
            else
            {
                Console.WriteLine($"\"{search}\"沒有包含在這個字串中");

            }
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------

        public static void StringHw03()
        {
            Console.WriteLine("字串-3.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。\n");
            Console.Write("請輸入一段字：");
            string texts = Console.ReadLine();

            for (int i = texts.Length - 1; i > 0; i--)
            {
                texts = texts.Insert(i, "-");
            }

            Console.WriteLine($"輸出結果為：{texts}");

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------

        public static void StringHw04()
        {
            Console.WriteLine("字串-4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。\n");
            Console.Write("請輸入一個檔名：");
            string fileName = Console.ReadLine();

            Console.WriteLine($"副檔名為：{fileName.Substring(fileName.IndexOf(".")+1)}");


            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------

        public static void StringHw05()
        {
            Console.WriteLine("字串-5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length  Substring()\n");
            Console.Write("請輸入一個單字：");
            string word = Console.ReadLine();
            if (word.Length > 5)
            {
                Console.WriteLine($"\n輸出結果：{word.Substring(0, 3)}");
            }
            else
            {
                Console.WriteLine("\n長度不夠。");
            }

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------

        public static void StringHw06()
        {
            Console.WriteLine("字串-6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()\n");
            Console.Write("請輸入一段字：");
            string input = Console.ReadLine();

            Console.WriteLine($"\n輸出結果：{input.Replace("我","小明")}");


            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------

        public static void StringHw07()
        {
            Console.WriteLine("字串-7.輸入一串字，顯示輸入幾個字。Length\n");
            Console.Write("請輸入一段字：");
            string input = Console.ReadLine();

            Console.WriteLine($"\n你一共輸入{input.Length}個字");

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------

        public static void StringHw_additional01()
        {
            Console.WriteLine("字串補充題-1.連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。\n");
            string[] inputs = new string[10];
            for (int i = 0; i < inputs.Length; i++)
            {
                string temp = Console.ReadLine();
                if(inputs.Contains(temp))
                {
                    Console.WriteLine("此字串輸入過。\n");
                }
                else
                {
                    Console.WriteLine("此字串還沒輸入過。\n");
                }
                inputs[i] = temp;
            }
            Console.WriteLine("\n執行完畢");
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------


        public static void StringHw_additional02()
        {
            Console.WriteLine("字串補充題-2.用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出");
            Console.WriteLine("Fifa");
            Console.WriteLine("fIfa");
            Console.WriteLine("fiFa");
            Console.WriteLine("fifA");
            Console.WriteLine();

            Console.Write("請輸入一個字母：");
            string input = Console.ReadLine();
            string output=input;
            Console.WriteLine();

            for (int i=0; i<output.Length; i++)
            {
                output=output.ToLower();
                output =output.Substring(0,i)+ output.Substring(i,1).ToUpper()+ output.Substring(i+1);
                Console.WriteLine(output);
            }


            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------


        public static void StringHw_additional03()
        {
            Console.WriteLine("字串補充題-3.輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。\n");
            string input;
            while(true)
            {
                Console.Write("請輸入一個時間(ex:11:30)：");
                input= Console.ReadLine();
                string pattern = @"\d{1,2}:\d{1,2}$";
                Regex regOj=new Regex(pattern);
                if(regOj.IsMatch(input))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("輸入錯誤，請重新輸入。\n");
                }
            }

            string output = input.Replace(":", "點")+"分";

            Console.WriteLine($"\n{output}");



            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------


        public static void StringHw_additional04()
        {
            Console.WriteLine("字串補充題-4.輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出");
            Console.WriteLine("<ul>");
            Console.WriteLine("     <li>Justin<li>");
            Console.WriteLine("     <li>Amy<li>");
            Console.WriteLine("     <li>David<li>");
            Console.WriteLine("</ul>");
            Console.WriteLine();

            Console.Write("請輸入內容，各項內容用,隔開：");
            string input= Console.ReadLine();
            string[] outputs = input.Split(',');
            Console.WriteLine("<ul>");
            foreach(string element in outputs) 
            { 
                Console.WriteLine($"\t <li>{element}</li>");
            }
            Console.WriteLine("</ul>");

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------


        public static void StringHw_additional05()
        {
            Console.WriteLine("字串補充題-5.輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87\n");
            Console.WriteLine("請輸入5個數字，數字間用空白隔開(ex:11 19 12 25 1 7 12)");
            string input=Console.ReadLine();
            double[] numbers=input.Split(' ').Select(Double.Parse).ToArray();
            Console.WriteLine("\n輸出結果如下：");

            Console.WriteLine($"{input}，輸出總和是{numbers.Sum()}");




            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------


        public static void StringHw_additional06()
        {
            Console.WriteLine("字串補充題-6.輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ\n");
            Console.Write("請輸入一段文字：");
            string input = Console.ReadLine();
            char[] ArrCharInput = input.ToCharArray();
            Array.Reverse(ArrCharInput);
            string output= string.Concat(ArrCharInput);
            Console.WriteLine($"\n輸出如下：\n{output}");


            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        //---------------------------------------------------------------
        //---------------------------------------------------------------
        //---------------------------------------------------------------


    }
}

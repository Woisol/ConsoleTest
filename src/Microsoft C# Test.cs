// //08-16

// using System;
// int a = 1;
// int b = 2;
// int res = Math.Max(a,b);//注意Math的调用需要System，只能比较两个数
// Console.WriteLine($"The Larger Numb is {res}");



//08-17

//Test1
// System.Console.WriteLine("New Intellicode Test");

//Test2
// var Name ="Bob";
// var InboxNumbs = 3;
// var Temp = 34.3;
// System.Console.WriteLine($"Hello, {Name}! You Have {InboxNumbs} in your inbox. The temperature is {Temp} celsius.");

// //Test3
// string projectName = "ACME";
// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// System.Console.WriteLine($@"
// View English output:
//     c:\Exercise\{projectName}\data.txt

// {russianMessage}:
//     c:\Exerise\{projectName}\ru-RU\data.txt");



//08-20

// //test4
// using System;;
// Random dice = new Random();
// int roll1 = dice.Next(7);
// int t = dice.Next(7);
// if (roll1 == t)
// {
//     t = dice.Next();
//     if (roll1 == t)
//     {
//         Console.WriteLine($"All are {roll1}, the SAME!");
//     }
//     else
//     {
//         int t2 = dice.Next();
//         if (roll1 == t2||t ==  t2)
//     //if后面的语句如果多了一个；会导致语句一定被执行,同时导致后面的else因为if被结束而出现“else can not start a statement”
//         {
//             Console.WriteLine($"{roll1},{t},{t2},some two are the same!");
//         }
//     }
// }
// else
// {
//     Console.WriteLine($"{roll1},{t},{t2},None are the same!");
// }
//烂尾，不如直接3个变量

// //Test5
// using System;
// string[] fradulentOrderIDs = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
// foreach (string Id in fradulentOrderIDs)
// {
//     if (Id.StartsWith("B"))
//     //注意是Starts………………不要漏了那个s！！！
//     {
//         Console.WriteLine($"{Id}");
//     }
// }



//08-21

// //Test6
// using System;
// Random random = new Random();
// string[] orderIDs = new string[5];
// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into a char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;
// }
// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }



//08-22

//Test7 Student Granding
// using System;
// namespace StudentGranding
// {
// 	class StudentGrandingClass
// 	{
// 		static void Main(string[] args)
// 		{
// 			float calTotalGrade(int[] grades)
// 			{
// 				float res = 0;
// 				foreach (int grade in grades)
// 				{
// 					res += grade;
// 				}
// 				return (res/5);
// 				//注意这里都已经是用（float）了返回值就不要再下意识用int了…………
// 			}

// 			string[] studentName = {"Sophia","Andrew","Emma","Logan"};
// 			int[] sophiaGrade = new int[5]{90,86,87,98,100};
// 			int[] andrewGrade = new int[5]{92,89,81,96,90};
// 			int[] emmaGrade = new int[5]{90,85,87,98,68};
// 			int[] loganGrade = new int[5]{90,95,87,88,96};

// 			float sophiaTotalGrade = calTotalGrade(sophiaGrade);
// 			float andrewTotalGrade = calTotalGrade(andrewGrade);
// 			float emmaTotalGrade = calTotalGrade(emmaGrade);
// 			float loganTotalGrade = calTotalGrade(loganGrade);
// 			//注意数组作为参数传导时不需要[]!!!

// 			string calRank(float totalGrade)
// 			{
// 				if (97<=totalGrade && totalGrade<=100){return("A+");}
// 				if (93<=totalGrade && totalGrade<=97){return("A");}
// 				//string返回值不能用char………………
// 				if (90<=totalGrade && totalGrade<=93){return("A-");}
// 				if (87<=totalGrade && totalGrade<=90){return("B+");}
// 				if (83<=totalGrade && totalGrade<=87){return("B");}
// 				if (80<=totalGrade && totalGrade<=83){return("B-");}
// 				if (77<=totalGrade && totalGrade<=80){return("C+");}
// 				if (73<=totalGrade && totalGrade<=77){return("C");}
// 				if (70<=totalGrade && totalGrade<=73){return("C-");}
// 				if (67<=totalGrade && totalGrade<=70){return("D+");}
// 				if (63<=totalGrade && totalGrade<=67){return("D");}
// 				if (60<=totalGrade && totalGrade<=63){return("D-");}
// 				if (0<=totalGrade && totalGrade<=60){return("F");}
// 				//mdsb 这里的totalGrade不是整数值！！！！！<=和<不同！！！
// 				else {return("error");}
// 				//注意不要漏掉特殊情况
// 			}

// 			Console.WriteLine($"Student\t\tGrade\nSophia\t\t{sophiaTotalGrade}\t{calRank(sophiaTotalGrade)}\nAndrew\t\t{andrewTotalGrade}\t{calRank(andrewTotalGrade)}\nEmma\t\t{emmaTotalGrade}\t{calRank(emmaTotalGrade)}\nLogan\t\t{loganTotalGrade}\t{calRank(loganTotalGrade)}\n");
// 			//似乎使用这个时是不能换行的…………要用换行的形式必须用@
// 			//@New Bing C#不能使用\来表示字符串的延续！！！

// 		}
// 	}
// }
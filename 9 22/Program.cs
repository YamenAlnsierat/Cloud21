//Console.WriteLine(DateTime.MaxValue); 
//string name = "Fredrik";
//name.ToUpper();
//string.Empty == ""



//Console.WriteLine(DateTime.Now);
//DateTime.UtcNow.Dump();
//DateTime.Today.Dump();

//DateTime.Now.Year.Dump();
//DateTime.Now.Month.Dump();
//DateTime.Now.Day.Dump();
//DateTime.Now.Hour.Dump();
//DateTime.Now.Minute.Dump();
//DateTime.Now.Second.Dump();
//DateTime.Now.Millisecond.Dump();
//DateTime.Now.DayOfYear.Dump();
//DateTime.Now.DayOfWeek.Dump();

//DateTime.Now.Ticks.Dump();

//DateTime.Now.AddDays(5).Dump();
//DateTime.Now.AddHours(1.3).Dump();


//DateTime myTime = new DateTime(2021, 8, 15, 11, 30, 3);

////DateTime.Now.Subtract(myTime).Dump();


//TimeSpan timeDiff = (DateTime.Now - myTime);
//timeDiff.Dump();
//timeDiff.Hours.Dump();
//timeDiff.TotalHours.Dump();
//DateTime.IsLeapYear(2021).Dump();

//DateTime myBirthDay = new DateTime(1981, 2, 4);
//TimeSpan diff = DateTime.Today - myBirthDay;
//diff.Dump();
//DateTime.Now.Add(diff).Dump();

//(DateTime.Now.Year - myBirthDay.Year).Dump();

//TimeSpan.FromSeconds(4000).Dump();




//string myString = String.Empty;
//Console.WriteLine("Fredrik Johansson".Length);

//string name = "Fredrik";
//Console.WriteLine(name[3]);

//"Fredrik".ToLower().Dump();
//"Fredrik".ToUpper().Dump();

//// Trim-metoder
//"\tHello\n\n\n".Dump();
//("-" + "   Fredrik Johansson   ".Trim() + "-").Dump();
//("-" + "   Fredrik Johansson   ".TrimStart() + "-").Dump();
//("-" + "   Fredrik Johansson   ".TrimEnd() + "-").Dump();
//"**   jj  *FREDRIK JOHANSSON***jjj*j*j*   *".Trim('*', 'j', ' ').Dump();

//// Null or whitespace
//String.IsNullOrEmpty(null).Dump();
//String.IsNullOrWhiteSpace("x   ").Dump();

//// Start, End, Contain
//"Fredrik".StartsWith("Fre").Dump();
//"Fredrik".EndsWith("ik").Dump();
//"Fredrik".Contains("dri").Dump();
//"Hej jag heter Fredrik!".Contains("fredrik", StringComparison.InvariantCultureIgnoreCase).Dump();

//// Concat & Join
//string[] names = { "Fredrik", "Anna", "Anders", "Karl" };
//("Fredrik" + "Kalle" + "Pelle").Dump();
//$"{"Fredrik"}{"Kalle"}{"Pelle"}".Dump();
//String.Concat("Fredrik", "Kalle", "Pelle").Dump();
//String.Concat(names).Dump();
//String.Join(", ", names).Dump();

//// Substring
//"Fredrik Johansson".Substring(3).Dump();
//"Fredrik Johansson".Substring(3, 8).Dump();
//"Fredrik Johansson".Remove(3).Dump();
//"Fredrik Johansson".Remove(3, 8).Dump();
//"Fredrik Johansson är ganska rik!".Replace("rik", "ABC").Dump();
//"Fredrik Johansson".Insert(3, "HEJ").Dump();
//string[] fullNames = "Fredrik Johansson, Anna Karlsson, Pelle Svensson".Split(", ");

//foreach (string word in fullNames)
//{
//	word.Dump();
//}

//// Padding
//"Fredrik".PadLeft(20).Dump();
//"Fredrik".PadLeft(20, '*').Dump();
//"Fredrik".PadRight(20, '*').Dump();

//string[] firstNames = { "Fredrik", "Anna", "Anders", "Karl" };
//foreach (string firstName in firstNames)
//{
//	firstName.PadLeft(20).Dump();
//}

//// Index Of
//"Fredrik".IndexOf('r').Dump();
//"Fredrik".IndexOf("abc").Dump();
//"Fredrik".LastIndexOf('r').Dump();
//"Fredrik".IndexOfAny(new char[] { 'k', 'd' }).Dump();



//Console.WriteLine(MyMethod(Math.Abs(-5.5)))

// Method chaining
//"Hello".ToUpper().Replace("el", "HEJ").Dump();




// Absolutbelopp
//Math.Abs(-5.5).Dump();

//// Avrunding
//Math.Floor(5.9).Dump();
//Math.Ceiling(-5.8).Dump();
//Math.Round(5.2).Dump();
//Math.Round(5.6).Dump();
//Math.Truncate(-5.8).Dump();

//// Min, Max, Clamp
//Math.Min(5.4, 4.3).Dump();
//Math.Max(5.4, 4.3).Dump();
//Math.Clamp(195, 0, 100).Dump();

//// Övriga
//Math.Pow(2, 8).Dump();
//Math.Sqrt(9.5).Dump();

//// Ternery operator
//x = (input > 100 ? 100 : x);
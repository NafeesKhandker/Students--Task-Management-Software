// Create a DateTime from date and time  
DateTime dob = new DateTime(1974, 7, 10, 7, 10, 24);  
   
// Create a DateTime from a String  
string dateString = "7/10/1974 7:10:24 AM";  
DateTime dateFromString =  
    DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);  
Console.WriteLine(dateFromString.ToString());  
   
// Empty DateTime  
DateTime emptyDateTime = new DateTime();  
   
// Just date  
DateTime justDate = new DateTime(2002, 10, 18);  
   
// DateTime from Ticks  
DateTime justTime = new DateTime(1000000);  
   
// DateTime with localization  
DateTime dateTimeWithKind = new DateTime(1974, 7, 10, 7, 10, 24, DateTimeKind.Local);  
   
// DateTime with date, time and milliseconds  
DateTime dateTimeWithMilliseconds = new DateTime(2010, 12, 15, 5, 30, 45, 100);

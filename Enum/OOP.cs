using System;

namespace visual_studio
{
    
   public class Months
    {
       public enum months{January,February,March,April,May,June,July,August,September,October,November,December}
      
       public void print()
       {
         foreach(int item in Enum.GetValues(typeof(months)))
		  {
			  Console.Write($"{Enum.GetName(typeof(months),item)}");
			  Console.WriteLine(" "+item);
		  }
		  

       }
      
    }

}


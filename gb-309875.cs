using System;
using System.Linq;
using System.Text;

public class Program
{
    
    public static void Main()
    {
    
      string[][] ReduceBySomeValues(string[][] WorkArray)
      {
        
        string[][] ReducedArray = new string[WorkArray.Length][];
        
        for (int i = 0; i < WorkArray.Length; i++)
        {   
          int l = WorkArray[i].Length;			
        	string[] ReducedString = new string[l];
        	int count = 0;
          for (int j = 0; j < l; j++)
          {
            if(WorkArray[i][j].Length <= 3)
            {
        		  ReducedString[count] = WorkArray[i][j];
        			count++;
        		  }
         		}
         		Array.Resize(ref ReducedString, count);
        	  ReducedArray[i] = ReducedString;
        	}  
        
        return ReducedArray;
        
        }  
        
    string[][] IArray = new string[3][];
    IArray[0] = new string[] {"Hello", "2", "world", ";-)"};
	  IArray[1] = new string[] {"1234", "1567", "-1", "computer science"};
	  IArray[2] = new string[] {"Code", "Data", "IT"};
        
    string[][] ResArray = ReduceBySomeValues(IArray);
      
	  if (ResArray.Count() == 0)
		{
		  Console.WriteLine("Ничего не осталось, либо ничего не было.");
		}
    else
    Console.WriteLine("Получился следующий массив:");
    Console.Write(ResArray);
	  }
    
}

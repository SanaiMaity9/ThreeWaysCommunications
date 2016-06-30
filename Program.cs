using System;

namespace ThreeWayCommunication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Connection connection = new Connection();
           int x1, x2, x3, y1, y2, y3 , r , t;
           Console.WriteLine("no of connection ");
           t = Convert.ToInt32(Console.ReadLine());
           if(t<=100){
            while(t != 0){
                Console.WriteLine("Meters to check the connection");
                r = Convert.ToInt32(Console.ReadLine());
                    if(r<=1000){
                        int count = 0;
                        Console.WriteLine("Connection in Bytes");
                        x1 = Convert.ToInt32(Console.ReadLine());
                        y1 = Convert.ToInt32(Console.ReadLine());
                        x2 = Convert.ToInt32(Console.ReadLine());
                        y2 = Convert.ToInt32(Console.ReadLine());
                        x3 = Convert.ToInt32(Console.ReadLine());
                        y3 = Convert.ToInt32(Console.ReadLine());
                        if(connection.CheckConnection(x1-x2,y1-y2,r)){
                            count++;
                        }
                        if(connection.CheckConnection(x2-x3,y2-y3,r)){
                            count++;
                        }
                        if(connection.CheckConnection(x3-x1,y3-y1,r)){
                            count++;
                        }
                        if(count > 1){
                            Console.WriteLine("Yes");
                        }
                        else{
                            Console.WriteLine("No");
                        }
                    }
                    t--;
                   }
              } 
        }
    }
}

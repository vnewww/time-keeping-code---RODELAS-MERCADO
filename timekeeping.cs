using System;
class TimeKeeping {
  static void Main() {
      string name;
      string time1, time2, ToutR;
      double hour1, hour2, min1, min2;
      double sum1, sum2, Rhours, Rgp, Overtm, Overth, underH, Total;
      double whi = 08;
      double wmi = 00;
      double who = 17;
      double wmo = 00;
      double graceP = 30;
      char c = ':';
      char Tout;
      
      Console.WriteLine("Enter your full name");
      name = Console.ReadLine();
      Console.WriteLine(" ");
      Console.WriteLine("Hello " + name);
      Console.WriteLine("Enter the time of your time in (24h format/Military time)");
      time1 = Console.ReadLine();
      hour1 = Convert.ToInt32(time1.Split(c)[0]);
      min1 = Convert.ToInt32(time1.Split(c)[1]);
        
      if(hour1 > 23 || min1 > 59){
          Console.WriteLine("Worng input");
      }
      else{
          Console.WriteLine("Time in: " + hour1.ToString("00") + c + min1.ToString("00"));
      }
        Console.WriteLine("Are you ready to time out? Y/N");
        Tout = Convert.ToChar(Console.ReadLine());
        
        switch(Tout){
            case 'y':
            case 'Y':
            Console.WriteLine("Enter the time of your time out (24h format/Military time)");
            time2 = Console.ReadLine();
            hour2 = Convert.ToInt32(time2.Split(c)[0]);
            min2 = Convert.ToInt32(time2.Split(c)[1]);
            
            if(hour2 > 23 || min2 > 59){
            Console.WriteLine("Worng input");
            }
            else{
                Console.WriteLine("Time out: " + hour2.ToString("00") + c + min2.ToString("00"));
                
                if(hour2 > hour1){
                    sum1 = hour1 * 3600 + min1 * 60;
                    sum2 = hour2  * 3600 + min2 * 60;
                    Rhours = (sum2 - sum1) / 60 / 60;
                    Rgp = graceP - min1;
                    
                    if(hour1 == 8){
                        Console.WriteLine(" ");
                        Console.WriteLine("Employee: " + name);
                        Console.WriteLine("The working hours is " + whi.ToString("00") + c + wmi.ToString("00") + " to " + who.ToString("00") + c + wmo.ToString("00"));
                        Console.WriteLine("The company have 30 minutes grace period");
                        Console.WriteLine("Time in: " + hour1.ToString("00") + c + min1.ToString("00"));
                        Console.WriteLine("You have " + Rgp + " minutes left in your 30 minutes grace period (if the minutes is negative it means you're late)");
                        Console.WriteLine("Time out: " + hour2.ToString("00") + c + min2.ToString("00"));
                        Console.WriteLine("Total number of hours you work for is " + Rhours);
                        
                        if(hour2 == 17){
                            Overtm = min2 + wmo;
                            Console.WriteLine("You have " + Overtm + " minutes of over time");
                        }
                        else if(hour2 > 17){
                            Overth = hour2 - who;
                            Overtm = min2 + wmo;
                            Console.WriteLine("You have " + Overth + " hours and " + Overtm + " minutes of overtime");
                        }
                        else if(hour2 < 17){
                            underH = 9 - Rhours;
                            Total = underH * 60;
                            Console.WriteLine("You have " + Total + " minutes of undertime");
                        }
                        else{
                            Console.WriteLine("No overtime or undertime hours");
                        }
                    }
                    else if(hour1 > 8){
                        Console.WriteLine(" ");
                        Console.WriteLine("Employee: " + name);
                        Console.WriteLine("The working hours is " + whi.ToString("00") + c + wmi.ToString("00") + " to " + who.ToString("00") + c + wmo.ToString("00"));
                        Console.WriteLine("The company have 30 minutes grace period");
                        Console.WriteLine("Time in: " + hour1.ToString("00") + c + min1.ToString("00"));
                        Console.WriteLine("You're late way pass the grace period");
                        Console.WriteLine("Time out: " + hour2.ToString("00") + c + min2.ToString("00"));
                        Console.WriteLine("Total number of hours you work for is " + Rhours);
                        
                        if(hour2 == 17){
                            Overtm = min2 + wmo;
                            Console.WriteLine("You have " + Overtm + " minutes of over time");
                        }
                        else if(hour2 > 17){
                            Overth = hour2 - who;
                            Overtm = min2 + wmo;
                            Console.WriteLine("You have " + Overth + " hours and " + Overtm + " minutes of overtime");
                        }
                        else if(hour2 < 17){
                            underH = 9 - Rhours;
                            Total = underH * 60;
                            Console.WriteLine("You have " + Total + " minutes of undertime");
                        }
                        else{
                            Console.WriteLine("No overtime or undertime hours");
                        }
                    }
                }
                else{
                    Console.WriteLine("Use 24h format/Military time");
                }
            }
            
            break;
            
            case 'n':
            case 'N':
            Console.WriteLine("Okay just type READY(all caps) if you're ready to time out.");
            ToutR = Console.ReadLine();
            Console.WriteLine("Enter the time of your time out (24h format/Military time)");
            time2 = Console.ReadLine();
            hour2 = Convert.ToInt32(time2.Split(c)[0]);
            min2 = Convert.ToInt32(time2.Split(c)[1]);
            
            if(hour2 > 23 || min2 > 59){
            Console.WriteLine("Worng input");
            }
            else{
                Console.WriteLine("Time out: " + hour2.ToString("00") + c + min2.ToString("00"));
                
                if(hour2 > hour1){
                    sum1 = hour1 * 3600 + min1 * 60;
                    sum2 = hour2  * 3600 + min2 * 60;
                    Rhours = (sum2 - sum1) / 60 / 60;
                    Rgp = graceP - min1;
                    
                    if(hour1 == 8){
                        Console.WriteLine(" ");
                        Console.WriteLine("Employee: " + name);
                        Console.WriteLine("The working hours is " + whi.ToString("00") + c + wmi.ToString("00") + " to " + who.ToString("00") + c + wmo.ToString("00"));
                        Console.WriteLine("The company have 30 minutes grace period");
                        Console.WriteLine("Time in: " + hour1.ToString("00") + c + min1.ToString("00"));
                        Console.WriteLine("You have " + Rgp + " minutes left in your 30 minutes grace period (if the minutes is negative it means you're late)");
                        Console.WriteLine("Time out: " + hour2.ToString("00") + c + min2.ToString("00"));
                        Console.WriteLine("Total number of hours you work for is " + Rhours);
                        
                        if(hour2 == 17){
                            Overtm = min2 + wmo;
                            Console.WriteLine("You have " + Overtm + " minutes of over time");
                        }
                        else if(hour2 > 17){
                            Overth = hour2 - who;
                            Overtm = min2 + wmo;
                            Console.WriteLine("You have " + Overth + " hours and " + Overtm + " minutes of overtime");
                        }
                        else if(hour2 < 17){
                            underH = 9 - Rhours;
                            Total = underH * 60;
                            Console.WriteLine("You have " + Total + " minutes of undertime");
                        }
                        else{
                            Console.WriteLine("No overtime or undertime hours");
                        }
                    }
                    else if(hour1 > 8){
                        Console.WriteLine(" ");
                        Console.WriteLine("Employee: " + name);
                        Console.WriteLine("The working hours is " + whi.ToString("00") + c + wmi.ToString("00") + " to " + who.ToString("00") + c + wmo.ToString("00"));
                        Console.WriteLine("The company have 30 minutes grace period");
                        Console.WriteLine("Time in: " + hour1.ToString("00") + c + min1.ToString("00"));
                        Console.WriteLine("You're late way pass the grace period");
                        Console.WriteLine("Time out: " + hour2.ToString("00") + c + min2.ToString("00"));
                        Console.WriteLine("Total number of hours you work for is " + Rhours);
                        
                        if(hour2 == 17){
                            Overtm = min2 + wmo;
                            Console.WriteLine("You have " + Overtm + " minutes of over time");
                        }
                        else if(hour2 > 17){
                            Overth = hour2 - who;
                            Overtm = min2 + wmo;
                            Console.WriteLine("You have " + Overth + " hours and " + Overtm + " minutes of overtime");
                        }
                        else if(hour2 < 17){
                            underH = 9 - Rhours;
                            Total = underH * 60;
                            Console.WriteLine("You have " + Total + " minutes of undertime");
                        }
                        else{
                            Console.WriteLine("No overtime or undertime hours");
                        }
                    }
                }
                else{
                    Console.WriteLine("Use 24h format/Military time");
                }
            }
            
            break;
        }
  }
}
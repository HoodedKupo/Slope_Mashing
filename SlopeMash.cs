using System;
using System.Windows.Forms;
/**
Author: HoodedKupo
this program will wait 5 seconds after being run to start clicking the "D" button
to call the program type "SlopeAuto [int:clicks] [char:DisplayProgress]"
    clicks: the amount of times the D key will be clicked before enter
            set clicks to 0 to have the program infinitly press D
    DisplayProgress: type anything in to indicate that you want the console to display
                     how many times D has been pressed so far.

 **NOTE: to access the infinite loop feature simply comment out line 24
   (the line that has a comment and reads "return")**
**/
public class main{
    public static void Main(string[] args){
        int clicks = 0;
        if(args.Length > 0){
            clicks = Int32.Parse(args[0]);
        }
        System.Threading.Thread.Sleep(5000);
            
        if(clicks == 0){
            return; //Saftey because general public won't know how to exit an infinite loop
            while(true){
                SendKeys.SendWait("{D}");
            }
        }else{
            Console.WriteLine(DateTime.Now);
            for(int i=0; i< clicks; i++){
                if(args.Length >= 2){
                    Console.WriteLine(i);
                }
                SendKeys.SendWait("{D}");
            }
            Console.WriteLine(DateTime.Now);
            SendKeys.SendWait("{Enter}");
        }
    }
}
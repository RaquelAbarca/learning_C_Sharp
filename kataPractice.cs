using System;

public class Program
{
public static void Main(string[] args)
    {
    string events = "..P......";
    bool complet = false;
    string progress = "";
    int i = 0;
    int fase = 0;
  
    string[] eventsArray = events.Split("");
  
    do{
      if(eventsArray[i] == "."){
        progress += "0";
        ++i;}
      else if(eventsArray[i] == "P")
        progress += ToString()

    } while (i == eventsArray.lenght);

  }
  
  public static void open() 
  {
    Console.WriteLine("I just got executed!");
  }
  
  Console.WriteLine(progres);
  }

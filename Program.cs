using EmergencyQueue_Crownhart;
using System;
using System.Linq;

Console.WriteLine("To begin Emergency Room Queue press y ");
string start = Console.ReadLine().ToLower();



if (start != "y")
{
    Console.WriteLine("Goodbye!");
    return;
}
Console.WriteLine("These are the patients currently in the queue: ");
EmergencyRoom EmergencyQueue = new EmergencyRoom();
EmergencyQueue.Enqueue(new EmergencyPatients("Mickey Mouse"), 2);
EmergencyQueue.Enqueue(new EmergencyPatients("Fred Flintstone"), 1);
EmergencyQueue.Enqueue(new EmergencyPatients("George Jetson"), 2);
EmergencyQueue.Enqueue(new EmergencyPatients("Barney Rubble"), 3);
EmergencyQueue.Enqueue(new EmergencyPatients("Johnny Quest"), 1);
EmergencyQueue.patientsNames();
EmergencyQueue.ECount();



BeginQueue();



void MainMenu()
    

{
    Console.WriteLine(" EMERGENCY ROOM QUEUE  ");
    Console.WriteLine("***********************");
    Console.WriteLine("*      Add            *");
    Console.WriteLine("*      Remove         *");
    Console.WriteLine("*      List           *");
    Console.WriteLine("*      Exit           *");
    Console.WriteLine("***********************");
}

void BeginQueue()
{
    while (start == "y")
    {
        MainMenu();
        Console.WriteLine("Choose from one of the following");
        string choice;
        choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "add":
                
                string pName;
                string p;
                int priority = 0;
                Console.WriteLine("Please type the patient's first name and last name");
                pName = Console.ReadLine();
                if(pName == "")
                {
                    while (pName == "")
                    {
                        Console.WriteLine("You didn't type anything");
                        pName = Console.ReadLine();
                    }
                    
                }
                
                Console.WriteLine("What is the patent's priority? 1 or 2 or 3");
                p = Console.ReadLine();
                if(p == "1" || p == "2" || p == "3")
                {
                    priority = Convert.ToInt32(p);
                }
                else
                {
                    while (p != "1" || p != "2" || p != "3")
                    {
                        Console.WriteLine("You need to type a 1 or a 2 or a 3");
                        p = Console.ReadLine();
                        if (p == "1" || p == "2" || p == "3")
                        {
                            break;
                        }
                    }
                }
                EmergencyQueue.Enqueue(new EmergencyPatients(pName), priority);
                Console.WriteLine(pName + " has been added with a number " + priority +" priority.");
                pName = "";
                p = "";
                priority = 0;
                EmergencyQueue.ECount();
                break;

            case "remove":
                Console.WriteLine("Do you wish to remove the first person in the queue? y/n");
                string remove = Console.ReadLine();
                
                if (remove == "y")
                {
                    EmergencyQueue.removeNames();
                    
                }
                if (remove == "n")
                {
                    Console.WriteLine("The Queue remains unchanged");
                }
                if (remove != "y" && remove != "n")
                {
                    Console.WriteLine("Didn't catch that...");
                }


                EmergencyQueue.ECount();
                break;

            case "list":

                EmergencyQueue.patientsNames();
                EmergencyQueue.ECount();
                break;
            case "exit":
                Console.WriteLine("Goodbye");
                break;
            default:
                Console.WriteLine("Sorry.... you are not understood");
                break;
        }

        if (choice == "exit".ToLower())
        {
            break;
        }
    }

}
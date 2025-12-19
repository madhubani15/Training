// See https://aka.ms/new-console-template for more information
using Project2;
/*static void Menu()
{
    System.Console.WriteLine("1. Add Student details");
    System.Console.WriteLine("2. Update Student details");
    System.Console.WriteLine("3. Drop Student details");
}*/
Console.WriteLine("Hello, World!");
Student sobj=new Student(123,"Alok","Delhi");

//System.Console.WriteLine("RollNo : {0}\n Name :{1}\n Address :{2}",sobj);

sobj.DisplayDetails(sobj);
sobj=new Student(123,"Alok","Chennai");
sobj.DisplayDetails(sobj);

string[] cities = {"Pune", "Chennai","Agra","Amritsar","Mumbai"};

/*
int i=0;
while(i<cities.Length)
{
    System.Console.WriteLine(cities[i]);
    i++;
}*/

/*
foreach(var item in cities)
{
    System.Console.WriteLine(item);
}*/

// for each gives better working when we want to just print things
// for is better when we want to add/ modify


/*
int choice = 0;
do{

    Menu()
    System.Console.WriteLine("Enter your choice");
    Choice = Int32. Parse(Console.ReadLine);
    switch ()
    {
        case 1{
                break;
            }
        case 2{
                break;
            }
        case 3{
                break;
            }
    }

}while(true)
*/
//Switch case is used when multiple options are present and to avoid nested ifs

using System;

class KonsolProgram
{ 
static void Main()
    { 

Console.WriteLine("Hello, World!");
Console.ReadLine();
Console.Clear();
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Blue;
Console.Beep();
Console.Title = "konsol başlığı";
string degisken ;
degisken = Console.ReadLine();
Console.WriteLine(degisken);
Console.ReadLine();
do
{
    Console.WriteLine(Console.Title);
    Console.WriteLine(Console.WindowLeft);
    Console.WriteLine(
        Console.CapsLock);
    Console.WriteLine(Console.CursorSize);

}
while (Console.CapsLock);
Console.CursorSize = 80;

for (int x = 1; x < 100; x++)
{
    Console.CursorSize = x;
    Console.Read();
}
Console.ReadLine();
}
}
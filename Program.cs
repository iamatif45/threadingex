using ConAppThreadingEx;
using System.ComponentModel;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Thread thread = new Thread(new ThreadStart(OurClass.Display));
Console.WriteLine("Thread Details");
Console.WriteLine("Background:\t"+thread.IsBackground);
Console.WriteLine("Name:\t"+thread.Name);
Console.WriteLine("State:\t"+thread.ThreadState);
Console.WriteLine("Is Alive:\t"+thread.IsAlive);
thread.Start();

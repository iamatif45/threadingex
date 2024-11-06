using ConAppThreadingEx;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Thread thread = new Thread(new ThreadStart(OurClass.Display));
thread.Start();

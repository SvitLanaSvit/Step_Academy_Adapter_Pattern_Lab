//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lab_Adapter_Pattern_1;

RoundHole hole = new RoundHole { Radius = 10};
SquarePeg peg = new SquarePeg { Width = 30 };
SquarePegAdapter pegAdapter = new SquarePegAdapter(peg);
bool res = hole.fits(pegAdapter);
Console.WriteLine(res);
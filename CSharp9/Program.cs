using System;
using System.Collections.Generic;

Person p1 = new(2, "a");
Person p2 = new (2, "a");
Console.WriteLine(p1==p2);
Console.WriteLine(p1);
Person p3 = p2 with { Navn = "b" };
Console.WriteLine(p3);

var (i, n) = p3;

Console.WriteLine(i);
Console.WriteLine(n);

public record Person(int Id, string Navn);





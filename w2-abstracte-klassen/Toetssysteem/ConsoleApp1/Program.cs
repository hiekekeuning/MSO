using System;
using System.Collections.Generic;
using Testing;

MultipleChoice q1 = new ("Wat is de hoofdstad van Letland?", new string[] { "Moskou", "Riga", "Tallinn" }, 'b');
TrueFalse q2 = new("Ligt Letland aan zee?", true);
Open q3 = new("Hoe heet de president van Letland?", "Egils Levits");

List<Question> test1 = new() { q1, q2, q3};
foreach (var item in test1)
{
    Console.WriteLine(item);
}

Console.WriteLine("1 B: " + q1.CheckAnswer("B"));
Console.WriteLine("1 A: " + q1.CheckAnswer("A"));
Console.WriteLine("2 False: " + q2.CheckAnswer("False"));
Console.WriteLine("3 Egils Levits!: " + q3.CheckAnswer("Egils Levits!"));
List<int> listOfNumbers = new List<int>() { 10, 20, 30, 40, 50 , 50};

/*
    le righe 7 e 8 generano un'eccezione semplicemente perchè nella prima riga, vengono trovati più di una corrispondeza,
    la seconda riga, perchè mi da questo messaggio "Sequence contains more than one matching element"
*/
//Console.WriteLine(listOfNumbers.SingleOrDefault(number=> number == 50));
//Console.WriteLine(listOfNumbers.SingleOrDefault(number=> number < 40));
Console.WriteLine(listOfNumbers.SingleOrDefault(number=> number == 60));

Console.WriteLine("------------------------------------");

//Restituisce il primo elemento specifico da un insieme di elementi se viene trovata una o più corrispondenze per tale elemento
Console.WriteLine(listOfNumbers.FirstOrDefault(number=> number == 50));
Console.WriteLine(listOfNumbers.FirstOrDefault(number=> number < 50));
Console.WriteLine(listOfNumbers.FirstOrDefault(number=> number > 60));


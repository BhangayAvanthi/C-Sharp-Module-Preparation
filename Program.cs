// See https://aka.ms/new-console-template for more information
using M1Preparation;

Console.WriteLine("Hello, World!");


//ExceptionHandling exceptionalHandling = new ExceptionHandling();
//exceptionalHandling.Sample();

//MyOwnExample myOwnExample = new MyOwnExample();
//myOwnExample.example();

//CountryNames countryNames = new CountryNames();
//try
//{
//    Console.WriteLine(countryNames.getCountryName(123456));
//}
//catch(InvalidCodeException ex)
//{
//    Console.WriteLine($"error  ::{ex.Message}");
//}

//YummyDish yummyDish = new YummyDish();
//yummyDish.AddDish("one");
//yummyDish.AddDish("two");
//yummyDish.AddDish("three");
//yummyDish.AddDish("four");
//yummyDish.GetNewDishes(2);

ListExample listExample = new ListExample();
listExample.AddElement('a');
listExample.AddElement('b');
listExample.AddElement('c');
listExample.AddElement('d');
listExample.ChangeOccurence('c', 's');
listExample.ListIndex();
listExample.AfterElement('a', 'h');
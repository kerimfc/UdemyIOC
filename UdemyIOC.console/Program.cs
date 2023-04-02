// See https://aka.ms/new-console-template for more information
using UdemyIOC.console;

Console.WriteLine("Hello, World!");

//BL bL = new BL(new DAL());

BL bL = new BL(new OracleDAL());

bL.GetProducts().ForEach(
    product =>
    Console.WriteLine($"{product.Id} - {product.Name}")
    );

Console.ReadLine();
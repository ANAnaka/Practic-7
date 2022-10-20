using _12._10;

Pizza Margorita = new Pizza();
Margorita.Name = "Маргарита";
Margorita.Diametr = 20;

Pizza Havai = new Pizza();
Havai.Name = "Гавайская";
Havai.Diametr = 30;

List <Pizza> menu = new List <Pizza>();
menu.Add(Margorita);
menu.Add(Havai);

foreach (Pizza pizza in menu)
{
    Console.WriteLine(pizza.Name);
    Console.WriteLine(pizza.Diametr);

}
using System.Diagnostics;
using System.Threading.Tasks;
using Asynchronous_Functions;

//MakeDinner1 dinner=new MakeDinner1();

//dinner.MakeDinner();

static async Task CookMeat()
{

    Console.WriteLine("Cook Meat");
}
static async Task CookVegetables()
{

    Console.WriteLine("Cook Vegetables");
}

static async Task MakeBread()
{

    Console.WriteLine("Make Bread");
}

static async Task MakeSoup()
{

    Console.WriteLine("Make Soup");
}

static async Task MakeSalad()
{

    Console.WriteLine("Make Salad");
}

static async Task MakeDrinks()
{

    Console.WriteLine("Make Drinks");
}

static async void MakeDinner()
{

    await CookMeat();
    await CookVegetables();
    await MakeBread();
    await MakeSoup();
    await MakeDrinks();


}
MakeDinner();



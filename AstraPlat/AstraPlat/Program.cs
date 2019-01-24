using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    public enum TypeOfCard { Child=1, Usual, Pensionary };
    public enum TypeOfBus { City=1, Express, Suburban };
    class Program
    {
        Card testChild;
        Card testUsual;
        Card testPensionary;
        Bus testCity;
        Bus testExpress;
        Bus testSuburban;
        static void Main(string[] args)
        {
            Card testChild = new Card
            {
                NumberOfCard = 001,
                BalanceOfCard = 300,
                Type = TypeOfCard.Child
            };
            Card testUsual = new Card
            {
                NumberOfCard = 002,
                BalanceOfCard = 500,
                Type = TypeOfCard.Usual
            };
            Card testPensionary = new Card
            {
                NumberOfCard = 003,
                BalanceOfCard = 200,
                Type = TypeOfCard.Pensionary
            };
            
            Bus testCity = new Bus
            {
                Type = TypeOfBus.City,
                CostOfRide = 90
            };
            Bus testExpress = new Bus
            {
                Type = TypeOfBus.Express,
                CostOfRide = 180
            };
            Bus testSuburban = new Bus
            {
                Type = TypeOfBus.Suburban,
                CostOfRide = 250
            };


            Console.WriteLine("Выберите тип поездки: 1 - Город, 2 - Экспресс, 3 - Пригород");
            int typeOfRide;
            while (!int.TryParse(Console.ReadLine(), out typeOfRide))
            {
                Console.WriteLine("Неправильно введен тип");
            }
            Console.WriteLine("Выберите тип карты: 1 - Детский, 2 - Обычный, 3 - Пенсионный");
            int typeOfCard;
            while (!int.TryParse(Console.ReadLine(), out typeOfCard))
            {
                Console.WriteLine("Неправильно введен тип");
            }
            int costOfRide = 0;
            int balanceOfCard = 0;
            int halfOfCost;
            switch (typeOfCard)
            {
                case 1:
                    switch (typeOfRide)
                    {
                        case 1:
                            halfOfCost = testCity.CostOfRide / 2;
                            costOfRide = halfOfCost;
                            break;
                        case 2:
                            halfOfCost = testExpress.CostOfRide / 2;
                            costOfRide = halfOfCost;
                            break;
                        case 3:
                            halfOfCost = testSuburban.CostOfRide / 2;
                            costOfRide = halfOfCost;
                            break;
                    }
                    balanceOfCard = testChild.BalanceOfCard;
                    break;
                case 2:
                    switch (typeOfRide)
                    {
                        case 1: costOfRide = testCity.CostOfRide; break;
                        case 2: costOfRide = testExpress.CostOfRide; break;
                        case 3: costOfRide = testSuburban.CostOfRide; break;
                    }
                    balanceOfCard = testUsual.BalanceOfCard;
                    break;
                case 3:
                    switch (typeOfRide)
                    {
                        case 1: costOfRide = 0; break;
                        case 2: costOfRide = 0; break;
                        case 3: costOfRide = 0; break;
                    }
                    balanceOfCard = testPensionary.BalanceOfCard;
                    break;
            }

            if (balanceOfCard < costOfRide)
            {
                Console.WriteLine($"Недостаточно средств на карте: {balanceOfCard}, стоймость поездки {costOfRide}");
            }
            else
            {
                Console.WriteLine($"Стоймость поездки {costOfRide}, Остаток на карте {balanceOfCard-costOfRide}, ");
            }
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_group
{
    public class DispatcherPresentationLayer : IDispatcherPresentationLayer
    {
        private IDBItem_DataAccessLayer dbItem_DataAccessLayer;

        public DispatcherPresentationLayer(IDBItem_DataAccessLayer dbItem_DataAccessLayer)
        {
            this.dbItem_DataAccessLayer = dbItem_DataAccessLayer;
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Показати диспетчер меню");
            Console.WriteLine("2. Вихiд");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowDispatcherMenu();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        public void ShowDispatcherMenu()
        {
            Console.WriteLine("Меню диспетчера");
            Console.WriteLine("1. Додати рейс");
            Console.WriteLine("2. Шукати рейс");
            Console.WriteLine("3. Видалити рейс");
            Console.WriteLine("4. Оновити рейс");
            Console.WriteLine("5. Повернутися до Main Menu");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddFlight();
                    break;
                case 2:
                    SearchFlight();
                    break;
                case 3:
                    RemoveFlight();
                    break;
                case 4:
                    UpdateFlight();
                    break;
                case 5:
                    ShowMainMenu();
                    break;
            }
        }

        private void AddFlight()
        {
            Console.WriteLine("Введiть iнформацiю про рейс:");
            Console.WriteLine("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер рейсу: ");
            string flightNumber = Console.ReadLine();
            Console.WriteLine("Пункт призначення: ");
            string destination = Console.ReadLine();
            Console.WriteLine("Пункт вiдправлення: ");
            string pointOfDeparture = Console.ReadLine();
            Console.WriteLine("Дата (рррр-мм-дд): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Flight flight = new Flight
            {
                Id = id,
                FlightNumber = flightNumber,
                Destination = destination,
                PointOfDeparture = pointOfDeparture,
                Date = date
            };

            dbItem_DataAccessLayer.AddFlight(flight);
        }

        private void SearchFlight()
        {
            Console.WriteLine("Введiть iдентифiкатор рейсу: ");
            int id = int.Parse(Console.ReadLine());

            Flight flight = dbItem_DataAccessLayer.GetFlightById(id);

            if (flight != null)
            {
                Console.WriteLine("Iнформацiя про рейс:");
                Console.WriteLine($"Id: {flight.Id}");
                Console.WriteLine($"Номер рейсу: {flight.FlightNumber}");
                Console.WriteLine($"Пункт призначення: {flight.Destination}");
                Console.WriteLine($"Пункт відправлення: {flight.PointOfDeparture}");
                Console.WriteLine($"Дата: {flight.Date}");
            }
            else
            {
                Console.WriteLine("Рейс не знайдено");
            }
        }

        private void RemoveFlight()
        {
            Console.WriteLine("Введiть iдентифiкатор рейсу: ");
            int id = int.Parse(Console.ReadLine());

            Flight flight = dbItem_DataAccessLayer.GetFlightById(id);

            if (flight != null)
            {
                dbItem_DataAccessLayer.RemoveFlight(flight);
                Console.WriteLine("Рейс успішно видалено.");
            }
            else
            {
                Console.WriteLine("Рейс не знайдено.");
            }
        }

        private void UpdateFlight()
        {
            Console.WriteLine("Введiть iдентифiкатор рейсу: ");
            int id = int.Parse(Console.ReadLine());

            Flight oldFlight = dbItem_DataAccessLayer.GetFlightById(id);

            if (oldFlight != null)
            {
                Console.WriteLine("Введiть нову iнформацiю про рейс:");
                Console.WriteLine("Номер рейсу: ");
                string flightNumber = Console.ReadLine();
                Console.WriteLine("Пункт призначення: ");
                string destination = Console.ReadLine();
                Console.WriteLine("Пункт вiдправлення: ");
                string pointOfDeparture = Console.ReadLine();
                Console.WriteLine("Дата (рррр-мм-дд): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Flight newFlight = new Flight
                {
                    Id = oldFlight.Id,
                    FlightNumber = flightNumber,
                    Destination = destination,
                    PointOfDeparture = pointOfDeparture,
                    Date = date
                };

                dbItem_DataAccessLayer.UpdateFlight(oldFlight, newFlight);
                Console.WriteLine("Рейс успiшно оновлено.");
            }
            else
            {
                Console.WriteLine("Рейс не знайдено.");
            }
        }
    }
}

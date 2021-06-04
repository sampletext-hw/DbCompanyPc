using System;
using System.Linq;
using DbCompanyPc.Models;

namespace DbCompanyPc
{
    public class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new CompanyPcMsContext())
            {
                Prepare(context);
            }

            bool exit = false;
            while (!exit)
            {
                using var context = new CompanyPcMsContext();
                
                PrintMenu();

                var menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                    {
                        var rooms = context.Rooms.ToList();
                        rooms.ForEach(r => Console.WriteLine($"Room: Id({r.Id}) - Number({r.Number})"));
                        break;
                    }
                    case 2:
                    {
                        Console.Write("Введите номер комнаты: ");
                        var room = Console.ReadLine();
                        context.Rooms.Add(new Room() {Number = room});
                        context.SaveChanges();
                        break;
                    }
                    case 3:
                    {
                        Console.Write("Введите Id комнаты: ");
                        int id = int.Parse(Console.ReadLine());
                        var room = new Room() {Id = id};
                        context.Attach(room);
                        context.Rooms.Remove(room);
                        context.SaveChanges();
                        break;
                    }
                    case 4:
                    {
                        var networks = context.LocalNetworks.ToList();

                        networks.ForEach(n => Console.WriteLine($"LocalNetwork: Id({n.Id}) - Address({n.Address}) - Mask({n.Mask})"));
                        break;
                    }
                    case 5:
                    {
                        Console.Write("Введите адрес сети: ");
                        string address = Console.ReadLine();
                        Console.Write("Введите маску сети: ");
                        string mask = Console.ReadLine();
                        context.LocalNetworks.Add(new LocalNetwork() {Address = address, Mask = mask});
                        context.SaveChanges();
                        break;
                    }
                    case 6:
                    {
                        Console.Write("Введите Id сети: ");
                        int id = int.Parse(Console.ReadLine());
                        var network = new LocalNetwork() {Id = id};
                        context.Attach(network);
                        context.LocalNetworks.Remove(network);
                        context.SaveChanges();

                        break;
                    }
                    case 7:
                    {
                        var computers = context.Computers.ToList();

                        computers.ForEach(c => Console.WriteLine($"Computer: Id({c.Id}) - NetworkId({c.NetworkId}) - RoomId({c.RoomId})"));
                        break;
                    }
                    case 8:
                    {
                        Console.Write("Введите Id комнаты: ");
                        int roomId = int.Parse(Console.ReadLine());
                        Console.Write("Введите Id сети: ");
                        int networkId = int.Parse(Console.ReadLine());
                        var computer = new Computer() {RoomId = roomId, NetworkId = networkId};
                        context.Computers.Add(computer);
                        context.SaveChanges();
                        break;
                    }
                    case 9:
                    {
                        Console.Write("Введите Id компьютера: ");
                        int id = int.Parse(Console.ReadLine());
                        var computer = new Computer() {Id = id};
                        context.Attach(computer);
                        context.Computers.Remove(computer);
                        context.SaveChanges();
                        break;
                    }
                    case 0:
                    {
                        exit = true;
                        break;
                    }
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("1. Посмотреть все комнаты");
            Console.WriteLine("2. Добавить комнату");
            Console.WriteLine("3. Удалить комнату");
            Console.WriteLine("4. Посмотреть все сети");
            Console.WriteLine("5. Добавить сеть");
            Console.WriteLine("6. Удалить сеть");
            Console.WriteLine("7. Посмотреть все компьютеры");
            Console.WriteLine("8. Добавить компьютер");
            Console.WriteLine("9. Удалить компьютер");
            Console.WriteLine("0. Выйти");
        }

        static void Prepare(CompanyPcMsContext context)
        {
            context.Database.EnsureCreated();

            var random = new Random(DateTime.Now.Millisecond);

            if (!context.Departments.Any())
            {
                context.Departments.Add(new Department() {Title = "Bird Egop Department"});
            }

            context.SaveChanges();
            if (!context.Rooms.Any())
            {
                context.Rooms.Add(new Room() {Number = random.Next(1000, 10000).ToString()});
                context.Rooms.Add(new Room() {Number = random.Next(1000, 10000).ToString()});
            }

            context.SaveChanges();

            if (!context.LocalNetworks.Any())
            {
                context.LocalNetworks.Add(new LocalNetwork() {Address = "192.168.1." + random.Next(0, 255), DepartmentId = 1, Mask = "255.255." + random.Next(0, 255) + ".0"});
                context.LocalNetworks.Add(new LocalNetwork() {Address = "192.168.1." + random.Next(0, 255), DepartmentId = 1, Mask = "255.255." + random.Next(0, 255) + ".0"});
                context.LocalNetworks.Add(new LocalNetwork() {Address = "192.168.1." + random.Next(0, 255), DepartmentId = 1, Mask = "255.255." + random.Next(0, 255) + ".0"});
            }

            context.SaveChanges();
            if (!context.Computers.Any())
            {
                context.Computers.Add(new Computer() {NetworkId = 1, RoomId = 1});
                context.Computers.Add(new Computer() {NetworkId = 1, RoomId = 1});
                context.Computers.Add(new Computer() {NetworkId = 2, RoomId = 1});
                context.Computers.Add(new Computer() {NetworkId = 2, RoomId = 2});
                context.Computers.Add(new Computer() {NetworkId = 3, RoomId = 2});
                context.Computers.Add(new Computer() {NetworkId = 3, RoomId = 2});
            }

            var producer = new Producer() {Title = "Bird Egop Company"};
            context.Producers.Add(producer);

            context.SaveChanges();

            var part = new Part() {Title = "Видеокарта 1080", PartType = PartType.VideoGraphicsCard, WarrantyReasons = "Нападение инопланетян"};

            context.Parts.Add(part);
            context.SaveChanges();

            var partElement = new PartElement() {ProducerId = producer.Id, PartId = part.Id, PurchaseDate = DateTime.Now, WarrantyDuration = TimeSpan.FromHours(10)};

            context.PartElements.Add(partElement);
            context.SaveChanges();

            var soft = new Soft() {Title = "Антивирус Касперского", SoftType = SoftType.Antivirus};

            context.Softs.Add(soft);
            context.SaveChanges();

            var softElement = new SoftElement() {ProducerId = producer.Id, SoftId = soft.Id, LicenseExpirationDate = DateTime.Now.AddDays(10)};

            context.SoftElements.Add(softElement);
            context.SaveChanges();

            context.ComputerToSoftElements.Add(new ComputerToSoftElement() {ComputerId = 1, SoftElementId = softElement.Id});
            context.ComputerToSoftElements.Add(new ComputerToSoftElement() {ComputerId = 2, SoftElementId = softElement.Id});
            context.ComputerToSoftElements.Add(new ComputerToSoftElement() {ComputerId = 3, SoftElementId = softElement.Id});
            context.ComputerToSoftElements.Add(new ComputerToSoftElement() {ComputerId = 4, SoftElementId = softElement.Id});
            context.ComputerToSoftElements.Add(new ComputerToSoftElement() {ComputerId = 5, SoftElementId = softElement.Id});
            
            context.ComputerToPartElements.Add(new ComputerToPartElement() {ComputerId = 1, PartElementId = partElement.Id});
            context.ComputerToPartElements.Add(new ComputerToPartElement() {ComputerId = 2, PartElementId = partElement.Id});
            context.ComputerToPartElements.Add(new ComputerToPartElement() {ComputerId = 3, PartElementId = partElement.Id});
            context.ComputerToPartElements.Add(new ComputerToPartElement() {ComputerId = 4, PartElementId = partElement.Id});
            context.ComputerToPartElements.Add(new ComputerToPartElement() {ComputerId = 5, PartElementId = partElement.Id});

            context.SaveChanges();
        }
    }
}
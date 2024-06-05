using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<UserAccount> list = new List<UserAccount>();
            list.Add(new UserAccount("Sơn Tùng", 10, 55.5f, "Ca Nhạc", 50));
            list.Add(new UserAccount("Đen Vâu", 5, 70, "Ca Nhạc", 10));
            list.Add(new UserAccount("Thùy Linh", 15, 45.5f, "Ca Nhạc", 25));
            list.Add(new UserAccount("Độ Mixi", 1, 90, "ALL", 2));
            list.Add(new UserAccount("Bà Tuyết Diamond", 3, 60.5f, "Ấm thực", 10));
            list.Add(new UserAccount("PewPew", 4, 55.5f, "live", 50));
            list.Add(new UserAccount("Liên Minh", 2, 85.5f, "Game", 255));
            list.Add(new UserAccount("Liên Quân", 11, 55.5f, "Game", 200));
            list.Add(new UserAccount("Fifa 4", 7, 55.5f, "Game", 150));
            list.Add(new UserAccount("CSO", 8, 55.5f, "Game", 1000));
            list.Add(new UserAccount("CSGO", 6, 85.5f, "Game", 500));
            //
            Console.WriteLine("BÀI 1a: Danh sách UserAccount");
            foreach (var item in list)
            {
                Console.WriteLine("Name: " + item.name + " | Rank: " + item.rank + " | Winrate: " + item.winRate
                                 + " | Type: " + item.type + " | Skin: " + item.skin);
            }
            //
            Console.WriteLine();
            Console.WriteLine("BÀI 1b: Sắp xếp danh sách UserAccount theo “Rank” giảm dần");
            var listRank = list.OrderBy(e => e.rank);
            foreach (var item in listRank)
            {
                Console.WriteLine("Name: " + item.name + " | Rank: " + item.rank + " | Winrate: " + item.winRate
                                 + " | Type: " + item.type + " | Skin: " + item.skin);
            }
            //
            Console.WriteLine();
            Console.WriteLine("BÀI 1c:  Sắp xếp danh sách UserAccount theo “Name” và “Skin” giảm dần");
            var listNameAndSkin = list.OrderByDescending(e => e.name).ThenByDescending(e => e.skin);
            var sorted = list.OrderBy(e => e.name).ThenBy(e => e.skin);
            foreach (var item in sorted)
            {
                Console.WriteLine("Name: " + item.name + " | Rank: " + item.rank + " | Winrate: " + item.winRate
                                 + " | Type: " + item.type + " | Skin: " + item.skin);
            }
            //
            Console.WriteLine();
            Console.WriteLine("BÀI 1d:   Liệt kê danh sách các người có Name bắt đầu bằng ký tự “B”");
            var listNameB = list.Where(e => e.name.StartsWith("B"));
            foreach (var item in listNameB)
            {
                Console.WriteLine("Name: " + item.name + " | Rank: " + item.rank + " | Winrate: " + item.winRate
                                 + " | Type: " + item.type + " | Skin: " + item.skin);
            }
            //------------------------------------------------------------------------------------------------//
            Console.WriteLine("Bai 2:");
            Console.WriteLine("BÀI 2a: Xuất ra màn hình danh sách các người có “WinRate” > 50");
            var listMax50 = list.Where(x => x.winRate > 50);
            foreach (var item in listMax50)
            {
                Console.WriteLine("Name: " + item.name + " | Rank: " + item.rank + " | Winrate: " + item.winRate
                                 + " | Type: " + item.type + " | Skin: " + item.skin);
            }

            //------

            Console.WriteLine();
            Console.WriteLine("BÀI 2b: Tìm người có WinRate cao nhất");
            var listMax = list.Max(x => x.winRate);
            var Max = list.FirstOrDefault(x => x.winRate == listMax);
            Console.WriteLine("Name: " + Max.name + " | Rank: " + Max.rank + " | Winrate: " + Max.winRate
                                 + " | Type: " + Max.type + " | Skin: " + Max.skin);

            //-------

            Console.WriteLine();
            Console.WriteLine("BÀI 2c: Cho biết danh sách UserAccount có bao nhiêu tài khoản?");
            var listCount = list.Count();
            Console.WriteLine(listCount);

            //-----------------------------------------------------------------------------------------------------//

            Console.WriteLine("Bai 3: ");
            var newList = list.ToLookup(x => x.type);
            foreach (var item in newList)
            {
                Console.WriteLine("Key: " + item.Key + " |Count: " + item.Count());
                foreach (var enemy in item)
                {
                    Console.WriteLine("Name: " + enemy.name + " | Rank: " + enemy.rank + " | Winrate: " + enemy.winRate
                                 + " | Type: " + enemy.type + " | Skin: " + enemy.skin);
                }
                Console.WriteLine("------------------------");
            }
            Console.ReadLine();
        }
    }
}

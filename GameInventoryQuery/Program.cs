using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

List<GameItem> items = new List<GameItem>()
{
    new GameItem("나무검", "무기", "일반", 100, 3),
    new GameItem("강철 대검", "무기", "희귀", 800, 1),
    new GameItem("용의 검", "무기", "전설", 5000, 1),
    new GameItem("가죽 갑옷", "방어구", "일반", 200, 2),
    new GameItem("미스릴 갑옷", "방어구", "희귀", 1200, 1),
    new GameItem("드래곤 갑옷", "방어구", "전설", 8000, 0),
    new GameItem("체력 물약", "소비", "일반", 50, 10),
    new GameItem("마나 물약", "소비", "일반", 80, 5),
    new GameItem("고급 물약", "소비", "희귀", 500, 0),
    new GameItem("엘릭서", "소비", "전설", 3000, 2)
};

Console.WriteLine("=== 쿼리 1: 가격 500 이상(가격 내림차순) ===");
var price = items
    .Where(n => n.Price >= 500)
    .OrderByDescending(n => n.Price);
foreach (var p1 in price)
{
    Console.WriteLine($"{p1.Name} - {p1.Type} - {p1.Price}원");
}

Console.WriteLine("=== 쿼리 2: 무기 타입 (등급순) ===");
var Grade = items
    .Where(n => n.Type == "무기")
     .OrderBy(n => n.Grade switch
     {
         "일반" => 0,
         "희귀" => 1,
         "전설" => 2,
         _ => 99
     });
foreach (var g1 in Grade)
{
    Console.WriteLine($"{g1.Name} - {g1.Grade} - {g1.Price}원");
}
Console.WriteLine("=== 쿼리 3: 총 가치 1000 이상 ===");
var totalprice = items
    .Where(n => n.Price * n.Quantity >= 1000);
foreach (var p1 in totalprice)
{
    Console.WriteLine($"{p1.Name}-총 가치 {p1.Price*p1.Quantity}원");
}
Console.WriteLine("=== 쿼리 4: 품절 아이템 (이름순) ===");
var zQuantity = items
    .Where(n => n.Quantity ==0)
    .OrderBy(n => n.Name);
foreach (var p1 in zQuantity)
{
    Console.WriteLine($"{p1.Name}");
}
Console.WriteLine("=== 쿼리 5: 전설 등급 (이름과 가격) ===");
var GO = items
    .Where(n => n.Grade == "전설")
    .Select(n => new { n.Name, n.Price });
foreach (var p1 in GO)
{
    Console.WriteLine($"{p1.Name} - {p1.Price}원");
}


class GameItem
{
    public string Name;
    public string Type;
    public string Grade;
    public int Price;
    public int Quantity;

    public GameItem(string name, string type, string grade,int price, int quantity)
    {
        Name=name;
        Type=type;
        Grade=grade;
        Price=price;
        Quantity=quantity;
    }

}


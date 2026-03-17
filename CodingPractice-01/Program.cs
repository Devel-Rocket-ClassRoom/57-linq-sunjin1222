using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


// 1. 메서드 구문 기본 사용법
int[] number = { 1, 2, 3, 4, 5 };
IEnumerable<int> result1 = number.Where(n => n > 3);
foreach (int n1 in result1)
{
    Console.WriteLine(n1);
}

// 2. Where - 필터링
string[] name = { "Tom", "Dick", "Harry", "Mary", "Jay" };
var result2 = name.Where(n => n.Contains("a"));
foreach (string n2 in result2)
{
    Console.WriteLine(n2);
}

// 3. Select - 변환
string[] toms = { "Tom", "Dick", "Harry" };
var result3= toms.Select(n => n.ToUpper());
foreach (string n3 in result3)
{
    Console.WriteLine(n3);
}

// 4. OrderBy - 오름차순 정렬
string[] c = { "Red", "Green", "Blue" };
var c1 = c.OrderBy(n => n);
foreach (string n4 in c1)
{
    Console.WriteLine(n4);
}


// 5. OrderByDescending - 내림차순 정렬
int[] n = { 3, 1, 4, 1, 5, 9, 2, 6 };
var n5=n.OrderByDescending(n => n);
foreach (int n45 in n5)
{
     Console.Write($"{n45} ");
    
}
Console.WriteLine();

// 6. 쿼리 연산자 체이닝
string[] n6 = { "Tom", "Dick", "Harry", "Mary", "Jay" };
var n66 = n6
    .Where(n66 => n66.Contains("a"))
    .OrderBy(n66 => n66.Length)
    .Select(n66 => n66.ToUpper());
foreach (var n61 in n66)
{
    Console.WriteLine($"{n61} ");

}



// 7. 쿼리 구문 기본 구조
int[] num7 = { 1, 2, 3, 4, 5 };
var query = from n7 in num7
            where n7 % 2 == 0
            select n7;
foreach (var n71 in query)
{
    Console.WriteLine($"{n71} ");

}


// 8. 쿼리 구문 필터링과 정렬
string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

var n88 = from n81 in names
            where n81.Contains("a")
            orderby n81.Length
            select n81.ToUpper();

foreach (var n881 in n88)
{
    Console.WriteLine(n881);
}

// 9. 메서드 구문과 쿼리 구문 비교

int[] cao = { 3, 2, 1, 4, 5 };

var methodResult = cao
    .Where(n => n % 2 == 1)
    .OrderBy(n => n);

var queryResult = from n91 in cao
                  where n91 % 2 == 1
                  orderby n91
                  select n91;

Console.WriteLine("메서드 구문:");
foreach (var n92 in methodResult)
{
    Console.Write($"{n92} ");
}

Console.WriteLine("\n쿼리 구문:");
foreach (var n92 in queryResult)
{
    Console.Write($"{n92} ");
}

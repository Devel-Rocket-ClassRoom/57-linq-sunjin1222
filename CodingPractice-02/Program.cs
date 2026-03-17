using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

// 1. Sum, Count, Average
int[] numbers1 = { 1, 2, 3, 4, 5 };

int sum = numbers1.Sum();
int count = numbers1.Count();
double average = numbers1.Average();

Console.WriteLine($"합계: {sum}");
Console.WriteLine($"개수: {count}");
Console.WriteLine($"평균: {average}");

// 2. Min, Max
int[] numbers2 = { 3, 1, 4, 1, 5, 9, 2, 6 };
int Min = numbers2.Min();
int Max = numbers2.Max();

Console.WriteLine($"최솟값: {Min}");
Console.WriteLine($"최댓값: {Max}");
// 3. 조건부 집계
int[] numbers3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int evenSum = numbers3.Where(n => n % 2 == 0).Sum();
int Over5 = numbers3.Count(n => n > 5);

Console.WriteLine($"짝수 합계: {evenSum}");
Console.WriteLine($"5보다 큰 숫자 개수: {Over5}");

// 4. First, Last
int[] numbers4 = { 10, 20, 30, 40, 50 };
int First=numbers4.First();
int Last=numbers4.Last();
Console.WriteLine($"첫 번째: {First}");
Console.WriteLine($"마지막: {Last}");

// 5. 조건부 요소 선택
int[] numbers5 = { 1, 2, 3, 4, 5 };
int First5 = numbers5.First(n => n > 3);
Console.WriteLine($"3보다 큰 첫 번째: {First5}");

// 6. Take, Skip
int[] numbers6 = { 10, 20, 30, 40, 50 };
var Take = numbers6.Take(3);
var Skip = numbers6.Skip(2);
Console.WriteLine($"처음 3개:");
foreach (int n in Take)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
Console.WriteLine($"2개 건너뛴 후:");
foreach (int n in Skip)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
// 7. Any, All
int[] number7 = { 1, 2, 3, 4, 5 };
bool Any7 = number7.Any();
bool hasEven = number7.Any(n => n % 2 == 0);
bool allPositive = number7.All(n => n > 0);
Console.WriteLine($"요소 존재: {Any7}");
Console.WriteLine($"짝수 존재: {hasEven}");
Console.WriteLine($"모두 양수: {allPositive}");
// 8. Contains
int[] number8 = { 1, 2, 3, 4, 5 };
bool Contains81 = number8.Contains(3);
bool Contains82 = number8.Contains(10);
Console.WriteLine($"3 포함: {Contains81}");
Console.WriteLine($"10 포함: {Contains82}");

// 9. Distinct
int[] number9 = { 1, 2, 2, 3, 3, 3, 4, 5 };
var Distinct = number9.Distinct();
foreach (int n in Distinct)
{
    Console.Write($"{n} ");
}
Console.WriteLine();

// 10. Concat, Union
int[] first = { 1, 2, 3 };
int[] second = { 3, 4, 5 };
var concat = first.Concat(second);

var union = first.Union(second);

Console.WriteLine("Concat:");
foreach (var n in concat)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
Console.WriteLine("Union:");
foreach (var n in union)
{
    Console.Write($"{n} ");
}
Console.WriteLine();

// 11. 지연 실행
var numbers11 = new List<int> { 1, 2, 3 };
var query = numbers11.Where(n => n > 1);

numbers11.Add(4);

Console.WriteLine("결과:");
foreach (var n in query)
{
    Console.WriteLine(n);
}


// 12. 즉시 실행 연산자
var numbers12 = new List<int> { 1, 2, 3 };
int count12 = numbers12.Count();
numbers12.Add(4);
Console.WriteLine($"개수:{count12}");

// 13. ToList로 결과 고정
var numbers13 = new List<int> { 1, 2, 3 };
var result = numbers13.Where(n => n > 1).ToList();

numbers13.Add(4);

Console.WriteLine("결과:");
foreach (var n in result)
{
    Console.WriteLine(n);
}

// 14. Select로 새 타입 생성
var names14 = new List<string> { "홍길동", "김철수", "이영희" };

var result14 = names14.Select(n => new { Name = n, Length = n.Length });

foreach (var item14 in result14)
{
    Console.WriteLine($"이름: {item14.Name}, 길이: {item14.Length}");
}

// 15. 혼합 구문
string[] names15 = { "Tom", "Dick", "Harry", "Mary", "Jay" };

int count15 = (from n in names15
             where n.Contains("a")
             select n).Count();

Console.WriteLine($"'a' 포함 이름 개수: {count15}");

string first15 = (from n in names15
                orderby n
                select n).First();

Console.WriteLine($"알파벳 순 첫 번째: {first15}");

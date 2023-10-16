using System;
/*1
double a, b, c, result;
double.TryParse(Console.ReadLine(), out a);
double.TryParse(Console.ReadLine(), out b);
double.TryParse(Console.ReadLine(), out c);
result = Math.Sqrt(Math.Pow(b, 2) + 4 * a * c);
result += b;
result = result / (2 * a);
result = result - Math.Pow(a, 3) * c;
result = result = Math.Pow(b, -2);
Console.WriteLine(result);
*/
/*2
double a, b, c, d, result;
double.TryParse(Console.ReadLine(), out a);
double.TryParse(Console.ReadLine(), out b);
double.TryParse(Console.ReadLine(), out c);
double.TryParse(Console.ReadLine(), out d);

result = (a * b) / (c * d);
result = result - ((a * b - c) / (c * d));
Console.WriteLine(result);
*/
/*3
double x, y, result;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = Math.Sin(x) + Math.Cos(y);
result = result / (Math.Cos(x) - Math.Sin(y));
result = result * Math.Tan(x*y);
Console.WriteLine(result);
*/
/*4
double x, y, result;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = (x + y) / (y + 1);
result = result - (x * y - 12) / (34 + x);
Console.WriteLine(result);
*/
/*5
double x, y, result;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = 3+Math.Pow(Math.E, y-1);
result = result / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));
Console.WriteLine(result);
*/
/*6
double x, result;
double.TryParse(Console.ReadLine(), out x);
result = x - (Math.Pow(x, 3) / 3) + (Math.Pow(x, 5) / 5);
Console.WriteLine(result);
*/
/*7
double x, y, result;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = y - Math.Sqrt(Math.Abs(x));
result = result * (x - (y / (x + Math.Pow(x, 2) / 4)));
result = Math.Abs(result);
result = Math.Log(result);
Console.WriteLine(result);
*/
/*8
double x, y, result;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = (1 - Math.Tan(x));
result = Math.Pow(result, 1 / Math.Tan(x));
result = result + Math.Cos(x - y);
Console.WriteLine(result);
*/
/*9
double x, result;
double.TryParse(Console.ReadLine(), out x);
result = Math.Log(Math.Abs(Math.Cos(x)));
result = result / (Math.Log(1 + Math.Pow(x, 2)));
Console.WriteLine(result);
*/
/*10
double x, y, a, b, result;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
a = (x + 1);
b = (x - 1);
result = Math.Pow(a, x) / Math.Pow(b, x);
result = result = 18 * x * Math.Pow(y, 2);
Console.WriteLine(result);
*/
/*11
double x, y, result;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = 1 + (1 / Math.Pow(x, 2));
result = Math.Pow(result, x);
result = result - 12 * Math.Pow(x, 2) * y;
Console.WriteLine(result);
*/
/*12
double x, result;
double.TryParse(Console.ReadLine(), out x);
result = Math.Pow(x, 2) - 7*x+10;
result = result / (Math.Pow(x, 2) - 8 * x + 12);
Console.WriteLine(result);
*/
/*13
double x, y, result;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = (Math.Cos(x)) / (Math.PI - 2 * x);
result = result + 16 * x * Math.Cos(x * y) - 2;
Console.WriteLine(result);
*/
/*14
double x, y, result;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = Math.Pow(2, -x) - Math.Cos(x) + Math.Sin(2 * x * y);
Console.WriteLine(result);
*/
/*15
double x, result;
double.TryParse(Console.ReadLine(), out x);
*/
/*2
double x1, x2, x3, y1, y2, y3, P, S, p, A, B, C;

double.TryParse(Console.ReadLine(), out x1);
double.TryParse(Console.ReadLine(), out x2);
double.TryParse(Console.ReadLine(), out x3);
double.TryParse(Console.ReadLine(), out y1);
double.TryParse(Console.ReadLine(), out y2);
double.TryParse(Console.ReadLine(), out y3);

A = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
B = Math.Sqrt(Math.Pow(x3-x2, 2) + Math.Pow(y3-y2, 2));
C = Math.Sqrt(Math.Pow(x1-x3, 2) + Math.Pow(y1-y3, 2));



P = A + B + C;
p = P / 2;
S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
Console.WriteLine(P);
Console.WriteLine(S);
*/
/*3
double r, C, S;
double.TryParse(Console.ReadLine(), out r);
S = 2 * Math.PI * r;
C = Math.Pow(r, 2) * Math.PI;
Console.WriteLine(C);
Console.WriteLine(S);
*/
/*5
double x, y, result, result2;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = (Math.Pow(x, 3) + Math.Pow(y, 3)) / 2;
result2 = Math.Sqrt(Math.Abs(x) * Math.Abs(y));

Console.WriteLine(result);
Console.WriteLine(result2);
*/
/*6
double x1, x2, y1, y2, result;
double.TryParse(Console.ReadLine(), out x1);
double.TryParse(Console.ReadLine(), out x2);
double.TryParse(Console.ReadLine(), out y1);
double.TryParse(Console.ReadLine(), out y2);
result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine(result);
*/
/*7
double x, y, result, result1, result2, result3;

double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
result = x + y;
result1 = x-y;
result2 = y*x;
result3 = x/y;
Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);
*/
/*8
double a, result, v, s;
double.TryParse(Console.ReadLine(), out a);
s = Math.Pow(a, 2);
v = Math.Pow(a, 3);
result = 6 * Math.Pow(a, 2);
Console.WriteLine(result);
Console.WriteLine(s);
Console.WriteLine(v);
*/
/*9
double a, s, h, r, R;
double.TryParse(Console.ReadLine(), out a);
s = Math.Sqrt(3)/4*Math.Pow(a, 2);
h = a * Math.Sqrt(3) / 2;
r = a* Math.Sqrt(3) / 6;
R = a* Math.Sqrt(3) / 3;
Console.WriteLine(s);
Console.WriteLine(h);
Console.WriteLine(r);
Console.WriteLine(R);
*/
/*10
double l, s;

double.TryParse(Console.ReadLine(), out l);
s = Math.Pow(l, 2)/(Math.PI*4);
Console.WriteLine(s);
*/
/*11
double r, R, result;

double.TryParse(Console.ReadLine(), out r);
double.TryParse(Console.ReadLine(), out R);

result = Math.PI * (Math.Pow(R, 2) - r * 2);
Console.WriteLine(result);
*/
/*12
double a, b, c, A, B, C, r;
double.TryParse(Console.ReadLine(), out r);
double.TryParse(Console.ReadLine(), out a);
double.TryParse(Console.ReadLine(), out b);
double.TryParse(Console.ReadLine(), out c);
A = 2 * r * Math.Sin(a);
B = 2 * r * Math.Sin(b);
C = 2 * r * Math.Sin(c);
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
*/
/*4
int.TryParse(Console.ReadLine(), out int num);
int a = num / 100;
int b = num % 100 / 10;
int c = num % 10;
if (Math.Pow(num, 2) == Math.Pow(a+b+c, 3))
    Console.WriteLine(true);
else
    Console.WriteLine(false);  
*/
/*3
int.TryParse(Console.ReadLine(), out int x);
int.TryParse(Console.ReadLine(), out int y);
int.TryParse(Console.ReadLine(), out int m);
int.TryParse(Console.ReadLine(), out int n);
if (x>=m && x<=n)
    Console.WriteLine(true);
else
    Console.WriteLine(false);
*/
/*5
int.TryParse(Console.ReadLine(), out int n);
if (n / 100 == 0 & n % 100 >= 10 & n % 100 <= 99 & n%2 ==0)
    Console.WriteLine(true);
else
    Console.WriteLine(false);
*/
/*6
int.TryParse(Console.ReadLine(), out int a);
int.TryParse(Console.ReadLine(), out int b);
int.TryParse(Console.ReadLine(), out int c);
if (a == b & b == c)
    Console.WriteLine(true);
else
    Console.WriteLine(false);
*/
/*7
int.TryParse(Console.ReadLine(), out int a);
int.TryParse(Console.ReadLine(), out int b);
int.TryParse(Console.ReadLine(), out int c);
if (a == b || b == c || a == c)
    Console.WriteLine(true);
else
    Console.WriteLine(false);
*/
/*8
int.TryParse(Console.ReadLine(), out int a);
int.TryParse(Console.ReadLine(), out int b);
int.TryParse(Console.ReadLine(), out int c);
if ( a == -b || a == -c || b == -c)
    Console.WriteLine(true);
else
{
    Console.WriteLine(false);   
}
*/
/*9
float.TryParse(Console.ReadLine(), out float a);
float.TryParse(Console.ReadLine(), out float b);
float.TryParse(Console.ReadLine(), out float c);
float.TryParse(Console.ReadLine(), out float d);
if (a / c == b / d)
    Console.WriteLine(true);
else
    Console.WriteLine(false);
*/
/*10
double P, P2, S, S2, p, p2;
double.TryParse(Console.ReadLine(), out double a);
double.TryParse(Console.ReadLine(), out double b);
double.TryParse(Console.ReadLine(), out double c);
double.TryParse(Console.ReadLine(), out double a2);
double.TryParse(Console.ReadLine(), out double b2);
double.TryParse(Console.ReadLine(), out double c2);
P = a + b + c;
p = P / 2;
P2 = a2 + b2 + c2;
p2 = P2 / 2;
S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
S2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
if (S == S2)
    Console.WriteLine(true);
else
    Console.WriteLine(false);

int s, A, B, C;
int.TryParse(Console.ReadLine(), out int a);
int.TryParse(Console.ReadLine(), out int b);
int.TryParse(Console.ReadLine(), out int c);
A = Math.Pow(a, 2);
B = Math.Pow(b, 2);
C = Math.Pow(c, 2);
if (A = B+C);*/

/*1
Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c:");
int c = int.Parse(Console.ReadLine());

if (a > 0)
    Console.WriteLine($"Положительная a: {Math.Pow(a, 2)}");
else
    Console.WriteLine($"Отрицательная a: {Math.Pow(a, 4)}");
if (b > 0)
    Console.WriteLine($"Положительная b: {Math.Pow(b, 2)}");
else
    Console.WriteLine($"Отрицательная b: {Math.Pow(b, 4)}");
if (c > 0)
    Console.WriteLine($"Положительная c: {Math.Pow(c, 2)}");
else
    Console.WriteLine($"Отрицательная c: {Math.Pow(c, 2)}"); */

/*2
int a, b, c, d;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);
int.TryParse(Console.ReadLine(), out c);
int.TryParse(Console.ReadLine(), out d);
double e = Math.Sqrt(a * a + b * b);
double f = Math.Sqrt(c * c + d * d);
if (e > f)
    Console.WriteLine("Первая точка ближе");
else
    Console.WriteLine("Вторая точка ближе");*/

/*3
int a, b;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);

if (a + b <= 179)
    Console.WriteLine("не существует");
else if (a == 90)
    Console.WriteLine("прямоугольный");
else if (b == 90)
    Console.WriteLine("прямоугольный");
else if (a + b == 90)
    Console.WriteLine("прямоугольный");
else
    Console.WriteLine("не прямоугольный");*/

/*4
int.TryParse(Console.ReadLine(), out int x);
int.TryParse(Console.ReadLine(), out int y);
if (x>y)
y=(x+y)/2;
else
    y=(x*y)*2;
Console.WriteLine(y);*/

/*6-
int.TryParse(Console.ReadLine(), out int m);
int.TryParse(Console.ReadLine(), out int n);
if (m > n)
n = m;
else if (n > m)
    m = n;
else
n = 0;
m = 0;
Console.WriteLine(m);
Console.WriteLine(n);*/

/* 3tema 2
int.TryParse(Console.ReadLine(), out int num);
num = num % 10;
switch (num)
{
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
        num = (int)(Math.Pow(num, 2) % 10);
        break;
}
Console.WriteLine($"последняя цифра квадрата этого числа равна: {num} ");*/

/* 4
int.TryParse(Console.ReadLine(), out int num);
switch (num)
{
   case 0:
       Console.WriteLine("zero");
       break;
   case 1:
       Console.WriteLine("one");
       break;
   case 2:
       Console.WriteLine("two");
       break;
   case 3:
       Console.WriteLine("three");
       break;
   case 4:
       Console.WriteLine("four");
       break;
   case 5:
       Console.WriteLine("five");
       break;
   case 6:
       Console.WriteLine("six");
       break;
   case 7:
       Console.WriteLine("seven");
       break;
   case 8:
       Console.WriteLine("eight");
       break;
   case 9:
       Console.WriteLine("nine");
       break;
   default:
       Console.WriteLine("такого числа нет");
       return; 
}      */

/* 5
int.TryParse(Console.ReadLine(), out int month);
switch (month)
{
    case 0:
        Console.WriteLine("январь");
        break;
    case 1:
        Console.WriteLine("февраль");
        break;
    case 2:
        Console.WriteLine("март");
        break;
    case 3:
        Console.WriteLine("апрель");
        break;
    case 4:
        Console.WriteLine("май");
        break;
    case 5:
        Console.WriteLine("июнь");
        break;
    case 6:
        Console.WriteLine("июль");
        break;
    case 7:
        Console.WriteLine("август");
        break;
    case 8:
        Console.WriteLine("сентябрь");
        break;
    case 9:
        Console.WriteLine("октябрь");
        break;
    case 10:
        Console.WriteLine("ноябрь");
        break;
        case 11:
        Console.WriteLine("декабрь");
        break;
    default:
        Console.WriteLine("такого месяца нет");
        return;
} */

/* 6 
int.TryParse(Console.ReadLine(), out int num);
switch (num)
{
    case 1:
        Console.WriteLine("плохо");
        break;
    case 2:
        Console.WriteLine("неудовлетворительно");
        break;
    case 3:
        Console.WriteLine("удовлетворительно");
        break;
    case 4:
        Console.WriteLine("хорошо");
        break;
    case 5:
        Console.WriteLine("отлично");
        break;
    default:
        Console.WriteLine("такой оценки нет");
        return;
} */
/*7
double s;
Console.WriteLine("Номер элемента круга (1-3)");
int.TryParse(Console.ReadLine(), out int num);

switch (num)
{
    case 1:
        Console.WriteLine("radius =");
        int.TryParse(Console.ReadLine(), out int r);
        s = Math.PI * Math.Pow(r,2);
        break;
    case 2:
        Console.WriteLine("diametr =");
        int.TryParse(Console.ReadLine(), out int d);
        s = Math.PI * (1/4) * Math.Pow(d, 2);
        break;
    case 3:
        Console.WriteLine("dlina =");
        int.TryParse(Console.ReadLine(), out int l);
        s = (l / Math.PI) * (1 / 4) * l;
        break;
    default:
        Console.WriteLine("net takogo elementa");
        return;

}
Console.WriteLine(s);
*/
/*8
double a = 0, b = 0, h = 0, s = 0;
Console.WriteLine("nomer elementa treugolnika (1-4)");
int.TryParse(Console.ReadLine(), out int num);
switch (num)
{
    case 1:
        double.TryParse(Console.ReadLine(), out  a);
         b = Math.Sqrt(Math.Pow(a, 2) * Math.Pow(a, 2));
         h = b / 2;
         s = (1 / 2) * b * h;
        break;
    case 2:
        double.TryParse(Console.ReadLine(), out  b);
         a = Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a, 2));
         h = b/2;
         s = (1 / 2) * b * h;
        break;
    case 3:
        double.TryParse(Console.ReadLine(), out h);
        a = Math.Sqrt(Math.Pow(h*2, 2) - Math.Pow(a, 2));
        b = Math.Sqrt(Math.Pow(a, 2) * Math.Pow(a, 2));
        s = (1 / 2) * b * h;
        break;
    case 4:
        double.TryParse(Console.ReadLine(), out s);
        h = s / (3 / 2);
        b = s;
        a = s / 2;
        break;
}
*/
/*9


Console.WriteLine("Номер mesec (1-12)");
int.TryParse(Console.ReadLine(), out int num);

switch (num)
{
    case 1:
        Console.WriteLine("февраль");
        break;
    case 2:
        Console.WriteLine("март");
        break;
    case 3:
        Console.WriteLine("апрель");
        break;
    case 4:
        Console.WriteLine("май");
        break;
    case 5:
        Console.WriteLine("июнь");
        break;
    case 6:
        Console.WriteLine("июль");
        break;
    case 7:
        Console.WriteLine("август");
        break;
    case 8:
        Console.WriteLine("сентябрь");
        break;
    case 9:
        Console.WriteLine("октябрь");
        break;
    case 10:
        Console.WriteLine("ноябрь");
        break;
    case 11:
        Console.WriteLine("декабрь");
        break;
    case 12:
        Console.WriteLine("январь");
        break;
    default:
        Console.WriteLine("такого месяца нет");
        return;
}
*/
/*10
Console.WriteLine("Номер элемента круга (1-4)");
int.TryParse(Console.ReadLine(), out int num);


switch (num)
{
    case 1:
        Console.WriteLine("зима: декабрь - 31, январь- 31, февраль - 28/29 ");
        break;
    case 2:
        Console.WriteLine("весна: март -31, апрель -30, май-31");
        break;
    case 3:
        Console.WriteLine("лето: июнь - 30, июль -31, август - 31");
        break;
    case 4:
        Console.WriteLine("осень: сентябрь - 30, октябрь -31, ноябрь - 30");
        break;
    default:
        Console.WriteLine("Нет такого времени года");
        return;
}
*/
/*11
int.TryParse(Console.ReadLine(), out int year);
int animal = (year - 4) % 12;

switch (animal)
{
    case 0:
        Console.WriteLine("крыса");
        break;
    case 1:
        Console.WriteLine("корова");
        break;
    case 2:
        Console.WriteLine("тигр");
        break;
    case 3:
        Console.WriteLine("заяц");
        break;
    case 4:
        Console.WriteLine("дракон");
        break;
    case 5:
        Console.WriteLine("змея");
        break;
    case 6:
        Console.WriteLine("лошадь");
        break;
    case 7:
        Console.WriteLine("овца");
        break;
    case 8:
        Console.WriteLine("обезьяна");
        break;
    case 9:
        Console.WriteLine("курица");
        break;
    case 10:
        Console.WriteLine("собака");
        break;
    case 11:
        Console.WriteLine("свинья");
        break;
    default:
        Console.WriteLine("takogo net");
        return;
}
*/
/*2
int.TryParse(Console.ReadLine(), out int s);
double norm = 10;
double result = 0;
for (int i = 0; i < s; i++)
{
    result += norm;
    norm = norm + norm * 0.1;
}
Console.WriteLine(result"км За {s} дней");
*/
/*3
int chasi, ameba;
ameba = 1;
int.TryParse(Console.ReadLine(), out chasi);
do
{
    ameba = ameba * 2;
    chasi = chasi - 3;
}
while (chasi > 2.9);
Console.WriteLine(ameba);
*/
/*5
for (int i = 64; i >= 0; i = i - 4)
{
    int rabits = i / 4;
    int goose = (64 - i) / 2;
    Console.WriteLine($"{rabits} {goose}");
}
*/
/*6
float money = 100;
int b = 0;
int c = 0;
int t = 0;
for (b = 1; b<= 10; b++)
{
    for(c = 1; c<= 10; c++)
    {
        for(t = 1; t<= 10; t++)
        {
            if (((b * 10) + (c * 5) + (t * 0.5)) == 100)
            {
                if((b+c+t) == 10)
            }
        }
    }
}    
*/
/*7
int a, b, c;
for (a = 0; a <= 1; a++)
{
    for (b = 0; b <= 1; b++)
    {
        for (c = 0; c <= 1; c++)
        {
            if (a + b == b + a)
                Console.WriteLine("Доказано");
            else
                Console.WriteLine("Опровергнуто");
            if (a * b == b * a)
                Console.WriteLine("Доказано");
            else
                Console.WriteLine("Опровергнуто");
            if ((a + b) + c == c + a)
                Console.WriteLine("Доказано");
            else
                Console.WriteLine("Опровергнуто");
            if ((a * b) * c == a * (b * c))
                Console.WriteLine("Доказано");
            else
                Console.WriteLine("Опровергнуто");
            if (a * (a + b) == a)
                Console.WriteLine("Доказано");
            else
                Console.WriteLine("Опровергнуто");
            if (a + (a * b) == a)
                Console.WriteLine("Доказано");
            else
                Console.WriteLine("Опровергнуто");
            if (a * (b + c) == (a * b) + (a * c))
                Console.WriteLine("Доказано");
            else
                Console.WriteLine("Опровергнуто");
            if (a + (b * c) == (a + b) * (a + c))
                Console.WriteLine("Доказано");
            else
                Console.WriteLine("Опровергнуто");
        }
            
    }
}
*/

/*8
int i, y, x,a;
a = 0;

for (x = 0; x <= 15; x++)
{
    y = (int)Math.Pow(x, 2) + x + 17;
    for (i = 2; i < y; i++)
    {
        if (y % i != 0)
            a = a + 1;
            
            Console.WriteLine(a);
            break;
    }
}
*/

/*9
int i, y, x,a;
a = 0;

for (x = 0; x <= 40; x++)
{
    y = (int)Math.Pow(x, 2) + x + 41;
    for (i = 2; i < y; i++)
    {
        if (y % i != 0)
            a = a + 1;
            
            Console.WriteLine(a);
            break;
    }
}
*/

/*2
int n = int.Parse(Console.ReadLine());
int min = int.MaxValue; 
for (int i = 0; i < n; i++)
{
    
    int number = int.Parse(Console.ReadLine());
    if (number < min)
        min = number;
}
Console.WriteLine(min); 
*/
/*1
int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n; i++)
{
    int a = int.Parse(Console.ReadLine());
    sum += a;
}
Console.WriteLine(sum);
*/

/*3
int n = int.Parse(Console.ReadLine());
int maxx = int.MinValue;
int max  = int.MinValue;
int a = 0;
for (int i = 0; i < n; i++)
{
    a = int.Parse(Console.ReadLine());
    if (a > max)
    { maxx = max; max = a; } 
    else if (a > maxx) a = maxx;
    Console.WriteLine("Ответ" + a);*/

/*4  
int n = int.Parse(Console.ReadLine());
int e = 0;
for (int i = 0; i < n; i++)
{
    int a = int.Parse(Console.ReadLine());
    if (a == n) e++;
}
Console.WriteLine("Ответ:" + e);*/

/* 6
int n = int.Parse(Console.ReadLine());
int proizv = 1;
for (int i = 0; i < n; i++)
{
    int a = int.Parse(Console.ReadLine());
    proizv *= a;
}
Console.WriteLine(proizv);
*/

/* массивы 
 */
/*1
//Console.WriteLine("Сколько элементов в массиве?");
//int.TryParse(Console.ReadLine(), out int count);
//Console.WriteLine("Введите К");
//int k = int.Parse(Console.ReadLine());
//int[] array = new int[count];
//Random random = new Random();
//int summ = 0;
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(1, 20);
//    Console.WriteLine($"[{i}] = {array[i]}");
//if ((array[i] % k) == 0)
//summ = summ + array[i];
//}
//Console.WriteLine(summ);
*/


/* 3
Console.WriteLine("Сколько элементов в массиве?");
int.TryParse(Console.ReadLine(), out int count);
int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine("значение для [i]");
    int.TryParse(Console.ReadLine(), out array[i]);
}
for (int i = 0;i < count; i++)
{
    if (array[i] >= 0)
        Console.WriteLine($"положительное");
    else
        Console.WriteLine($"отрицательное");
}
*/
/*4
Console.WriteLine("Сколько элементов в массиве?");
int.TryParse(Console.ReadLine(), out int count);
int[] array = new int[count];
Random random = new Random();
bool c = true;
for (int i = 0; i < count; i++)
{
    array[i] = random.Next(1, 20);
    Console.WriteLine($"[{i}] = {array[i]}");
}
for (int i = 0; i < count - 1; i++)
{
    if (array[i] >= array[i + 1])
    {
        c = false;
        break;
    }
}
if (c == true)
    Console.WriteLine("возрастающая");
else
    Console.WriteLine("не возрастающая");
задача 5
Console.WriteLine("Сколько элементов в массиве?");
int.TryParse(Console.ReadLine(), out int count);
int[] array = new int[count];
int a = 0;
int b = 0;
Random random = new Random();
for (int i = 0; i < count; i++)
{
    array[i] = random.Next(1, 20);
    Console.WriteLine($"[{i}] = {array[i]}");
}
for (int i = 0; i < count; i++)
{
    if ((array[i] % 2) == 0)
        a++;
}
if (a != 0)
{
    int[] array2 = new int[a];
    for (int i = 0; i < count; i++)
    {
        if ((array[i] % 2) == 0)
        {
            array2[b] = array[i]; 
        b++;
        }
    }
}
else
    Console.WriteLine("таких значений нет");*/

/* 7
Console.WriteLine("Сколько элементов в массиве?");
int.TryParse(Console.ReadLine(), out int count);
Console.WriteLine("Z");
int.TryParse(Console.ReadLine(), out int countZ);
int[] array = new int[count];
int a = 0;
Random random = new Random();
for (int i = 0; i < count; i++)
{
    array[i] = random.Next(1, 20);
    Console.WriteLine($"[{i}] = {array[i]}");
}
for (int i = 0; i < count; i++)
{
    if (array[i] > countZ)
    {
        array[i] = countZ;
        a++;
    }
    Console.WriteLine($"[{i}] = {array[i]}");
    Console.WriteLine("замена");
}
*/

////#8
//Console.WriteLine("Сколько элементов в массиве?");
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//int a = 0;
//for (int i = 0; i < count; i++)
//{
//    Console.WriteLine($"ввести значение для [i] ячейки");
//    int.TryParse(Console.ReadLine(), out array[i]);
//    a++;
//    if (array[i] == 0)
//    {
//        break;
//    }
//}

//Console.WriteLine(a);

//9
//Console.WriteLine("Сколько элементов в массиве?");
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//int a = 0;
//int b = 0;
//int z = 0;
//Random random = new Random();
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"[{i}] = {array[i]}");
//    if (array[i] > 0)
//        a++;
//    else if(array[i] < 0)
//        b++;
//    else
//        z++;
//}
//Console.WriteLine($"положительное - {a}; отрицательное - {b}; нули - {z}");
//#15
//Console.WriteLine("Сколько элементов в массиве?");
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//int a = 0;
//for (int i = 0; i < count; i++)
//{
//    Console.WriteLine($"ввести значение для [i] ячейки");
//    int.TryParse(Console.ReadLine(), out array[i]);
//    {
//        if (array[i] == 0)
//            break;
//    }
//}
//int[] b = new int[count];
//for (int i = 0; i < count - 1; i++)
//{
//    b[i] = array[i + 1] - array[i];
//    Console.WriteLine(b[i]);

//    Console.WriteLine($"[{i}] = {array[i]}");
//}

//10

/*Console.WriteLine("Сколько элементов в массиве?");
int.TryParse(Console.ReadLine(), out int count);
double[] array = new double[count];
int cifra;
int min, min1 = 0;
int max, max1= 0;
Random random = new Random();
for (int i = 0; i < count; i++)
{
    array[i] = random.Next(1, 20);
    Console.WriteLine($"[{i}] = {array[i]}");
    max = array.Max();
    min = array.Min();
    if (array[i] > max)
    {
max = array[i];
        max1 = i;
    }
    if (array[i] < min)
        min = array[i];
    min1 = i;
}

Console.WriteLine($"Max {max1}; Min {min1}");*/
/*29
Console.WriteLine("Сколько элементов в массиве?");
int.TryParse(Console.ReadLine(), out int count);
Console.WriteLine("count");
int.TryParse(Console.ReadLine(), out int M);
Console.WriteLine("M");
int.TryParse(Console.ReadLine(), out int L);
Console.WriteLine("L");
int.TryParse(Console.ReadLine(), out int N);
Console.WriteLine("N");
int sum = 0;// счётчик

int[]array = new int[count];

for (int i = 0; i < count; i++)
    int.TryParse(Console.ReadLine(), out array[i]);
for (int i = 0; i < count; i++)
    if (array[i] % M == 0 && array[i] > L && array[i] < N)
        sum++;
Console.WriteLine(sum);
*/
/*30
Console.WriteLine("Сколько элементов в массиве?");
int.TryParse(Console.ReadLine(), out int count);
double sum = 0;
int[] array = new int[count];
int a = 0;//чётные
int b = 0;//нечётные
for (int i = 0; i < count; i++)
    int.TryParse(Console.ReadLine(), out array[i]);
for (int i = 0; i < count; i++)

    if (array[i] % 2 == 1)
        sum++;
double count2 = (int)count;
sum = sum / (count2) * 100;
Console.WriteLine(sum);
*/
/*
using System.Text.Json;

Console.WriteLine("Сколько элементов в массиве?");
int.TryParse(Console.ReadLine(), out int count);
Console.WriteLine("N");
int.TryParse(Console.ReadLine(), out int N);
int sum = 0;
int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    int.TryParse(Console.ReadLine(), out array[i]);
    if (array[i] < N)
        sum++;
}
double[] array2 = new double[sum];

for (int i = 0, a=0; i < count; i++)
    if (array[i] < N)
        array2[a++] = array[i];
for (int i = 0; i<sum; i++)
    Console.WriteLine(JsonSerializer.Serialize(array2));
*/
using System;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp10
{
    internal class newClass
    {
        //2
        /*static void Main(string[] args)
        {
            int a, b, c, d;
            int.TryParse(Console.ReadLine(), out  a);
            int.TryParse(Console.ReadLine(), out  b);
            int.TryParse(Console.ReadLine(), out  c);
            int.TryParse(Console.ReadLine(), out  d);
            int nod = Nod(a, b);
            int nok = (a * b) / nod;
            Console.WriteLine(nod);
            Console.WriteLine(nok);
        }*/
        static int Nod(int x, int y, int z, int n)
        {
            for (int i = x; i > 0; i--)
            {
                if (x % i == 0 && y % i == 0 && z % i == 0 && n % i == 0)
                    return i;
            }
            return 1;
        }
        //3
        /*static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            int.TryParse(Console.ReadLine(), out int c);
            int.TryParse(Console.ReadLine(), out int d);
            int nod = Nod(a, b, c, d);
            Console.WriteLine(nod);
        }*/
        //4
        /*static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            int.TryParse(Console.ReadLine(), out int c);
            Console.WriteLine(Nok(a, b, c));
        }*/
        static int Nok(int a, int b, int c)
        {
            for (int i = 0; i < a * b * c; i++)
            {
                if (i % a == 0 && i % b == 0 && i % c == 0)
                    return i;
            }
            return 1;
        }

        static double Sum(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        //5
        /*static void Main(String[] args)
        {
            double[] array = new double[3];

            for (int i = 0; i < 3; i++)
                double.TryParse(Console.ReadLine(), out array[i]);

            Console.WriteLine(Sum(array.Max(), array.Min()));
        }*/

        static double Ploshad(double a)
        {
            double S = Math.Pow(a, 2) * (Math.Sqrt(3) / 4);
            S = S * 6;
            return S;
        }
        //6
        /*static void Main(String[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine(Ploshad(a));
        }*/
        //7
        /*static void Main(string[] args)
        {   
            Console.WriteLine("Кол-во точек");
            int.TryParse(Console.ReadLine(), out int n);
            Zapolnenie(n);
            // вывксти массив целиком
            
        }
        */
        static void Tochki(double[] array)
        {
            // буфер = max if буфер > max тогда max = буфер
            // создать массив {max x1 x2 y1 y2}
            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = i + 2; j < array.Length; j += 2)
                {
                    Rasto(array[i], array[i + 1], array[j], array[j + 1]);
                    // создать буфер переменную
                }

            }


        }
        static public double Rasto(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        }



        static void Zapolnenie(int x)
        {
            x *= 2;
            double[] array = new double[x];
            for (int i = 0; i < x; i++)
            {
                double.TryParse(Console.ReadLine(), out array[i]);

            }
        }
        /*static void Main(string[] args)
        {
            Console.WriteLine("text:");
            string str = Console.ReadLine();
            char[] split = new char[] { ' ', '.', ',', '!', '?' };
            string[] substr = str.Split(split, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(JsonSerializer.Serialize(substr));
            Console.WriteLine(substr.Length);
        }*/
        /*static void Main(string[] args)
         //2
        {
            Console.WriteLine("text:");
            string str = Console.ReadLine();
            char[] split = new char[] { ' ', '.', ',', '!', '?' };
            int slova = str.Split(split).Where(x=> x[0] == "b").Count();
            Console.WriteLine(slova)
        }*/
        //3
        /*static void Main(string[] args)
        {
            Console.WriteLine("text:");
            string str = Console.ReadLine();
            int r = 0, k = 0, t = 0;
            foreach (char letter in str)
            {
                if (letter == 'r' || letter == 'R')
                    r++;
                if (letter == 'k' || letter == 'K')
                    k++;
                if (letter == 't' || letter == 'T')
                    t++;

            }
            Console.WriteLine(r);
            Console.WriteLine(k);
            Console.WriteLine(t);

        }*/
        //4
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("text:");
            string str = Console.ReadLine();
            int r = 0, k = 0, t = 0;
            foreach (char letter in str)
            {
                if (letter == '*')
                    r++;
                if (letter == ':')
                    r++;
                if (letter == ';')
                    r++;

            }
            Console.WriteLine(r);
        }*/
        //6
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("text:");
            string str = Console.ReadLine();
            int a = str.IndexOf(":");
            str = str.Substring(0, a);
            Console.WriteLine(str.Length);
        }*/
        //7
        /*static void Main(string[] args)
        {
            Console.WriteLine("text:");
            string str = Console.ReadLine();
            char[] split = new char[] { ' ', '.', ',', '!', '?' };
            string[] substr = str.Split(split, StringSplitOptions.RemoveEmptyEntries);
            int strLegth = 3;
            for(int i = 0; i < substr.Length; i++)
            {
                if (substr[i].Length == strLegth)
                    Console.WriteLine(substr[i]);
            }
        }*/
        //8
        /*static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string start = Console.ReadLine();
            sb.Clear();// очистка билдера
            for (int i = 0; i < start.Length; i++)
            {
                if (start[i] != '*')
                    sb.Append(start[i]).Append(start[i]);
            }
            string result8 = sb.ToString();
            Console.WriteLine(result8);
        }*/
        //9
        /*static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++ )
            {
                if (text[i] == "a")
                {

                }
            }
        }*/
        /*
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);


        }*/
        private static int SumOfNumber(int number)
        {
            if (number < 0)
                return 0;
            else
                return number % 10 + SumOfNumber(number / 10);
        }
        /*//3static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int m);
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine(C(m,n));
        }*/
        static int C(int m, int n)
        {
            if (m == 0 || m == n)
                return 1;

            else
                return C(m, n - 1) + C(m - 1, n - 1);
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine(Length(a));

        }
        static int Length(int a)
        {
            if (a <= 0)
                return 0;
            else
                return 1 + Length(a / 10);
        }
        /*static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            int.TryParse(Console.ReadLine(), out int z);
            Console.WriteLine(Root(a, b, z));
        }
        static double Root(double a, double b, int z)
        {
            double c = (a + b) / 2;

            if (Math.Abs(b - a) < z)
            {
                return c;
            }
            if (F(a)*F(b)<0)
                return Root(a, b, z);
            else
                return Root(c, b, z);
        }
        public static double F(double x)
        {
            return 0;
        }*/
        //что-то



    }



}

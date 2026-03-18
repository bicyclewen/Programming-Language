以主控台模式設計專案，自動算出以下結果:
//第一題 8y+3
string y;
int a;
y = Console.ReadLine();
a = Convert.ToInt32(y);
Console.WriteLine(8*a+3);


//第二題 3x^2+4
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( Math.Pow(x,2)*3 + 4);


//第三題 (5x+1)(2y+2)
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((5 * x + 1) * (2 * y + 2));


//第四題 (B^2-4AC)^0.5
double B = Convert.ToDouble(Console.ReadLine());
double A = Convert.ToDouble(Console.ReadLine());
double C = Convert.ToDouble(Console.ReadLine());

double answer = Math.Pow((Math.Pow(B, 2) - 4 * A * C), 0.5);
Console.WriteLine(answer);


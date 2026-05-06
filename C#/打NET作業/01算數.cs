以主控台模式設計專案，自動算出以下結果:

Console.WriteLine("請輸入x= ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("請輸入y= ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("請輸入A= ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("請輸入B= ");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("請輸入C= ");
double C = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("\n第一題 : 8y+3=" + (8 * y + 3) );
Console.WriteLine("第二題 : 3x^2+4=" + (Math.Pow(x, 2) * 3 + 4) );
Console.WriteLine("第三題 : (5x+1)(2y+2)=" + (5 * x + 1) * (2 * y + 2));
Console.WriteLine("第四題 : (B^2-4AC)^0.5=" + (Math.Pow((Math.Pow(B, 2) - 4 * A * C), 0.5)) );

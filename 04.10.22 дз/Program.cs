//Формула Мэтчина 
double a, b,x,y,e,p,x1,y1,i;
int f, j;


f = 1; e = 0.001; p = 0;
x = (double) 1/5; y =(double) 1 / 239;
x1=x; y1=y;
a = 0;b = 0; i = -1;
p = 16 * x - 4 * y;
//решение без метода
while (f<200)
{
    x1 *= x * x;
    y1 *= y * y;
    a += (double)(i * x1) / (2 * f + 1);
    b+= (double) (i * y1 )/ (2 * f + 1);
    f++;
    i *= -1;
    p += 16 * a - 4 * b;
    Console.WriteLine(p);
    if ((p>Math.PI-e)&&(p < Math.PI + e))
    { break; }

}
Console.WriteLine(p);
Console.WriteLine(16*Math.Atan((double)1 / 5)-4* Math.Atan((double)1 / 239));

//решение с методом
static double arctg(double d, int k)
{
    if (k % 2 == 0)
    { return (double)d / (2 * k + 1); }
    else
    { return (double)-d / (2 * k + 1); }
}
f = 1; e = 0.1; p = 0;
x = (double)1 / 5; y = (double)1 / 239;
p += 16 * x - 4 * y;
while (f < 100)
{
    x *= x * x;
    y *= y * y;
    a = arctg(x, f);
    b = arctg(y, f);
    f++;
    p += 16 * a - 4 * b;
    if ((p > Math.PI - e) && (p < Math.PI + e))
    { break; }

}
Console.WriteLine(p);
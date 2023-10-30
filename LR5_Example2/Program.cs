using System;
interface IFigure
{
    void Print();
    double Square();
    double Bound();
    bool Exist();
}
class Triangle : IFigure
{
    double a, b, c;
    public Triangle(double a,double b,double c)
    {
        this.a = a; this.b = b; this.c = c;
    }
    public void Print()
    {
        Console.WriteLine("a = {0} b = {1} c = {2}",a,b,c);
    }
    public bool Exist()
    {
        if (a<b+c&&b<a+c&&c<a+b) return true;
        else return false;
    }
    public double Bound()
    {
        return a+b+c;
    }
    public double Square()
    {
        double p=Bound()/ 2;
        return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    }
}
class Circle : IFigure
{
    double r;
    public Circle(double r)
    {
        this.r = r;
    }
    public void Print()
    {
        Console.WriteLine("r = {0} ",r);
    }
    public bool Exist()
    {
        if (r > 0) return true;
        else return false;    
    }
    public double Bound()
    {
        return 2 * Math.PI * r;
    }
    public double Square()
    {
        return Math.PI * r*r;
    }
}
class Program
{
    static void Main(string[] args)
    {
        IFigure obj = null; //змінна інтерфейсного класу
        Random o = new Random();
        string n = ""; int f, r, a, b, c;
        for (int i = 1; i <= 5; i++)
        {
            f=o.Next(1,3); //яка фігура
            if (f == 1)
            {
                n = "Трикутник: ";
                a=o.Next(2,8); b=o.Next(2,8); c=o.Next(2,8);
                obj = new Triangle(a, b, c);
                obj.Print();
            }
            if (f == 2)
            {
                n = "Круг: ";
                r=o.Next(2,8);
                obj = new Circle(r);
                obj.Print();
            }
            if (obj.Exist())
            {
                double p =obj.Bound();
                double s=obj.Square();
                Console.WriteLine("{0} P = {1:F2}  S = {2:F2}",n,p,s);
            }
            else
                Console.WriteLine("Не iснує");
        }
    }
}

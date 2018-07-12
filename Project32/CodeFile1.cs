using System;

class BinomialDistribution
{
    private double count;
    private double probability;
    public BinomialDistribution(double x,double y)
    {
        count = x;
        probability = y;
    }

    public static void Main() {
        try
        {
            Console.WriteLine("------二項分布------");
            Console.WriteLine("何回行いますか？");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("一度の確立を教えてください。");
            var y = double.Parse(Console.ReadLine());
       
        BinomialDistribution BD = new BinomialDistribution(x,y);
        Console.WriteLine("B（{0},{1}）", x, y);
        Console.WriteLine("E(X):{0} , V(X):{1}", BD.ExpectedValue(), BD.Variance());
        Console.WriteLine("標準偏差は{0}", BD.StandardDeviation(BD.Variance()));
        }
        catch (System.FormatException)
        {
            Console.WriteLine("入力方法に誤りがあります。");
        }
    }

    public double ExpectedValue() {
        return count * probability;
    }
    public double Variance()
    {
        return count * probability * (1 - probability);
    }
    public double StandardDeviation(double Variance)
    {
        return Math.Sqrt(Variance);
    }
}


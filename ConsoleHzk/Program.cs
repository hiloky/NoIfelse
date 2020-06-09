using System;

namespace ConsoleHzk
{
    public class Program
    {
        /// <summary>
        /// 工厂+策略模式实现消除代码中过多的ifelse
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //输入 Apple 后，自动执行 Apple 类中的FruitsSay方法
            var zifu = Console.ReadLine().ToString();

            ProductFactory productFactory = new ProductFactory();
            productFactory.play(Utls.ToEnum<ProductEnum>(zifu));

            Console.WriteLine("happy end");
            //Product product = new Product();

            //if(zifu == "apple")
            //{
            //    product.Apple();
            //}
            //else if(zifu == "banana")
            //{
            //    product.Banana();
            //}
            //else if(zifu == "pear")
            //{
            //    product.Pear();
            //}
            //else
            //{
            //    Console.WriteLine("无效输入");
            //}
        }
        
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHzk
{
    public class Apple : IProduct
    {
        public Apple()
        {

        }
        public void FruitsSay()
        {
            Console.WriteLine("I am a apple");
        }

        public int getFruitsType()
        {
            return (int)ProductEnum.Apple;
        }
    }

    public class Pear : IProduct
    {
        public void FruitsSay()
        {
            Console.WriteLine("I am a pear");
        }

        public int getFruitsType()
        {
            return (int)ProductEnum.Pear;
        }
    }

    public class Banana : IProduct
    {
        public void FruitsSay()
        {
            Console.WriteLine("I am a banana");
        }

        public int getFruitsType()
        {
            return (int)ProductEnum.Banana;
        }
    }


}

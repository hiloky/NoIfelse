using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHzk
{
    interface IProduct
    {
        /// <summary>
        /// 执行某种产品的方法
        /// </summary>
        void FruitsSay();

        /// <summary>
        /// 获取枚举
        /// </summary>
        /// <returns></returns>
        int getFruitsType();
    }
}
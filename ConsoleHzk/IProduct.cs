using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHzk
{
    /// <summary>
    /// 实现该接口必须要有空的构造函数，因为反射的Invoke方法第一个参数的要求
    /// </summary>
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
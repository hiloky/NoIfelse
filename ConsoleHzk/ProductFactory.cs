using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleHzk
{
    public class ProductFactory
    {
        public ProductFactory()
        {

        }

        /// <summary>
        /// 根据所有实现IProduct接口的类，反射找到所有枚举getFruitsType 与输入字符串匹配的，并调用FruitsSay方法
        /// </summary>
        /// <param name="fruit"></param>
        public void play(ProductEnum fruit)
        {
            string TypeMethod = "getFruitsType";
            string PlayMethod = "FruitsSay";
            //反射获取当前加载的程序集
            Assembly assembly = Assembly.GetAssembly(typeof(IProduct));
            //获取此程序集中定义的所有类型
            Type[] types = assembly.GetTypes();

            List<Type> tys = new List<Type>();
            //获取所有实现 IProduct 接口的类
            types.ToList().ForEach(t =>
            {
                //非接口 非抽象类
                if (!t.IsInterface && !t.IsAbstract)
                {
                    //获取由当前System.Type实现或继承的所有接口,即当前类所实现的接口大全，看是否实现了 IProduct 接口
                    Type[] interfaces = t.GetInterfaces();
                    interfaces.ToList().ForEach(m =>
                    {
                        if (m == typeof(IProduct))
                            tys.Add(t);
                    });
                }
            });

            //循环找出当前水果类型对应的类
            tys.ForEach(t =>
            {
                //因为当前类实现了 IProduct 接口，故一定实现了该接口的方法
                MethodInfo method = t.GetMethod(TypeMethod);
                var obj = assembly.CreateInstance(t.Namespace+"."+t.Name); //执行带参数的公共方法
                //object[] objParam = new object[1];
                //objParam[0] = fruit;
                var result = method.Invoke(obj, null);
                //类型是否符合产品类型
                if (Utls.ParseInt(method.Invoke(obj, null),-1) == (int)fruit)
                {
                    //执行产品方法
                    t.GetMethod(PlayMethod).Invoke(obj, null);
                }
            });
        }
    }
}

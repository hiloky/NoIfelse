using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHzk
{
    public static class Utls
    {
        /// <summary>
        /// 对一个字符串解整数，若解析失败，则返回 defaultVal 值
        /// </summary>
        /// <param name="o">将被解析字符串</param>
        /// <param name="defaultVal">当解析失败返回的默认值</param>
        /// <returns>整数</returns>
        public static int ParseInt(object o, int defaultVal)
        {
            if (o == null)
                return defaultVal;

            int val;
            string s = o.ToString();
            if (!int.TryParse(s, out val))
                val = defaultVal;
            return val;
        }

        /// <summary>
        /// 通过字符串获取枚举
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this string name)
        {
            return (T)Enum.Parse(typeof(T), name);
        }

    }
}

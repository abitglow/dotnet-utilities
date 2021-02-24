using System;
using System.Collections.Generic;
using System.Text;

namespace GlowLab.Utilities.Extensions
{
    /// <summary>
    /// 对 <see cref="Int32"/> 类型扩展一些实用方法。
    /// </summary>
    public static class Int32Extension
    {
        /// <summary>
        /// 使用指定的字符串数组的长度作为进位制系统转换到字符串表示形式。
        /// </summary>
        /// <param name="number">要转换的整数。</param>
        /// <param name="radixSymbols">进位制系统使用的基数符号数组。该数组的长度作为指定的进位制。长度不应小于 2。</param>
        /// <returns>返回指定进位制表示该整数的字符串。</returns>
        /// <exception cref="ArgumentNullException">当 radixSymbols 为 null 时抛出此异常。</exception>
        /// <exception cref="ArgumentException">当 radixSymbols 的长度小于 2 时抛出此异常。</exception>
        public static string ToStringByRadix(this int number, string[] radixSymbols)
        {
            if (radixSymbols == null) { throw new ArgumentNullException(nameof(radixSymbols)); }
            if (radixSymbols.Length < 2) { throw new ArgumentException("数组长度不能小于 2", nameof(radixSymbols)); }

            // 除 N 取余逆序排列法。
            List<string> stringCollection = new List<string>();
            int div = number, radix = radixSymbols.Length;
            do
            {
                int quotient = Math.DivRem(div, radix, out int rem);
                stringCollection.Add(radixSymbols[Math.Abs(rem)]);
                div = quotient;
            } while (div != 0);
            if (number < 0) { stringCollection.Add("-"); }
            stringCollection.Reverse();
            return string.Concat(stringCollection);
        }
    }
}

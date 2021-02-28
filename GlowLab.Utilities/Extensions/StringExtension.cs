using System;
using System.Text;

namespace GlowLab.Utilities.Extensions
{
    /// <summary>
    /// 对 <see cref="String"/> 类型扩展一些实用方法。
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 获取一个新字符串，由该字符串按 Unicode 码位反转后得到。
        /// </summary>
        /// <param name="str">要反转的字符串。</param>
        /// <returns>返回反转后的新字符串。</returns>
        /// <exception cref="ArgumentNullException">当 str 为 null 时抛出此异常。</exception>
        /// <remarks>
        /// 一个 Unicode 码位可能由两个 char 单元组成，这被称为代理项对。该方法处理了该种情况。
        /// 对于由多个 Unicode 码位组成的字形群集，该方法并未处理。当要反转的字符串中包含字形群集时候请勿使用该方法。
        /// </remarks>
        public static string Reverse(this string str)
        {
            if (str == null) { throw new ArgumentNullException(nameof(str)); }
            StringBuilder stringBuilder = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!char.IsSurrogate(str[i]))
                {
                    stringBuilder.Append(str[i]);
                }
                else
                {
                    stringBuilder.Append(str[i - 1]);
                    stringBuilder.Append(str[i]);
                    i--;
                }
            }
            return stringBuilder.ToString();
        }
    }
}

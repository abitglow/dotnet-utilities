using System;

namespace GlowLab.Utilities.Braille
{    /// <summary>
     ///  表示一方盲文点字中八个点位突起状态的结构。
     /// </summary>
    public readonly struct BrailleCell : IEquatable<BrailleCell>
    {
        /// <summary>
        /// Unicode 盲文点字符号的首个字符，及空白盲文点位。
        /// </summary>
        public const char UnicodeBrailleFirstCharacter = '\u2800';

        /// <summary>
        /// Unicode 盲文点字符号的最后一个字符，及满方盲文点位。
        /// </summary>
        public const char UnicodeBrailleLastCharacter = '\u28ff';

        /// <summary>
        /// 存储八个盲文点字点位突起状态的字段。
        /// 8 位二进制位和八个盲文点位一一对应存储。
        /// </summary>
        private readonly byte value;

        /// <summary>
        /// 表示 1 点 （⠁） 突起的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell Dot1 = new BrailleCell(1);

        /// <summary>
        /// 表示 2 点 （⠂） 突起的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell Dot2 = new BrailleCell(2);

        /// <summary>
        /// 表示 3 点 （⠄） 突起的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell Dot3 = new BrailleCell(4);

        /// <summary>
        /// 表示 4 点 （⠈） 突起的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell Dot4 = new BrailleCell(8);

        /// <summary>
        /// 表示 5 点 （⠐） 突起的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell Dot5 = new BrailleCell(16);

        /// <summary>
        /// 表示 6 点 （⠠） 突起的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell Dot6 = new BrailleCell(32);

        /// <summary>
        /// 表示 7 点 （⡀） 突起的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell Dot7 = new BrailleCell(64);


        /// <summary>
        /// 表示 8 点 （⢀） 突起的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell Dot8 = new BrailleCell(128);

        /// <summary>
        /// 表示没有点位突起 （⠀） 的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell EmptyCell = new BrailleCell(byte.MinValue);

        /// <summary>
        /// 所有点位突起 （⣿） 的 <see cref="BrailleCell"/> 结构。 此为静态只读字段。
        /// </summary>
        public static readonly BrailleCell FullCell = new BrailleCell(byte.MaxValue);

        /// <summary>
        /// 获取一个表示该 <see cref="BrailleCell"/> 结构存储的盲文点字点位的字符。
        /// 该字符属于 Unicode 盲文点字模型。
        /// </summary>
        public char Character
        {
            get { return (char)(UnicodeBrailleFirstCharacter + this.value); }
        }

        /// <summary>
        /// 获取一个表示八个盲文点字点位的 <see cref="Byte"/> 值。
        /// </summary>
        public byte Value
        {
            get { return this.value; }
        }

        /// <summary>
        /// 用一个表示八个盲文点字点位的八位无符号整数初始化 <see cref="BrailleCell"/> 结构。
        /// </summary>
        /// <param name="value">用于初始化 <see cref="BrailleCell"/> 结构的八位无符号整数值。</param>
        public BrailleCell(byte value)
        {
            this.value = value;
        }

        /// <summary>
        /// 使用表示盲文点字点位的字符初始化 <see cref="BrailleCell"/> 结构。
        /// </summary>
        /// <param name="chr">一个盲文点字字符。</param>
        /// <exception cref="ArgumentOutOfRangeException">当 chr 的值小于 <see cref="UnicodeBrailleFirstCharacter"/> 或 chr > <see cref="UnicodeBrailleLastCharacter"/> 时抛出此异常。</exception>
        public BrailleCell(char chr)
        {
            if (chr < UnicodeBrailleFirstCharacter || chr > UnicodeBrailleLastCharacter)
            {
                throw new ArgumentOutOfRangeException(nameof(chr));
            }
            this.value = (byte)(chr - UnicodeBrailleFirstCharacter);
        }

        /// <summary>
        /// 比较该值是否等于给定对象的值。
        /// </summary>
        /// <param name="obj">要比较的对象。</param>
        /// <returns>如果该结构值等于给定对象值返回 true； 如果两值不相等或给定对象不是 <see cref="BrailleCell"/> 结构返回 false。</returns>
        public override bool Equals(object obj)
        {
            if (obj is BrailleCell v)
            {
                return this.value == v.value;
            }
            return false;
        }

        /// <summary>
        /// 比较该值是否等于给定的 <see cref="BrailleCell"/> 值。
        /// </summary>
        /// <param name="v">要比较的另一个 <see cref="BrailleCell"/> 实例。</param>
        /// <returns>如果两个值相等返回 true； 如果两个值不相等返回 false。</returns>
        public bool Equals(BrailleCell v)
        {
            return this.value == v.value;
        }

        /// <summary>
        /// 获取指定点位突起的 <see cref="BrailleCell"/> 结构。
        /// </summary>
        /// <param name="dot">突起的点位。应在 1-8 之间。</param>
        /// <returns>返回指定点位突起的 <see cref="BrailleCell"/> 结构。</returns>
        public static BrailleCell GetDot(int dot)
        {
            if (dot < 1 || dot > 8)
            {
                throw new ArgumentOutOfRangeException(nameof(dot));
            }
            return new BrailleCell((byte)(1 << dot - 1));
        }

        /// <summary>
        /// 适用于此结构的哈希函数。总是返回 <see cref="Value"/> 的值。
        /// </summary>
        /// <returns>返回 <see cref="Value"/> 的值。</returns>
        public override int GetHashCode()
        {
            return this.value;
        }

        /// <summary>
        /// 判断是否含有指定的 <see cref="BrailleCell"/> 结构中的盲文点位。
        /// </summary>
        /// <param name="brailleCell">盲文点字点位。</param>
        /// <returns>如果含有指定的盲文点位返回 true； 否则返回 false。</returns>
        public bool Have(BrailleCell brailleCell)
        {
            return (this.value & brailleCell.value) == brailleCell.value;
        }

        /// <summary>
        /// 获取 <see cref="BrailleCell"/> 的字符串表示形式。
        /// </summary>
        /// <returns>返回表示盲文点字的字符串。</returns>
        public override string ToString()
        {
            return ((char)(UnicodeBrailleFirstCharacter + this.value)).ToString();
        }

        /// <summary>
        /// 比较两个 <see cref="BrailleCell"/> 结构是否相等。
        /// </summary>
        /// <param name="a">一个 <see cref="BrailleCell"/> 结构。</param>
        /// <param name="b">另一个 <see cref="BrailleCell"/> 结构。</param>
        /// <returns>如果两值相等返回 true， 否则返回 false。</returns>
        public static bool operator ==(BrailleCell a, BrailleCell b) => a.value == b.value;

        /// <summary>
        /// 比较两个 <see cref="BrailleCell"/> 结构是否不相等。
        /// </summary>
        /// <param name="a">一个 <see cref="BrailleCell"/> 结构。</param>
        /// <param name="b">另一个 <see cref="BrailleCell"/> 结构。</param>
        /// <returns>如果两值不相等返回 true， 否则返回 false。</returns>
        public static bool operator !=(BrailleCell a, BrailleCell b) => a.value != b.value;

        /// <summary>
        /// 将两个 <see cref="BrailleCell"/> 结构中突起的点位合并为一个 <see cref="BrailleCell"/> 结构。
        /// </summary>
        /// <param name="a">一方盲文点字。</param>
        /// <param name="b">另一方盲文点字。</param>
        /// <returns>返回两方合并为一方的 <see cref="BrailleCell"/> 结构。</returns>
        public static BrailleCell operator +(BrailleCell a, BrailleCell b) => new BrailleCell((byte)(a.value | b.value));

        /// <summary>
        /// 将指定一方盲文点字中的指定点位抹平。
        /// </summary>
        /// <param name="a">存储被抹平的盲文点字的 <see cref="BrailleCell"/> 结构。</param>
        /// <param name="b">指定要抹平的盲文点位的 <see cref="BrailleCell"/> 结构。</param>
        /// <returns>返回指定一方盲文点字被抹平了指定点位的 <see cref="BrailleCell"/> 结构。</returns>
        public static BrailleCell operator -(BrailleCell a, BrailleCell b) => new BrailleCell((byte)(a.value - (a.value & b.value)));
    }
}

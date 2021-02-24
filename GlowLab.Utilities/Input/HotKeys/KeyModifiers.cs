using System;

namespace GlowLab.Utilities.Input.HotKeys
{
    /// <summary>
    /// 为热键提供修饰键选项的枚举。
    /// </summary>
    [Flags]
    public enum KeyModifiers
    {
        /// <summary>
        /// 没有修饰键。
        /// </summary>
        None = 0X00,

        /// <summary>
        /// ALT 键。
        /// </summary>
        Alt = 0X01,

        /// <summary>
        /// CTRL 键。
        /// </summary>
        Control = 0X02,

        /// <summary>
        /// SHIFT 键。
        /// </summary>
        Shift = 0X04,

        /// <summary>
        /// Windows 徽标键。
        /// </summary>
        Windows = 0X08,

        /// <summary>
        /// 热键按下时禁止重复发出消息。
        /// </summary>
        NoRepeat = 0X4000
    }
}

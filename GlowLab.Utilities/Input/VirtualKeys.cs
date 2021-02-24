using System;

namespace GlowLab.Utilities.Input
{
    /// <summary>
    /// 包含 PC 键盘中的虚拟键代码常量的枚举。
    /// 详细信息可查看 https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes。
    /// </summary>
    public enum VirtualKeys
    {
        /// <summary>
        /// 不按任何键。作为该枚举的默认值。
        /// </summary>
        None = 0X00,

        /// <summary>
        /// 鼠标左键。
        /// </summary>
        LeftButton = 0X01,

        /// <summary>
        /// 鼠标右键。
        /// </summary>
        RightButton = 0X02,

        /// <summary>
        /// 取消键。
        /// </summary>
        Cancel = 0X03,

        /// <summary>
        /// 鼠标中键。
        /// </summary>
        MiddleButton = 0X04,

        /// <summary>
        /// 第一个 X 鼠标按钮（五个按钮的鼠标）。
        /// </summary>
        XButton1 = 0X05,

        /// <summary>
        /// 第二个 X 鼠标按钮（五个按钮的鼠标）。
        /// </summary>
        XButton2 = 0X06,

        // 0X07 is undefined.

        /// <summary>
        /// BACKSPACE （退格） 键。
        /// </summary>
        Back = 0x08,

        /// <summary>
        /// TAB 键。
        /// </summary>
        Tab = 0x09,

        // 0X0A 0X0B is reserved.

        /// <summary>
        /// CLEAR 键。
        /// </summary>
        Clear = 0x0C,

        /// <summary>
        /// RETURN （回车） 键。
        /// </summary>
        Return = 0x0D,

        // 0X0E 0X0F is undefined.

        /// <summary>
        /// SHIFT （转换） 键。
        /// </summary>
        Shift = 0x10,

        /// <summary>
        /// CTRL （控制） 键。
        /// </summary>
        Control = 0x11,

        /// <summary>
        /// ALT 键。
        /// </summary>
        Menu = 0x12,

        /// <summary>
        /// PAUSE 键。
        /// </summary>
        Pause = 0x13,

        /// <summary>
        /// 大写锁定键。
        /// </summary>
        CapsLock = 0x14,

        /// <summary>
        /// IME Kana 模式键。
        /// </summary>
        Kana = 0X15,

        /// <summary>
        /// IME Hangul 模式键。
        /// </summary>
        Hangul = 0X15,

        // 0X16 is undefined.

        /// <summary>
        /// IME Junja 模式键。
        /// </summary>
        Junja = 0x17,

        /// <summary>
        /// IME 最终模式键。
        /// </summary>
        Final = 0x18,

        /// <summary>
        /// IME Hanja 模式键。
        /// </summary>
        Hanja = 0x19,

        /// <summary>
        /// IME Kanji 模式键。
        /// </summary>
        Kanji = 0x19,

        // 0X1A is undefined.

        /// <summary>
        /// ESC 键。
        /// </summary>
        Escape = 0x1B,

        /// <summary>
        /// IME 转换键。
        /// </summary>
        IMEConvert = 0x1C,

        /// <summary>
        /// IME 非转换键。
        /// </summary>
        NonConvert = 0x1D,

        /// <summary>
        /// IME 接受键。
        /// </summary>
        IMEAccept = 0x1E,

        /// <summary>
        /// IME 模式更改键。
        /// </summary>
        IMEModeChange = 0x1F,

        /// <summary>
        /// Spacebar （空格） 键。
        /// </summary>
        Space = 0x20,

        /// <summary>
        /// PAGE UP 键。
        /// </summary>
        PageUp = 0x21,

        /// <summary>
        /// PageDown 键。
        /// </summary>
        PageDown = 0x22,

        /// <summary>
        /// END （行尾） 键。
        /// </summary>
        End = 0x23,

        /// <summary>
        /// HOME （行首） 键。
        /// </summary>
        Home = 0x24,

        /// <summary>
        /// 左箭头键。
        /// </summary>
        Left = 0x25,

        /// <summary>
        /// 上箭头键。
        /// </summary>
        Up = 0x26,

        /// <summary>
        /// 右箭头键。
        /// </summary>
        Right = 0x27,

        /// <summary>
        /// 下箭头键。
        /// </summary>
        Down = 0x28,

        /// <summary>
        /// SELECT 键。
        /// </summary>
        Select = 0x29,

        /// <summary>
        /// PRINT 键。
        /// </summary>
        Print = 0x2A,

        /// <summary>
        /// EXECUTE 键。
        /// </summary>
        Execute = 0x2B,

        /// <summary>
        /// PRINT SCREEN 键。
        /// </summary>
        Snapshot = 0x2C,

        /// <summary>
        /// INS （插入） 键。
        /// </summary>
        Insert = 0x2D,

        /// <summary>
        /// DEL （删除） 键。
        /// </summary>
        Delete = 0x2E,

        /// <summary>
        /// HELP 键。
        /// </summary>
        Help = 0x2F,

        /// <summary>
        /// 0 键。
        /// </summary>
        D0 = 0x30,

        /// <summary>
        /// 1 键。
        /// </summary>
        D1 = 0x31,

        /// <summary>
        /// 2 键。
        /// </summary>
        D2 = 0x32,

        /// <summary>
        /// 3 键。
        /// </summary>
        D3 = 0x33,

        /// <summary>
        /// 4 键。
        /// </summary>
        D4 = 0x34,

        /// <summary>
        /// 5 键。
        /// </summary>
        D5 = 0x35,

        /// <summary>
        /// 6 键。
        /// </summary>
        D6 = 0x36,

        /// <summary>
        /// 7 键。
        /// </summary>
        D7 = 0x37,

        /// <summary>
        /// 8键。
        /// </summary>
        D8 = 0x38,

        /// <summary>
        /// 9 键。
        /// </summary>
        D9 = 0x39,

        // 0X3A -0X40 is undefined.

        /// <summary>
        /// A 键。
        /// </summary>
        A = 0x41,


        /// B 键。        B = 0x42,

        /// C 键。
        C = 0x43,

        /// <summary>
        /// D 键。
        /// </summary>
        D = 0x44,

        /// <summary>
        /// E 键。
        /// </summary>
        E = 0x45,

        /// <summary>
        /// F 键。
        /// </summary>
        F = 0x46,

        /// <summary>
        /// G 键。
        /// </summary>
        G = 0x47,

        /// <summary>
        /// H 键。
        /// </summary>
        H = 0x48,

        /// <summary>
        /// I 键。
        /// </summary>
        I = 0x49,

        /// <summary>
        /// J 键。
        /// </summary>
        J = 0x4A,

        /// <summary>
        /// K 键。
        /// </summary>
        K = 0x4B,

        /// <summary>
        /// L 键。
        /// </summary>
        L = 0x4C,

        /// <summary>
        /// M 键。
        /// </summary>
        M = 0x4D,

        /// <summary>
        /// N 键。
        /// </summary>
        N = 0x4E,

        /// <summary>
        /// O 键。
        /// </summary>

        /// O 键。
        O = 0x4F,

        /// <summary>
        /// P 键。
        /// </summary>
        P = 0x50,

        /// <summary>
        /// Q 键。
        /// </summary>
        Q = 0x51,

        /// <summary>
        /// R 键。
        /// </summary>
        R = 0x52,

        /// <summary>
        /// S 键。
        /// </summary>
        S = 0x53,

        /// <summary>
        /// T 键。
        /// </summary>
        T = 0x54,

        /// <summary>
        /// U 键。
        /// </summary>
        U = 0x55,

        /// <summary>
        /// V 键。
        /// </summary>
        V = 0x56,

        /// <summary>
        /// W键。
        /// </summary>
        W = 0x57,

        /// <summary>
        /// X 键。
        /// </summary>
        X = 0x58,

        /// <summary>
        /// Y 键。
        /// </summary>
        Y = 0x59,

        /// <summary>
        /// Z 键。
        /// </summary>
        Z = 0x5A,

        /// <summary>
        /// 左 Windows 徽标键 (Microsoft Natural Keyboard)。
        /// </summary>
        LeftWindows = 0x5B,

        /// <summary>
        /// 右 Windows 徽标键 (Microsoft Natural Keyboard)。
        /// </summary>
        RightWindows = 0x5C,

        /// <summary>
        /// 应用程序键（Microsoft Natural Keyboard，人体工程学键盘）。
        /// </summary>
        Application = 0x5D,

        // 0X5E is Reserved.

        /// <summary>
        /// 计算机睡眠键。
        /// </summary>
        Sleep = 0x5F,

        /// <summary>
        /// 数字键盘上的 0 键。
        /// </summary>
        NumPad0 = 0x60,

        /// <summary>
        /// 数字键盘上的 1 键。
        /// </summary>
        NumPad1 = 0x61,

        /// <summary>
        /// 数字键盘上的 2 键。
        /// </summary>
        NumPad2 = 0x62,

        /// <summary>
        /// 数字键盘上的 3 键。
        /// </summary>
        NumPad3 = 0x63,

        /// <summary>
        /// 数字键盘上的 4 键。
        /// </summary>
        NumPad4 = 0x64,

        /// <summary>
        /// 数字键盘上的 5 键。
        /// </summary>
        NumPad5 = 0x65,

        /// <summary>
        /// 数字键盘上的 6 键。
        /// </summary>
        NumPad6 = 0x66,

        /// <summary>
        /// 数字键盘上的7 键。
        /// </summary>
        NumPad7 = 0x67,

        /// <summary>
        /// 数字键盘上的 8 键。
        /// </summary>
        NumPad8 = 0x68,

        /// <summary>
        /// 数字键盘上的 9 键。
        /// </summary>
        NumPad9 = 0x69,

        /// <summary>
        /// 乘号键。
        /// </summary>
        Multiply = 0x6A,

        /// <summary>
        /// 加号键。
        /// </summary>
        Add = 0x6B,

        /// <summary>
        /// 分隔符键。
        /// </summary>
        Separator = 0x6C,

        /// <summary>
        /// 减号键。
        /// </summary>
        Subtract = 0x6D,

        /// <summary>
        /// 据点键。
        /// </summary>
        Decimal = 0x6E,

        /// <summary>
        /// 除号键。
        /// </summary>
        Divide = 0x6F,

        /// <summary>
        /// F1 键。
        /// </summary>
        F1 = 0x70,

        /// <summary>
        /// F2 键。
        /// </summary>
        F2 = 0x71,

        /// <summary>
        /// F3 键。
        /// F3 键。
        /// </summary>
        F3 = 0x72,

        /// <summary>
        /// F4 键。
        /// </summary>
        F4 = 0x73,

        /// <summary>
        /// F5 键。
        /// </summary>
        F5 = 0x74,

        /// <summary>
        /// F6 键。
        /// </summary>
        F6 = 0x75,

        /// <summary>
        /// F7 键。
        /// </summary>
        F7 = 0x76,

        /// <summary>
        /// F8 键。
        /// </summary>
        F8 = 0x77,

        /// <summary>
        /// F9 键。
        /// </summary>
        F9 = 0x78,

        /// <summary>
        /// F10 键。
        /// </summary>
        F10 = 0x79,

        /// <summary>
        /// F11 键。
        /// </summary>
        F11 = 0x7A,

        /// <summary>
        /// F12 键。
        /// </summary>
        F12 = 0x7B,

        /// <summary>
        /// F13 键。
        /// </summary>
        F13 = 0x7C,

        /// <summary>
        /// F14 键。
        /// </summary>
        F14 = 0x7D,

        /// <summary>
        /// F15 键。
        /// </summary>
        F15 = 0x7E,

        /// <summary>
        /// F16 键。
        /// </summary>
        F16 = 0x7F,

        /// <summary>
        /// F17 键。
        /// </summary>
        F17 = 0x80,

        /// <summary>
        /// F18 键。
        /// </summary>
        F18 = 0x81,

        /// <summary>
        /// F19 键。
        /// </summary>
        F19 = 0x82,

        /// <summary>
        /// F20 键。
        /// </summary>
        F20 = 0x83,

        /// <summary>
        /// F21 键。
        /// </summary>
        F21 = 0x84,

        /// <summary>
        /// F22 键。
        /// </summary>
        F22 = 0x85,

        /// <summary>
        /// F23 键。
        /// </summary>
        F23 = 0x86,

        /// <summary>
        /// F24 键。
        /// </summary>
        F24 = 0x87,

        // 0X88 - 0X8F is undefined.
        /// <summary>
        /// 数字锁定键。
        /// </summary>
        NumLock = 0x90,

        /// <summary>
        /// 滚动锁定键。
        /// </summary>
        ScrollLock = 0x91,

        // 0X92 -0X96 is OEM specific.
        // 0X9 7-0X9F is unassigned.

        /// <summary>
        /// 左 Shift 键。
        /// </summary>
        LeftShift = 0xA0,

        /// <summary>
        /// 右 Shift 键。
        /// </summary>
        RightShift = 0xA1,

        /// <summary>
        /// 左 CTRL 键。
        /// </summary>
        LeftControl = 0xA2,

        /// <summary>
        /// 右 CTRL 键。
        /// </summary>
        RightControl = 0xA3,

        /// <summary>
        /// 左 ALT 键。
        /// </summary>
        LeftMenu = 0xA4,

        /// <summary>
        /// 右 ALT 键。
        /// </summary>
        RightMenu = 0xA5,

        /// <summary>
        /// 浏览器后退键。
        /// </summary>
        BrowserBack = 0xA6,

        /// <summary>
        /// 浏览器前进键。
        /// </summary>
        BrowserForward = 0xA7,

        /// <summary>
        /// 浏览器刷新键。
        /// </summary>
        BrowserRefresh = 0xA8,

        /// <summary>
        /// 浏览器停止键。
        /// </summary>
        BrowserStop = 0xA9,

        /// <summary>
        /// 浏览器搜索键。
        /// </summary>
        BrowserSearch = 0xAA,

        /// <summary>
        /// 浏览器收藏夹键。
        /// </summary>
        BrowserFavorites = 0xAB,

        /// <summary>
        /// 浏览器主页键。
        /// </summary>
        BrowserHome = 0xAC,

        /// <summary>
        /// 静音键。
        /// </summary>
        VolumeMute = 0xAD,

        /// <summary>
        /// 减小音量键。
        /// </summary>
        VolumeDown = 0xAE,

        /// <summary>
        /// 增大音量键。
        /// </summary>
        VolumeUp = 0xAF,

        /// <summary>
        /// 媒体下一曲目键。
        /// </summary>
        MediaNextTrack = 0xB0,

        /// <summary>
        /// 媒体上一曲目键。
        /// </summary>
        MediaPrevTrack = 0xB1,

        /// <summary>
        /// 媒体停止键。
        /// </summary>
        MediaStop = 0xB2,

        /// <summary>
        /// 媒体播放暂停键。
        /// </summary>
        MediaPlayPause = 0xB3,

        /// <summary>
        /// 启动邮件键。
        /// </summary>
        LaunchMail = 0xB4,

        /// <summary>
        /// 选择媒体键。
        /// </summary>
        LaunchMediaSelect = 0xB5,

        /// <summary>
        /// 启动应用程序一键。
        /// </summary>
        LaunchApplication1 = 0xB6,

        /// <summary>
        /// 启动应用程序二键。
        /// </summary>
        LaunchApplication2 = 0xB7,

        // 0XB8 -0XB9 is reserved.

        /// <summary>
        /// 美式标准键盘上的 OEM 分号键。
        /// </summary>
        OemSemicolon = 0xBA,

        /// <summary>
        /// 任何国家/地区键盘上的 OEM 加号键。
        /// </summary>
        OemPlus = 0xBB,

        /// <summary>
        /// 任何国家/地区键盘上的 OEM 逗号键。
        /// </summary>
        OemComma = 0xBC,

        /// <summary>
        /// 任何国家/地区键盘上的 OEM 减号键。
        /// </summary>
        OemMinus = 0xBD,

        /// <summary>
        /// 任何国家/地区键盘上的 OEM 句点键。
        /// </summary>
        OemPeriod = 0xBE,

        /// <summary>
        /// 美式标准键盘上的 OEM 问号键。
        /// </summary>
        OemQuestion = 0xBF,

        /// <summary>
        /// 美式标准键盘上的 OEM 波形符键。
        /// </summary>
        OemTilde = 0xC0,

        // 0XC1 -0XD7 is reserved.
        // 0XD8 - 0XDA is undefined.

        /// <summary>
        /// 美式标准键盘上的 OEM 左括号键。
        /// </summary>
        OemOpenBrackets = 0xDB,

        /// <summary>
        /// 美式标准键盘上的 OEM 管道键。
        /// </summary>
        OemPipe = 0xDC,

        /// <summary>
        /// 美式标准键盘上的 OEM 右括号键。
        /// </summary>
        OemCloseBrackets = 0xDD,

        /// <summary>
        /// 美式标准键盘上的 OEM 单/双引号键。
        /// </summary>
        OemQuotes = 0xDE,

        /// <summary>
        /// OEM 8 键。
        /// </summary>
        Oem8 = 0xDF,

        // 0XE0 is reserved.
        // 0XE1 is OEM specific.

        /// <summary>
        /// RT 102 键的键盘上的 OEM 尖括号或反斜杠键。
        /// </summary>
        OemBackslash = 0xE2,

        // 0XE3 -0XE4 is OEM specific.

        /// <summary>
        /// Process Key 键。
        /// </summary>
        ProcessKey = 0xE5,

        // 0XE6 is OEM specific.

        /// <summary>
        /// 用于将 Unicode 字符当作键击传递。 Packet 键值是用于非键盘输入法的 32 位虚拟键值的低位字。
        /// </summary>
        Packet = 0xE7,

        // 0XE8 is undefined.
        // 0XE9 -0XF5 is OEM specific.

        /// <summary>
        /// ATTN 键。
        /// </summary>
        Attn = 0xF6,

        /// <summary>
        /// CRSEL 键。
        /// </summary>
        CRSel = 0xF7,

        /// <summary>
        /// EXSEL 键。
        /// </summary>
        EXSel = 0xF8,

        /// <summary>
        /// ERASE EOF 键。
        /// </summary>
        EraseEof = 0xF9,

        /// <summary>
        /// 播放键。
        /// </summary>
        Play = 0xFA,

        /// <summary>
        /// 缩放键。
        /// </summary>
        Zoom = 0xFB,

        /// <summary>
        /// 留待将来使用的常数。
        /// </summary>
        NoName = 0xFC,

        /// <summary>
        /// PA1 键。
        /// </summary>
        Pa1 = 0xFD,

        /// <summary>
        /// CLEAR 键。
        /// </summary>
        OemClear = 0xFE
    }
}

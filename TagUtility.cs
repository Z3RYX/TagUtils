using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagUtils
{
    public static class TagUtility
    {
        public static class TagValues
        {
#pragma warning disable CA2211 // Non-constant fields should not be visible
            //! Render Distance
            public static TagValue<float> RenderDistance = new(1350.0f, 0x00143b98, 0x0014497c);

            //! Movement
            // Up
            public static TagValue<Keys> MovementUpPrime = new(Keys.WPressed, 0x00003934, 0x00003854);
            public static TagValue<Keys> MovementUpSecond = new(Keys.UpArrowPressed, 0x0000393f, 0x0000385f);

            // Down
            public static TagValue<Keys> MovementDownPrime = new(Keys.SPressed, 0x00003954, 0x00003874);
            public static TagValue<Keys> MovementDownSecond = new(Keys.DownArrowPressed, 0x0000395d, 0x0000387d);

            // Left
            public static TagValue<Keys> MovementLeftPrime = new(Keys.APressed, 0x00003970, 0x00003890);
            public static TagValue<Keys> MovementLeftSecond = new(Keys.LeftArrowPressed, 0x00003979, 0x00003899);

            // Right
            public static TagValue<Keys> MovementRightPrime = new(Keys.DPressed, 0x0000398c, 0x000038ac);
            public static TagValue<Keys> MovementRightSecond = new(Keys.RightArrowPressed, 0x00003995, 0x000038b5);


            //! Can Select
            // 1
            public static TagValue<Keys> CanSelect1_First = new(Keys.One, 0x00003de5, 0x00003d11);
            public static TagValue<Keys> CanSelect1_Second = new(Keys.OnePressed, 0x00003dec, 0x00003d18);
            // Third check doesn't exist
            public static TagValue<Keys> CanSelect1_Fourth = new(Keys.OnePressed, 0x00003e23, 0x00003d4f);

            // 2
            public static TagValue<Keys> CanSelect2_First = new(Keys.Two, 0x00003df5, 0x00003d21);
            public static TagValue<Keys> CanSelect2_Second = new(Keys.TwoPressed, 0x00003dfb, 0x00003d27);
            public static TagValue<Keys> CanSelect2_Third = new(Keys.Two, 0x00003e4b, 0x00003d77);
            public static TagValue<Keys> CanSelect2_Fourth = new(Keys.TwoPressed, 0x00003e51, 0x00003d7d);

            // 3
            public static TagValue<Keys> CanSelect3_First = new(Keys.Three, 0x00003e04, 0x00003d30);
            public static TagValue<Keys> CanSelect3_Second = new(Keys.ThreePressed, 0x00003e0e, 0x00003d3a);
            public static TagValue<Keys> CanSelect3_Third = new(Keys.Three, 0x00003e7d, 0x00003da9);
            public static TagValue<Keys> CanSelect3_Fourth = new(Keys.ThreePressed, 0x00003e83, 0x00003daf);


            //! Can Cheat (v1.1 only)
            // 1
            public static TagValue<Keys> CanCheats1_First = new(Keys.Eight, -1, 0x00003e1e);
            public static TagValue<Keys> CanCheats1_Second = new(Keys.EightPressed, -1, 0x00003e2d);

            // 2
            public static TagValue<Keys> CanCheats2_First = new(Keys.Nine, -1, 0x00003e3e);
            public static TagValue<Keys> CanCheats2_Second = new(Keys.NinePressed, -1, 0x00003e44);

            // 3
            public static TagValue<Keys> CanCheats3_First = new(Keys.Zero, -1, 0x00003e54);
            public static TagValue<Keys> CanCheats3_Second = new(Keys.ZeroPressed, -1, 0x00003e5a);
#pragma warning restore CA2211 // Non-constant fields should not be visible
        }
    }

    public enum Keys
    {
        NULL = 0x0,
        Escape = 0x1,
        EscapePressed = 0x101,
        One = 0x2,
        OnePressed = 0x102,
        Two = 0x3,
        TwoPressed = 0x103,
        Three = 0x4,
        ThreePressed = 0x104,
        Four = 0x5,
        FourPressed = 0x105,
        Five = 0x6,
        FivePressed = 0x106,
        Six = 0x7,
        SixPressed = 0x107,
        Seven = 0x8,
        SevenPressed = 0x108,
        Eight = 0x9,
        EightPressed = 0x109,
        Nine = 0xA,
        NinePressed = 0x10A,
        Zero = 0xB,
        ZeroPressed = 0x10B,
        Minus = 0xC,
        MinusPressed = 0x10C,
        Equals = 0xD,
        EqualsPressed = 0x10D,
        Backspace = 0xE,
        BackspacePressed = 0x10E,
        Tab = 0xF,
        TabPressed = 0x10F,
        Q = 0x10,
        QPressed = 0x110,
        W = 0x11,
        WPressed = 0x111,
        E = 0x12,
        EPressed = 0x112,
        R = 0x13,
        RPressed = 0x113,
        T = 0x14,
        TPressed = 0x114,
        Y = 0x15,
        YPressed = 0x115,
        U = 0x16,
        UPressed = 0x116,
        I = 0x17,
        IPressed = 0x117,
        O = 0x18,
        OPressed = 0x118,
        P = 0x19,
        PPressed = 0x119,
        LeftBracket = 0x1A,
        LeftBracketPressed = 0x11A,
        RightBracket = 0x1B,
        RightBracketPressed = 0x11B,
        Enter = 0x1C,
        EnterPressed = 0x11C,
        LeftControl = 0x1D,
        LeftControlPressed = 0x11D,
        A = 0x1E,
        APressed = 0x11E,
        S = 0x1F,
        SPressed = 0x11F,
        D = 0x20,
        DPressed = 0x120,
        F = 0x21,
        FPressed = 0x121,
        G = 0x22,
        GPressed = 0x122,
        H = 0x23,
        HPressed = 0x123,
        J = 0x24,
        JPressed = 0x124,
        K = 0x25,
        KPressed = 0x125,
        L = 0x26,
        LPressed = 0x126,
        Semicolon = 0x27,
        SemicolonPressed = 0x127,
        Apostrophe = 0x28,
        ApostrophePressed = 0x128,
        Tilde = 0x29,
        TildePressed = 0x129,
        LeftShift = 0x2A,
        LeftShiftPressed = 0x12A,
        BackSlash = 0x2B,
        BackSlashPressed = 0x12B,
        Z = 0x2C,
        ZPressed = 0x12C,
        X = 0x2D,
        XPressed = 0x12D,
        C = 0x2E,
        CPressed = 0x12E,
        V = 0x2F,
        VPressed = 0x12F,
        B = 0x30,
        BPressed = 0x130,
        N = 0x31,
        NPressed = 0x131,
        M = 0x32,
        MPressed = 0x132,
        Comma = 0x33,
        CommaPressed = 0x133,
        Period = 0x34,
        PeriodPressed = 0x134,
        ForwardSlash = 0x35,
        ForwardSlashPressed = 0x135,
        RightShift = 0x36,
        RightShiftPressed = 0x136,
        NumAsterisk = 0x37,
        NumAsteriskPressed = 0x137,
        LeftAlt = 0x38,
        LeftAltPressed = 0x138,
        Spacebar = 0x39,
        SpacebarPressed = 0x139,
        CapsLock = 0x3A,
        CapsLockPressed = 0x13A,
        F1 = 0x3B,
        F1Pressed = 0x13B,
        F2 = 0x3C,
        F2Pressed = 0x13C,
        F3 = 0x3D,
        F3Pressed = 0x13D,
        F4 = 0x3E,
        F4Pressed = 0x13E,
        F5 = 0x3F,
        F5Pressed = 0x13F,
        F6 = 0x40,
        F6Pressed = 0x140,
        F7 = 0x41,
        F7Pressed = 0x141,
        F8 = 0x42,
        F8Pressed = 0x142,
        F9 = 0x43,
        F9Pressed = 0x143,
        F10 = 0x44,
        F10Pressed = 0x144,
        NumLock = 0x45,
        NumLockPressed = 0x145,
        ScrollLock = 0x46,
        ScrollLockPressed = 0x146,
        Num7 = 0x47,
        Num7Pressed = 0x147,
        Num8 = 0x48,
        Num8Pressed = 0x148,
        Num9 = 0x49,
        Num9Pressed = 0x149,
        NumMinus = 0x4A,
        NumMinusPressed = 0x14A,
        Num4 = 0x4B,
        Num4Pressed = 0x14B,
        Num5 = 0x4C,
        Num5Pressed = 0x14C,
        Num6 = 0x4D,
        Num6Pressed = 0x14D,
        NumPlus = 0x4E,
        NumPlusPressed = 0x14E,
        Num1 = 0x4F,
        Num1Pressed = 0x14F,
        Num2 = 0x50,
        Num2Pressed = 0x150,
        Num3 = 0x51,
        Num3Pressed = 0x151,
        Num0 = 0x52,
        Num0Pressed = 0x152,
        NumPeriod = 0x53,
        NumPeriodPressed = 0x153,
        F11 = 0x57,
        F11Pressed = 0x157,
        F12 = 0x58,
        F12Pressed = 0x158,
        NumEnter = 0x9C,
        NumEnterPressed = 0x19C,
        RightControl = 0x9D,
        RightControlPressed = 0x19D,
        NumSlash = 0xB5,
        NumSlashPressed = 0x1B5,
        RightAlt = 0xB8,
        RightAltPressed = 0x1B8,
        Home = 0xC7,
        HomePressed = 0x1C7,
        UpArrow = 0xC8,
        UpArrowPressed = 0x1C8,
        PageUp = 0xC9,
        PageUpPressed = 0x1C9,
        LeftArrow = 0xCB,
        LeftArrowPressed = 0x1CB,
        RightArrow = 0xCD,
        RightArrowPressed = 0x1CD,
        End = 0xCF,
        EndPressed = 0x1CF,
        DownArrow = 0xD0,
        DownArrowPressed = 0x1D0,
        PageDown = 0xD1,
        PageDownPressed = 0x1D1,
        Insert = 0xD2,
        InsertPressed = 0x1D2,
        Delete = 0xD3,
        DeletePressed = 0x1D3,
        MouseHorizontal = 0x200,
        MouseVertical = 0x204,
        MouseScroll = 0x208,
        MouseLeft = 0x20C,
        MouseLeftPressed = 0x210,
        MouseRight = 0x20D,
        MouseRightPressed = 0x211,
        MouseMiddle = 0x20E,
        MouseMiddlePressed = 0x212
    }

    public class TagValue<T>
    {
        public Dictionary<TagVersion, int> Address { get; }
        public T Value { get; set; }
        public T Default { get; }

        public TagValue(T defaultValue, int v10Address, int v11Address)
        {
            Default = defaultValue;
            Value = defaultValue;
            Address = new()
            {
                { TagVersion.V1_0, v10Address },
                { TagVersion.V1_1, v11Address }
            };
        }
    }

    public static class KeyConverter
    {
        public static string ToString(Keys key)
        {
            return key switch
            {
                Keys.Escape or Keys.EscapePressed => "Esc",
                Keys.One or Keys.OnePressed => "1",
                Keys.Two or Keys.TwoPressed => "2",
                Keys.Three or Keys.ThreePressed => "3",
                Keys.Four or Keys.FourPressed => "4",
                Keys.Five or Keys.FivePressed => "5",
                Keys.Six or Keys.SixPressed => "6",
                Keys.Seven or Keys.SevenPressed => "7",
                Keys.Eight or Keys.EightPressed => "8",
                Keys.Nine or Keys.NinePressed => "9",
                Keys.Zero or Keys.ZeroPressed => "0",
                Keys.Minus or Keys.MinusPressed => "-",
                Keys.Equals or Keys.EqualsPressed => "=",
                Keys.Backspace or Keys.BackspacePressed => "Backspace",
                Keys.Tab or Keys.TabPressed => "Tab",
                Keys.Q or Keys.QPressed => "Q",
                Keys.W or Keys.WPressed => "W",
                Keys.E or Keys.EPressed => "E",
                Keys.R or Keys.RPressed => "R",
                Keys.T or Keys.TPressed => "T",
                Keys.Y or Keys.YPressed => "Y",
                Keys.U or Keys.UPressed => "U",
                Keys.I or Keys.IPressed => "I",
                Keys.O or Keys.OPressed => "O",
                Keys.P or Keys.PPressed => "P",
                Keys.LeftBracket or Keys.LeftBracketPressed => "[",
                Keys.RightBracket or Keys.RightBracketPressed => "]",
                Keys.Enter or Keys.EnterPressed => "Enter",
                Keys.LeftControl or Keys.LeftControlPressed => "LCtrl",
                Keys.A or Keys.APressed => "A",
                Keys.S or Keys.SPressed => "S",
                Keys.D or Keys.DPressed => "D",
                Keys.F or Keys.FPressed => "F",
                Keys.G or Keys.GPressed => "G",
                Keys.H or Keys.HPressed => "H",
                Keys.J or Keys.JPressed => "J",
                Keys.K or Keys.KPressed => "K",
                Keys.L or Keys.LPressed => "L",
                Keys.Semicolon or Keys.SemicolonPressed => ";",
                Keys.Apostrophe or Keys.ApostrophePressed => "'",
                Keys.Tilde or Keys.TildePressed => "~",
                Keys.LeftShift or Keys.LeftShiftPressed => "LShift",
                Keys.BackSlash or Keys.BackSlashPressed => "\\",
                Keys.Z or Keys.ZPressed => "Z",
                Keys.X or Keys.XPressed => "X",
                Keys.C or Keys.CPressed => "C",
                Keys.V or Keys.VPressed => "V",
                Keys.B or Keys.BPressed => "B",
                Keys.N or Keys.NPressed => "N",
                Keys.M or Keys.MPressed => "M",
                Keys.Comma or Keys.CommaPressed => ",",
                Keys.Period or Keys.PeriodPressed => ".",
                Keys.ForwardSlash or Keys.ForwardSlashPressed => "/",
                Keys.RightShift or Keys.RightShiftPressed => "RShift",
                Keys.NumAsterisk or Keys.NumAsteriskPressed => "*",
                Keys.LeftAlt or Keys.LeftAltPressed => "LAlt",
                Keys.Spacebar or Keys.SpacebarPressed => "Space",
                Keys.CapsLock or Keys.CapsLockPressed => "CapsLock",
                Keys.F1 or Keys.F1Pressed => "F1",
                Keys.F2 or Keys.F2Pressed => "F2",
                Keys.F3 or Keys.F3Pressed => "F3",
                Keys.F4 or Keys.F4Pressed => "F4",
                Keys.F5 or Keys.F5Pressed => "F5",
                Keys.F6 or Keys.F6Pressed => "F6",
                Keys.F7 or Keys.F7Pressed => "F7",
                Keys.F8 or Keys.F8Pressed => "F8",
                Keys.F9 or Keys.F9Pressed => "F9",
                Keys.F10 or Keys.F10Pressed => "F10",
                Keys.NumLock or Keys.NumLockPressed => "NumLock",
                Keys.ScrollLock or Keys.ScrollLockPressed => "ScrollLock",
                Keys.Num7 or Keys.Num7Pressed => "Num7",
                Keys.Num8 or Keys.Num8Pressed => "Num8",
                Keys.Num9 or Keys.Num9Pressed => "Num9",
                Keys.NumMinus or Keys.NumMinusPressed => "Num-",
                Keys.Num4 or Keys.Num4Pressed => "Num4",
                Keys.Num5 or Keys.Num5Pressed => "Num5",
                Keys.Num6 or Keys.Num6Pressed => "Num6",
                Keys.NumPlus or Keys.NumPlusPressed => "Num+",
                Keys.Num1 or Keys.Num1Pressed => "Num1",
                Keys.Num2 or Keys.Num2Pressed => "Num2",
                Keys.Num3 or Keys.Num3Pressed => "Num3",
                Keys.Num0 or Keys.Num0Pressed => "Num0",
                Keys.NumPeriod or Keys.NumPeriodPressed => "Num.",
                Keys.F11 or Keys.F11Pressed => "F11",
                Keys.F12 or Keys.F12Pressed => "F12",
                Keys.NumEnter or Keys.NumEnterPressed => "NumEnter",
                Keys.RightControl or Keys.RightControlPressed => "RCtrl",
                Keys.NumSlash or Keys.NumSlashPressed => "/",
                Keys.RightAlt or Keys.RightAltPressed => "RAlt",
                Keys.Home or Keys.HomePressed => "Home",
                Keys.UpArrow or Keys.UpArrowPressed => "Up",
                Keys.PageUp or Keys.PageUpPressed => "PgUp",
                Keys.LeftArrow or Keys.LeftArrowPressed => "Left",
                Keys.RightArrow or Keys.RightArrowPressed => "Right",
                Keys.End or Keys.EndPressed => "End",
                Keys.DownArrow or Keys.DownArrowPressed => "Down",
                Keys.PageDown or Keys.PageDownPressed => "PgDn",
                Keys.Insert or Keys.InsertPressed => "Insert",
                Keys.Delete or Keys.DeletePressed => "Delete",
                Keys.MouseLeft or Keys.MouseLeftPressed => "Left Click",
                Keys.MouseRight or Keys.MouseRightPressed => "Right Click",
                Keys.MouseMiddle or Keys.MouseMiddlePressed => "Middle Click",
                _ => ""
            };
        }

        public static Keys ToKey(string key, bool v)
        {
            key = key.ToLower().Trim();

            return key switch
            {
                "esc" or "escape" => v ? Keys.EscapePressed : Keys.Escape,
                "1" or "one" => v ? Keys.OnePressed : Keys.One,
                "2" or "two" => v ? Keys.TwoPressed : Keys.Two,
                "3" or "three" => v ? Keys.ThreePressed : Keys.Three,
                "4" or "four" => v ? Keys.FourPressed : Keys.Four,
                "5" or "five" => v ? Keys.FivePressed : Keys.Five,
                "6" or "six" => v ? Keys.SixPressed : Keys.Six,
                "7" or "seven" => v ? Keys.SevenPressed : Keys.Seven,
                "8" or "eight" => v ? Keys.EightPressed : Keys.Eight,
                "9" or "nine" => v ? Keys.NinePressed : Keys.Nine,
                "0" or "zero" => v ? Keys.ZeroPressed : Keys.Zero,
                "-" or "minus" => v ? Keys.MinusPressed : Keys.Minus,
                "=" or "equals" => v ? Keys.EqualsPressed : Keys.Equals,
                "backspace" or "back" => v ? Keys.BackspacePressed : Keys.Backspace,
                "tab" => v ? Keys.TabPressed : Keys.Tab,
                "q" => v ? Keys.QPressed : Keys.Q,
                "w" => v ? Keys.WPressed : Keys.W,
                "e" => v ? Keys.EPressed : Keys.E,
                "r" => v ? Keys.RPressed : Keys.R,
                "t" => v ? Keys.TPressed : Keys.T,
                "y" => v ? Keys.YPressed : Keys.Y,
                "u" => v ? Keys.UPressed : Keys.U,
                "i" => v ? Keys.IPressed : Keys.I,
                "o" => v ? Keys.OPressed : Keys.O,
                "p" => v ? Keys.PPressed : Keys.P,
                "[" or "left bracket" => v ? Keys.LeftBracketPressed : Keys.LeftBracket,
                "]" or "right bracket" => v ? Keys.RightBracketPressed : Keys.RightBracket,
                "enter" => v ? Keys.EnterPressed : Keys.Enter,
                "ctrl" or "lctrl" or "left control" => v ? Keys.LeftControlPressed : Keys.LeftControl,
                "a" => v ? Keys.APressed : Keys.A,
                "s" => v ? Keys.SPressed : Keys.S,
                "d" => v ? Keys.DPressed : Keys.D,
                "f" => v ? Keys.FPressed : Keys.F,
                "g" => v ? Keys.GPressed : Keys.G,
                "h" => v ? Keys.HPressed : Keys.H,
                "j" => v ? Keys.JPressed : Keys.J,
                "k" => v ? Keys.KPressed : Keys.K,
                "l" => v ? Keys.LPressed : Keys.L,
                ";" or "semicolon" => v ? Keys.SemicolonPressed : Keys.Semicolon,
                "'" or "apostrophe" => v ? Keys.ApostrophePressed : Keys.Apostrophe,
                "~" or "tilde" => v ? Keys.TildePressed : Keys.Tilde,
                "shift" or "lshift" or "left shift" => v ? Keys.LeftShiftPressed : Keys.LeftShift,
                "\\" or "backslash" => v ? Keys.BackSlashPressed : Keys.BackSlash,
                "z" => v ? Keys.ZPressed : Keys.Z,
                "x" => v ? Keys.XPressed : Keys.X,
                "c" => v ? Keys.CPressed : Keys.C,
                "v" => v ? Keys.VPressed : Keys.V,
                "b" => v ? Keys.BPressed : Keys.B,
                "n" => v ? Keys.NPressed : Keys.N,
                "m" => v ? Keys.MPressed : Keys.M,
                "," or "comma" => v ? Keys.CommaPressed : Keys.Comma,
                "." or "period" => v ? Keys.PeriodPressed : Keys.Period,
                "/" or "forward slash" or "slash" => v ? Keys.ForwardSlashPressed : Keys.ForwardSlash,
                "rshift" or "right shift" => v ? Keys.RightShiftPressed : Keys.RightShift,
                "*" or "asterisk" => v ? Keys.NumAsteriskPressed : Keys.NumAsterisk,
                "alt" or "lalt" or "left alt" => v ? Keys.LeftAltPressed : Keys.LeftAlt,
                "space" or "spacebar" => v ? Keys.SpacebarPressed : Keys.Spacebar,
                "capslock" => v ? Keys.CapsLockPressed : Keys.CapsLock,
                "f1" => v ? Keys.F1Pressed : Keys.F1,
                "f2" => v ? Keys.F2Pressed : Keys.F2,
                "f3" => v ? Keys.F3Pressed : Keys.F3,
                "f4" => v ? Keys.F4Pressed : Keys.F4,
                "f5" => v ? Keys.F5Pressed : Keys.F5,
                "f6" => v ? Keys.F6Pressed : Keys.F6,
                "f7" => v ? Keys.F7Pressed : Keys.F7,
                "f8" => v ? Keys.F8Pressed : Keys.F8,
                "f9" => v ? Keys.F9Pressed : Keys.F9,
                "f10" => v ? Keys.F10Pressed : Keys.F10,
                "numlock" => v ? Keys.NumLockPressed : Keys.NumLock,
                "scrolllock" => v ? Keys.ScrollLockPressed : Keys.ScrollLock,
                "num7" => v ? Keys.Num7Pressed : Keys.Num7,
                "num8" => v ? Keys.Num8Pressed : Keys.Num8,
                "num9" => v ? Keys.Num9Pressed : Keys.Num9,
                "num-" or "num minus" or "numminus" => v ? Keys.NumMinusPressed : Keys.NumMinus,
                "num4" => v ? Keys.Num4Pressed : Keys.Num4,
                "num5" => v ? Keys.Num5Pressed : Keys.Num5,
                "num6" => v ? Keys.Num6Pressed : Keys.Num6,
                "num+" or "num plus" or "numplus" => v ? Keys.NumPlusPressed : Keys.NumPlus,
                "num1" => v ? Keys.Num1Pressed : Keys.Num1,
                "num2" => v ? Keys.Num2Pressed : Keys.Num2,
                "num3" => v ? Keys.Num3Pressed : Keys.Num3,
                "num0" => v ? Keys.Num0Pressed : Keys.Num0,
                "num." or "num period" or "numperiod" => v ? Keys.NumPeriodPressed : Keys.NumPeriod,
                "f11" => v ? Keys.F11Pressed : Keys.F11,
                "f12" => v ? Keys.F12Pressed : Keys.F12,
                "numenter" or "num enter" => v ? Keys.NumEnterPressed : Keys.NumEnter,
                "rctrl" or "right control" => v ? Keys.RightControlPressed : Keys.RightControl,
                "num/" or "num slash" or "numslash" => v ? Keys.NumSlashPressed : Keys.NumSlash,
                "ralt" or "right alt" => v ? Keys.RightAltPressed : Keys.RightAlt,
                "home" => v ? Keys.HomePressed : Keys.Home,
                "up" or "up arrow" => v ? Keys.UpArrowPressed : Keys.UpArrow,
                "pgup" or "page up" => v ? Keys.PageUpPressed : Keys.PageUp,
                "left" or "left arrow" => v ? Keys.LeftArrowPressed : Keys.LeftArrow,
                "right" or "right arrow" => v ? Keys.RightArrowPressed : Keys.RightArrow,
                "end" => v ? Keys.EndPressed : Keys.End,
                "down" or "down arrow" => v ? Keys.DownArrowPressed : Keys.DownArrow,
                "pgdn" or "page down" => v ? Keys.PageDownPressed : Keys.PageDown,
                "insert" => v ? Keys.InsertPressed : Keys.Insert,
                "delete" or "del" => v ? Keys.DeletePressed : Keys.Delete,
                "left click" or "leftclick" or "mouse left" or "left mouse" => v ? Keys.MouseLeftPressed : Keys.MouseLeft,
                "right click" or "rightclick" or "mouse right" or "right mouse" => v ? Keys.MouseRightPressed : Keys.MouseRight,
                "middle click" or "middleclick" or "mouse middle" or "middle mouse" => v ? Keys.MouseMiddlePressed : Keys.MouseMiddle,
                _ => Keys.NULL
            };
        }
    }
}

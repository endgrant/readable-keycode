using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadableKeycode {
    public static class Keycode {
        private static Dictionary<string, int> keycodes = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase) {
            ["LeftMouse"] = 1,
            ["RightMouse"] = 2,
            ["Cancel"] = 3,
            ["MiddleMouse"] = 4,
            ["MouseX1"] = 5,
            ["MouseX2"] = 6,
            ["Backspace"] = 8,
            ["Tab"] = 9,
            ["Clear"] = 12,
            ["Enter"] = 13,
            ["MouseVWheel"] = 14,
            ["MouseHWheel"] = 15,
            ["Shift"] = 16,
            ["Ctrl"] = 17,
            ["Alt"] = 18,
            ["Pause"] = 19,
            ["CapsLock"] = 20,
            ["Escape"] = 27,
            ["Space"] = 32,
            ["PageUp"] = 33,
            ["PageDown"] = 34,
            ["End"] = 35,
            ["Home"] = 36,
            ["Left"] = 37,
            ["Up"] = 38,
            ["Right"] = 39,
            ["Down"] = 40,
            ["Insert"] = 45,
            ["Delete"] = 46,
            ["0"] = 48,
            ["1"] = 49,
            ["2"] = 50,
            ["3"] = 51,
            ["4"] = 52,
            ["5"] = 53,
            ["6"] = 54,
            ["7"] = 55,
            ["8"] = 56,
            ["9"] = 57,
            ["a"] = 65,
            ["b"] = 66,
            ["c"] = 67,
            ["d"] = 68,
            ["e"] = 69,
            ["f"] = 70,
            ["g"] = 71,
            ["h"] = 72,
            ["i"] = 73,
            ["j"] = 74,
            ["k"] = 75,
            ["l"] = 76,
            ["m"] = 77,
            ["n"] = 78,
            ["o"] = 79,
            ["p"] = 80,
            ["q"] = 81,
            ["r"] = 82,
            ["s"] = 83,
            ["t"] = 84,
            ["u"] = 85,
            ["v"] = 86,
            ["w"] = 87,
            ["x"] = 88,
            ["y"] = 89,
            ["z"] = 90,
            ["MetaLeft"] = 91,
            ["MetaRight"] = 92,
            ["Select"] = 93,
            ["Numpad0"] = 96,
            ["Numpad1"] = 97,
            ["Numpad2"] = 98,
            ["Numpad3"] = 99,
            ["Numpad4"] = 100,
            ["Numpad5"] = 101,
            ["Numpad6"] = 102,
            ["Numpad7"] = 103,
            ["Numpad8"] = 104,
            ["Numpad9"] = 105,
            ["NumpadMultiply"] = 106,
            ["NumpadAdd"] = 107,
            ["NumpadSubtract"] = 109,
            ["NumpadDecimal"] = 110,
            ["NumpadDivide"] = 111,
            ["F1"] = 112,
            ["F2"] = 113,
            ["F3"] = 114,
            ["F4"] = 115,
            ["F5"] = 116,
            ["F6"] = 117,
            ["F7"] = 118,
            ["F8"] = 119,
            ["F9"] = 120,
            ["F10"] = 121,
            ["F11"] = 122,
            ["F12"] = 123,
            ["NumLock"] = 144,
            ["ScrollLock"] = 145,
            ["LeftShift"] = 160,
            ["RightShift"] = 161,
            ["LeftCtrl"] = 162,
            ["RightAlt"] = 163,
            ["LeftAlt"] = 164,
            ["RightCtrl"] = 165,
            [";"] = 186,
            ["="] = 187,
            [","] = 188,
            ["-"] = 189,
            ["."] = 190,
            ["/"] = 191,
            ["`"] = 192,
            ["["] = 219,
            ["\\"] = 220,
            ["]"] = 221,
            ["'"] = 222
        };


        /// <summary>
        ///  Converts an integer keycode to a human-readable string
        /// </summary>
        /// <remarks>Returns a null string if the keycode is not found</remarks>
        /// <param name="code">Integer representation of the keycode</param>
        /// <returns>String name of the keycode (i.e, passing code 8 returns "Backspace")</returns>
        public static string ToHuman(int code) {
            try {
                string key = keycodes.First(kv => kv.Value == code).Key;
                return key;
            } catch (Exception) {
                return null;
            }
        }


        /// <summary>
        ///  Converts a human-readable string into an integer keycode.
        ///  Uses an Ordinal String comparison to ignore case. This means "LeftMouse" and "leftmouse" will grab the same keycode.
        /// </summary>
        /// <remarks>Returns 0 if the keycode is not found</remarks>
        /// <param name="key">String representation of the keycode</param>
        /// <returns>Integer keycode (i.e, passing key "Backspace" returns 8)</returns>
        public static int ToComputer(string key) {
            if (keycodes.ContainsKey(key)) {
                return keycodes[key];
            } else {
                return 0;
            }
        }
    }
}

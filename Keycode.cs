﻿using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace ReadableKeycode {
    public class Keycode {
        private Dictionary<string, int> keycodes = new Dictionary<string, int> {
            ["Backspace"] = 8,
            ["Tab"] = 9,
            ["Enter"] = 13,
            ["ShiftLeft"] = 16,
            ["ShiftRight"] = 16,
            ["CtrlLeft"] = 17,
            ["CtrlRight"] = 17,
            ["AltLeft"] = 18,
            ["AltRight"] = 18,
            ["Pause"] = 19,
            ["CapsLock"] = 20,
            ["Escape"] = 27,
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


        // Converts an integer keycode to a human-readable string
        public string ToHuman(int code) {
            string key = keycodes.First(kv => kv.Value == code).Key;
            return key;
        }


        // Converts a human-readable string into an integer keycode
        public int ToComputer(string key) {
            return keycodes[key];
        }
    }
}
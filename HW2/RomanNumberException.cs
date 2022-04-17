using System;

namespace HW2 {
    class RomanNumberException : Exception {
        public RomanNumberException() : base() { }
        public RomanNumberException(string message) : base(message) { }
    }
}
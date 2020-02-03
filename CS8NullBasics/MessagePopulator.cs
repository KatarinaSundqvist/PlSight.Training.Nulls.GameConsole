using System;
using System.Reflection;

namespace CS8NullBasics {
    static class MessagePopulator {
        public static void Populate(Message message) {
            message.GetType().InvokeMember("From",
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                Type.DefaultBinder, message, new[] { "Jason (set using reflection)" });
        }
    }
}

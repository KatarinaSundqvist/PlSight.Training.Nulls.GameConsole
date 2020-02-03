using System;

namespace CS8NullBasics {
    class Program {
        static void Main(string[] args) {

            Message message = new Message { 
            Text="Hello there!",
            From = null
            };

            MessagePopulator.Populate(message);

            Console.WriteLine(message.Text);
            Console.WriteLine(message.From);
            Console.WriteLine(message.From!.Length); // null-forgiving operator
            // only has effect on compiler. If we pass a null value, it will still throw exception at runtime
            Console.WriteLine(message.ToUpperFrom());

            Console.ReadLine();

        }
    }
}

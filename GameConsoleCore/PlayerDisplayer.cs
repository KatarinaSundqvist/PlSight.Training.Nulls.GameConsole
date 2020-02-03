using System;


namespace GameConsoleCore {
    static class PlayerDisplayer {
        public static void Write(PlayerCharacter? player) {
            if (player is null) {
                Console.WriteLine("No player specified");
                return;
            }
            Console.WriteLine(player.Name);

            int days = player.DaysSinceLastLogin ?? -1;
            Console.WriteLine($"{days} days since last login");

            if (player.DateOfBirth == null) {
                Console.WriteLine("No date of birth specified");
            }
            else {
                Console.WriteLine(player.DateOfBirth);
            }
        }
    }
}

﻿using System;

namespace Discension {
    public static class Program {
        [STAThread]
        static void Main() {
            using (var game = new DiscensionGame()) {
                game.Run();
            }
        }
    }
}

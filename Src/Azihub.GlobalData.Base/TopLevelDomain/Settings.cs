﻿using System.IO;

namespace Azihub.GlobalData.Base
{
    public static class Settings
    {
        public static char DS => Path.DirectorySeparatorChar;
        public static string TldDataPath => $"..{DS}..{DS}..{DS}..{DS}Azihub.GlobalData.Base{DS}TopLevelDomain{DS}";

    }
}

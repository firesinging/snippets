using System;
using System.IO;

namespace Libraries.helpers.pathing
{

    public static class PathingHelper
    {

        public static readonly string baseDir = $"{AppDomain.CurrentDomain.BaseDirectory}";

        public static readonly string gamedatabaseDir = $"{baseDir}AOEOQuestFiles{Path.DirectorySeparatorChar}game{Path.DirectorySeparatorChar}";
        
    }

}

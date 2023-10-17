namespace Shooting.Editor
{
    public class ToolsPath
    {

        public class SwitchScene
        {
            public const string Root = "Tools/Switch Scene/";
            public const int BasePriority = 20;

            public class Startup
            {
                public const string Path = Root + "Startup";
                public const int Priority = BasePriority+1;
            }

            public class Verification
            {
                public const string Path = Root + "Verification";
                public const int Priority = BasePriority + 2;
            }

            public class Lobby
            {
                public const string Path = Root + "Lobby";
                public const int Priority = BasePriority + 3;
            }
        }
    }
}
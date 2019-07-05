using System.ComponentModel;

namespace MarsRover.Core.Const
{
    public class CommandType
    {
        [Description("Turn Left")]
        public const char Left = 'L';
        [Description("Turn Right")]
        public const char Right = 'R';
        [Description("Move")]
        public const char Move = 'M';
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core.Contracts;

namespace MarsRover.Business.Contracts
{
    public interface IRoverController
    {
        IRover GetRover { get; }
        void TurnLeft();
        void TurnRight();
        void SetCommand(string commandString);
        void ExecuteCommand();
        string GetPosition();
    }
}

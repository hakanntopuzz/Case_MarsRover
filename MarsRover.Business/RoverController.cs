using MarsRover.Business.Contracts;
using MarsRover.Core.Const;
using MarsRover.Core.Domain;
using MarsRover.Core.Enums;
using System;
using System.Linq;
using MarsRover.Core.Contracts;

namespace MarsRover.Business
{
    public class RoverController : IRoverController
    {
        private readonly IRover _rover;
        private readonly IPlato _plato;
        private string _command;
        public RoverController(IRover rover, IPlato plato)
        {
            _rover = rover;
            _plato = plato;
        }

        public IRover GetRover => _rover;

        /// <summary>
        /// Sola dön komutu
        /// </summary>
        public void TurnLeft()
        {
            switch (_rover.Direction)
            {
                case Direction.N:
                    _rover.Direction = Direction.W;
                    break;
                case Direction.E:
                    _rover.Direction = Direction.N;
                    break;
                case Direction.S:
                    _rover.Direction = Direction.E;
                    break;
                case Direction.W:
                    _rover.Direction = Direction.S;
                    break;
            }
        }

        /// <summary>
        /// Sağa dön komutu
        /// </summary>
        public void TurnRight()
        {
            switch (_rover.Direction)
            {
                case Direction.N:
                    _rover.Direction = Direction.E;
                    break;
                case Direction.E:
                    _rover.Direction = Direction.S;
                    break;
                case Direction.S:
                    _rover.Direction = Direction.W;
                    break;
                case Direction.W:
                    _rover.Direction = Direction.N;
                    break;
            }
        }

        /// <summary>
        /// Rover'a iletilen komutu çalıştıran metod
        /// </summary>
        /// <param name="command">İşletilecek komut</param>
        public void SetCommand(string command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            if (string.IsNullOrEmpty(_command))
            {
                throw new NullReferenceException($"{nameof(_command)} was null!");
            }

            var commands = _command.ToList();
            foreach (var item in commands)
            {
                switch (item)
                {
                    case CommandType.Left:
                        TurnLeft();
                        break;
                    case CommandType.Right:
                        TurnRight();
                        break;
                    case CommandType.Move:
                        MoveForward();
                        break;
                }
            }
        }

        /// <summary>
        /// Rover ın aktif pozisyonunu verir
        /// </summary>
        public string GetPosition()
        {
            return $"{_rover.Coordinate.CoordinateX}{_rover.Coordinate.CoordinateY}{_rover.Direction}";
        }

        /// <summary>
        /// Rover ın aktif yöne ilerlemesini sağlayan metod.
        /// </summary>
        private void MoveForward()
        {
            if (!IsRoverInPlato(_rover.Coordinate, _rover.Direction))
            {
                throw new Exception("Rover coordinate exceeded out of plato!");
            }

            switch (_rover.Direction)
            {
                case Direction.N:
                    _rover.Coordinate.CoordinateY++;
                    break;
                case Direction.S:
                    _rover.Coordinate.CoordinateY--;
                    break;
                case Direction.E:
                    _rover.Coordinate.CoordinateX++;
                    break;
                case Direction.W:
                    _rover.Coordinate.CoordinateX--;
                    break;
            }
        }

        private bool IsRoverInPlato(Coordinate coordinate, Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    if (coordinate.CoordinateY >= _plato.Coordinate.CoordinateY)
                        return false;
                    break;
                case Direction.W:
                    if (coordinate.CoordinateX == 0)
                        return false;
                    break;
                case Direction.S:
                    if (coordinate.CoordinateY == 0)
                        return false;
                    break;
                case Direction.E:
                    if (coordinate.CoordinateX >= _plato.Coordinate.CoordinateX)
                        return false;
                    break;
            }

            return true;
        }
    }
}

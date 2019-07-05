using MarsRover.Business.Contracts;
using System.Collections.Generic;
using System.Linq;
namespace MarsRover.Business
{
    public class RoverSquad
    {
        private readonly List<IRoverController> _rovers;
        public RoverSquad()
        {
            _rovers = new List<IRoverController>();
        }
        
        /// <summary>
        /// Plato üzerinde rover ı hareket ettirir.
        /// </summary>
        /// <param name="rover">Hareket ettirilcek rover.</param>
        public void ExecuteRover(IRoverController rover)
        {
            rover.ExecuteCommand();
        }

        public IEnumerable<IRoverController> Rovers => _rovers.AsEnumerable();

        /// <summary>
        /// Rover takımına yeni bir rover ekler.
        /// </summary>
        /// <param name="rover">Eklenecek rover</param>
        public void AddRover(IRoverController rover)
        {
            _rovers.Add(rover);
        }
    }
}
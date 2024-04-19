using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorClassLibrary
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private Dictionary<Runway, Aircraft> _busyRunways = new Dictionary<Runway, Aircraft>();
        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }
        public void LandingAircraft(Aircraft aircraft)
        {
            if(_busyRunways.Any(pair => pair.Value == aircraft))
            {
                aircraft.Land();
                return;
            }
            foreach(var runway in _runways)
            {
                if (runway.IsAvailable)
                {
                    _busyRunways.Add(runway, aircraft);
                    aircraft.Land();
                    aircraft.IsTakingOff = false;
                    runway.IsAvailable = false;
                    runway.HighLightRed();
                    return;
                }
            }
            Console.WriteLine($"Aircraft {aircraft.Name} could not land, all runways are busy.");
        }
        public void TakingOffAircraft(Aircraft aircraft)
        {
            if (_busyRunways.Any(pair => pair.Value == aircraft))
            {
                var entry = _busyRunways.FirstOrDefault(pair => pair.Value == aircraft);
                var runway = entry.Key;
                _busyRunways.Remove(runway);
                aircraft.TakeOff();
                aircraft.IsTakingOff = true;
                runway.IsAvailable = true;
                runway.HighLightGreen();
                return;
            }
            else
            {
                aircraft.TakeOff();
            }
        }
    }
}

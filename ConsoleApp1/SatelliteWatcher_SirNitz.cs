using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
public interface SateliteObserver
		{
			void ChangeLocation(double temperature, double windspeed);
		}

		public class GPS : SateliteObserver
		{
		public GPS(Satellite_SirNitz satellite)

			{
			satellite.OnLocationChanged += ChangeLocation;
			}

			public void ChangeLocation(double latitude, double longitude)
			{
				Console.WriteLine("\nPosition Changed...");
				Console.WriteLine("Latitude: " + latitude);
				Console.WriteLine("Longitude:" + longitude);
			}
		}
	}


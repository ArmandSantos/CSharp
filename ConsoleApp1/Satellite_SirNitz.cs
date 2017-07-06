using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Satellite_SirNitz
	{
		public delegate void LocationHandler(double latitude, double longitude);
		public event LocationHandler OnLocationChanged;

		private int _latitude;
		public int Latitude
		{
			get
			{
				return _latitude;
			}
			set
			{
				_latitude = value;
				OnLocationChanged(_latitude, _longitude);
			}
		}

		private int _longitude;
		public int Longitude
		{
			get
			{
				return _longitude;
			}
			set
			{
				_longitude = value;
				OnLocationChanged(_latitude, _longitude);
			}
		}

		public Satellite_SirNitz()
		{
			_latitude = 0;
			_longitude = 0;
		}
	}
}
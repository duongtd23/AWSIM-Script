using System;
using System.Diagnostics;
using AWSIM_Script.Object;

namespace AWSIM_Script.Object
{
	public enum VehicleType
	{
		TAXI,
		HATCHBACK,
		VAN,
		TRUCK,
		SMALL_CAR
	}
	public class NPC
	{
        public NPC(VehicleType vehicleType, IPosition spawnPosition)
        {
            VehicleType = vehicleType;
            InitialPosition = spawnPosition;
        }
        public NPC(VehicleType vehicleType, IPosition spawnPosition,
			IPosition goal) :
			this(vehicleType, spawnPosition)
		{
			Goal = goal;
		}
        public NPC(VehicleType vehicleType, IPosition spawnPosition,
			IPosition goal, string name) :
            this(vehicleType, spawnPosition, goal)
        {
			Name = name;
        }
        public IPosition InitialPosition { get; set; }
        public IPosition? Goal { get; set; }
		public NPCSpawnDelay? SpawnDelayOption { get; set; }
		public NPCConfig? Config { get; set; }
		public VehicleType VehicleType { get; set; }
		public string? Name { get; set; }

		public Dictionary<string,float>? Route()
		{
			if (Config == null)
				return null;
			return Config.RouteSpeeds;
		}
    }
}


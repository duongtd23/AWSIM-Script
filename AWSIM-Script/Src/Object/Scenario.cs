using System;
namespace AWSIM_Script.Object
{
	public class Scenario
	{
		public Scenario()
		{
			NPCs = new List<NPC>();
        }
		// list of NPCs
        public List<NPC> NPCs { get; set; }

		// some other config might be added later
    }
}


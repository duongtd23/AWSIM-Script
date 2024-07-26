﻿using System;
namespace AWSIM_Script.Object
{
    public enum NPCDelayType
    {
        FROM_BEGINNING,           //default
        UNTIL_EGO_ENGAGE,
        UNTIL_EGO_MOVE
    }
    public class NPCSpawnDelay
    {
        public float DelayAmount { get; set; }

        public NPCDelayType DelayType { get; set; }

        // Delay `delay` seconds from the beginning
        public static NPCSpawnDelay Delay(float delay)
        {
            return new NPCSpawnDelay()
            {
                DelayAmount = delay,
                DelayType = NPCDelayType.FROM_BEGINNING,
            };
        }
        // Delay until the Ego vehicle got engaged (in seconds).
        // E.g., if the passed param (`delay`) is 2,
        // it will be delayed 2 seconds after the Ego vehicle engaged.
        // If `delay` is 0, the action concerned will be triggered at the same time
        // when the Ego engaged.
        public static NPCSpawnDelay DelayUntilEgoEngaged(float delay)
        {
            return new NPCSpawnDelay()
            {
                DelayAmount = delay,
                DelayType = NPCDelayType.UNTIL_EGO_ENGAGE,
            };
        }
        // Delay until the Ego vehicle moves (in seconds)
        // E.g., if the passed param (`delay`) is 2,
        // it will be delayed 2 seconds after the Ego vehicle moves.
        // Don't set `delay` value to 0 as it may cause the NPC and the Ego never move.
        // In such a case, use DelayUntilEgoEngaged instead
        public static NPCSpawnDelay DelayUntilEgoMove(float delay)
        {
            return new NPCSpawnDelay()
            {
                DelayAmount = delay,
                DelayType = NPCDelayType.UNTIL_EGO_MOVE,
            };
        }
    }
}


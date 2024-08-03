using System.Collections.Generic;
using AWSIM_Script.Object;
using AWSIM_Script.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test;

[TestClass]
public class UnitTest1
{
    public const float DEFAULT_SPEED_LIMIT = -1;
    [TestMethod]
    public void TestMethod1()
    {
        string input1 = File.ReadAllText("inputs/input.txt");
        Scenario scenario = new ScriptParser().ParseScript(input1);
        Assert.AreEqual(scenario.NPCs.Count, 3);

        NPC npc1 = scenario.NPCs[0];
        Assert.AreEqual(npc1.VehicleType, VehicleType.TAXI);
        AssertPositionEqual(npc1.InitialPosition, "TrafficLane.239", 15);
        Assert.IsNotNull(npc1.Goal);
        AssertPositionEqual(npc1.Goal, "TrafficLane.265", 60);

        Assert.IsNotNull(npc1.Config);
        Assert.AreEqual(npc1.Config.RouteSpeeds.Count, 3);
        Assert.AreEqual(npc1.Config.RouteSpeeds.TryGetValue("TrafficLane.239", out float speed), true);
        Assert.AreEqual(speed, DEFAULT_SPEED_LIMIT);
        Assert.AreEqual(npc1.Config.RouteSpeeds.TryGetValue("TrafficLane.448", out speed), true);
        Assert.AreEqual(speed, 20);
        Assert.AreEqual(npc1.Config.RouteSpeeds.TryGetValue("TrafficLane.265", out speed), true);
        Assert.AreEqual(speed, 7);

        NPC npc2 = scenario.NPCs[1];
        Assert.AreEqual(npc2.VehicleType, VehicleType.HATCHBACK);
        AssertPositionEqual(npc2.InitialPosition, "TrafficLane.240", 0);
        Assert.IsNotNull(npc2.Goal);
        AssertPositionEqual(npc2.Goal, "TrafficLane.241", 0);

        Assert.IsNull(npc2.Config);
    }

    public void AssertPositionEqual(IPosition position, string lane, float offset)
    {
        Assert.AreEqual(((LaneOffsetPosition)position).GetLane(), lane);
        Assert.AreEqual(((LaneOffsetPosition)position).GetOffset(), offset);
    }
}

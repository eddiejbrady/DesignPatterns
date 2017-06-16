using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPatternRealWorld2.Receiver;
using CommandPatternRealWorld2.ConcreteCommand;
using CommandPatternRealWorld2.Invoker;

namespace CommandPatternRealWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Existing stuff in the house
            Light bedRoomLights = new Light();
            AirConditioner acForEntireHouse = new AirConditioner();

            // Create the ON commands
            LightOn turnBedRoomLightsOn = new LightOn(bedRoomLights);
            AirConditionerOn turnOnAC = new AirConditionerOn(acForEntireHouse);

            // Create the OFF commands
            LightOff turnBedRoomLightsOff = new LightOff(bedRoomLights);
            AirConditionerOff turnOffAC = new AirConditionerOff(acForEntireHouse);

            // Add the ON to the remote
            RemoteController remote = new RemoteController();
            remote.InsertNewOnCommand(turnBedRoomLightsOn);
            remote.InsertNewOnCommand(turnOnAC);

            // Add the OFF to the remote
            remote.InsertNewOffCommand(turnBedRoomLightsOff);
            remote.InsertNewOffCommand(turnOffAC);

            // Turn on the lights and AC
            remote.PressButtonOn(0);
            remote.PressButtonOn(1);

            // Turn off the lights and AC
            remote.PressButtonOff(0);
            remote.PressButtonOff(1);
        }
    }
}

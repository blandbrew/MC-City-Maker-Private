﻿using MC_City_Maker.Command_Generator;
using MC_City_Maker.Grid_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_City_Maker.Grid_Zones.Scenery
{
    public class GenericScenery
    {

        Coordinate StartPoint;


        Coordinate CenterlineStart;
        Coordinate CrosswalkStart;


        public GenericScenery()
        {

        }

        public void Build_Scenery(Grid_Square square)
        {
            //Coordinate endPoint = new Coordinate(startingPoint.x + 12, startingPoint.y, startingPoint.z + 12);

            Generate_Commands.Add_Command($"fill {square.startCoordinate.x} {square.startCoordinate.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {square.startCoordinate.z} {square.endCoordinate.x} {square.endCoordinate.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {square.endCoordinate.z} concrete 13"); //13 is green concrete

        }
    }
}

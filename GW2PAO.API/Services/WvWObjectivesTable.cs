﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using GW2PAO.API.Data;
using GW2PAO.API.Data.Enums;

namespace GW2PAO.API.Services
{
    /// <summary>
    /// The WvW Objectives Table containing all information about the various objectives in WvW
    /// </summary>
    public class WvWObjectivesTable
    {
        /// <summary>
        /// File name for the table
        /// </summary>
        public static readonly string FileName = "WvWObjectives.xml";

        /// <summary>
        /// List of dungeons and their details
        /// </summary>
        public List<Objective> Objectives { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public WvWObjectivesTable()
        {
            this.Objectives = new List<Objective>();
        }

        /// <summary>
        /// Loads the WvW objectives table file
        /// </summary>
        /// <returns>The loaded event time table data</returns>
        public static WvWObjectivesTable LoadTable()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(WvWObjectivesTable));
            TextReader reader = new StreamReader(FileName);
            object obj = deserializer.Deserialize(reader);
            WvWObjectivesTable loadedData = (WvWObjectivesTable)obj;
            reader.Close();

            return loadedData;
        }

        /// <summary>
        /// Loads the WvW objectives table file
        /// </summary>
        /// <returns>The loaded event time table data</returns>
        public static void CreateTable()
        {
            WvWObjectivesTable table = new WvWObjectivesTable();
            table.Objectives.Add(new Objective() { ID = 1, Type = ObjectiveType.Keep, Name = "Overlook", FullName = "Overlook", Points = 25, Map = WvWMap.EternalBattlegrounds, Location = "N", MapLocation = new Point(4548, 17078.4) });
            table.Objectives.Add(new Objective() { ID = 2, Type = ObjectiveType.Keep, Name = "Valley", FullName = "Valley", Points = 25, Map = WvWMap.EternalBattlegrounds, Location = "SE", MapLocation = new Point(25620, -20251.2) });
            table.Objectives.Add(new Objective() { ID = 3, Type = ObjectiveType.Keep, Name = "Lowlands", FullName = "Lowlands", Points = 25, Map = WvWMap.EternalBattlegrounds, Location = "SW", MapLocation = new Point(-19802.4, -17690.4) });
            table.Objectives.Add(new Objective() { ID = 4, Type = ObjectiveType.Camp, Name = "Golanta", FullName = "Golanta Clearing", Points = 5, Map = WvWMap.EternalBattlegrounds, Location = "SSW", MapLocation = new Point(-7497.6, -25468.8) });
            table.Objectives.Add(new Objective() { ID = 5, Type = ObjectiveType.Camp, Name = "Pangloss", FullName = "Pangloss Rise", Points = 5, Map = WvWMap.EternalBattlegrounds, Location = "NNE", MapLocation = new Point(18393.6, 13939.2) });
            table.Objectives.Add(new Objective() { ID = 6, Type = ObjectiveType.Camp, Name = "Speldan", FullName = "Speldan Clearcut", Points = 5, Map = WvWMap.EternalBattlegrounds, Location = "NNW", MapLocation = new Point(-16848.72, 19048.8) });
            table.Objectives.Add(new Objective() { ID = 7, Type = ObjectiveType.Camp, Name = "Danelon", FullName = "Danelon Passage", Points = 5, Map = WvWMap.EternalBattlegrounds, Location = "SSE", MapLocation = new Point(13310.4, -28867.2) });
            table.Objectives.Add(new Objective() { ID = 8, Type = ObjectiveType.Camp, Name = "Umberglade", FullName = "Umberglade Woods", Points = 5, Map = WvWMap.EternalBattlegrounds, Location = "E", MapLocation = new Point(25802.4, -2716.8) });
            table.Objectives.Add(new Objective() { ID = 9, Type = ObjectiveType.Castle, Name = "Stonemist", FullName = "Stonemist Castle", Points = 35, Map = WvWMap.EternalBattlegrounds, Location = "C", MapLocation = new Point(2690.4, -5174.4) });
            table.Objectives.Add(new Objective() { ID = 10, Type = ObjectiveType.Camp, Name = "Rogue's", FullName = "Rogue's Quarry", Points = 5, Map = WvWMap.EternalBattlegrounds, Location = "W", MapLocation = new Point(-22010.16, -2349.6) });
            table.Objectives.Add(new Objective() { ID = 11, Type = ObjectiveType.Tower, Name = "Aldon's", FullName = "Aldon's Ledge", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "W", MapLocation = new Point(-26110.56, -12943.2) });
            table.Objectives.Add(new Objective() { ID = 12, Type = ObjectiveType.Tower, Name = "Wildcreek", FullName = "Wildcreek Run", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "W", MapLocation = new Point(-12559.92, -5227.2) });
            table.Objectives.Add(new Objective() { ID = 13, Type = ObjectiveType.Tower, Name = "Jerrifer's", FullName = "Jerrifer's Slough", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "SW", MapLocation = new Point(15682.08, -25161.6) });
            table.Objectives.Add(new Objective() { ID = 14, Type = ObjectiveType.Tower, Name = "Klovan", FullName = "Klovan Gully", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "SW", MapLocation = new Point(-5013.6, -17596.8) });
            table.Objectives.Add(new Objective() { ID = 15, Type = ObjectiveType.Tower, Name = "Langor", FullName = "Langor Gulch", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "SE", MapLocation = new Point(21544.8, -27280.8) });
            table.Objectives.Add(new Objective() { ID = 16, Type = ObjectiveType.Tower, Name = "Quentin", FullName = "Quentin Lake", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "SE", MapLocation = new Point(10137.6, -21256.8) });
            table.Objectives.Add(new Objective() { ID = 17, Type = ObjectiveType.Tower, Name = "Mendon's", FullName = "Mendon's Gap", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "NW", MapLocation = new Point(-5599.2, 22768.8) });
            table.Objectives.Add(new Objective() { ID = 18, Type = ObjectiveType.Tower, Name = "Anzalias", FullName = "Anzalias Pass", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "NW", MapLocation = new Point(-6684, 7200) });
            table.Objectives.Add(new Objective() { ID = 19, Type = ObjectiveType.Tower, Name = "Ogrewatch", FullName = "Ogrewatch Cut", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "NE", MapLocation = new Point(12072, 10622.4) });
            table.Objectives.Add(new Objective() { ID = 20, Type = ObjectiveType.Tower, Name = "Veloka", FullName = "Veloka Slope", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "NE", MapLocation = new Point(13173.6, 2058) });
            table.Objectives.Add(new Objective() { ID = 21, Type = ObjectiveType.Tower, Name = "Durios", FullName = "Durios Gulch", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "E", MapLocation = new Point(17412, -5109.6) });
            table.Objectives.Add(new Objective() { ID = 22, Type = ObjectiveType.Tower, Name = "Bravost", FullName = "Bravost Escarpment", Points = 10, Map = WvWMap.EternalBattlegrounds, Location = "E", MapLocation = new Point(29232, -11200.8) });

            table.Objectives.Add(new Objective() { ID = 23, Type = ObjectiveType.Keep, Name = "Garrison", FullName = "Garrison", Points = 25, Map = WvWMap.BlueBorderlands, Location = "C", MapLocation = new Point(-441.6, 9160.8) });
            table.Objectives.Add(new Objective() { ID = 24, Type = ObjectiveType.Camp, Name = "Orchard", FullName = "Champion's Demense", Points = 5, Map = WvWMap.BlueBorderlands, Location = "S", MapLocation = new Point(-648, -32762.4) });
            table.Objectives.Add(new Objective() { ID = 25, Type = ObjectiveType.Tower, Name = "Redbriar", FullName = "Redbriar", Points = 10, Map = WvWMap.BlueBorderlands, Location = "SW", MapLocation = new Point(-7545.6, -17548.8) });
            table.Objectives.Add(new Objective() { ID = 26, Type = ObjectiveType.Tower, Name = "Greenlake", FullName = "Greenlake", Points = 10, Map = WvWMap.BlueBorderlands, Location = "SE", MapLocation = new Point(11155.2, -16648.8) });
            table.Objectives.Add(new Objective() { ID = 27, Type = ObjectiveType.Keep, Name = "Bay", FullName = "Ascension Bay", Points = 25, Map = WvWMap.BlueBorderlands, Location = "W", MapLocation = new Point(-22857.6, -6789.6) });
            table.Objectives.Add(new Objective() { ID = 28, Type = ObjectiveType.Tower, Name = "Dawn's", FullName = "Dawn's Eyrie", Points = 10, Map = WvWMap.BlueBorderlands, Location = "NE", MapLocation = new Point(12969.6, 12840) });
            table.Objectives.Add(new Objective() { ID = 29, Type = ObjectiveType.Camp, Name = "Spiritholme", FullName = "The Spiritholme", Points = 5, Map = WvWMap.BlueBorderlands, Location = "N", MapLocation = new Point(232.8, 34180.8) });
            table.Objectives.Add(new Objective() { ID = 30, Type = ObjectiveType.Tower, Name = "Woodhaven", FullName = "Woodhaven", Points = 10, Map = WvWMap.BlueBorderlands, Location = "NW", MapLocation = new Point(-14152.8, 14712) });
            table.Objectives.Add(new Objective() { ID = 31, Type = ObjectiveType.Keep, Name = "Hills", FullName = "Askalion Hills", Points = 25, Map = WvWMap.BlueBorderlands, Location = "E", MapLocation = new Point(22420.8, -5016) });

            table.Objectives.Add(new Objective() { ID = 32, Type = ObjectiveType.Keep, Name = "Hills", FullName = "Etheron Hills", Points = 25, Map = WvWMap.RedBorderlands, Location = "E", MapLocation = new Point(22420.8, -5016) });
            table.Objectives.Add(new Objective() { ID = 33, Type = ObjectiveType.Keep, Name = "Bay", FullName = "Dreaming Bay", Points = 25, Map = WvWMap.RedBorderlands, Location = "W", MapLocation = new Point(-22857.36, -6789.6) });
            table.Objectives.Add(new Objective() { ID = 34, Type = ObjectiveType.Camp, Name = "Orchard", FullName = "Victors's Lodge", Points = 5, Map = WvWMap.RedBorderlands, Location = "S", MapLocation = new Point(-648, -32762.4) });
            table.Objectives.Add(new Objective() { ID = 35, Type = ObjectiveType.Tower, Name = "Greenbriar", FullName = "Greenbriar", Points = 10, Map = WvWMap.RedBorderlands, Location = "SW", MapLocation = new Point(-7545.6, -17548.8) });
            table.Objectives.Add(new Objective() { ID = 36, Type = ObjectiveType.Tower, Name = "Bluelake", FullName = "Bluelake", Points = 10, Map = WvWMap.RedBorderlands, Location = "SE", MapLocation = new Point(11155.2, -16648.8) });
            table.Objectives.Add(new Objective() { ID = 37, Type = ObjectiveType.Keep, Name = "Garrison", FullName = "Garrison", Points = 25, Map = WvWMap.RedBorderlands, Location = "C", MapLocation = new Point(-441.6, 9160.8) });
            table.Objectives.Add(new Objective() { ID = 38, Type = ObjectiveType.Tower, Name = "Longview", FullName = "Longview", Points = 10, Map = WvWMap.RedBorderlands, Location = "NW", MapLocation = new Point(-14153.28, 14712) });
            table.Objectives.Add(new Objective() { ID = 39, Type = ObjectiveType.Camp, Name = "Godsword", FullName = "The Godsword", Points = 5, Map = WvWMap.RedBorderlands, Location = "N", MapLocation = new Point(232.8, 34180.08) });
            table.Objectives.Add(new Objective() { ID = 40, Type = ObjectiveType.Tower, Name = "Cliffside", FullName = "Cliffside", Points = 10, Map = WvWMap.RedBorderlands, Location = "NE", MapLocation = new Point(12969.6, 12840) });

            table.Objectives.Add(new Objective() { ID = 41, Type = ObjectiveType.Keep, Name = "Hills", FullName = "Shadaran Hills", Points = 25, Map = WvWMap.GreenBorderlands, Location = "E", MapLocation = new Point(22421.04, -5016) });
            table.Objectives.Add(new Objective() { ID = 42, Type = ObjectiveType.Tower, Name = "Redlake", FullName = "Redlake", Points = 10, Map = WvWMap.GreenBorderlands, Location = "SE", MapLocation = new Point(11154.72, -16648.8) });
            table.Objectives.Add(new Objective() { ID = 43, Type = ObjectiveType.Camp, Name = "Orchard", FullName = "Hero's Lodge", Points = 5, Map = WvWMap.GreenBorderlands, Location = "S", MapLocation = new Point(-648, -32762.4) });
            table.Objectives.Add(new Objective() { ID = 44, Type = ObjectiveType.Keep, Name = "Bay", FullName = "Dreadfall Bay", Points = 25, Map = WvWMap.GreenBorderlands, Location = "W", MapLocation = new Point(-22857.36, -6789.6) });
            table.Objectives.Add(new Objective() { ID = 45, Type = ObjectiveType.Tower, Name = "Bluebriar", FullName = "Bluebriar", Points = 10, Map = WvWMap.GreenBorderlands, Location = "SW", MapLocation = new Point(-7544.64, -17548.8) });
            table.Objectives.Add(new Objective() { ID = 46, Type = ObjectiveType.Keep, Name = "Garrison", FullName = "Garrison", Points = 25, Map = WvWMap.GreenBorderlands, Location = "C", MapLocation = new Point(-441.6, 9160.8) });
            table.Objectives.Add(new Objective() { ID = 47, Type = ObjectiveType.Tower, Name = "Sunnyhill", FullName = "Sunnyhill", Points = 10, Map = WvWMap.GreenBorderlands, Location = "NW", MapLocation = new Point(-14153.52, 14712) });
            table.Objectives.Add(new Objective() { ID = 48, Type = ObjectiveType.Camp, Name = "Faithleap", FullName = "Faithleap", Points = 5, Map = WvWMap.GreenBorderlands, Location = "NW", MapLocation = new Point(-21083.28, 11462.4) });

            table.Objectives.Add(new Objective() { ID = 49, Type = ObjectiveType.Camp, Name = "Bluevale", FullName = "Bluevale Refuge", Points = 5, Map = WvWMap.GreenBorderlands, Location = "SW", MapLocation = new Point(-19053.12, -18657.6) });
            table.Objectives.Add(new Objective() { ID = 50, Type = ObjectiveType.Camp, Name = "Bluewater", FullName = "Bluewater Lowlands", Points = 5, Map = WvWMap.RedBorderlands, Location = "SE", MapLocation = new Point(22442.4, -19444.8) });
            table.Objectives.Add(new Objective() { ID = 51, Type = ObjectiveType.Camp, Name = "Astralholme", FullName = "Astralholme", Points = 5, Map = WvWMap.RedBorderlands, Location = "NE", MapLocation = new Point(23253.6, 12273.6) });
            table.Objectives.Add(new Objective() { ID = 52, Type = ObjectiveType.Camp, Name = "Arah's", FullName = "Arah's Hope", Points = 5, Map = WvWMap.RedBorderlands, Location = "NW", MapLocation = new Point(-21083.28, 11462.4) });
            table.Objectives.Add(new Objective() { ID = 53, Type = ObjectiveType.Camp, Name = "Greenvale", FullName = "Greenvale Refuge", Points = 5, Map = WvWMap.RedBorderlands, Location = "SW", MapLocation = new Point(-19053.12, -18657.6) });
            table.Objectives.Add(new Objective() { ID = 54, Type = ObjectiveType.Camp, Name = "Foghaven", FullName = "Foghaven", Points = 5, Map = WvWMap.GreenBorderlands, Location = "NE", MapLocation = new Point(23253.36, 12273.6) });
            table.Objectives.Add(new Objective() { ID = 55, Type = ObjectiveType.Camp, Name = "Redwater", FullName = "Redwater Lowlands", Points = 5, Map = WvWMap.GreenBorderlands, Location = "SE", MapLocation = new Point(22442.16, -19444.8) });
            table.Objectives.Add(new Objective() { ID = 56, Type = ObjectiveType.Camp, Name = "Titanpaw", FullName = "The Titanpaw", Points = 5, Map = WvWMap.GreenBorderlands, Location = "N", MapLocation = new Point(232.8, 34180.8) });
            table.Objectives.Add(new Objective() { ID = 57, Type = ObjectiveType.Tower, Name = "Cragtop", FullName = "Cragtop", Points = 10, Map = WvWMap.GreenBorderlands, Location = "NE", MapLocation = new Point(12969.6, 12840) });
            table.Objectives.Add(new Objective() { ID = 58, Type = ObjectiveType.Camp, Name = "Godslore", FullName = "Godslore", Points = 5, Map = WvWMap.BlueBorderlands, Location = "NW", MapLocation = new Point(-21084, 11462.4) });
            table.Objectives.Add(new Objective() { ID = 59, Type = ObjectiveType.Camp, Name = "Redvale", FullName = "Redvale Refuge", Points = 5, Map = WvWMap.BlueBorderlands, Location = "SW", MapLocation = new Point(-19053.6, -18657.6) });
            table.Objectives.Add(new Objective() { ID = 60, Type = ObjectiveType.Camp, Name = "Stargrove", FullName = "Stargrove", Points = 5, Map = WvWMap.BlueBorderlands, Location = "NE", MapLocation = new Point(23253.6, 12273.6) });
            table.Objectives.Add(new Objective() { ID = 61, Type = ObjectiveType.Camp, Name = "Greenwater", FullName = "Greenwater Lowlands", Points = 5, Map = WvWMap.BlueBorderlands, Location = "SE", MapLocation = new Point(22442.4, -19444.8) });

            table.Objectives.Add(new Objective() { ID = 62, Type = ObjectiveType.TempleofLostPrayers, Name = "Temple", FullName = "Temple of Lost Prayers", Map = WvWMap.RedBorderlands, Location = "", MapLocation = new Point(-279.59, -16015.255) });
            table.Objectives.Add(new Objective() { ID = 63, Type = ObjectiveType.BattlesHollow, Name = "Hollow", FullName = "Battle's Hollow", Map = WvWMap.RedBorderlands, Location = "", MapLocation = new Point(-7939.68, -9885.6) });
            table.Objectives.Add(new Objective() { ID = 64, Type = ObjectiveType.BauersEstate, Name = "Estate", FullName = "Bauer's Estate", Map = WvWMap.RedBorderlands, Location = "", MapLocation = new Point(-5251.525, -783.006) });
            table.Objectives.Add(new Objective() { ID = 65, Type = ObjectiveType.OrchardOverlook, Name = "Orchard", FullName = "Orchard Overlook", Map = WvWMap.RedBorderlands, Location = "", MapLocation = new Point(5983.413,-2110.027) });
            table.Objectives.Add(new Objective() { ID = 66, Type = ObjectiveType.CarversAscent, Name = "Carver's", FullName = "Carver's Ascent", Map = WvWMap.RedBorderlands, Location = "", MapLocation = new Point(6802.815,-10643.904) });
            table.Objectives.Add(new Objective() { ID = 67, Type = ObjectiveType.CarversAscent, Name = "Carver's", FullName = "Carver's Ascent", Map = WvWMap.BlueBorderlands, Location = "", MapLocation = new Point(6802.815, -10643.904) });
            table.Objectives.Add(new Objective() { ID = 68, Type = ObjectiveType.OrchardOverlook, Name = "Orchard", FullName = "Orchard Overlook", Map = WvWMap.BlueBorderlands, Location = "", MapLocation = new Point(5983.413, -2110.027) });
            table.Objectives.Add(new Objective() { ID = 69, Type = ObjectiveType.BauersEstate, Name = "Estate", FullName = "Bauer's Estate", Map = WvWMap.BlueBorderlands, Location = "", MapLocation = new Point(-5251.525, -783.006) });
            table.Objectives.Add(new Objective() { ID = 70, Type = ObjectiveType.BattlesHollow, Name = "Hollow", FullName = "Battle's Hollow", Map = WvWMap.BlueBorderlands, Location = "", MapLocation = new Point(-7939.68, -9885.6) });
            table.Objectives.Add(new Objective() { ID = 71, Type = ObjectiveType.TempleofLostPrayers, Name = "Temple", FullName = "Temple of Lost Prayers", Map = WvWMap.BlueBorderlands, Location = "", MapLocation = new Point(-279.59, -16015.255) });
            table.Objectives.Add(new Objective() { ID = 72, Type = ObjectiveType.CarversAscent, Name = "Carver's", FullName = "Carver's Ascent", Map = WvWMap.GreenBorderlands, Location = "", MapLocation = new Point(6802.815, -10643.904) });
            table.Objectives.Add(new Objective() { ID = 73, Type = ObjectiveType.OrchardOverlook, Name = "Orchard", FullName = "Orchard Overlook", Map = WvWMap.GreenBorderlands, Location = "", MapLocation = new Point(5983.413, -2110.027) });
            table.Objectives.Add(new Objective() { ID = 74, Type = ObjectiveType.BauersEstate, Name = "Estate", FullName = "Bauer's Estate", Map = WvWMap.GreenBorderlands, Location = "", MapLocation = new Point(-5251.525,-783.006) });
            table.Objectives.Add(new Objective() { ID = 75, Type = ObjectiveType.BattlesHollow, Name = "Hollow", FullName = "Battle's Hollow", Map = WvWMap.GreenBorderlands, Location = "", MapLocation = new Point(-7939.68, -9885.6) });
            table.Objectives.Add(new Objective() { ID = 76, Type = ObjectiveType.TempleofLostPrayers, Name = "Temple", FullName = "Temple of Lost Prayers", Map = WvWMap.GreenBorderlands, Location = "", MapLocation = new Point(-279.59, -16015.255) });

            XmlSerializer serializer = new XmlSerializer(typeof(WvWObjectivesTable));
            TextWriter textWriter = new StreamWriter(FileName);
            serializer.Serialize(textWriter, table);
            textWriter.Close();
        }

        public class Objective
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public Point MapLocation { get; set; }
            public ObjectiveType Type { get; set; }
            public WvWMap Map { get; set; }
            public int Points { get; set; }
        }
    }
}

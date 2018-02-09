using System;
using System.IO;
using System.Collections.Generic;

using Libraries.helpers.pathing;
using Libraries.helpers.xml;
using Libraries.database.models;


namespace AOEOQuestParser
{

    class Program
    {

        public static readonly Dictionary<int, ModelQuest> Quests = new Dictionary<int, ModelQuest>();

        static void Main(string[] args)
        {

            foreach (string QuestFile in Directory.GetFiles($"{PathingHelper.gamedatabaseDir}quests", "*.quest", SearchOption.AllDirectories))
            {

                ModelQuest Quest = new ModelQuest().DeserializeFromFile(QuestFile);

                //@TODO figure out correct settings for ModelQuestinstance

                ModelQuestinstance Instance = new ModelQuestinstance { Id = Quest.Id, Active = "false", Status = "assigned", Timer = Quest.Timer };

                //@TODO add Instance to Quests model

                Console.WriteLine($"Pharsing questfile:" + QuestFile + " with quest Id " + Quest.Id + ". Instance status is " + Instance.Status);

                Quest.Source = QuestFile;                

                Quests.Add(Quest.Id, Quest);

                if(Quest.Id == 10138)
                {

                    // Example write back XML for quest Id 10138

                    Quest.SerializeObjectToFile<ModelQuest>($"{PathingHelper.gamedatabaseDir}quests{Path.DirectorySeparatorChar}test{Path.DirectorySeparatorChar}" + Path.GetFileName(QuestFile));

                }

            }

            Console.WriteLine("\nPress any key to close this window.");
            Console.ReadKey(true);

        }

    }

}
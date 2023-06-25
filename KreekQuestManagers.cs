using System;
using System.Collections.Generic;
using System.Text;
using XRL;
using XRL.World.QuestManagers;
using XRL.World.Parts;
using XRL.World;
 
namespace XRL.World.QuestManagers
{
    [Serializable]
    public class QodEnhanced_BringKreekMucarp : QuestManager
    {

        public class QodEnhanced_BringKreekMucarpSystem : IGameSystem
        {
            public override void PlayerTook(GameObject GO)
            {
                 if( GO != null && GO.Blueprint == "Mucarp" )
                {
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Mucarp for Kreek", "Catch a Mucarp");
                }
            }
        }
        public override void OnQuestAdded()
        {
            The.Player.Inventory.ForeachObject(delegate(GameObject GO)
            {
                 if( GO != null && GO.Blueprint == "Mucarp" )
                {
                    // Could potentially check for the carp's size, etc here before completing step
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Mucarp for Kreek", "Catch a Mucarp");
                    return false;
                }
                return true;
            });
 
            The.Game.AddSystem(new QodEnhanced_BringKreekMucarpSystem());
        }
 
        public override void OnQuestComplete()
        {
            IComponent<GameObject>.ThePlayer.RemovePart(this);
		    The.Game.FlagSystemsForRemoval(typeof(QodEnhanced_BringKreekMucarpSystem));
        }
 
        public override bool FireEvent(Event E)
        {
            if (E.ID == "Took")
            {
                GameObject GO = E.GetGameObjectParameter("Object");
                if(GO != null && GO.Blueprint == "Mucarp" )
                {
                    // Could potentially check for the carp's size, etc here before completing step
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Mucarp for Kreek", "Catch a Mucarp");
                }
            }
 
            return base.FireEvent(E);
        }
    }

    [Serializable]
    public class QodEnhanced_BringKreekCorrocandus : QuestManager
    {

        public class QodEnhanced_BringKreekCorrocandusSystem : IGameSystem
        {
            public override void PlayerTook(GameObject GO)
            {
                 if( GO != null && GO.Blueprint == "Corrocandus" )
                {
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Corrocandus for Kreek", "Catch a Corrocandus");
                }
            }
        }
        public override void OnQuestAdded()
        {
            The.Player.Inventory.ForeachObject(delegate(GameObject GO)
            {
                 if( GO != null && GO.Blueprint == "Corrocandus" )
                {
                    // Could potentially check for the carp's size, etc here before completing step
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Corrocandus for Kreek", "Catch a Corrocandus");
                    return false;
                }
                return true;
            });
 
            The.Game.AddSystem(new QodEnhanced_BringKreekCorrocandusSystem());
        }
 
        public override void OnQuestComplete()
        {
            IComponent<GameObject>.ThePlayer.RemovePart(this);
		    The.Game.FlagSystemsForRemoval(typeof(QodEnhanced_BringKreekCorrocandusSystem));
        }
 
        public override bool FireEvent(Event E)
        {
            if (E.ID == "Took")
            {
                GameObject GO = E.GetGameObjectParameter("Object");
                if(GO != null && GO.Blueprint == "Corrocandus" )
                {
                    // Could potentially check for the carp's size, etc here before completing step
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Corrocandus for Kreek", "Catch a Corrocandus");
                }
            }
 
            return base.FireEvent(E);
        }
    }

    public class QodEnhanced_BringKreekRareFish : QuestManager
    {

        public class QodEnhanced_BringKreekRareFishSystem : IGameSystem
        {
            public override void PlayerTook(GameObject GO)
            {
                 if( GO != null && GO.HasTag("EpicFish") )
                {
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Rare Fish for Kreek", "Catch a Rare Fish");
                }
            }
        }
        public override void OnQuestAdded()
        {
            The.Player.Inventory.ForeachObject(delegate(GameObject GO)
            {
                 if( GO != null && GO.HasTag("EpicFish") )
                {
                    // Could potentially check for the carp's size, etc here before completing step
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Rare Fish for Kreek", "Catch a Rare Fish");
                    return false;
                }
                return true;
            });
 
            The.Game.AddSystem(new QodEnhanced_BringKreekRareFishSystem());
        }
 
        public override void OnQuestComplete()
        {
            IComponent<GameObject>.ThePlayer.RemovePart(this);
		    The.Game.FlagSystemsForRemoval(typeof(QodEnhanced_BringKreekRareFishSystem));
        }
 
        public override bool FireEvent(Event E)
        {
            if (E.ID == "Took")
            {
                GameObject GO = E.GetGameObjectParameter("Object");
                if(GO != null && GO.HasTag("EpicFish"))
                {
                    // Could potentially check for the carp's size, etc here before completing step
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Rare Fish for Kreek", "Catch a Rare Fish");
                }
            }
 
            return base.FireEvent(E);
        }
    }
}

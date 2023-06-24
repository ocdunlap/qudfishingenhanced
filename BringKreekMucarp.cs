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
}
using System;
using System.Collections.Generic;
using System.Text;
using XRL.World.QuestManagers;
using XRL.World.Parts;
using XRL.World;
 
namespace XRL.World.QuestManagers
{
    [Serializable]
    class BringKreekMucarp : QuestManager
    {
        public override void OnQuestAdded()
        {
            Inventory pInventory = XRL.Core.XRLCore.Core.Game.Player.Body.GetPart("Inventory") as Inventory;
 
            foreach (GameObject GO in pInventory.GetObjects())
            {
                if (GO.HasPart("Mucarp"))
                {
                    // Could potentially check for the carp's size, etc here before completing step
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Mucarp for Kreek", "Catch a Mucarp");
                }
            }
 
            // this.Name = "QMQodEnhanced_BringKreekMucarp";
            XRL.Core.XRLCore.Core.Game.Player.Body.AddPart(this);
            XRL.Core.XRLCore.Core.Game.Player.Body.RegisterPartEvent(this, "Took");
        }
 
        public override void OnQuestComplete()
        {
            XRL.Core.XRLCore.Core.Game.Player.Body.RemovePart(this);
        }
 
        public override bool FireEvent(Event E)
        {
            if (E.ID == "Took")
            {
                GameObject GO = E.GetParameter("Object") as GameObject;
                if (GO.HasPart("Mucarp"))
                {
                    // Could potentially check for the carp's size, etc here before completing step
                    XRL.Core.XRLCore.Core.Game.FinishQuestStep("Catch a Mucarp for Kreek", "Catch a Mucarp");
                }
            }
 
            return true;
        }
    }
}
using System;

namespace XRL.World.Parts
{
  [Serializable]
  public class QODENHANCED_KreekSpawner : IPart
  {
    public override bool WantEvent(int ID, int cascade) => base.WantEvent(ID, cascade) || ID == ZoneActivatedEvent.ID || ID == EndTurnEvent.ID;

    public void checkSpawn()
    {
      if (this.ParentObject.CurrentCell.ParentZone.FindObject("QODENHANCED_Kreek")!=null)
    //     || The.Game.HasGameState("CRYPTOGEOLOGY_CryptogeologistKilled")
    //     || (
    //       The.Game.HasGameState("CRYPTOGEOLOGY_CryptogeologistMoved") && (
    //         The.Game.GetQuestFinishTime("The Dig") <= 0L
    //         || Calendar.TotalTimeTicks - The.Game.GetQuestFinishTime("The Dig") <= 100L
    //       )
    //     )
    //   )
        return;



      this.currentCell.ParentZone.GetCell(44, 16).AddObject("QODENHANCED_Kreek");
    }

    public override bool HandleEvent(EndTurnEvent E)
    {
      this.checkSpawn();
      return base.HandleEvent(E);
    }

    public override bool HandleEvent(ZoneActivatedEvent E)
    {
      this.checkSpawn();
      return base.HandleEvent(E);
    }
  }
}
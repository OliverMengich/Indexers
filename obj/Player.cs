namespace Indexers.obj
{
    public class Player
    {
        private int skillSets;
         private int xp;
         private PlayerType playerType;
         private string[] inventoryTable;
          Player(int _skillSets , int _xp,PlayerType _playertype, params Inventory[] inventories )
          {
            skillSets =_skillSets;
            xp = _xp;
            playerType =_playertype;
            inventoryTable = new string[skillSets];
            FillInventory(inventories);
          }
         private void FillInventory(Inventory[] inventories)
         {
             for( int i =0;i<inventoryTable.Length; i++)
             {
                  inventoryTable[i] = inventories[i].ToString();
             }
         }
         public string this[int index]
         {
             get
             {
                 if(index >=0 && index <inventoryTable.Length)
                 {
                     return inventoryTable[index];

                 }
                 else
                 {
                     return " Inventory doesn't exist for index" + index;
                 }
             }
             set
             {
                 if(index >= 0 && index < inventoryTable.Length)
                 {
                     inventoryTable[index] = value;
                 }
                 else
                 { 
                    System.Console.WriteLine("Inventory Cannot be set at " + index);
                 }
             }
         }
        
    }
   enum PlayerType
        {
             Archer, Magician, knight ,
            Emperor ,Grunt , Hybrid
        }
        enum Inventory
        {
            Melee, Range,Selficial,
             ReviveDead , Teleport , Berserk, Lightning,Poison
             , SmokeCloud
        }
}
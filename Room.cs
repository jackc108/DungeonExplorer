namespace DungeonExplorer
{
    public class Room
    {
        private string description;

        public Room(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string newDescription)
        {
            description = newDescription;
        }

        public void DisplayDescription()
        {
            Console.WriteLine("Room Description: " + description);
        }
    }
}

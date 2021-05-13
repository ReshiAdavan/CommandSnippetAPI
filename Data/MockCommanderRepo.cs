using System.Collections.Generic;
using Commander.Models; 

namespace Commander.Data 
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "B", Line = "C", Platform = "D"}, 
                new Command{Id = 1, HowTo = "E", Line = "f", Platform = "g"}, 
                new Command{Id = 2, HowTo = "h", Line = "i", Platform = "j"}, 
            }; 

            return commands; 
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo = "B", Line = "C", Platform = "D"}; 

        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
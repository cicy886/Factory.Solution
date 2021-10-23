using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Description { get; set; }
    public string SerialNumber { get; set; }
    public int Date { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get;}
  }
}
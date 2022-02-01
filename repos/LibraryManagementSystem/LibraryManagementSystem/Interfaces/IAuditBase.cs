using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces
{
  public  interface IAuditBase
  {
    public string CreatedBy { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Modified { get; set; }
  }
}

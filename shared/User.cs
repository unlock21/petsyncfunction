using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Function
{
  class User
  {
    public User(string name)
    {
      this.name = name;
      this.userId = Guid.NewGuid().ToString();
    }
    public string name { get; set; } // Mira / Zoe / Maya / Mylo
    public string userId { get; set; } // GUID
  }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace maths_quiz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile
    {
        public Profile()
        {
            this.Games = new HashSet<Game>();
        }
    
        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
    
        public virtual ICollection<Game> Games { get; set; }
    }
}

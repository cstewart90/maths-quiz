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
    
    public partial class Level
    {
        public Level()
        {
            this.Games = new HashSet<Game>();
        }
    
        public int LevelId { get; set; }
        public string LevelName { get; set; }
    
        public virtual ICollection<Game> Games { get; set; }
    }
}

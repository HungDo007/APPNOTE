//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APPNOTE_dbfirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Note
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Note()
        {
            this.Tag = new HashSet<Tag>();
        }
    
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> Info { get; set; }
        public Nullable<bool> isTrash { get; set; }
        public Nullable<bool> isPin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tag { get; set; }
    }
}

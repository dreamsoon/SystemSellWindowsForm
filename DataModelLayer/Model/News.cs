//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public int NewsID { get; set; }
        public string MainText { get; set; }
        public byte[] Atachment { get; set; }
        public string CreateDate { get; set; }
        public int UserID { get; set; }
        public string Subject { get; set; }
        public Nullable<int> FileSize { get; set; }
        public string FileName { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_TEST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public int ID { get; set; }
        public string ProjectCode { get; set; }
        public string Name { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> ExpectedFinishDate { get; set; }
        public Nullable<System.DateTime> ActualFinishDate { get; set; }
        public Nullable<int> ResponsibleDeptID { get; set; }
        public Nullable<int> ProjectManagerID { get; set; }
        public Nullable<int> ViceProjectManagerID { get; set; }
        public Nullable<System.DateTime> WarrantyFinishDate { get; set; }
        public Nullable<int> CreateID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> ModifyID { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class FIRETEAM
    {
        public int FIT_ID { get; set; }
        public int FIT_FLOOR { get; set; }
        public string FIT_TITLE { get; set; }
        public Nullable<int> EMP_ID { get; set; }
        public Nullable<int> EMP_SUBID { get; set; }
    
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        public virtual EMPLOYEE EMPLOYEE1 { get; set; }
    }
}

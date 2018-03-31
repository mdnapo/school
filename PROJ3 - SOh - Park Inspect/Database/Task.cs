//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.Inspections = new HashSet<Inspection>();
            this.TaskSchedules = new HashSet<TaskSchedule>();
        }
    
        public int ID { get; set; }
        public System.DateTime DateTimeStart { get; set; }
        public Nullable<System.DateTime> DateTimeEnd { get; set; }
        public string Remarks { get; set; }
        public System.DateTime DatetimeCreated { get; set; }
        public string Hash { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inspection> Inspections { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ParkingLot ParkingLot { get; set; }
        public virtual Checklist Checklist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskSchedule> TaskSchedules { get; set; }
    }
}
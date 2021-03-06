
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MedicalAppointmentScheduler.Core.Data
{

using System;
    using System.Collections.Generic;
    
public partial class Appointment
{

    public int ID { get; set; }

    public string Details { get; set; }

    public int DoctorID { get; set; }

    public Nullable<int> PatientID { get; set; }

    public int BookedBy { get; set; }

    public System.DateTime Date { get; set; }

    public int SlotID { get; set; }



    public virtual UserDetails User_Details { get; set; }

    public virtual UserDetails User_Details1 { get; set; }

    public virtual UserDetails User_Details2 { get; set; }

    public virtual Slots L_Slots { get; set; }

}

}

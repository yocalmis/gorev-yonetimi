//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GorevYoneticisi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sistem_ayarlari
    {
        public int id { get; set; }
        public int vid { get; set; }
        public int sort { get; set; }
        public System.DateTime date { get; set; }
        public string mail_address { get; set; }
        public string mail_pswd { get; set; }
        public string mail_port { get; set; }
        public string mail_ssl { get; set; }
        public string mail_host { get; set; }
        public string sms_header { get; set; }
        public string sms_password { get; set; }
        public string sms_username { get; set; }
        public int ekleyen { get; set; }
        public int flag { get; set; }
    
        public virtual kullanicilar kullanicilar { get; set; }
    }
}
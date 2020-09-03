//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wholesale.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AccountTransaction
    {
        public int TransactionID { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MMM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ValueDate { get; set; }
        public Nullable<decimal> DebitAmount { get; set; }
        public Nullable<decimal> CreditAmount { get; set; }
        public string DebitCredit { get; set; }
        public string Transactionnarrative { get; set; }
    
        public virtual AccountList AccountList { get; set; }
    }
}
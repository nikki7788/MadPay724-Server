using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MadPay724.Data.Models
{
    public class BankCard:BaseEntity<string>
    {

        #region ################## ctor ##################

        public BankCard()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }

        #endregion#############
        #region ################## Properties ##################

        /// <summary>
        /// نام بانک
        /// </summary>
        [Required]
        public string BankName { get; set; }
        
        /// <summary>
        /// شماره شبا
        /// </summary>
        public string Shaba { get; set; }

        /// <summary>
        /// شماره کارت
        /// </summary>
        [Required]
        [Range(16, 16)]
        public string CardNumber { get; set; }
      
        /// <summary>
        /// تاریخ انقضا - ماه
        /// </summary>
        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string ExpireDateMonth { get; set; }
        
        /// <summary>
        /// تاریخ انقضا - سال
        /// </summary>
        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string ExpireDateYear { get; set; }

        /// <summary>
        /// شناسه کاربر
        /// کلید خارجی
        /// </summary>
        [Required]
        public string UserId { get; set; }

        #endregion#############
        #region ################## Navigation Properties ##################

        public User User { get; set; }
        #endregion#############
    }
}

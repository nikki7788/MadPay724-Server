using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MadPay724.Data.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class User : BaseEntity<string>
    {

        #region ################## ctor ##################

        public User()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }

        #endregion#############
        #region ################## Properties ##################
      /// <summary>
      /// نام کاربر
      /// </summary>
        [Required]
        public string Name { get; set; }
        
        /// <summary>
        /// نام کاربری =ایمیل
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// شماره تماس
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// آدرس
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        ///  پسورد هش
        /// </summary>
        [Required]
        public byte[] PasswordHash { get; set; }
        
        /// <summary>
        /// پسورد
        /// </summary>
        [Required]
        public byte[] PasswordSalt { get; set; }

        /// <summary>
        /// جنسیت
        /// </summary>
        public string Gender { get; set; }
        
        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public string DateOfBirth { get; set; }
        
        /// <summary>
        /// شهر
        /// </summary>
        public string City { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public bool IsAcive { get; set; }
        
        /// <summary>
        /// وضعیت
        /// </summary>
        [Required]
        public bool Status { get; set; }
        
        #endregion#############
        #region ################## Navigation Properties ##################
       
        public ICollection<Photo> Phohots { get; set; }
        
        public ICollection<BankCard> BankCards { get; set; }
        #endregion#############
    }
}

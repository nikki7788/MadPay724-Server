using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MadPay724.Data.Models
{
    /// <summary>
    /// تصاویر
    /// </summary>
    public class Photo : BaseEntity<string>
    {

        #region ################## ctor ##################

        public Photo()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }

        #endregion#############
        #region ################## Properties ##################

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Url { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// عنوان عکس
        /// </summary>
        /// مواردی که عکس بارگذاری نشود
        public string Alt { get; set; }

        /// <summary>
        /// عکس اصلی - پروفایل
        /// </summary>
        [Required]
        public bool IsMain { get; set; }

        /// <summary>
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

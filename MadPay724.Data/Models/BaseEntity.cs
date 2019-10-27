using System;
using System.Collections.Generic;
using System.Text;

namespace MadPay724.Data.Models
{
    /// <summary>
    /// کلاس جنریک ثابت و پایه هر کلاس
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class BaseEntity<T>
    {

        /// <summary>
        /// شناسه
        /// </summary>
        public T Id { get; set; }

        /// <summary>
        /// زمان ایجاد
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// زمان ویرایش
        /// </summary>
        public DateTime DateModified { get; set; }
      
    }
}

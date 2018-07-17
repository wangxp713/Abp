using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using MPACore.PhoneBook.PhoneBooks.PhoneNumbers;

namespace MPACore.PhoneBook.PhoneBooks.Persons
{
    [Table("Person")]
    public class Person : FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(80)]
        public string Email { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(200)]
        public string Address { get; set; }
    }
}

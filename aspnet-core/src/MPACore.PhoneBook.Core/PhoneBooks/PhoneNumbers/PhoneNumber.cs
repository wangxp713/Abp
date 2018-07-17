using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MPACore.PhoneBook.PhoneBooks.Persons;

namespace MPACore.PhoneBook.PhoneBooks.PhoneNumbers
{
    public class PhoneNumber : Entity<long>, IHasCreationTime
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [MaxLength(11)]
        public string Number { get; set; }

        public PhoneNumber PhoneType { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
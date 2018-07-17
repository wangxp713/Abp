using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MPACore.PhoneBook.PhoneBooks.Persons
{
    public class Person : FullAuditedEntity
    {
        public string Name { get; set; }

    }
}

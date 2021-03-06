﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeSharing.Models
{
    public class Client
    {
        public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public float? Money { get; set; }

        public string Role { get; set; }

        public string Status { get; set; }

        [Display(Name = "Имя")]
        public Name2 FirstName { get; set; }
        public int FirstNameId { get; set; }

        [Display(Name = "Фамилия")]
        public Name1 LastName { get; set; }
        public int LastNameId { get; set; }

        [Display(Name = "Отчество")]
        public Name3 Patronymic { get; set; }
        public int? PatronymicId { get; set; }

        [Display(Name = "Мобильный телефон")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public Address Address { get; set; }
        public int? AddressId { get; set; }

        public Passport Passport { get; set; }
        public int? PassportId { get; set; }

        public Blocking Blocking { get; set; }

        public int? BlockingId { get; set; }  
        
        public bool Deleted { get; set; }
        
    }
}

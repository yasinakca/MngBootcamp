﻿using Core.Persistence.Repositories;
using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice: Entity
    {
        public Invoice()
        {
            Cars = new HashSet<Car>();
        }
        public Invoice(int id,int invoiceNo, DateTime creationDate, DateTime rentEndDate, DateTime rentStartDate, int totalRentDay, double totalRentAmount, int customerId,int userId, double additionalRentAmount): this()
        {
            Id = id;
            InvoiceNo = invoiceNo;
            CreationDate = creationDate;
            RentEndDate = rentEndDate;
            RentStartDate = rentStartDate;
            TotalRentDay = totalRentDay;
            TotalRentAmount = totalRentAmount;
            UserId = userId;
            AdditionalRentAmount = additionalRentAmount;
        }
   
        public int InvoiceNo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime RentEndDate { get; set; }
        public DateTime RentStartDate { get; set; }
        public int TotalRentDay { get; set; }
        public double TotalRentAmount { get; set; }
        public double AdditionalRentAmount { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}

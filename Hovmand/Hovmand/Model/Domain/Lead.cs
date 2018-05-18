﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hovmand.Model.Domain
{
    public partial class Lead
    {
        public Lead()
        {
            Offers = new HashSet<Offer>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeadId { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public DateTime DateAdded { get; set; }
        public int FkCustomersId { get; set; }
        public int FkUserId { get; set; }
        public int FkPipelineId { get; set; }

        public Customer FkCustomers { get; set; }
        public Pipeline FkPipeline { get; set; }
        public User FkUser { get; set; }
        public ICollection<Offer> Offers { get; set; }
        
    }
}

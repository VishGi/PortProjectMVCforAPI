﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortProjectMVCforAPI.Models
{
    public class Slot
    {
        [Key]
        public int ID { get; set; }
        public int SlotId { get; set; }

        public int RUID { get; set; }

        public int SLUserID { get; set; }

        public int Status { get; set; }
        public DateTime Sdate { get; set; }

        public DateTime Edate { get; set; }

        public int Cost { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Recuperatorio_prueba_2.Models
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FindexScores.Dtos
{
    public class FindexScoreDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public short Score { get; set; }
    }
}

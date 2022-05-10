﻿using System.Collections.Generic;

namespace WodCatClone.Db.Entities.Actions
{
    public class Programs
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Type { get; set; }

        public string Aim { get; set; }

        public int? HallId { get; set; }

        public Halls Halls { get; set; }

        public List<ProgramsWorkouts> ProgramsWorkouts { get; set; }
    }
}

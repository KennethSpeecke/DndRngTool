﻿using Inno.RngDNDTool.Core.Entities.DndEntities;
using Inno.RngDNDTool.Core.Entities.DndEntities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Joins
{
    public class CharacterClassLanguages
    {
        public Guid CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public Guid LanguageId { get; set; }
        public Language Language { get; set; }
    }
}

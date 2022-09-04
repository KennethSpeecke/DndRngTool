using Inno.RngDNDTool.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.DndEntities.Skills
{
    public class MetaSkills : BaseEntity<Guid>
    {
        #region Public Properties

        public int Acrobatics { get; set; } = 0;
        public int AnimalHandling { get; set; } = 0;
        public int Arcana { get; set; } = 0;
        public int Athletics { get; set; } = 0;
        public int Deception { get; set; } = 0;
        public int History { get; set; } = 0;
        public int Insight { get; set; } = 0;
        public int Intimidation { get; set; } = 0;
        public int Investigation { get; set; } = 0;
        public int Medicine { get; set; } = 0;
        public int Nature { get; set; } = 0;
        public int Perception { get; set; } = 0;
        public int Performance { get; set; } = 0;
        public int Persuasion { get; set; } = 0;
        public int Religion { get; set; } = 0;
        public int SleightOfHand { get; set; } = 0;
        public int Stealth { get; set; } = 0;
        public int Survival { get; set; } = 0;

        #endregion Public Properties
    }
}
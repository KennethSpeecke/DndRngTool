using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        #region Public Properties

        public string Adress { get; set; } = "Default";
        public string FirstName { get; set; } = "Default";
        public string LastName { get; set; } = "Default";
        public ICollection<ApplicationUserCharacters> ApplicationUserCharacters { get; set; }
        public ICollection<ApplicationUserMaps> ApplicationUserMaps { get; set; }

        #endregion Public Properties
    }
}
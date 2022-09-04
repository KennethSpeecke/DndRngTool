using Inno.RngDNDTool.Core.Entities.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Infrastructure.Data.Seeders
{
    public static class CharacterSpellSeeder
    {
        /*
         * Level 0 Spell Id's
         Id
            C16A9A18-A96D-47FE-A49E-0EE0088E7E2D
            BACAFDB6-99F5-488F-8F19-1822D0384397
            EB2F23B5-515E-42EF-BD3F-2F3612980259
            54ACD0B4-4D86-45A6-887E-2F47594E99C4
            06A1B6E4-030E-4B30-9D7D-31357A2B3C96
            D12BE89A-E0DF-441F-B1C2-4F91557B4D1C
            8430CF6E-648F-4650-9556-54FD4D00941A
            8947B394-C70A-4CCD-B6C9-8A4ADB8D89D8
            9CD33CDF-D89E-4098-BABE-8AAB6E933F9D
            CED0814A-0C2C-415D-BDEF-8FB71E941883
            2A570F48-40A0-432E-957A-958EBAACE68F
            8E42CFB4-CB7F-4A7E-8AEE-9A52481A90F5
            6E42CE23-9081-4B91-B38D-A77F1436BAFF
            7BB9AB78-59B0-4307-8DE8-ABCAB51605A3
            E7C94125-1D1B-4E33-B525-B85F4F20618D
            AB94BFFE-0EB2-4F9D-B6C1-CC5FB4D8DE47
            18BEC186-D145-4EDD-83DF-CF14EC9D1A29
            FEA8FEEF-77AB-4134-BB93-D3D9B4581D24
            949F6ADA-7E39-437C-894E-DAE920EB1469
            E2DF3FD1-5C97-4705-9A6F-E007C7710D34
            274F0700-D3B4-486A-B424-F6B71414EAD7
            26E9A642-4958-4A3F-BDAE-FAA383B08198
            582F69ED-94E7-4D9C-BDD3-FB3F16E173B0
            9FCD8482-DF14-4E47-8433-FFAE30E74735
         */

        public static void Seed(ModelBuilder builder) 
        {
            var copuulId = Guid.Parse("29bcd574-1436-4a71-a750-4484d10cb105");

            var characterSpells = new List<CharacterSpells> 
            {
                new CharacterSpells
                {
                    CharacterId = copuulId,
                    SpellId = Guid.Parse("C16A9A18-A96D-47FE-A49E-0EE0088E7E2D")
                },
                new CharacterSpells
                {
                    CharacterId = copuulId,
                    SpellId = Guid.Parse("9FCD8482-DF14-4E47-8433-FFAE30E74735")
                },
                new CharacterSpells
                {
                    CharacterId = copuulId,
                    SpellId = Guid.Parse("6E42CE23-9081-4B91-B38D-A77F1436BAFF")
                },
                new CharacterSpells
                {
                    CharacterId = copuulId,
                    SpellId = Guid.Parse("D12BE89A-E0DF-441F-B1C2-4F91557B4D1C")
                }
            };

            builder.Entity<CharacterSpells>().HasData(characterSpells);
        }
    }
}

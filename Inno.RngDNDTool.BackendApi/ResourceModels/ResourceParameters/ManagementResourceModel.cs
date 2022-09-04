namespace Inno.RngDNDTool.BackendApi.ResourceModels.ResourceParameters
{
    public class ManagementResourceModel
    {
        public bool FetchSpells { get; set; } = false;
        public bool FetchArmors { get; set; } = false;
        public bool FetchPotions { get; set; } = false;
        public bool FetchWeapons { get; set; } = false;
        public bool FetchScrolls { get; set; } = false;
    }
}

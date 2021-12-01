using System.Collections.Generic;

namespace Messages.UI.Dto
{
    public class PrintListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FamilyDto> Families { get; set; }
    }
}
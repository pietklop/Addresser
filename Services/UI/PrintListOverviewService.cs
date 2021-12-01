using System.Collections.Generic;
using System.Linq;
using DAL;
using DAL.Entities;
using Messages.UI.Overview;
using Microsoft.EntityFrameworkCore;

namespace Services.UI
{
    public class PrintListOverviewService
    {
        private readonly AddressDbContext db;

        public PrintListOverviewService(AddressDbContext db)
        {
            this.db = db;
        }

        public List<PrintListViewModel> GetLists()
        {
            var listsDb = db.PrintLists.Include(p => p.FamilyPrintListRelations)
                .OrderBy(l => l.Name).ToList();

            return listsDb.Select(Map).ToList();

            PrintListViewModel Map(PrintList list)
            {
                return new PrintListViewModel
                {
                    Name = list.Name,
                    Count = list.FamilyPrintListRelations.Count,
                };
            }
        }
    }
}
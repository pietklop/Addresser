using System.Collections.Generic;
using System.Linq;
using DAL;
using DAL.Entities;
using Messages.UI.Dto;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class PrintListService
    {
        private readonly AddressDbContext db;

        public PrintListService(AddressDbContext db)
        {
            this.db = db;
        }

        public void Save(PrintListDto printListDto)
        {
            PrintList printListDb = GetByOrDefault(printListDto.Name);

            Map();

            db.SaveChanges();

            void Map()
            {
                if (printListDb == null)
                {
                    printListDb = new PrintList
                    {
                        Name = printListDto.Name,
                        FamilyPrintListRelations = new List<FamilyPrintListRelation>(),
                    };
                    db.Add(printListDb);
                }
                else
                    printListDb.FamilyPrintListRelations.Clear();

                foreach (var famDto in printListDto.Families)
                {
                    printListDb.FamilyPrintListRelations.Add(new FamilyPrintListRelation
                    {
                        PrintList = printListDb,
                        FamilyId = famDto.Id,
                    });
                }
            }
        }

        private PrintList GetByOrDefault(string name) => db.PrintLists.Include(p => p.FamilyPrintListRelations).SingleOrDefault(f => f.Name == name);

        public void Delete(string listName)
        {
            PrintList printListDb = GetByOrDefault(listName);
            if (printListDb == null) return;

            printListDb.FamilyPrintListRelations.Clear();
            db.Remove(printListDb);

            db.SaveChanges();
        }
    }
}
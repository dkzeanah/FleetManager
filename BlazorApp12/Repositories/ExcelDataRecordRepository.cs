using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Repositories
{
    public class ExcelDataRecordRepository : IExcelDataRecordRepository
    {
        private readonly ApplicationDbContext _context;
        private HashSet<string> processedColumns = new HashSet<string>();

        public ExcelDataRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        // public Task<EntityAttributeValue> EntityAttributeValues { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task<ExcelDataRecord> GetByHash(string hash)
        {
            // Retrieve the record by hash
            return await _context.ExcelDataRecords
                .Include(e => e.Changes) // Include changes in the query
                .FirstOrDefaultAsync(e => e.Hash == hash);
        }

       /* public async Task<ExcelDataRecord> GetByHash(string hash)
        {
            // Retrieve the record by hash
            return await _context.ExcelDataRecords
                .Include(e => e.Changes) // Include changes in the query
                .SingleOrDefaultAsync(e => e.DataHash == hash);
            //return await _context.Get.SingleOrDefaultAsync(r => r.DataHash == hash);
        }*/
        public async Task<IEnumerable<ExcelDataRecord>> GetAll()
        {
            return await _context.ExcelDataRecords.ToListAsync();
        }

        public async Task<ExcelDataRecord> Get(int id)
        {
            // Retrieve the record by id
            return await _context.ExcelDataRecords
                .Include(e => e.Changes) // Include changes in the query
                .FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task Add(ExcelDataRecord record)
        {
            // Add a new record
            _context.ExcelDataRecords.Add(record);
            await _context.SaveChangesAsync();
        }
        public async Task AddAttribute(ExcelDataRecordAttribute attribute)
        {
            // Add a new attribute record
            _context.ExcelDataRecordAttributes.Add(attribute);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ExcelDataRecordAttribute>> GetAttributes(int excelDataRecordId)
        {
            // Retrieve all attribute records for a given ExcelDataRecord
            return await _context.ExcelDataRecordAttributes
                .Where(a => a.ExcelDataRecordId == excelDataRecordId)
                .ToListAsync();
        }
        public async Task Update(ExcelDataRecord record)
        {
            // Update an existing record
            _context.ExcelDataRecords.Update(record);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await _context.ExcelDataRecords.FindAsync(id);
            if (record != null)
            {
                _context.ExcelDataRecords.Remove(record);
                await _context.SaveChangesAsync();
            }
        }
        public async Task AddChange(ExcelDataRecord record, ExcelDataRecordChange change)
        {
            record.Changes.Add(change);
            _context.ExcelDataRecords.Update(record);
            await _context.SaveChangesAsync();
        }

        /* public Task Add(IXLRow rowdata)
         {
             throw new NotImplementedException();
         }*/

        public async Task AddChange(ExcelDataRecordChange change)
        {
            // Add a new change record
            _context.ExcelDataRecordChanges.Add(change);
            await _context.SaveChangesAsync();
        }

        public Task UpdateColumnData(string columnLetter)
        {
            // If the column has not been processed before, add it to the set and print a message
            if (!processedColumns.Contains(columnLetter))
            {
                processedColumns.Add(columnLetter);
                Console.WriteLine($"Processing column {columnLetter} for the first time");
            }

            return Task.CompletedTask;
        }



        public async Task SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }

        public Task AddAsync(ExcelDataRecord record)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(ExcelDataRecordChange change)
        {
            throw new NotImplementedException();
        }
    }
}

using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace BlazorApp1.Repositories
{
    public class BlankRepository : IBlankRepository
    {
        private readonly ApplicationSQLiteDbContext _context;
        private readonly ApplicationDbContext _context2;


        public BlankRepository(ApplicationSQLiteDbContext context, ApplicationDbContext context2)
        {
            _context = context;
            _context2 = context2;
        }

        public async Task<IEnumerable<Blank>> GetAll()
        {
            var blanks1 = await _context.Blanks.ToListAsync();
            var blanks2 = await _context2.Blanks.ToListAsync();
            return blanks1.Concat(blanks2);
            //return await _context.Blanks.ToListAsync();
        }

        public async Task<Blank> Get(int id)
        {
            var blank1 = await _context.Blanks.FindAsync(id);
            var blank2 = await _context2.Blanks.FindAsync(id);
            // Return the first non-null value or any other logic as needed
            return blank1 ?? blank2;
            // return await _context.Blanks.FindAsync(id);
        }

        public async Task Add(Blank entity)
        {
            _context.Blanks.Add(entity);
            await _context.SaveChangesAsync();

            _context2.Blanks.Add(entity);
            await _context2.SaveChangesAsync();
            /* _context.Blanks.Add(entity);
            await _context.SaveChangesAsync();*/
        }

        public async Task Update(Blank entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            _context2.Entry(entity).State = EntityState.Modified;
            await _context2.SaveChangesAsync();
            /*_context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();*/
        }

        public async Task Delete(int id)
        {
            var entity1 = await _context.Blanks.FindAsync(id);
            if (entity1 != null)
            {
                _context.Blanks.Remove(entity1);
                await _context.SaveChangesAsync();
            }

            var entity2 = await _context2.Blanks.FindAsync(id);
            if (entity2 != null)
            {
                _context2.Blanks.Remove(entity2);
                await _context2.SaveChangesAsync();
                /*var entity = await _context.Blanks.FindAsync(id);
                if (entity != null)
                {
                    _context.Blanks.Remove(entity);
                    await _context.SaveChangesAsync();
                }*/
            }
        }
    }
}

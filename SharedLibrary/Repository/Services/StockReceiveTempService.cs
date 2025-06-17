using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace SharedLibrary.Repository.Services
{
    public class StockReceiveTempService : IStockReceiveTempService
    {
        private readonly ApplicationDbContext _context;

        public StockReceiveTempService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<InvStockReceiveTemp> GetAll()
        {
            return _context.Inv_StockReceive_Temp.AsQueryable();
        }


        public async Task<List<InvStockReceiveTemp>> GetAllAsync()
        {
            return await _context.Inv_StockReceive_Temp.ToListAsync();
        }

        public async Task AddAsync(InvStockReceiveTemp stockReceive)
        {
            _context.Inv_StockReceive_Temp.Add(stockReceive);
            await _context.SaveChangesAsync();
        }


        public async Task AddRangeAsync(List<InvStockReceiveTemp> list)
        {
            await _context.Inv_StockReceive_Temp.AddRangeAsync(list);
            await _context.SaveChangesAsync();
        }



    }
}

using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;
using BulkUpload.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace BulkUpload.Repository.Services
{
    public class StockReceiveService : IStockReceiveService
    {
        private readonly ApplicationDbContext _context;

        public StockReceiveService(ApplicationDbContext context)
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
    }
}

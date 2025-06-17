using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Authentication;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.DataModel.Inventory.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SubraVATWebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SalesTempController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly UserSession userSession = new UserSession();

        public SalesTempController(ApplicationDbContext context, UserSession userSession)
        {
            _context = context;
            this.userSession = userSession;
        }



        [HttpPost("bulksalestemp")]
        public async Task<IActionResult> PostBulkDTO([FromBody] List<SalesTempDTO> dtoList)
        {
            if (dtoList == null || dtoList.Count == 0)
                return BadRequest("No data received.");

            var userId = userSession.UserId;
            if (userId == Guid.Empty)
            {
                return Unauthorized("User is not authenticated.");
            }
            var currentDate = DateTime.UtcNow;
           
            string ocode = userSession.OCode;
            if (string.IsNullOrEmpty(ocode))
            {
                return BadRequest("OCODE is required.");
            }

        
            //var invoiceNo = GetNewSalesTempChallanNo(ocode);

            var entityList = new List<InvStockSalesTemp>();

            // Group the DTOs by InvoiceRef
            var groupedDtos = dtoList.GroupBy(d => d.InvoiceRef);


            foreach(var group in groupedDtos)
            {
                // Generate a new invoiceNo for each distinct InvoiceRef
                var invoiceNo = GetNewSalesTempChallanNo(ocode);
                
                foreach (var dto in group)
                {
                    var customer = await _context.INV_Customer
                    .FirstOrDefaultAsync(c => c.CustomerCode == dto.CustomerCode);

                    if (customer == null)
                    {
                        return BadRequest($"Customer code '{dto.CustomerCode}' not found.");
                    }

                    var store = await _context.Inv_Store
                        .FirstOrDefaultAsync(s => s.StoreCode == dto.StoreCode);


                    if (store == null)
                    {
                        return BadRequest($"Store code '{dto.StoreCode}' not found.");
                    }

                    // If ProductCode is null, we can skip the item or handle it as needed
                    if (string.IsNullOrEmpty(dto.ProductCode))
                    {
                        return BadRequest("Product code cannot be null or empty.");
                    }

                    var item = await _context.Inv_Product
                        .FirstOrDefaultAsync(i => i.ProductCode == dto.ProductCode);
                    if (item == null)
                    {
                        return BadRequest($"Product code '{dto.ProductCode}' not found.");
                    }


                    var entity = new InvStockSalesTemp
                    {

                        Invoice = invoiceNo,
                        CustomerID = customer.Customer_Id,
                        Date = dto.Date,
                        StoreId = store.Store_Id,
                        ItemId = item.ProductId,
                        Qty = dto.Qty,
                        Price = dto.Price,
                        Total = dto.Total,
                        //ItemDiscountAmt = dto.ItemDiscountAmt,
                        //SDPercentage = dto.SDPercentage,
                        //SDAmount = dto.SDAmount,
                        ItemVatPer = dto.ItemVatPer,
                        //FixedVATRate = dto.FixedVATRate,
                        ItemVat = dto.ItemVat,
                        NetTotal = dto.NetTotal,
                        //InvoiceAmount = dto.InvoiceAmount,
                        SalesType = dto.SalesType,
                        NatureOfSupply = dto.NatureOfSupply,
                        //DeliveryPoint_Id = dto.DeliveryPoint_Id,
                        Remarks = dto.Remarks,
                        OCODE = ocode,
                        //VehicleType_Id = dto.VehicleType_Id,
                        VehicleNo = dto.VehicleNo,
                        //DiscountPercent = dto.DiscountPercent,
                        //ItemRateDiscPercent = dto.ItemRateDiscPercent,
                        PO_RefNo = dto.InvoiceRef,

                        Create_User = userId,
                        Create_Date = currentDate,
                        Edit_User = null,
                        Edit_Date = null
                    };

                    entityList.Add(entity);

                }
            }



            await _context.Inv_StockSalesTemp.AddRangeAsync(entityList);
            int res = await _context.SaveChangesAsync();

            if (res > 0)
            {
                return Ok(new
                {
                    success = true,
                    message = $"{entityList.Count} items saved successfully."
                });

            }

            return BadRequest();

        }




        //[HttpPost("bulksalestemp")]
        //public async Task<IActionResult> PostBulk([FromBody] List<InvStockSalesTemp> list)
        //{
        //    if (list == null || list.Count == 0)
        //        return BadRequest("No data received.");

        //    await _context.Inv_StockSalesTemp.AddRangeAsync(list);
        //    int saved = await _context.SaveChangesAsync();

        //    if (saved > 0)
        //    {
        //        return Ok(new
        //        {
        //            success = true,
        //            message = "saved successfully.",
        //            totalSaved = saved
        //        });
        //    }
        //    else
        //    {
        //        return StatusCode(500, "Failed to save data.");
        //    }
        //}





        public string GetNewSalesTempChallanNo(string OCode)
        {
            try
            {
                var inv = (from x in _context.Inv_TransactionID
                           where x.OCODE == OCode && x.Module == "SalesTemp"
                           select x).FirstOrDefault();
                
                if (inv == null)
                {
                    throw new Exception("Transaction ID record not found for OCODE and Module.");
                }

                var currentInvoice = inv.Invoice;
                currentInvoice += 1;
                inv.Invoice = currentInvoice;

                _context.SaveChanges();

                var invoiceNo = $"{DateTime.Today.Year}{currentInvoice}";

                return invoiceNo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }



    }
}

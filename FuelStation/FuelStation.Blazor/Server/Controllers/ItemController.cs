using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("controller")]
    public class AfaffController : ControllerBase
    {
        private readonly IEntityRepo<Item> _itemRepo;

        //public ItemsController(IEntityRepo<Item> itemRepo)
        //{
        //    _itemRepo = itemRepo;

        //}

        public AfaffController()
        {

        }

        [HttpGet]
        public async Task<IEnumerable<ItemListViewModel>> Get()
        {
            var result = await _itemRepo.GetAllAsync();
            return result.Select(x => new ItemListViewModel
            {
                ID = x.ID,
                Code = x.Code,
                Description = x.Description,
                Price = x.Price,
                Cost = x.Cost,
                ItemType = x.ItemType,
            });
        }
        [HttpGet("{id}")]
        public async Task<ItemEditViewModel> Get(Guid id)
        {
            ItemEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existing = await _itemRepo.GetByIdAsync(id);
                model.ID = existing.ID;
                model.Description = existing.Description;
                model.Code = existing.Code;
                model.Price = existing.Price;
                model.Cost = existing.Cost;
                model.ItemType = existing.ItemType;
            }


            return model;
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _itemRepo.DeleteAsync(id);
        }



        [HttpPost]
        public async Task Post(ItemEditViewModel item)
        {
            var newItem = new Item()
            {
                ID = item.ID,
                Code = item.Code,
                Price = item.Price,
                Description = item.Description,
                ItemType = item.ItemType,
                Cost = item.Cost,


            };
            
            await _itemRepo.AddAsync(newItem);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemEditViewModel item)
        {
            var itemToUpdate = await _itemRepo.GetByIdAsync(item.ID);
            if (itemToUpdate == null) return NotFound();

            itemToUpdate.Code = item.Code;
            itemToUpdate.Description = item.Description;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Cost;
            itemToUpdate.ItemType = item.ItemType;

            await _itemRepo.UpdateAsync(item.ID, itemToUpdate);

            return Ok();
        }

    }
}

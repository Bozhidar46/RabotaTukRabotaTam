using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RabotaTukRabotaTam.Data;
using RabotaTukRabotaTam.Models;

namespace RabotaTukRabotaTam.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var entities = await context.Categories.ToListAsync();
           
            var model = entities
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImgURL = c.ImgURL

                });

            return View(model);
        }
    }
}

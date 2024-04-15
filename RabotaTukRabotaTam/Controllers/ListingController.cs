using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rabota_tuk__rabota_tam.Data.Models;
using RabotaTukRabotaTam.Data;
using RabotaTukRabotaTam.Models;

namespace Rabota_tuk__rabota_tam.Controllers
{
   
	public class ListingController:Controller
	{
		private readonly ApplicationDbContext context;

        public ListingController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var listings = await context.Listings.ToListAsync();
            return View(listings);
        }

        [HttpGet]
        public async Task<IActionResult> Add() {
            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddListingViewModel model)
        {
            var listing = new Listing()
            {
                Id=Guid.NewGuid(),
                Name=model.Name,
                Description=model.Description,
                Location=model.Location,
                Salary=model.Salary,
                

            };
            await context.Listings.AddAsync(listing);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult>  Update(Guid Id)
        {
            var listing = await context.Listings.FirstOrDefaultAsync(x=>x.Id==Id);

            if (listing !=null)
            {
                var viewModel = new UpdateListingViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = listing.Name,
                    Description = listing.Description,
                    Location = listing.Location,
                    Salary = listing.Salary,
                };
                return await Task.Run(() => View("View", viewModel));
            }
          
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateListingViewModel model)
        {
            var listing = await context.Listings.FindAsync(model.Id);
            if (listing !=null)
            {
                listing .Name = model.Name;
                listing .Description = model.Description;
                listing.Location = model.Location;
                listing .Salary = model.Salary;
                listing.Category = model.Category;
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateListingViewModel viewModel)
        {
            var listing = await context.Listings.FindAsync(viewModel.Id);

            if (listing != null)
            {
                context.Listings.Remove(listing);
                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
           

      

    }
}


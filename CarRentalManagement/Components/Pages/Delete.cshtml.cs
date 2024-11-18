using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Data;
using CarRentalManagement.Domain;

namespace CarRentalManagement.Components.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly CarRentalManagement.Data.CarRentalManagementContext _context;

        public DeleteModel(CarRentalManagement.Data.CarRentalManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Model Model { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Model.FirstOrDefaultAsync(m => m.Id == id);

            if (model == null)
            {
                return NotFound();
            }
            else
            {
                Model = model;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Model.FindAsync(id);
            if (model != null)
            {
                Model = model;
                _context.Model.Remove(Model);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad5WS.Data;
using Zad5WS.Models;

namespace Zad5WS.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly ProductContext _context;

        public PrivacyModel(ILogger<PrivacyModel> logger, ProductContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}

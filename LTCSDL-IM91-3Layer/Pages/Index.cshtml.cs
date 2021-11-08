using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LTCSDL.IM91.BLL;
using LTCSDL.IM91.DTO;

namespace LTCSDL_IM91_3Layer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Category> lst;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CategoryBLL bus = new CategoryBLL();            
            lst = bus.GetAll();
        }
    }
}

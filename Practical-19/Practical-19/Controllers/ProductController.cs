using Microsoft.AspNetCore.Mvc;
using Practical_19.Models;
using Practical_19.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_19.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost(nameof(CreateProduct))]
        public IActionResult CreateProduct(Product product)
        {
            var result = _unitOfWork.Products.Add(product);
            _unitOfWork.Complete();
            return View();
           
        }

        [HttpPut(nameof(UpdateProduct))]
        public IActionResult UpdateProduct(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Complete();
            return View();
        }
    }
}

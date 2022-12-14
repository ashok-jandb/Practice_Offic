using jQueryLearnings.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryLearnings.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseApiController
    {
        private readonly AdventureWorksLTDBContext _context;
        private const string ENTITY_NAME = "product";

        public ProductsController(AdventureWorksLTDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var products = _context.Products.OrderBy(x => x.Name).ToList();
                if (products == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, products);
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, products);
                }
            }
            catch (Exception ex)
            {
                return HandleException(ex, "Exception occurred while trying to get all Products");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if (product == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, product);
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, product);
                }
            }
            catch (Exception ex)
            {
                return HandleException(ex, "Exception occurred while trying to retrieve Product details.");
            }
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            try
            {
                if(product != null)
                {
                    product.ProductCategoryID = 18;
                    product.ProductModelID = 6;
                    product.rowguid = Guid.NewGuid();
                    product.ModifiedDate = DateTime.Now;
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    return StatusCode(StatusCodes.Status201Created, product);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Invalid Product object passed to Post method.");
                }
            }
            catch (Exception ex)
            {
                return HandleException(ex, "Exception occurred while trying to insert Product detailss");
            }
        }

        [HttpPut]
        public IActionResult Put(Product productToUpdate)
        {
            try
            {
                if(productToUpdate != null)
                {
                    var id = productToUpdate.ProductID;
                    var existingProduct = _context.Products.Find(id);
                    if(existingProduct != null)
                    {
                        existingProduct.Name = productToUpdate.Name;
                        existingProduct.ProductNumber = productToUpdate.ProductNumber;
                        existingProduct.Color = productToUpdate.Color;
                        existingProduct.StandardCost = productToUpdate.StandardCost;
                        existingProduct.ListPrice = productToUpdate.ListPrice;
                        existingProduct.Size = productToUpdate.Size;
                        existingProduct.Weight = productToUpdate.Weight;
                        existingProduct.SellStartDate = productToUpdate.SellStartDate;
                        existingProduct.SellEndDate = productToUpdate.SellEndDate;
                        existingProduct.ModifiedDate = productToUpdate.ModifiedDate;

                        _context.Products.Update(existingProduct);
                        _context.SaveChanges();
                        return StatusCode(StatusCodes.Status200OK, existingProduct);
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound, $"Cant find product with id: { id.ToString() }");
                    }
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Invalid Product passed to put method");
                }
            }
            catch (Exception ex)
            {
                return HandleException(ex, "Exception occurred while trying to update Product details");
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if(product == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, $"No product found with id: {id}");
                }
                _context.Products.Remove(product);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, true);
            }
            catch (Exception ex)
            {
                return HandleException(ex, $"Exception occurred while trying to delete the product with id: {id}");
            }
        }
    }
}

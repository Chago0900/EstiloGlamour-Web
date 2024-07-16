using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EstiloGlamourApi.Dtos;
using EstiloGlamourApi.Models;
using EstiloGlamourApi.Repositories;
using EstiloGlamourApi.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace EstiloGlamourApi.Controllers
{
    [ApiController]
    [Route("api/Producto")]
    public class ProductoController: ControllerBase
    {
    

        private readonly IProductoRepository _productoRepository;
        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
    
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProducto()
        {
            var productos = await _productoRepository.GetAll();
            return Ok(productos);
        }
    
        [HttpGet("{Id}")]
        public async Task<ActionResult<Producto>> GetProducto(string Id)
        {
            var producto = await _productoRepository.Get(Id);
            if(producto == null)
                return NotFound();
    
            return Ok(producto);
        }
        [HttpPost]
        public async Task<ActionResult> CreateProducto(CreateProductoDto createProductoDto)
        {
            Producto producto = new()
            {
                Id = createProductoDto.Id,
                Nombre = createProductoDto.Nombre,
                Casa = createProductoDto.Casa,
                Descripcion = createProductoDto.Descripcion,
                Tamanio = createProductoDto.Tamanio,
                Genero = createProductoDto.Genero,
                Imagen = createProductoDto.Imagen,
                Precio_mayor = createProductoDto.Precio_mayor,
                Tipo_perfume = createProductoDto.Tipo_perfume,
                Precio_detalle = createProductoDto.Precio_detalle
            };
            await _productoRepository.Add(producto);
            return Ok();
        }
    
        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteProducto(string Id)
        {
            await _productoRepository.Delete(Id);
            return Ok();
        }
    
        [HttpPut("{Id}")]
        public async Task<ActionResult> UpdateProducto(string Id, UpdateProductoDto updateProductoDto)
        {
            Producto producto = new()
            {
                Nombre = updateProductoDto.Nombre,
                Casa = updateProductoDto.Casa,
                Descripcion = updateProductoDto.Descripcion,
                Tamanio = updateProductoDto.Tamanio,
                Genero = updateProductoDto.Genero,
                Imagen = updateProductoDto.Imagen,
                Precio_mayor = updateProductoDto.Precio_mayor,
                Tipo_perfume = updateProductoDto.Tipo_perfume,
                Precio_detalle = updateProductoDto.Precio_detalle
            };
            
    
            await _productoRepository.Update(producto, Id);
            return Ok();
    
        }
        
    }
}
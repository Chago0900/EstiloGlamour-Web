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
    [Route("api/Cliente")]
    public class ClienteController: ControllerBase
    {
    

        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente()
        {
            var clientes = await _clienteRepository.GetAll();
            return Ok(clientes);
        }
    
        [HttpGet("{Id}")]
        public async Task<ActionResult<Cliente>> GetCliente(string Id)
        {
            var cliente = await _clienteRepository.Get(Id);
            if(cliente == null)
                return NotFound();
    
            return Ok(cliente);
        }
        [HttpPost]
        public async Task<ActionResult> CreateCliente(CreateClienteDto createClienteDto)
        {
            Cliente cliente = new()
            {
                Correo_electronico = createClienteDto.Correo_electronico,
                Nombre = createClienteDto.Nombre,
                Apellido = createClienteDto.Apellido,
                Telefono = createClienteDto.Telefono,
                Fecha_nacimiento = createClienteDto.Fecha_nacimiento,
                Contrasenia = createClienteDto.Contrasenia,
                Tipo_cliente = createClienteDto.Tipo_cliente

            };
            await _clienteRepository.Add(cliente);
            return Ok();
        }
    
        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteCliente(string Id)
        {
            await _clienteRepository.Delete(Id);
            return Ok();
        }
    
        [HttpPut("{Id}")]
        public async Task<ActionResult> UpdateCliente(string Id, UpdateClienteDto updateClienteDto)
        {
            Cliente cliente = new()
            {
                Nombre = updateClienteDto.Nombre,
                Casa = updateClienteDto.Casa,
                Descripcion = updateClienteDto.Descripcion,
                Tamanio = updateClienteDto.Tamanio,
                Genero = updateClienteDto.Genero,
                Imagen = updateClienteDto.Imagen,
                Precio_mayor = updateClienteDto.Precio_mayor,
                Tipo_perfume = updateClienteDto.Tipo_perfume,
                Precio_detalle = updateClienteDto.Precio_detalle
            };
            
    
            await _clienteRepository.Update(cliente, Id);
            return Ok();
    
        }
        
    }
}
using Microsoft.EntityFrameworkCore;
using DbContextDirect.Data;
using DbContextDirect.Models;

var options = new DbContextOptionsBuilder<AplicacionDbContext>()
    .UseInMemoryDatabase("MiTienda") // Base de datos en memoria para ejemplo
    .Options;

using var context = new AplicacionDbContext(options);

// 1️⃣ Agregar un producto
var producto = new Producto { Nombre = "Laptop", Precio = 1500 };
context.Productos.Add(producto);
context.SaveChanges();
Console.WriteLine("Producto agregado.");

var productos = context.Productos.ToList();
foreach (var p in productos)
{
    Console.WriteLine($"ID: {p.Id}, Nombre: {p.Nombre}, Precio: {p.Precio}");
}


producto.Precio = 1400;
context.Productos.Update(producto);
context.SaveChanges();
Console.WriteLine("Producto actualizado.");


context.Productos.Remove(producto);
context.SaveChanges();
Console.WriteLine("Producto eliminado.");
}
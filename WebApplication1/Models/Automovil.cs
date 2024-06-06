using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication1.Models;

public class Automovil{
    public Guid AutomovilId {get;set;}
    public Guid MarcaId { get; set; }
    public string Modelo {get;set;}
    public string Descripcion {get;set;}
    public double Precio {get;set;}
    public double Kilometraje { get; set; }
  
    public virtual Marca? Marca { get; set; }

}
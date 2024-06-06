using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using System.Threading;

namespace WebApplication1.Models;

public class Marca{

    public Guid MarcaId {get;set;}
   
    public string Nombre {get;set;}

    [JsonIgnore]
    public virtual ICollection<Automovil>? Automoviles { get; set; }

}

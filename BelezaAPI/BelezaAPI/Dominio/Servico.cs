using System;
using System.ComponentModel.DataAnnotations;

public class Servico
{
    [MaxLength(100)]
    public string Nome { get; set; }
    public int Id { get; set; }
    [Range(30, 480, ErrorMessage = "Valor de {0} precisa ser entre {1} e {2}.")]
    public decimal Preco { get; set; }
    public bool Disponibilidade { get; set; }
    [Range(30, 480, ErrorMessage = "Valor de {0} precisa ser entre {1} e {2}.")]
    public int DuracaoMin { get; set; }
}

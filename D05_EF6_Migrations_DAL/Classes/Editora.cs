using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_EF6_Migrations_DAL
{
    public class Editora
    {
        #region Scalar properties
        // Chave primária
        [Key]
        public int EditoraID { get; set; }
        
        // Obrigatório e tamanho máximo
        [Required]
        [StringLength(100, ErrorMessage = "Limite de 100 carateres.")]
        [MaxLength(100)]
        public string EditoraNome { get; set; }
        #endregion

        #region Navigation properties
        // 1 editora pode editar mais do que 1 livro
        public ICollection<Livro> Livro { get; set; }
        #endregion
    }

}

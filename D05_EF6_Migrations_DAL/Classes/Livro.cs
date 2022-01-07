using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_EF6_Migrations_DAL
{
    public class Livro
    {
        #region Scalar properties
        // Chave primária
        [Key]
        public int LivroID { get; set; }

        // Obrigatório e tamanho máximo
        [Required]
        [StringLength(9, ErrorMessage = "Limite de 9 carateres.")]
        [MaxLength(9)]
        public string ISBN { get; set; }

        // Obrigatório e tamanho máximo
        [Required]
        [StringLength(100, ErrorMessage = "Limite de 100 carateres.")]
        [MaxLength(100)]
        public string Titulo { get; set; }

        // Obrigatório e tamanho máximo
        [Required]
        [StringLength(100, ErrorMessage = "Limite de 100 carateres.")]
        [MaxLength(100)]
        public string Tipo { get; set; }

        // Foreign key, mas sem data annotation
        public int EditoraID { get; set; }
        #endregion

        #region Navigation properties
        // 1 livro, com ISBN, é editado por uma única editora
        public Editora Editora { get; set; }
        #endregion
    }

}

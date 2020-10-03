using System.Collections.Generic;
using System.Linq;
using TP04.Model;

namespace TP04
{
    public class AlunoViewModel
    {
        public AlunoViewModel() { }
        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Aluno> Alunos
        {
            get
            {
                return
                App.AlunoModel.GetAlunos().ToList();
            }
        }
        #endregion
    }
}
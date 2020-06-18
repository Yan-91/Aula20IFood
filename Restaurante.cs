namespace Aula20
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }
        public string Endereco { get; set; }

        public Restaurante(string _NomeRestaurante, string _Endereco){
            this.NomeRestaurante = _NomeRestaurante;
            this.Endereco = _Endereco;
        }

        public string MostrarDados(){
            return $"Nome Restaurante:{NomeRestaurante} Endereço:{Endereco}";
        }
        
    }
}
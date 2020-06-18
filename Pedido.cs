using System;
namespace Aula20
{
    public class Pedido
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public string itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaPGTO { get; set; }
        public bool PedidoPago { get; set; }

        public Pedido(string _itens, string _cliente, string _restaurante, string _formadepgto, bool _pedidopago)
        {
            this.itens = _itens;
            this.Cliente = _cliente;
            this.Restaurante = _restaurante;
            this.FormaPGTO = _formadepgto;
            this.PedidoPago = _pedidopago;
        }

        public Pedido(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public string EntregarPedido(){
            if(PedidoPago == true){
                return "Pedido a caminho";
            }else{
                return "Falha ao Pedir";
            }
        }
        

    }
}

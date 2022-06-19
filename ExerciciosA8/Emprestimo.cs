namespace ExerciciosA8
{
    public class Emprestimo
    {
        double codigoJogo;
        string dataLocacao;
        public string dataDevolução;
        double valorLocacao;
        double codigoCliente;

        public Emprestimo(double codigoJogo, string dataLocacao, string dataDevolução, double valorLocacao, double codigoCliente)
        {
            this.codigoJogo = codigoJogo;
            this.dataLocacao = dataLocacao;
            this.dataDevolução = dataDevolução;
            this.valorLocacao = valorLocacao;
            this.codigoCliente = codigoCliente;
        }

        public string DataDevolução
        {
            get { return dataDevolução; }
            set { dataDevolução = value; }
        }
    }
}

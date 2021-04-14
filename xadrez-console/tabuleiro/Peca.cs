namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            // aqui iniciamos a Quantidade de Movimentos com 0, pois as peças iniciam o jogo sem nenhum movimento.
            this.qtdeMovimentos = 0;
        }
    }
}
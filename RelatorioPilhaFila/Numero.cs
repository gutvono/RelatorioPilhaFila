namespace RelatorioPilhaFila
{
    internal class Numero
    {
        int Num;
        Numero Next;
        bool repete;

        public Numero(int n, bool rep)
        {
            this.Num = n;
            this.Next = null;
            this.repete = rep;
        }

        public void SetNext(Numero num) { this.Next = num; }
        public Numero GetNext() { return this.Next; }
        public int GetNum() { return this.Num; }
        public void SetRepete() { this.repete = true; }
        public bool GetRepete() { return this.repete; }
        public string PrintNum() { return this.Num.ToString(); }
    }
}

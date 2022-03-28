namespace projetos
{

    public class Ares
    {

        //Método construtor
        public Ares(string Name, int Level, string tipoHeroi ) {
            this.Name = Name;
            this.level = 23;
            this.tipoHeroi = tipoHeroi;
        }

        //Polimorfismo/ construtor do objeto
        public Ares () {} 
        

        
        public string Name;
        public int level;
        public string tipoHeroi;

        // O Override ignora aquilo que herdou de outra classe
        public override string ToString() {
            return this.Name + " " + this.level + " " + this.tipoHeroi + " "; 
        }
    }

}
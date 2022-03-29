namespace projetos
{
    //classe abstacta, que é uma que não se pode herdar
    //Uma clase para que outras usem
    public abstract class Hero
    {

        //Método construtor
        public Hero(string Name, int Level, string tipoHeroi ) {
            this.Name = Name;
            this.level = 23;
            this.tipoHeroi = tipoHeroi;
        }

        //Polimorfismo/ construtor do objeto
        public Hero () {

        } 
        

        
        public string Name;
        public int level;
        public string tipoHeroi;

        // O Override ignora aquilo que herdou de outra classe
        public override string ToString() {
            return this.Name + " " + this.level + " " + this.tipoHeroi + " "; 
        }


        // O método virtual é uma permissão que o filho altere o comportamento pai
        public virtual string Attack() {
           return this.Name + " Atacou o seu oponente com espada ";
        }
    }

}
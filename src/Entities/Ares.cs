namespace projetos
{

    public class Ares
    {

        //Método construtor
        public Ares(string Name, int Level, string tipoHeroi ) {
            this.Name = Name;
            this.level = 2;
            this.tipoHeroi = tipoHeroi;
        }

        //Polimorfismo/ construtor do objeto
        public Ares () {} 
        

        
        public string Name;
        public int level;
        public string tipoHeroi;
    }

}
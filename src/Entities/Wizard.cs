namespace projetos.src.Entities
{
    public class Wizard : Hero //Herança da classe 
    {

        public Wizard(string Name, int Level, string tipoHeroi)
        {
            this.Name = Name;
            this.level = Level;
            this.tipoHeroi = tipoHeroi;
        }
        public override string Attack () {
            return this.Name + "Lançou a sua magia";
        }
    }
}
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
        //Exemplo de polimorfismo
        public string Attack(int Bonus) {

            if (Bonus > 6) {
                return this.Name + "Lançou uma magia super eficaz de " + Bonus;
            } else {

                return this.Name + "Lançou um ataque magistico de força fraca com bonus de" + Bonus;  
            }

        }
    }
}

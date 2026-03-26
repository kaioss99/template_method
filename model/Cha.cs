namespace TemplateMethod_Bebidas
{
    public class Cha : BebidaBase
    {
        protected override string AdicionarIngredientePrincipal()
            => "🍃 Adicionando folhas de chá...\n";

        protected override string Coar()
            => "🫖 Coando as folhas de chá...\n";

        // Não sobrescreve AdicionarExtras — usa o hook vazio da classe base
    }
}

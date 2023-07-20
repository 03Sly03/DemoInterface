
using DemoInterface.Classes;
using DemoInterface.Interfaces;

Perche unePerche = new Perche();
Baleine uneBaleine = new Baleine();
Exoset unExoset = new Exoset();
unePerche.Nager();
uneBaleine.Nager();
unExoset.Decoller();
unExoset.Atterir();

List<Animal> animaux = new List<Animal>()
{
    new Perche(),
    new Perche(),
    new Baleine(),
    new Baleine(),
    new Exoset(),
    new Exoset(),
    new ChauveSouris(),
    new ChauveSouris(),
    new Pigeon(),
    new Pigeon(),
};

List<IPeutVoler> nageur = new List<IPeutVoler>()
{
    //new Perche(),
    //new Perche(),
    //new Baleine(),
    //new Baleine(),
    new Exoset(),
    new Exoset(),
    new ChauveSouris(),
    new ChauveSouris(),
    new Pigeon(),
    new Pigeon(),
};
List<IPeutNager> volant = new List<IPeutNager>()
{
    new Perche(),
    new Perche(),
    new Baleine(),
    new Baleine(),
    new Exoset(),
    new Exoset(),
    //new ChauveSouris(),
    //new ChauveSouris(),
    //new Pigeon(),
    //new Pigeon(),
};
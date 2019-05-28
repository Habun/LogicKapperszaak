using FactoryDAL;
using InterfaceDAL;
using InterfaceUI;

namespace LogicKapperszaak
{
    public class Behandeling : IBehandelingUi
    {
        public int Id { get; }
        public string Omschrijving { get; }
        public decimal Bedrag { get; }

        public IBehandelingDAL behandelingDal = DatabaseFactory.Behandelingdal();

        public BehandelingInfoDal behandelingsinfoDal;

        public CategorieInfoDal categorieInfoDal;

        public ICategorieUI Categorie ;
        public Behandeling(int id, string omschrijving, decimal bedrag, ICategorieUI categorie)
        {
            Id = id;
            Omschrijving = omschrijving;
            Bedrag = bedrag;
            Categorie = categorie;
        }

        public Behandeling()
        {
        }

        public Behandeling(int id, string omschrijving, decimal bedrag)
        {
            Id = id;
            Omschrijving = omschrijving;
            Bedrag = bedrag;
        }

        public void UpdateBehandeling(IBehandelingUi behandeling, ICategorieUI categorie)
        {
            categorieInfoDal = new CategorieInfoDal(categorie.CategorieId, categorie.Categorienaam);

            behandelingsinfoDal = new BehandelingInfoDal(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag, categorieInfoDal);
            behandelingDal.UpdateBehandeling(behandelingsinfoDal);
        }
    }
}

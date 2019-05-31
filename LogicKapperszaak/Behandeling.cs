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

        public ICategorieUI Categorie { get; } 

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

        public void UpdateBehandeling(int behandelingId, IBehandelingUi behandeling, ICategorieUI categorie)
        {
            CategorieInfoDal categorieInfoDal = new CategorieInfoDal(categorie.CategorieId, categorie.Categorienaam);

            BehandelingInfoDal behandelingsinfoDal = new BehandelingInfoDal(behandeling.Id, behandeling.Omschrijving, behandeling.Bedrag, categorieInfoDal);
            behandelingDal.UpdateBehandeling(behandelingsinfoDal);
        }
    }
}

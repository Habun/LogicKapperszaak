

namespace InterfaceUI
{
    public interface IBehandelingUi
    {
        int Id { get; }
        string Omschrijving { get; }
        decimal Bedrag { get; }
        void UpdateBehandeling(int behandelingId, IBehandelingUi behandeling, ICategorieUI categorie);
    }
}

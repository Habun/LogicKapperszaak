

namespace InterfaceUI
{
   public struct BehandelingsInfoUI
    {
        public int BehandelingsId { get; }
        public string Omschrijving { get;}
        public decimal Bedrag { get;}
        public CategorieInfoUI CategorieinfoUi { get; }
        public BehandelingsInfoUI(int behandelingsId, string omschrijving, decimal bedrag, CategorieInfoUI categorieInfoUI)
        {
            BehandelingsId = behandelingsId;
            Omschrijving = omschrijving;
            Bedrag = bedrag;
            CategorieinfoUi = categorieInfoUI;
        }

        public BehandelingsInfoUI(int behandelingId, string omschrijving, decimal bedrag) : this()
        {
            BehandelingsId = behandelingId;
            Omschrijving = omschrijving;
            Bedrag = bedrag;
        }
    }
}

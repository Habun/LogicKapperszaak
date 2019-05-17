

namespace InterfaceUI
{
    public interface IBehandelingUi
    {
        void UpdateBehandeling(int behandelingId, BehandelingsInfoUI behandelingUI, CategorieInfoUI categorieUI);
        int BehandelingIDdoorGeven();
    }
}

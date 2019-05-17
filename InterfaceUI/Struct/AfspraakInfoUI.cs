using System;


namespace InterfaceUI
{
    public struct AfspraakInfoUI
    {
        public string Opmerkingen { get;}
        public DateTime datetime { get;}
        public KlantInfoUI klantInfoUI { get;}

        public AfspraakInfoUI(string opmerking, DateTime dateTime, KlantInfoUI klantinfoAF)
        {
            klantInfoUI = klantinfoAF;
            Opmerkingen = opmerking;
            datetime = dateTime;
        }
    }
}

using System;


namespace InterfaceDAL
{
   public struct AfspraakInfoDal
    {
        public string Opmerkingen { get;}
        public DateTime datetime { get;}
        public KlantInfoDal klantinfo { get;}

        public AfspraakInfoDal(string opmerking, DateTime dateTime, KlantInfoDal klantinfoAF)
        {
            klantinfo = klantinfoAF;
            Opmerkingen = opmerking;
            datetime = dateTime;
        }
    }
}

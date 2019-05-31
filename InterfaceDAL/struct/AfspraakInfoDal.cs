using System;


namespace InterfaceDAL
{
   public struct AfspraakInfoDal
   {
       public int AfspraakId { get; }
        public string Opmerkingen { get;}
        public DateTime datetime { get;}
        public KlantInfoDal klantinfo { get;}


        public AfspraakInfoDal(int afspraakId, string opmerking, DateTime dateTime, KlantInfoDal klantinfoAF)
        {
            AfspraakId = afspraakId;
            klantinfo = klantinfoAF;
            Opmerkingen = opmerking;
            datetime = dateTime;
        }
   }
}

namespace Pensiune
{


    public class DoubleSimpleRoom : Rooms
    {
        public DoubleSimpleRoom( int room,int nrNights):base( room,nrNights){
            }
        public override double get_price()
        {
            if (nrNights > 3) return 120 * 3 + 120 * (nrNights - 3) * 0.8;
            return 120 * nrNights;
        }

    }
    
}

namespace Pensiune
{
   
        public class DoubleRoomWithView:Rooms
        {
        public DoubleRoomWithView(int room, int nrNights) : base( room,nrNights)
        {
            
        }
        public override double get_price()
        {
            if (nrNights > 3) return 150 * 3 + 150 * (nrNights - 3) * 0.8;
            return 150 * nrNights;
        }
    }
    
}

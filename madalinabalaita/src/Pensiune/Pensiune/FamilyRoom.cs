namespace Pensiune
{
    
         class FamilyRoom :Rooms
        {
        public FamilyRoom(int room, int nrNights):base(room,nrNights){
        }
        public override double get_price()
        {   if (nrNights > 3) return 200 * 3 + 200*(nrNights - 3) * 0.8;
            return 200 * nrNights;
        }

    }
    
}

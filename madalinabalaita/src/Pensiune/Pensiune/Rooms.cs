namespace Pensiune
{

    public abstract class Rooms
    {
        protected int price;
        protected int room;
        protected int nrNights;

        public abstract double get_price();
        public Rooms(int room,int nrNights)
        {
            this.room = room;
            this.nrNights = nrNights;
        }
    }
}

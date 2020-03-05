namespace Pensiune
{

    public abstract class Rooms
    {
        protected int price;
        protected int room;
        protected int nrNights;

        public abstract double get_price();
        public Rooms(int nrNights)
        {
            
            this.nrNights = nrNights;
        }
    }
}

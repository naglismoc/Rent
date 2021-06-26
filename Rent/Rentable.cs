namespace Rent
{
    class Rentable
    {
        public Rentable(int beds, bool kitchen, bool shower, int floor, string number, double price)
        {
            Available = true;
            Beds = beds;
            Kitchen = kitchen;
            Shower = shower;
            Floor = floor;
            Number = number;
            Price = price;
        }

        public Rentable()
        {
            Available = true;
        }

        public bool Available { get; set; }
        public int Beds { get; set; }
        public bool Kitchen { get; set; }
        public bool Shower { get; set; }
        public int Floor { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            Rentable r = (Rentable)obj;
            return this.Number.Equals(r.Number);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public Rentable grandinele(string name)
        {
            this.Number = name;
            return this;
        }
        public override string ToString()
        {
            return "Laisvas: " + Available + " lovos:" + Beds + " virtuve:" +
                Kitchen + " dušas:" + Shower + " Aukštas:" + Floor +
                " numeris:" + Number + " kaina:" + Price;
        }
    }

}

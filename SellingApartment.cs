namespace Apartment_brokerage
{
    public class SellingApartment
    {
        public int id { get; set; }
        public int idBueyr { get; set; }
        public string nameBueyr { get; set; }
        public int idSeller { get; set; }
        public string nameSeller { get; set; }
        public int idApartment { get; set; }
        public string phoneBuyer { get; set; }
        public string phoneSeller { get; set; }
        //public int getId() { return id; }
        //public int getIdBueyr() { return idBueyr; }
        //public string getNameBueyr() {return nameBueyr;}
        //public int getIdSeller() { return idSeller;}
        //public string getNameSeller() {return nameSeller;}
        //public string getPhoneBuyer() {return phoneBuyer;}
        //public int getIdApartment() {return idApartment;}
        //public string getPhoneSeller() {return phoneBuyer;}

        public void setId (int id) {this.id = id;}
        public void setIdBueyr(int idBueyr) {this.idBueyr=idBueyr;} 
        public void setNameBueyr(string nameBueyr) { this.nameBueyr = nameBueyr; }
        public void setIdSeller(int idSeller) { this.idSeller = idSeller; }
        public void setNameSeller(string nameSeller) { this.nameSeller = nameSeller; }
        public void setIdApartment(int idApartment) {this.idApartment = idApartment;}
        public void setPhoneBuyer(string phoneBuyer) { this.phoneBuyer = phoneBuyer; }
        public void setPhoneSeller(string phoneSeller) { this.phoneSeller=phoneSeller; }
    }
}

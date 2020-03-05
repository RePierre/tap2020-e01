using System;
using System.Collections.Generic;
using System.Text;


    abstract class Reception
    {
    protected static decimal money;
        //room number 1- camera de familie
        //room number 2- camera dubla cu vedere la munte
        //room number 3- camera dubla cu vedere la munte
        //room number 4- camera dubla fara vedere la munte
        //room number 5- camera la mansarda
        //room number 6- camera la mansarda
        public static decimal Price(int room_number, DateTime checkin, DateTime checkout) {
        var rezervareFR = new FamilyRoom();
        var rezervareAR = new AtticRoom();
        var rezervareDRS = new DoubleRoomSimple();
        var rezervareDRV = new DoubleRoomView();

        decimal number_days=(checkout - checkin).Days;
        decimal price;
        decimal moneynight;

        if (room_number == 1){ moneynight = rezervareFR.CalculatePrice();}
        else if (room_number==2||room_number == 3 ) {  moneynight = rezervareDRV.CalculatePrice(); }
        else if (room_number == 4) { moneynight = rezervareDRS.CalculatePrice(); }
        else { moneynight = rezervareAR.CalculatePrice(); }

        price = room_number * number_days;

        if (number_days >= 4){
            decimal reducere =  0.2m * moneynight* (number_days - 3);
            money = price - reducere;
            
        }
        else money = price;
        return moneynight;
        }

        
        protected abstract decimal CalculatePrice();
        public decimal Money { get; private set; }

       

      
    }


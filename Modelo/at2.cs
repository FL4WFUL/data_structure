namespace tasks{
    public class AtPrimo(){
        public static void pegaPrimo(double n1){
            double count = n1;
            double divs = 0;
            while(count >0 ){
                if(n1%count == 0){divs++;}
                count--;}
            if(divs>2){
                Console.WriteLine("NÃO É PRIMO");
                Console.WriteLine(divs);
            }
            else{
                Console.WriteLine("PRIMO");
                Console.WriteLine(divs);
            }
        }
    }
}
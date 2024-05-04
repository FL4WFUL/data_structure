namespace tasks{
    public class AtMax(){
        public static void Max(double n1, double n2, double n3){
            if(n1>n2&&n1>n3){
                Console.WriteLine(n1 + " É O MAIOR");
            }
            else if(n2>n3&&n2>n1){
                Console.WriteLine(n2 + " É O MAIOR");
            }
            else{
                Console.WriteLine(n3 + " É O MAIOR");
            }
        }
    }
}
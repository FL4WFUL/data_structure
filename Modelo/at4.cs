namespace tasks{
    public class AtFato(){
        public static double Fat(double n1){
            double fat = n1;
            while (n1>1){
                fat *= n1-1;
                n1--;
            }
            return fat;
        }
    }
}
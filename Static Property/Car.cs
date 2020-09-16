namespace Static_Property
{
    public class Car
    {
        private string name;
        private string engine;
        public static int numberOfCars;

        public Car(string name, string engine){
            this.name=name;
            this.engine=engine;
            numberOfCars++;
        }

        public string getName(){
            return name;
        }
        public void setName(string name){
            this.name=name;
        }

        public string getEngine(){
            return name;
        }
        public void setEngine(string engine){
            this.engine=engine;
        }

          public override string ToString(){
               return "Name: "+ this.name + " Engine: "+ this.engine;
    }
}
}
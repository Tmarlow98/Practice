class Vehicle {
  private String brand;
  private String modelName;
  
  public void setModelName(String modelName){
  this.modelName = modelName;
  }
  
  public void setBrand(String brand){
  this.brand = brand;
  }
  
  public String getBrand(){
  return brand;
  }
  
  public String getModelName(){
  return modelName;
  }
  
  public void honk() {
    System.out.println("Tuut, tuut!");
  }
  
}

class Car extends Vehicle {
  
  public void honk(){
    System.out.println("Car honks");
    }
  public static void main(String[] args) {
  
    Car myFastCar = new Car();
    myFastCar.honk();
    myFastCar.setModelName("Comaro");
    myFastCar.setBrand("Chevy");
    System.out.println(myFastCar.getBrand() + " " + myFastCar.getModelName());
    
    Vehicle newCar = new Vehicle();
    newCar.honk();
    newCar.setBrand("Ford");
    newCar.setModelName("F-150");
    System.out.println(newCar.getBrand() + " " + newCar.getModelName());
  }
}

class CarSharing {
    String name = "";
    int capacity;
    int weight;
    int maxspeed;
    int year;
    int mileage;

    CarSharing()
    {
        this.capacity = 2;
        this.weight = 1300;
        this.maxspeed = 300;
        this.year = 2020;
        this.mileage = 100000;
    }

    void displayInfo() {
        cout << "Name: " << name << "\n";
        cout << "Capacity: " << capacity << "\n";
        cout << "Weight: " << weight << "\n";
        cout << "Maxspeed: " << maxspeed << "\n";
        cout << "Year: " << year << "\n";
        cout << "Mileage" << mileage << "\n"
    }


}
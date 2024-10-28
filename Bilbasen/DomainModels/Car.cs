namespace DomainModels
{
    public class Car
    {
        private string? brand;
        private string? model;
        private int year;
        private int mileage;
        private string? color;
        private string? fuelType;
        private int weight;
        private string? carType;

        public Car(string? brand, string? model, int year, int mileage, string? color, string? fuelType, int weight, string? carType)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.color = color;
            this.fuelType = fuelType;
            this.weight = weight;
            this.carType = carType;
        }

        public string? GetBrand() => brand;
        public void SetBrand(string? value) => brand = value;

        public string? GetModel() => model;
        public void SetModel(string? value) => model = value;

        public int GetYear() => year;
        public void SetYear(int value) => year = value;

        public int GetMileage() => mileage;
        public void SetMileage(int value) => mileage = value;

        public string? GetColor() => color;
        public void SetColor(string? value) => color = value;

        public string? GetFuelType() => fuelType;
        public void SetFuelType(string? value) => fuelType = value;

        public int GetWeight() => weight;
        public void SetWeight(int value) => weight = value;

        public string? GetCarType() => carType;
        public void SetCarType(string? value) => carType = value;
    }
}

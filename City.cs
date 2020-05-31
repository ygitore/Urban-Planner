
namespace Urban_Planner
{
    class City
    {
        private int _yearEstablished;
        private string _mayor;

        private string _state { get; }
        private string _cityName { get; }
        private List<Building> buildings  = new List<Building>();
        public City(string name, string state, int year)
        {
            Name = name;
            _state = state;
            _yearEstablished = year;
        }
        public int YearEstablished(){
            return _yearEstablished;
        }
        public int CityMayor(){
            return _mayor;
        }
        public int State(){
            return _mayor;
        }
        public int CityName(){
            return _cityName;
        }
        public void AddBuilding(Building building){
            return this.buildings.Add(building);
        }
    }
}
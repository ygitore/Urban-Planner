
using System.Collections.Generic;

namespace Urban_Planner
{
    public class City
    {
        private int _yearEstablished;
        private string _mayor;

        private string _state { get; }
        private string _cityName { get; }
        private List<Building> buildings  = new List<Building>();
        public City(string city, string state, int year)
        {
            _cityName = city;
            _state = state;
            _yearEstablished = year;
        }
        public int YearEstablished(){
            return _yearEstablished;
        }
        public string CityMayor(){
            return _mayor;
        }
        public string State(){
            return _mayor;
        }
        public string CityName(){
            return _cityName;
        }
        public void AddBuilding(Building building){
            this.buildings.Add(building);
        }
    }
}
using System;

namespace Urban_Planner
{
    public class Building
    {
        private string _designer = "Yitbarek";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        public string Name { get; set; }
        public int Stories { get; set; }
        public double Depth { get; set; }
        public double Width { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * 3 * Stories;
            }
        }
        public Building(string address, DateTime dateConstructed)
        {
            this._address = address;
            this._dateConstructed = dateConstructed;
        }
        public void Purchase(string name)
        {
            _owner = name;
        }
        public DateTime DateContructed()
        {
            return _dateConstructed;
        }
        public void PrintBuilding()
        {
            string buildingInfo = $@"
                Address: {_address} 
                Designed by: {_designer}
                Built {_dateConstructed}
                Owned by: {_owner}
                Volume: {Volume}";
            System.Console.WriteLine(buildingInfo);
        }
    }
}
namespace FSDN.ZooExercise
{
    internal struct FoodItem
    {
        internal string Name { get; set; }
        internal FoodType Type { get; set; }

        internal FoodItem(string name, FoodType type)
        {
            Name = name;
            Type = type;
        }

        internal enum FoodType
        {
            Meat,
            Fruit,
            Vegetables,
            Grains
        }
    }
}

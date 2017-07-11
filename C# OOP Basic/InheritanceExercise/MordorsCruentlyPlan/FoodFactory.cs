public class FoodFactory
{
    public Food CreateFood(string food)
    {
        food = food.ToLower();
        int happines;
        switch (food)
        {
            case "cram":
                happines = 2;
                break;
            case "lembas":
                happines = 3;
                break;
            case "apple":
                happines = 1;
                break;
            case "melon":
                happines = 1;
                break;
            case "honeycake":
                happines = 5;
                break;
            case "mushrooms":
                happines =- 10;
                break;
            default:
                happines =- 1;
                break;
        }
        return new Food(happines);
    }
}


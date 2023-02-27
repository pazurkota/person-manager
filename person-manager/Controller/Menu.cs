namespace person_manager.Controller;

public class Menu
{
    private string showMenu()
    {
        string str = "Person Manager menu";

        str += "\n1. About";
        str += "\n2. Show full list";
        str += "\n3. Add new person";
        str += "\n4. Remove person (via ID)";
        str += "\n0. Exit program";

        return str;
    }
}
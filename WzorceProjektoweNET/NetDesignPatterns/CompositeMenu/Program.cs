using CompositeMenu;

MenuCategory mainMenu = new MenuCategory("Main Menu");

MenuCategory appetizers = new MenuCategory("Appetizers");
appetizers.Add(new Dish("Bruschetta"));
appetizers.Add(new Dish("Garlic Bread"));

MenuCategory mainCourses = new MenuCategory("Main Courses");
mainCourses.Add(new Dish("Margherita Pizza"));
mainCourses.Add(new Dish("Spaghetti Carbonara"));

MenuCategory desserts = new MenuCategory("Desserts");
desserts.Add(new Dish("Tiramisu"));
desserts.Add(new Dish("Panna Cotta"));

mainMenu.Add(appetizers);
mainMenu.Add(mainCourses);
mainMenu.Add(desserts);

mainMenu.Display(1);
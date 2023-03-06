using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create the restaurant.
        Restaurant restaurant = new Restaurant();

        // Create some tables.
        Table table1 = new Table(1);
        Table table2 = new Table(2);
        Table table3 = new Table(3);
        restaurant.AddTable(table1);
        restaurant.AddTable(table2);
        restaurant.AddTable(table3);

        // Create some menu items.
        MenuItem appetizer1 = new MenuItem("Nachos", "Tortilla chips topped with cheese, jalapenos, and salsa", 6.99m, MenuItemType.Appetizer);
        MenuItem appetizer2 = new MenuItem("Mozzarella Sticks", "Fried mozzarella cheese sticks with marinara sauce", 5.99m, MenuItemType.Appetizer);
        MenuItem entree1 = new MenuItem("Steak", "Grilled sirloin steak with roasted vegetables", 19.99m, MenuItemType.Entree);
        MenuItem entree2 = new MenuItem("Chicken Alfredo", "Fettuccine pasta with creamy Alfredo sauce and grilled chicken", 15.99m, MenuItemType.Entree);
        MenuItem dessert1 = new MenuItem("Cheesecake", "New York style cheesecake with raspberry sauce", 7.99m, MenuItemType.Dessert);
        MenuItem dessert2 = new MenuItem("Chocolate Cake", "Moist chocolate cake with chocolate ganache", 6.99m, MenuItemType.Dessert);
        MenuItem beverage1 = new MenuItem("Soda", "Coca-Cola, Diet Coke, Sprite, or Fanta", 2.99m, MenuItemType.Beverage);
        MenuItem beverage2 = new MenuItem("Iced Tea", "Freshly brewed iced tea with lemon", 2.99m, MenuItemType.Beverage);

        // Create some menus.
        Menu lunchMenu = new Menu();
        lunchMenu.AddItem(appetizer1);
        lunchMenu.AddItem(entree1);
        lunchMenu.AddItem(dessert1);
        lunchMenu.AddItem(beverage1);

        Menu dinnerMenu = new Menu();
        dinnerMenu.AddItem(appetizer2);
        dinnerMenu.AddItem(entree2);
        dinnerMenu.AddItem(dessert2);
        dinnerMenu.AddItem(beverage2);

        // Add the menus to the restaurant.
        restaurant.AddMenu(lunchMenu);
        restaurant.AddMenu(dinnerMenu);

        // Create some customers.
        Customer customer1 = new Customer("John", "Smith", "555-1234", "jsmith@example.com");
        Customer customer2 = new Customer("Jane", "Doe", "555-5678", "jdoe@example.com");

        // Make a reservation for customer1.
        DateTime reservationStartTime = new DateTime(2023, 03, 06, 18, 0, 0);
        DateTime reservationEndTime = new DateTime(2023, 03, 06, 20, 0, 0);
        Reservation reservation = restaurant.MakeReservation(reservationStartTime, reservationEndTime, 4);
        reservation.Customer = customer1;

        // Assign the reservation to a table.
        restaurant.AssignReservation(reservation, table1);

        // Simulate the customers arriving and being seated.
        restaurant.SeatCustomers(reservation);

        // Show the customers the menu.
        Console.WriteLine("Welcome to our restaurant! Here is our menu:");
        restaurant.ShowMenu(lunchMenu);

        // Take the customers' orders.
        Order order1 = restaurant.Take

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Hpcharacter
{
	public string Name { get; set; }
	public string House { get; set; }
	public List<string> Inventory { get; set; }

	public Hpcharacter (string name, string house, List <string> inventory)
	{
		Name = name;
		House = house;
		Inventory = inventory;

	}
	public void PrintInfo()
	{
		Console.WriteLine($"Denne karakteren heter {Name}, tilhører huset {House}, og har {PrintInventory()}");

		

	}
	public string PrintInventory()
	{
		string inventory = "";
		for (int i = 0; i < Inventory.Count; i++)
		{
			inventory += Inventory[i] + ", ";
		}
		return inventory;
	}
}
public class Butikk
{
	public List<string> Items { get; set; }

	public Butikk ( List<string> items)
	{
		Items = items;
	}
	public void PrintInfo() 
	{
		Console.WriteLine($"I denne butikken kan du skaffe deg: \n{PrintStore()}"); 

	}
	public string PrintStore()
	{
		string items = "";
		for (int i = 0; i < Items.Count; i++)
		{
			items += $"{i + 1}. " + Items[i] + "\n";
		}
		return items;
	}
	
		
		
}
using System;
using System.Collections.Generic;

class Element
{
    public int number;
    public string name;
    public string category;
    public string info;

    public Element(int no, string nme, string cat, string information)
    {
        number = no;
        name = nme;
        category = cat;
        info =information;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Element> el = new Dictionary<int, Element>();

        // First 30 elements of the periodic table
        el.Add(1, new Element(1, "Hydrogen", "Nonmetal", "Lightest element"));
        el.Add(2, new Element(2, "Helium", "Noble Gas","No additional info"));
        el.Add(3, new Element(3, "Lithium", "Alkali Metal", "No additional info" ));
        el.Add(4, new Element(4, "Beryllium", "Alkaline Earth Metal", "No additional info" ));
        el.Add(5, new Element(5, "Boron", "Metalloid", "No additional info" ));
        el.Add(6, new Element(6, "Carbon", "Nonmetal", "No additional info"));
        el.Add(7, new Element(7, "Nitrogen", "Nonmetal","No additional info" ));
        el.Add(8, new Element(8, "Oxygen", "Nonmetal", "Essential for respiration and supports life" ));
        el.Add(9, new Element(9, "Fluorine", "Halogen", "No additional info"));
        el.Add(10, new Element(10, "Neon", "Noble Gas", "No additional info"));
        el.Add(11, new Element(11, "Sodium", "Alkali Metal", "No additional info"));
        el.Add(12, new Element(12, "Magnesium", "Alkaline Earth Metal", "No additional info" ));
        el.Add(13, new Element(13, "Aluminium", "Metal", "No additional info" ));
        el.Add(14, new Element(14, "Silicon", "Metalloid", "No additional info"));
        el.Add(15, new Element(15, "Phosphorus", "Nonmetal", "No additional info" ));
        el.Add(16, new Element(16, "Sulfur", "Nonmetal","No additional info" ));
        el.Add(17, new Element(17, "Chlorine", "Halogen", "No additional info" ));
        el.Add(18, new Element(18, "Argon", "Noble Gas", "No additional info" ));
        el.Add(19, new Element(19, "Potassium", "Alkali Metal", "No additional info" ));
        el.Add(20, new Element(20, "Calcium", "Alkaline Earth Metal", "No additional info" ));
        el.Add(21, new Element(21, "Scandium", "Transition Metal","No additional info" ));
        el.Add(22, new Element(22, "Titanium", "Transition Metal", "No additional info" ));
        el.Add(23, new Element(23, "Vanadium", "Transition Metal", "No additional info" ));
        el.Add(24, new Element(24, "Chromium", "Transition Metal", "No additional info" ));
        el.Add(25, new Element(25, "Manganese", "Transition Metal", "No additional info" ));
        el.Add(26, new Element(26, "Iron", "Transition Metal","No additional info" ));
        el.Add(27, new Element(27, "Cobalt", "Transition Metal", "No additional info"));
        el.Add(28, new Element(28, "Nickel", "Transition Metal", "No additional info"));
        el.Add(29, new Element(29, "Copper", "Transition Metal", "No additional info" ));
        el.Add(30, new Element(30, "Zinc", "Transition Metal", "No additional info" ));

        char chr;

        Console.WriteLine("Hi there! Happy to help!");

        do
        {
            Console.Write("\nProvide atomic number of the element: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (el.ContainsKey(x))
            {
                Element elements = el[x];

                Console.WriteLine("\nAtomic Number: " + elements.number);
                Console.WriteLine("Name: " + elements.name);
                Console.WriteLine("Class: " + elements.category + "(" + elements.info + ")");
            }
            else
            {
                Console.WriteLine("Invalid atomic number");
            }

            Console.Write("\nDo you want to know more elements [y/n]? ");
            string? input = Console.ReadLine();
            if(!string.IsNullOrEmpty(input))
            chr = input[0];
            else
            chr = 'n';

        } while (chr == 'y' || chr == 'Y');

        Console.WriteLine("\nThanks!");
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heidi_schwartz_C968.model
{
    internal class Inventory
    {
        static public BindingList<Product> Products = new BindingList<Product>();
        static public BindingList<Part> AllParts = new BindingList<Part>();

        static public Product CurrentProduct { get; set; }
        static public Part CurrentPart { get; set; }
        static private int PartID { get; set; }
        static private int ProductID { get; set; }

        // Add some default data to the inventory
        static Inventory() 
        {
            addProduct(new Product(1, "Rubber Canary Crate", 10.00m, 10, 1, 100));
            addProduct(new Product(2, "PaperMache Cat Corner", 20.00m, 20, 1, 200));
            addProduct(new Product(3, "Cardboard Doghouse", 30.00m, 30, 1, 300));
            addPart(new Inhouse(1, "Good Rock", 1.00m, 10, 1, 100, 1));
            addPart(new Inhouse(2, "Flat Rock", 2.00m, 20, 1, 200, 2));
            addPart(new Outsourced(3, "Bad Rock", 3.00m, 30, 1, 300, "Bob's Builders"));
            PartID = 4; // Start at 4 because we added 3 parts
            ProductID = 4; // Start at 4 because we added 3 products
        }

        public static int generatePartID()
        {
            return PartID++;
        }

        public static int generateProductID()
        {
            try
            {
                return ProductID++;
            }
            catch (Exception)
            {

                return 0;
            }
            
        }

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        public static void updateProduct(int productID, Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = product;
                    break;
                }
            }
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool removePart(Part part)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == part.PartID)
                {
                    AllParts.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public static void updatePart(int partID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = part;
                    break;
                }
            }
        }
    }
}

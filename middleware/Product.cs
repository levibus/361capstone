﻿namespace _361capstone;

public class Product
{
    public int SKU { get; set; }
    public string itemName { get; set; }
    public float cost { get; set; }
    public string manufacturer { get; set; }
    public int categoryId { get; set; }
    public string img { get; set; }
    public int imgId { get; set; }

    public Product(int SKU, string itemName, float cost, string manufacturer, int categoryId, string img, int imgId)
    {
        this.SKU = SKU;
        this.cost = cost;
        this.SKU = SKU;
        this.itemName = itemName;
        this.cost = cost;
        this.manufacturer = manufacturer;
        this.categoryId = categoryId;
        this.img = img;
        this.imgId = imgId;
    }

    public float ApplyDiscount(int discount)
    {
        return discount * cost;
    }
}
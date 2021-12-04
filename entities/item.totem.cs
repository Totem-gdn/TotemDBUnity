using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TotemItem
{
    public int id;
    public string created_at;
    public string name;
    public string seed;
    public string type;
    public float speed;
    public int damage;
    public string element;
    public OwnerEntity owner;
    public IconEntity icon;
}

[Serializable]
public class TotemItemsResponseDto
{
    public List<TotemItem> items;
}

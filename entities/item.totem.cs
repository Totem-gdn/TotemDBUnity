using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemTotem {
    public int id { get; set; }
    public string name { get; set; }
    public string seed { get; set; }
    public string type { get; set; }
    public OwnerEntity owner { get; set; }
    //public string icon { get; set; }
    public ItemAttributes attrs { get; set; }
}
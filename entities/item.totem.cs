using System;
using System.Collections.Generic;
using UnityEngine;

namespace entities
{
    [Serializable]
    public class TotemItem
    {
        public int id;
        public int created_at;
        public string name;
        public string seed;
        public string type;
        public string attrs;
        public OwnerEntity owner;
        public IconEntity icon;
    }

    [Serializable]
    public class TotemItemsResponseDto
    {
        public List<TotemItem> items;
    }
}
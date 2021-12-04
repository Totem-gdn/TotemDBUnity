using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class TotemAvatar {
    public int id;
    public string seed;
    public string name;
    public string skinColor;
    public string hairType;
    public string hairColor;
    public OwnerEntity owner;
    public IconEntity icon;
}

[Serializable]
public class TotemAvatarsResponseDto
{
    public List<TotemAvatar> avatars;
}
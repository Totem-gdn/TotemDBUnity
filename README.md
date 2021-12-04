# TotemDB Wrapper for Unity!
Totem DB wrapper for unity

## Installation

You can check the manual: https://docs.unity3d.com/Manual/upm-ui-giturl.html <br>
With our git link: https://github.com/Totem-gdn/TotemDBUnity.git


## Example

```csharp
using System;
using TotemDB;
using UnityEngine;

public class TotemTest : MonoBehaviour
{
    void Start()
    {
        var wrapper = gameObject.AddComponent<TotemDBWrapper>();
        List<TotemItem> items = wrapper.GetAllItems();
        List<TotemAvatar> avatars = wrapper.GetAllAvatars();
    }
}
```
## Items and Avatars objects:

### TotemItem:
```csharp
public class TotemItem {
    public int id;
    public string created_at;
    public string name;
    public string seed;
    public string type;
    public float speed;
    public int damage;
    public string element;
    public ColorEntity color;
    public OwnerEntity owner;
}
```

### TotemAvatar:
```csharp
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
```

### Owner:
```csharp
public class OwnerEntity {
    public int id;
    public string name;
}
```

### Icon:
```csharp
public class IconEntity {
    public string path;
    public string name;
    public string type;
    public int size;
    public string mime;
    public string url;
}
```

### Color:
```csharp
public class ColorEntity {
    public float red;
    public float green;
    public float blue;
    public float alpha;
}
```

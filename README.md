# TotemDB Wrapper for Unity! 
Totem DB wrapper for unity

## Instructions
You can install this package in three ways!
### A) Package Manager (GIT Url)

The suggested way to install this package is through the "Unity's Package Manager", with our GIT url. 
This way, you will be notified once new versions get released, and you will be able to download them directly from the Unity Editor.

1/ **The GIT url you need to add to the Package manager is the following** (copy and paste it): **https://github.com/Totem-gdn/TotemDBUnity.git**

2/ In the Unity editor, open **Window -> Package Manager** to open the Package Manager, then click **+ -> Add package from git URL... -> paste the link above**.

**Still having trouble this way?**
<br>
You can always check Unity's docs for how to install from git: https://docs.unity3d.com/Manual/upm-ui-giturl.html

### B) Manual Install
You can also install this package manually, by copying the source files directly into your project's assets folder. (You'd have to do this every time there is a new update.)

### C) Using .unitypackage from our "Release" tab
1/ Head over to our releases tab: https://github.com/Totem-gdn/TotemDBUnity/releases.
Download the requested version .unitypackage.
<br>
2/ In the Unity editor, open **Assets -> Import Package -> Custom Package... -> navigate and select downloaded package** and Voilà!

---


You can check the manual: https://docs.unity3d.com/Manual/upm-ui-giturl.html <br>


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

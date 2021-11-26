# TotemDB Wrapper for Unity!
Totem DB wrapper for unity

## Installation

You can check the manual: https://docs.unity3d.com/Manual/upm-ui-giturl.html <br>
With our git link: https://github.com/Totem-gdn/TotemDBUnity.git


## Example

```unity
using System;
using TotemDB;
using UnityEngine;

public class TotemTest : MonoBehaviour
{
    void Start()
    {
        var totemdb = gameObject.AddComponent<TotemDBWrapper>();
        Action<string> itemCallback = items => Debug.Log(items);
        Action<string> avatarCallback = items => Debug.Log(items);
        StartCoroutine(totemdb.GetAllItems(itemCallback));
        StartCoroutine(totemdb.GetAllAvatars(avatarCallback));
    }
}
```

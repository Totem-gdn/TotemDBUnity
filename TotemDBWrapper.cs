using System.Collections.Generic;
using System.IO;
using System.Net;
using entities;
using UnityEngine;
using UnityEngine.Serialization;

public class TotemDBWrapper: MonoBehaviour
{
    [FormerlySerializedAs("_itemsUrl")] [SerializeField]
    private string itemsUrl = "https://x8ki-letl-twmt.n7.xano.io/api:y8B1f40J/items";
    [FormerlySerializedAs("_avatarsUrl")] [SerializeField]
    private string avatarsUrl  = "https://x8ki-letl-twmt.n7.xano.io/api:y8B1f40J/avatars";
    public List<TotemAvatar> GetAllAvatars()
    {
        var avatarsResponseDto = GenericApiGet<TotemAvatarsResponseDto>(this.avatarsUrl);
        return avatarsResponseDto.avatars;
    }

    public List<TotemItem> GetAllItems()
    {
        var itemsResponseDto = GenericApiGet<TotemItemsResponseDto>(this.itemsUrl);
        return itemsResponseDto.items;
    }

    private static T GenericApiGet<T>(string url)
    {
        var request = (HttpWebRequest)WebRequest.Create(url);
        var response = (HttpWebResponse) request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream()!);
        var jsonResponse = reader.ReadToEnd();
        var objects = JsonUtility.FromJson<T>(jsonResponse);
        return objects;
    }
}
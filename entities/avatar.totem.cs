using UnityEngine;

public class AvatarTotem {
    public int id { get; set; }
    public string seed { get; set; }
    public string name { get; set; }
    public string skinColor { get; set; }
    public string hairType { get; set; }
    public string hairColor { get; set; }
    public int owner { get; set; }
    public string icon { get; set; }
    public static AvatarTotem CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<AvatarTotem>(jsonString);
    }
}
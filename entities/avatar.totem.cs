[Serializea]
class AvatarTotem: ITotem {
    private TotemType type = TotemType.Avatar;
    TotemType Gettype => this.type;

    public int id;
    public string seed;
    public string name;
    public string skinColor;
    public string hairType;
    public string hairColor;
    public int owner;
    public string icon;
}
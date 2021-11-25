class ItemTotem: ITotem {
    private TotemType type = TotemType.Avatar;
    TotemType Gettype => this.type;

    int id;
    string name;
    string seed;
    string type;
    int owner;
    string icon;
    Dictionary<string, string> attrs;
}
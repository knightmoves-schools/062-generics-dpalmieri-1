namespace knightmoves;

public class Box{
    public List<string> Items {get;}

    public Box(){
        Items = new List<string>();
    }

    public void Add(string item){
        Items.Add(item);
    }

    public void Remove(string item){
        Items.Remove(item);
    }
}
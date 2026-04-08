namespace knightmoves;

public class Box<T>{
    public List<T> Items {get;}

    public Box(){
        Items = new List<T>();
    }

    public void Add(T item){
        Items.Add(item);
    }

    public void Remove(T item){
        Items.Remove(item);
    }
}
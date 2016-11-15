using UnityEngine;
using System.Collections;

public class Lu_menu_move : Buttons {
    public float move;
    public GameObject Lu;
    public float timedestroy;
    // Update is called once per frame
    void move_Lu() {
        transform.Translate(new Vector3(move, 0, 0));
        Destroy(Lu, timedestroy);
    }
    void Update () {
        move_Lu();
    }
    
}

using UnityEngine;
using System.Collections;

public class PlayerContriller : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float playerSpeed;
    public float jumpPower;
    public int h_directionInput;
    public int v_directionInput;
    public bool groundCheck;
    public bool facingRight = true;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(playerSpeed * h_directionInput, playerSpeed * v_directionInput);
    }
    public void H_Move(int InputAxis)
    {
        Debug.Log("H");
        Debug.Log(InputAxis);
        h_directionInput = InputAxis;

    }
    public void V_Move(int InputAxis)
    {
        Debug.Log("V");
        Debug.Log(InputAxis);
        v_directionInput = InputAxis;

    }
}

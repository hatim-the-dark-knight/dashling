using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player;
    public float player_speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 inputposn = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        Vector3 input_pos = new Vector3(inputposn.x, 0, -inputposn.y);
        
        player.AddForce(input_pos * player_speed * Time.deltaTime * 10, ForceMode.Acceleration);
        
    }
}

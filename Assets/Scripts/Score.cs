using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player, start;
    public Text score;
    private void Start()
    {
        player.transform.position = start.position;
    }
    void Update()
    {
        score.text = (player.position.x/2).ToString("0");
    }
}

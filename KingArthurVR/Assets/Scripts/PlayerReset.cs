using UnityEditor.Rendering;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    public Transform player;
    public float resetY = -5f;

    public void ResetOnFall()
    {
        if (player.position.y <= resetY)
        {
            player.position = Vector3.zero;
        }
    }

    private void Update()
    {
        ResetOnFall();
    }
}
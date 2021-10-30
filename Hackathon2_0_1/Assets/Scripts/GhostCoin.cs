using UnityEngine;

public class GhostCoin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            GhostPower.Value++;
            Destroy(gameObject);
        }
    }
}

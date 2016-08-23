using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
    public GameObject explosionPrefab;
    public AudioClip shootSound;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" )
        {
            
            Debug.Log(score.ObjectCounter);
            // explode if specified
            if (explosionPrefab != null)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }
            score.ObjectCounter++;
            // destroy after collection
            Destroy(gameObject);
        }
    }
}

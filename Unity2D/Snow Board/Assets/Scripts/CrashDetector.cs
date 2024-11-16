using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class CrashDetector : MonoBehaviour
{
    // void OnTriggerEnter2D(Collider2D other) 
    // {
    //     if(other.tag == "Player")
    //     {
    //         Debug.Log("Loading Eror");
    //         SceneManager.LoadScene(0);
    //     }
    // }
IEnumerator ReloadScene()
{
    yield return new WaitForSeconds(0.1f); // Küçük bir gecikme ekle
    SceneManager.LoadScene(0); // Sahneyi yükle
}

void OnCollisionEnter2D(Collision2D other)
{
    if (other.gameObject.CompareTag("Player")) // Player tag'ini doğru şekilde kontrol et
    {
        StartCoroutine(ReloadScene()); // Coroutine başlat
    }
}

}

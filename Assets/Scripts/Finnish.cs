using UnityEngine;
using UnityEngine.SceneManagement;

public class Finnish : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
}

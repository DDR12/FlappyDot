using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstController : MonoBehaviour
{
    public float MaxDelay = 5;

    private float delay;

    void Start()
    {
        delay = 0;
    }

    void Update()
    {
        delay += Time.deltaTime;

        if (delay >= MaxDelay)
        {
            // TODO don't load if loading add.
            SceneManager.LoadScene(1);
        }
    }
}

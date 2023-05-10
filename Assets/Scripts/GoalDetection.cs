using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalDetection : MonoBehaviour
{
    public GameObject ball;
    public GameObject goalScoredPanel; // This panel will be displayed when a goal is scored

    void Start()
    {
     Debug.Log("GoalDetection script started");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "Trigger entered!");
        if (other.gameObject == ball)
        {
            Debug.Log("Goal Scored!");
            goalScoredPanel.SetActive(true); // Display the panel when a goal is scored
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Retry()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

}

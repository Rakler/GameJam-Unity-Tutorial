using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineController : MonoBehaviour
{
    // Called when a Collider2D enters the Trigger collider of this GameObject where the script is attached to
    private void OnTriggerEnter2D(Collider2D other)
    {
        // We do not load the scene immediately, as that would look very abrupt.
        // Instead, we start a Coroutine that waits a few seconds and THEN loads the new level.
        // A coroutine is a function that can suspend its execution (yield) until the given YieldInstruction finishes
        StartCoroutine(LoadNextLevel());
    }

    // This is how a Coroutine is declared in C#, using IEnumerator.
    IEnumerator LoadNextLevel()
    {
        // Change the number inside WaitForSeconds to tweak how long it takes before loading next level
        yield return new WaitForSeconds(2);

        // LoadScene takes as input the number of the scene in the BuildSettings (File -> Build Settings)
        // So we get the current scene number ( SceneManager.GetActiveScene().buildIndex ) and add 1 to get
        // the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);        
    }
}

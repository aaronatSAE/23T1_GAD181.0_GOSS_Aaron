using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AaronGoss.SimpleLevelLoader
{
    public class SceneLoader : MonoBehaviour
    {
        // need a feature that loads X scene when trigger is collided with
        [SerializeField] private int sceneToLoad;

        private void OnTriggerEnter(Collider other)
        {
            // If it is the PLAYER that has triggered this event...
            if (other.tag == "Player")
            {
                // ...LOAD the specified scene!
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}

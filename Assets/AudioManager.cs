using UnityEngine;
 
 
 
 
public class AudioManager : MonoBehaviour {
 
    public AudioClip nextMusic; // drag the next music here in the Inspector
    private AudioSource audioObject; // drag the music player here or...
 
    void Start()
    { // find it at Start:
        // supposing that the music player is named "MusicPlayer":
        audioObject = gameObject.GetComponent<AudioSource>();
    }
 
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        { // only an object tagged Player stops the sound
            audioObject.Stop();
            Debug.Log("Player entered!");
        }
    }
 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        { // only an object tagged Player restarts the sound
            audioObject.clip = nextMusic;  // select the next music
            audioObject.Play(); // play it
            Debug.Log("Player exit!");
        }
    }
}
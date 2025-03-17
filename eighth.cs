using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class uchan : MonoBehaviour
{
    public Animator animator;
    public Button playButton;
    public AudioSource sound;
    public VideoPlayer player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playButton.onClick.AddListener(PlayAnimation);
    }

    void PlayAnimation ()
    {
        animator.Play("New Animation");
        sound.Play();
        player.Play();
    }

}

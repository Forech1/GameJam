using UnityEngine;

public class Test_audio : MonoBehaviour
{
    [SerializeField] AudioClip clip;

    private void Start()
    {

        AudioSystems.instance.PlaySoundBGM(clip);
        AudioSystems.instance.SetSoundVolBGM(0.2f);
    }
}

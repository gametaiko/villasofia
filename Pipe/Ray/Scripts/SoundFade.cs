using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFade : MonoBehaviour
{
        public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
        {
            float startVolume = audioSource.volume;

            while (audioSource.volume > 0)
            {
                audioSource.volume -= 0.01f * Time.deltaTime / FadeTime;

            yield return new WaitForEndOfFrame();
            }

            audioSource.Stop();
            audioSource.volume = startVolume;
        }
}

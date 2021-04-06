using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace CookieTweener
{
    public class UIFade : IUIEffect
    {
        private Image UiImage { get; }
        private float Alpha { get; }
        private float LerpSpeed { get; }

        public UIFade(Image image, float alpha, float speed)
        {
            UiImage = image;
            Alpha = alpha;
            LerpSpeed = speed;
        }

        public IEnumerator Execute()
        {
            var time = 0f;
            var currentAlpha = UiImage.color.a;

            while (UiImage.color.a != Alpha)
            {
                time += Time.deltaTime * LerpSpeed;
                var alphaToSet = Mathf.Lerp(currentAlpha, Alpha, time);

                Color temp = UiImage.color;
                temp.a = alphaToSet;
                UiImage.color = temp;
                yield return null;
            }
        }
    }
}

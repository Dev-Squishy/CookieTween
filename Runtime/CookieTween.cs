using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CookieTweener
{
    public static class CookieTween
    {
        public static void Scale(RectTransform rect, float scale, float speed, bool scaleBack = false)
        {
            if (!rect.gameObject.GetComponent<CookieTweenCallbacks>())
                rect.gameObject.AddComponent<CookieTweenCallbacks>();

            CookieTweenCallbacks mono = rect.gameObject.GetComponent<CookieTweenCallbacks>();
            UIScale scaler = new UIScale(rect, scale, speed, scaleBack);
            // mono.StopAllCoroutines();
            mono.StartCoroutine(scaler.Execute());
        }

        public static void Rotate(RectTransform rect, Vector3 rotation, float speed)
        {
            if (!rect.gameObject.GetComponent<CookieTweenCallbacks>())
                rect.gameObject.AddComponent<CookieTweenCallbacks>();

            CookieTweenCallbacks mono = rect.gameObject.GetComponent<CookieTweenCallbacks>();
            UIRotate rotateRect = new UIRotate(rect, rotation, speed);
            // mono.StopAllCoroutines();
            mono.StartCoroutine(rotateRect.Execute());
        }


        public static void Fade(Image image, float alpha, float speed)
        {
            if (!image.gameObject.GetComponent<CookieTweenCallbacks>())
                image.gameObject.AddComponent<CookieTweenCallbacks>();

            CookieTweenCallbacks mono = image.gameObject.GetComponent<CookieTweenCallbacks>();
            UIFade fadeAlpha = new UIFade(image, alpha, speed);
            // mono.StopAllCoroutines();
            mono.StartCoroutine(fadeAlpha.Execute());
        }
    }
}


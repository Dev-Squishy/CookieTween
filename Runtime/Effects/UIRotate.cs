using System.Collections;
using UnityEngine;

namespace CookieTweener
{
    public class UIRotate : IUIEffect
    {
        public RectTransform RectTransform { get; }
        public Vector3 Rotation { get; }
        public float LerpSpeed { get; }

        public UIRotate(RectTransform rectTransform, Vector3 rotation, float lerpSpeed)
        {
            RectTransform = rectTransform;
            Rotation = rotation;
            LerpSpeed = lerpSpeed;
        }

        public IEnumerator Execute()
        {
            var time = 0f;
            var currentRotation = RectTransform.localRotation;
            var desiredRotation = Quaternion.Euler(Rotation);


            while (RectTransform.localRotation != desiredRotation)
            {
                time += Time.deltaTime * LerpSpeed;
                var rotate = Quaternion.Lerp(currentRotation, desiredRotation, time);
                RectTransform.localRotation = rotate;
                yield return null;
            }
        }
    }
}
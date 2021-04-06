using System.Collections;
using UnityEngine;
using System;

namespace CookieTweener
{
    public class UIScale : IUIEffect
    {
        private RectTransform RectTransform { get; }
        private Vector3 ScaleSize { get; }
        private float ScaleSpeed { get; }
       
        private bool ScaleBack { get; }

        /// <summary>
        /// Uniformly Scale UI object with Auto Scale back
        /// </summary>
        /// <param name="_rectTransform">UI obj rect transform</param>
        /// <param name="uniformScaleSize">Single float value used for uniform scale</param>
        /// <param name="scaleSpeed">Lerp speed for scale</param>
        /// <param name="wait">Time to wait till scale back is executed</param>
        /// <param name="scaleBack">Scale back enabled</param>
        public UIScale(RectTransform _rectTransform,float uniformScaleSize, float scaleSpeed,bool scaleBack = true)
        {
            RectTransform = _rectTransform;
            ScaleSize = new Vector3(uniformScaleSize, uniformScaleSize, uniformScaleSize);           
            ScaleSpeed = scaleSpeed;            
            ScaleBack = scaleBack;
            
        }
        /// <summary>
        /// Custom Scale UI object with auto Scale back
        /// </summary>
        /// <param name="_rectTransform">UI obj rect transform</param>
        /// <param name="customScaleSize">Vector3 value used for custom scale</param>
        /// <param name="scaleSpeed">Lerp speed for scale</param>
        /// <param name="wait">Time to wait till Scale back is executed</param>
        /// <param name="scaleBack">Scale back enabled</param>
        public UIScale(RectTransform _rectTransform, Vector3 customScaleSize, float scaleSpeed,bool scaleBack = true)
        {
            RectTransform = _rectTransform;
            ScaleSize = customScaleSize;
            ScaleSpeed = scaleSpeed;            
            ScaleBack = scaleBack;
          
        }


        public IEnumerator Execute()
        {
            var time = 0f;
            var currentScale = RectTransform.localScale;

            while(RectTransform.localScale != ScaleSize)
            {
                time += Time.deltaTime * ScaleSpeed;
                var scale = Vector3.Lerp(currentScale, ScaleSize, time);
                RectTransform.localScale = scale;
                yield return null;
            }
            
            if(ScaleBack)
            {
                //yield return Wait;

                currentScale = RectTransform.localScale;
                time = 0;
                Debug.Log("Cook");
                while(RectTransform.localScale != Vector3.one)
                {
                    time += Time.deltaTime * ScaleSpeed;
                    var scale = Vector3.Lerp(currentScale, Vector3.one, time);
                    RectTransform.localScale = scale;
                    yield return null;
                }
            }
        }
    }
}
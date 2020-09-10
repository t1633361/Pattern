using System;
using DesignPattern.Factory;
using UnityEngine;

namespace Sample
{
    public class TestPattern : MonoBehaviour
    {
        private PatternType nowPatternType;
        public  PatternType patternType;
        

        // Update is called once per frame
        void Update()
        {
            if (nowPatternType != patternType)
            {
                ShowPattern();
            }
        }

        void ShowPattern()
        {
            nowPatternType = patternType;
            switch (nowPatternType)
            {
                case PatternType.Invalid:
                    Debug.Log("Idle");
                    break;
                case PatternType.Factory:
                    ShowFactory();
                    break;
                default:
                    throw new NotImplementedException(nowPatternType.ToString());
            }
        }

        void ShowFactory()
        {
            var factory = new GameObject("Factory");
            factory.transform.SetParent(transform);
            factory.AddComponent<FactorySample>();
        }
    }
}

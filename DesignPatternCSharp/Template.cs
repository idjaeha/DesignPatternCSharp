using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1.DesignPattern
{
    class NotPullingMaterialException : Exception
    {
        public NotPullingMaterialException()
        {

        }

        public NotPullingMaterialException(string message) : base(message)
        {

        }
    }

    abstract class Subject
    {
        /// <summary>
        /// 실행 과정을 나타내는 함수
        /// </summary>
        /// <returns></returns>
        public int Study()
        {
            int score = 0;
            OnPreStudy();
            if ( !PullMaterial())
            {
                throw CreateException();
            }

            PullBook();
            score += DoStudy();

            Console.WriteLine("{0}점을 획득했다.\n", score);
            return score;
        }

        /// <summary>
        /// 하위 클래스에서 확장 가능하다.
        /// 훅 메서드
        /// 1. 상위 클래스에서 실행 시점이 제어된다.
        /// 2. 기본 구현이 제공되어, 하위 클래스에서 알맞게 확장할 수 있다.
        /// </summary>
        protected virtual void OnPreStudy()
        {
            Console.WriteLine("공부하기 전에 마음을 다 잡았다.");
        }

        protected abstract void PullBook();
        protected abstract int DoStudy();

        private Exception CreateException()
        {
            throw new NotPullingMaterialException();
        }

        protected abstract bool PullMaterial();
    }

    class Math : Subject
    {
        protected override int DoStudy()
        {
            int count = (new Random()).Next(1, 10);
            int score = 0;
            for(int index = 0; index < count; index++)
            {
                Console.WriteLine("수학에 대해서 좀 알게 되었다.");
                score += 10;
                Thread.Sleep(1000);
            }
            return score;
        }

        protected override void PullBook()
        {
            Console.WriteLine("수학 책을 꺼냈다.");
        }

        protected override bool PullMaterial()
        {
            Console.WriteLine("삼각자를 꺼냈다.");
            Console.WriteLine("연필를 꺼냈다.");
            Console.WriteLine("모눈종이를 꺼냈다.");
            return true;
        }
    }

    class English : Subject
    {
        protected override int DoStudy()
        {
            int count = (new Random()).Next(1, 10);
            int score = 0;
            for (int index = 0; index < count; index++)
            {
                Console.WriteLine("영어에 대해서 좀 알게 되었다.");
                score += 10;
                Thread.Sleep(1000);
            }
            return score;
        }

        protected override void PullBook()
        {
            Console.WriteLine("영어 책을 꺼냈다.");
        }

        protected override bool PullMaterial()
        {
            Console.WriteLine("연필를 꺼냈다.");
            Console.WriteLine("단어장을 꺼냈다.");
            return true;
        }

        protected override void OnPreStudy()
        {
            Console.WriteLine("영어 공부 전에 어제 공부한 내용을 생각했다.");
        }
    }


    class Template : IPattern
    {
        public void Start()
        {
            Subject subject = new Math();
            int score = subject.Study();
            
            subject = new English();
            score = subject.Study();
        }
    }
}

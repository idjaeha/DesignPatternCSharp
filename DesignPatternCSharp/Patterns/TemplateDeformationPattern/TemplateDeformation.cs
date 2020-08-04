using DesignPatternCSharp.Patterns;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;

namespace ConsoleApp1.DesignPattern
{
    delegate void MyAction();

    /// <summary>
    /// 템플릿 메서드와 전략 패턴을 합친 메서드
    /// </summary>
    abstract class Speaker
    {         
        public void Play(MyAction action)
        {
            Prepare();
            action();
            OffSpeaker();
            Console.WriteLine("\n");
        }

        protected abstract void OffSpeaker();
        protected abstract void Prepare();
    }

    class Radio : Speaker
    {
        protected override void OffSpeaker()
        {
            Console.WriteLine("콘센트를 뽑습니다.");
        }

        protected override void Prepare()
        {
            Console.WriteLine("콘센트를 꽂습니다.");
        }
    }

    class BluetoothSpeaker : Speaker
    {
        protected override void OffSpeaker()
        {
            Console.WriteLine("페어링을 해제합니다.");
        }

        protected override void Prepare()
        {
            Console.WriteLine("페어링을 연결합니다.");
        }
    }

    class TemplateDeformation : IPattern
    {
        public void Start()
        {
            MyAction radioAction = delegate ()
            {
                Console.WriteLine("지지직...");
                Thread.Sleep(500);
                Console.WriteLine("앨범이 흘러나옵니다.");
            };

            MyAction bluetoothAction = () =>
            {
                Console.WriteLine("소리가 울려 퍼집니다.");
            };

            Speaker speaker = new Radio();
            speaker.Play(radioAction);

            speaker = new BluetoothSpeaker();
            speaker.Play(bluetoothAction);
        }
    }
}

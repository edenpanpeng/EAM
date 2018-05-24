using System;

namespace ExecuteAroundMethodPattern
{
    internal sealed class Resource
    {
        public static void Do(Action<Resource> act)
        {
            var resource = new Resource();
            try
            {
                act(resource);
            }
            finally
            {
                resource.Clean();
            }
        }

        public void StepOne()
        {
            Console.WriteLine("step 1: Take your pan.");
        }

        public void StepTwo()
        {
            Console.WriteLine("step 2: Pour two cups of water into pan.");
        }

        private void Clean()
        {
            Console.WriteLine("Clean up the resource.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Injection5_4.Mocking;

namespace Dependency_Injection5_4.Mocking
{
    public class Program
    {
        public static void Main()
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle(new FileReader());
        }
    }
}

namespace Dependency_Injection5_4
{
    class VideoService
    {
        public VideoService()
        {
        }

        internal object ReadVideoTitle(IFileReader fileReader)
        {
            throw new NotImplementedException();
        }
    }
}
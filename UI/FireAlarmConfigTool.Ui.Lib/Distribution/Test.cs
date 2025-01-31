using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireAlarmConfigTool.Logic.Http.Client.Api;
using LogicTest = FireAlarmConfigTool.Logic.Lib.Test;


namespace FireAlarmConfigTool.Ui.Lib.Distribution
{
    static public class Test
    {
        static bool local = true;
        static public String TestMethod()
        {
            String result;
            if (local)
            {
                result = LogicTest.Test.testFunction(11000);
                Console.WriteLine(result);
            }
            else
            {
                DefaultApi api = new DefaultApi();
                result = api.TestGet(1111111111);
                Console.WriteLine(result);
            }
            return result;
        }

        static public void Switch()
        {
            if(local)
            {
                local = false;
            }
            else
            {
                local = true;
            }
        }
    }
}

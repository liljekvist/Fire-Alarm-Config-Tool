using System.Diagnostics;
using FireAlarmConfigTool.Logic.Http.Client.Api;
using Microsoft.Extensions.Logging;
using LogicTest = FireAlarmConfigTool.Logic.Lib.Test;

namespace FireAlarmConfigTool.Ui.Lib.Distribution
{
    public class Test : ITest
    {
        private readonly ILogger<Test> _logger;
        private bool _local = true;
        private readonly IDefaultApi _api;

        // Constructor to inject dependencies
        public Test(IDefaultApi api, ILogger<Test> logger)
        {
            _api = api;
            _logger = logger;
        }

        public async Task<string> TestMethod()
        {
            string result;
            // response time mesurment
            try
            {
                if(_local)
                {
                    result = LogicTest.Test.testFunction(10101010);
                }
                else
                {
                    // Start the stopwatch
                    var watch = Stopwatch.StartNew();
                    result = await _api.TestGetAsync(1111111111);
                    // Stop the stopwatch
                    watch.Stop();
                    result += " Response time: " + watch.ElapsedMilliseconds + "ms";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in TestMethod.");
                throw;
            }

            _logger.LogInformation("Result: {Result}", result);
            return result;
        }

        public void Switch()
        {
            _local = !_local;
            _logger.LogInformation("Switched to {Mode} mode.", _local ? "local" : "API");
        }
    }
}
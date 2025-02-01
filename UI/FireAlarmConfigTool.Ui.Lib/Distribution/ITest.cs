namespace FireAlarmConfigTool.Ui.Lib.Distribution;

public interface ITest
{
    public Task<string> TestMethod();
    public void Switch();
}
using System;

public abstract class ReportGenerator
{
    // Шаблонный метод
    public void GenerateReport()
    {
        CollectData();
        ProcessData();
        FormatReport();
        ExportReport();
    }
    protected abstract void CollectData();
    protected abstract void ProcessData();
    protected abstract void FormatReport();

    // Конкретный метод
    private void ExportReport()
    {
        Console.WriteLine("Отчет сделан.");
    }
}
public class StudentReportGenerator : ReportGenerator
{
    protected override void CollectData()
    {
        Console.WriteLine("Собраны данные о студентах.");
    }
    protected override void ProcessData()
    {
        Console.WriteLine("Обработаны данные о студентах.");
    }
    protected override void FormatReport()
    {
        Console.WriteLine("Отчет о студентах отформатирован.");
    }
}
public class CourseReportGenerator : ReportGenerator
{
    protected override void CollectData()
    {
        Console.WriteLine("Собраны данные о курсах.");
    }
    protected override void ProcessData()
    {
        Console.WriteLine("Обработаны данные о курсах.");
    }
    protected override void FormatReport()
    {
        Console.WriteLine("Отчет о курсах отформатирован.");
    }
}
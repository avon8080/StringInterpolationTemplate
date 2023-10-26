using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        return date;
    }

    public string Number03()
    {
        var date = $"Day {_date.Now:dd} of {_date.Now:MMMM, yyyy}";
        return date;
    }

    public string Number04()
    {
        var date = $"Year:{_date.Now: yyyy}, Month:{_date.Now: MM}, Day:{_date.Now: dd}";
        return date;
    }

    public string Number05()
    {
        var date = $"{_date.Now,10: dddd}";
        return date;
    }

    public string Number06()
    {
        var date = $"{_date.Now, 10: hh:mm tt}{_date.Now, 10: dddd}";
        Console.WriteLine(date);
        return date;
    }

    public string Number07()
    {
        var date = $"h:{_date.Now:hh}, m:{_date.Now:mm}, s:{_date.Now:ss}";
        return date;
    }

    public string Number08()
    {
        var date = $"{_date.Now:yyyy.MM.dd.hh.mm.ss}";
        return date;
    }

    public string Number09()
    {
        var answer = $"{Math.PI:c2}";
        return answer;
    }

    public string Number10()
    {
        var answer = $"{Math.PI,10:n3}";

        return answer;
    }

    public string Number11()
    {
        var year = _date.Now.Year;
        var hexa = $"{year:X}";
        return hexa;
    }

    //2.2019.01.22
}

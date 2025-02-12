using System;
using Serilog;

/*
public interface ITextFormatter {

    string Format(string text);

}

public class UpperCaseFormatter : ITextFormatter {

    public string Format(string text) {

        return text.ToUpper();

    }
}

public class LowerCaseFormatter : ITextFormatter {

    public string Format(string text) {

        return text.ToLower();

    }
}

public class TitleCaseFormatter : ITextFormatter {

    public string Format(string text) {

        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());

    }
}

public class TextEditor {

    private ITextFormatter _formatter;

    public TextEditor(ITextFormatter formatter) {

        _formatter = formatter;

    }

    public void SetFormatter(ITextFormatter formatter) {

        _formatter = formatter;

    }

    public string FormatText(string text) {

        return _formatter.Format(text);

    }
}

public class Program {

    public static void Main(string[] args) {

        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        TextEditor editor = new TextEditor(new UpperCaseFormatter());
        Log.Information(editor.FormatText("ПРИВІТ СВІТ!")); 

        editor.SetFormatter(new LowerCaseFormatter());
        Log.Information(editor.FormatText("Привіт Світ!")); 

        editor.SetFormatter(new TitleCaseFormatter());
        Log.Information(editor.FormatText("привіт світ!")); 

    }
}
*/

/*
public class Projector {

    public void TurnOn() {

        Log.Information("Проектор увімкнено");

    }

    public void TurnOff() {

        Log.Information("Проектор вимкнено");

    }
}

public class SoundSystem {

    public void SetVolume(int volume) {

        Log.Information($"Гучність встановлено на {volume}");

    }

    public void Mute() {

        Log.Information("Звук вимкнено");

    }
}

public class StreamingService {

    public void PlayMovie(string title) {

        Log.Information($"Фільм '{title}' відтворюється");

    }

    public void StopMovie() {

        Log.Information("Фільм зупинено");

    }
}

public class SmartHome {

    private Projector _projector;
    private SoundSystem _soundSystem;
    private StreamingService _streamingService;

    public SmartHome() {

        _projector = new Projector();
        _soundSystem = new SoundSystem();
        _streamingService = new StreamingService();

    }

    public void StartMovie(string title) {

        _projector.TurnOn();
        _soundSystem.SetVolume(50);
        _streamingService.PlayMovie(title);

    }

    public void StopMovie() {

        _streamingService.StopMovie();
        _projector.TurnOff();
        _soundSystem.Mute();

    }
}

public class Program {

    public static void Main(string[] args) {

        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        SmartHome smartHome = new SmartHome();
        smartHome.StartMovie("Початок");
        smartHome.StopMovie();

    }
}
*/

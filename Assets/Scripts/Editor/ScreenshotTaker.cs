using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScreenshotTaker
{
    [MenuItem("FloppyDot/Take Screenshot")]
    private static void TakeScreenshot()
    {
        ScreenCapture.CaptureScreenshot(@"H:\Unity\GithubRepos\game-tiptop-master\src\Recordings/screenshot.png");
    }
}

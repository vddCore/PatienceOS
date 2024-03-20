using PatienceOS.Kernel;

internal unsafe class Program
{
    private const int VideoBaseAddress = 0xb8000;

    internal static int Main()
    {
        // Reverse engineering natively-compiled .NET apps
        // https://migeel.sk/blog/2023/09/15/reverse-engineering-natively-compiled-dotnet-apps/

        var frameBuffer = new FrameBuffer((byte*)VideoBaseAddress);
        var console = new Console(ConsoleMode.VGA_80x25, frameBuffer);


        console.Clear();


        //Ascii art courtesy of https://www.asciiart.eu/text-to-ascii-art
        //Doom font, width 80

        console.Print(@"                                                                                ");
        console.Print(@"   ______     _   _                      _____ _____                            ");
        console.Print(@"   | ___ \   | | (_)                    |  _  /  ___|                           ");
        console.Print(@"   | |_/ /_ _| |_ _  ___ _ __   ___ ___ | | | \ `--.                            ");
        console.Print(@"   |  __/ _` | __| |/ _ \ '_ \ / __/ _ \| | | |`--. \                           ");
        console.Print(@"   | | | (_| | |_| |  __/ | | | (_|  __/\ \_/ /\__/ /                           ");
        console.Print(@"   \_|  \__,_|\__|_|\___|_| |_|\___\___| \___/\____/                            ");


        return 0;
    }
}
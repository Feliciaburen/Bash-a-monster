using Bash_a_monster;
using Raylib_cs;

namespace Bash_a_monster;

class Program
{
    static bool hit = false;
    static int health = 100;

    static Rectangle player1Rectangle;
    static Rectangle player2Rectangle;

    static void Main(string[] args)
    {
        Raylib.InitWindow(600, 600, "Bash-a-monster");
        Raylib.SetTargetFPS(60);

        // skapa två spelare 
        player1Rectangle = new Rectangle(100, 500, 30, 50);

        player2Rectangle = new Rectangle(500, 500, 30, 50);

        while (!Raylib.WindowShouldClose())
        {
            Start();
        }
    }

    // Rita ut spelet
    static void Start()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.BLUE);

        // Rita ut spelarna 
        Raylib.DrawRectangle((int)player1Rectangle.x, (int)player1Rectangle.y, 30, 50, Color.WHITE);

        Raylib.EndDrawing();
    }
}

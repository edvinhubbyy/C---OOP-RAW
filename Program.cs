using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {

            GraphicEditor editor = new GraphicEditor();

            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            editor.Draw(circle);
            editor.Draw(rectangle);
            editor.Draw(square);

        }
    }
}

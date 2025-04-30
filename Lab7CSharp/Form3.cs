using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form3 : Form
{
    private Shape[] shapes;
    private Random rand = new Random();

    public Form3()
    {
        InitializeComponent();
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        int count = (int)numericUpDownCount.Value; // Кількість фігур
        shapes = new Shape[count]; // Ініціалізація масиву фігур

        // Створення об'єкта Bitmap для малювання
        Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        Graphics g = Graphics.FromImage(bmp);
        g.Clear(Color.White); // Очищення полотна

        // Вибір типу фігури з ComboBox
        string selectedShapeType = comboBoxShapeType.SelectedItem.ToString();

        // Введення розмірів
        int width = (int)numericUpDownWidth.Value;
        int height = (int)numericUpDownHeight.Value;
        Color selectedColor = colorDialog1.Color;

        // Генерація фігур
        for (int i = 0; i < count; i++)
        {
            // Випадкова позиція фігури на полотні
            Point pos = new Point(rand.Next(0, pictureBox1.Width - width), rand.Next(0, pictureBox1.Height - height));

            // Вибір типу фігури
            Shape shape = null;
            switch (selectedShapeType)
            {
                case "Еліпс":
                    shape = new EllipseShape(pos, new Size(width, height), selectedColor);
                    break;
                case "Прямокутник з заокругленими кутами":
                    shape = new RoundedRectangleShape(pos, new Size(width, height), selectedColor);
                    break;
                case "Дуга":
                    shape = new ArcShape(pos, new Size(width, height), selectedColor);
                    break;
                case "Сектор":
                    shape = new SectorShape(pos, new Size(width, height), selectedColor);
                    break;
                default:
                    shape = new EllipseShape(pos, new Size(width, height), selectedColor);
                    break;
            }

            shapes[i] = shape;
            shapes[i].Draw(g); 
        }

        // Встановлюємо згенероване зображення в PictureBox
        pictureBox1.Image = bmp;
    }

    private void btnChooseColor_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            btnChooseColor.BackColor = colorDialog1.Color;
        }
    }
}

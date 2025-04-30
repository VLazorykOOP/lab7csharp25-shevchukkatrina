using System.Drawing;
using System.Windows.Forms;
using System;

partial class Form3
{
    private PictureBox pictureBox1;
    private Button btnGenerate;
    private NumericUpDown numericUpDownCount;
    private ComboBox comboBoxShapeType;
    private NumericUpDown numericUpDownWidth;
    private NumericUpDown numericUpDownHeight;
    private Button btnChooseColor;
    private ColorDialog colorDialog1;

    private void InitializeComponent()
    {
        this.pictureBox1 = new PictureBox();
        this.btnGenerate = new Button();
        this.numericUpDownCount = new NumericUpDown();
        this.comboBoxShapeType = new ComboBox();
        this.numericUpDownWidth = new NumericUpDown();
        this.numericUpDownHeight = new NumericUpDown();
        this.btnChooseColor = new Button();
        this.colorDialog1 = new ColorDialog();

        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
        this.SuspendLayout();

        // pictureBox1
        this.pictureBox1.Location = new Point(20, 20);
        this.pictureBox1.Size = new Size(500, 400);
        this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;

        // btnGenerate
        this.btnGenerate.Location = new Point(540, 30);
        this.btnGenerate.Size = new Size(200, 30);
        this.btnGenerate.Text = "Згенерувати фігури";
        this.btnGenerate.Click += new EventHandler(this.btnGenerate_Click);

        // numericUpDownCount
        this.numericUpDownCount.Location = new Point(540, 70);
        this.numericUpDownCount.Minimum = 1;
        this.numericUpDownCount.Maximum = 100;
        this.numericUpDownCount.Value = 5;

        // comboBoxShapeType
        this.comboBoxShapeType.Location = new Point(540, 110);
        this.comboBoxShapeType.Items.AddRange(new object[] { "Еліпс", "Прямокутник з заокругленими кутами", "Дуга", "Сектор" });
        this.comboBoxShapeType.SelectedIndex = 0;

        // numericUpDownWidth
        this.numericUpDownWidth.Location = new Point(540, 150);
        this.numericUpDownWidth.Minimum = 20;
        this.numericUpDownWidth.Maximum = 200;
        this.numericUpDownWidth.Value = 50;

        // numericUpDownHeight
        this.numericUpDownHeight.Location = new Point(540, 190);
        this.numericUpDownHeight.Minimum = 20;
        this.numericUpDownHeight.Maximum = 200;
        this.numericUpDownHeight.Value = 50;

        // btnChooseColor
        this.btnChooseColor.Location = new Point(540, 230);
        this.btnChooseColor.Size = new Size(200, 30);
        this.btnChooseColor.Text = "Вибрати колір";
        this.btnChooseColor.Click += new EventHandler(this.btnChooseColor_Click);

        // Form3
        this.ClientSize = new Size(760, 460);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.btnGenerate);
        this.Controls.Add(this.numericUpDownCount);
        this.Controls.Add(this.comboBoxShapeType);
        this.Controls.Add(this.numericUpDownWidth);
        this.Controls.Add(this.numericUpDownHeight);
        this.Controls.Add(this.btnChooseColor);
        this.Text = "Малювання фігур";

        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
        this.ResumeLayout(false);
    }
}

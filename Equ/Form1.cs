using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equ.Logic.Model;
using Equ.Logic.Controller;

namespace Equ
{
    public partial class Main : Form
    {
        private PaintController paintController = new PaintController();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Draw(Equation equation, double step, double radiusSize)
        {
            graph.Series[0].Points.Clear();

            var list = paintController.GetDrawData(equation, step, radiusSize);

            foreach (var point in list)
            {
                graph.Series[0].Points.AddXY(point.X, point.Y);
            }
        }

        private void OutExtraInfo(Equation equation)
        {
            // Отвратительная хуйня
            extra.Text = "Направление ветвей: " + (paintController.GetBranchesDirection(equation) ? "вверх" : "вниз") + ";\n"
                       + $"Область определений: {paintController.GetDomain()}" + ";\n"
                       + $"Область значений: {paintController.GetRangeOfValues(equation)}" + ";\n"
                       + $"Вершина параболы: {paintController.GetVertex(equation)}" + ";\n";
        }

        private void OutSolution(Equation equation)
        {
            answer.Text = equation + " = 0" + ";\n"
                        + $"D = {Equation.GetSimpleSign(equation.B)}² - 4 * {Equation.GetSimpleSign(equation.A)} * {Equation.GetSimpleSign(equation.C)}" + ";\n";
            if (equation.HasSolution)
            {
                answer.Text += $"x = ({equation.B} + {Math.Sqrt(equation.B * equation.B - 4 * equation.A * equation.C)}) / (2 * {Equation.GetSimpleSign(equation.A)}) = {equation.Roots.X}" + ";\n"
                            + $"x = ({equation.B} + {Math.Sqrt(equation.B * equation.B - 4 * equation.A * equation.C)}) / (2 * {Equation.GetSimpleSign(equation.A)}) = {equation.Roots.Y}" + ";\n"
                            + $"Ответ: {equation.Roots}.";
            }
            else
            {
                answer.Text += "D < 0" + ";\n"
                            + "Ответ: решений нет.";
            }
        }

        private void buttonEnterCalculate_Click(object sender, EventArgs e)
        {
            double a, b, c, step, radiusSize;

            if (!GetInput(textBoxA.Text, out a)) return;
            if (!GetInput(textBoxB.Text, out b)) return;
            if (!GetInput(textBoxC.Text, out c)) return;
            if (!GetInput(textBoxStep.Text, out step)) return;
            if (!GetInput(textBoxRadiusSize.Text, out radiusSize)) return;

            var equation = new Equation(a, b, c);

            // Расчет уравнения

            OutSolution(equation);

            if (equation.HasSolution)
            {
                Draw(equation, step, radiusSize);
                OutExtraInfo(equation);
            }
            

        }

        private bool GetInput(string str, out double value)
        {
            value = 0;
            if (double.TryParse(str, out double result))
            {
                value = result;
                return true;
            }
            else
            {
                answer.Text = "Вы неверно ввели одно из значений.";
                return false;
            }
        }
    }
}

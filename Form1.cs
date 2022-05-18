using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace knowledge_base
{
    public partial class Form1 : Form
    {   
        public class Sign
        {
            public static int binary = 0;
            public static int enumeration = 1;
            public static int interval = 2;

            public string name;
            public int type;

            public string getName() { return name; }

            public string getType()
            {
                if (type == binary) return "бинарный";
                if (type == enumeration) return "перечислимый";
                if (type == interval) return "интервальный";
                return "ошибка";
            }

            public string getValue()
            {
                return value.getValue();
            }

            public Value value;
            public Sign(string n,string t)
            {
                name = n;
                switch (t)
                {
                    case "бинарный":
                        type = binary;
                        value = new ValueBinary();
                        break;
                    case "перечислимый":
                        type = enumeration;
                        value = new ValueEnum();
                        break;
                    case "интервальный":
                        type = interval;
                        value = new ValueInterval();
                        break;
                }
            }
            public Sign(string n, int t)
            {
                name = n;
                type = t;
                switch (t)
                {
                    case 0:
                        value = new ValueBinary();
                        break;
                    case 1:
                        value = new ValueEnum();
                        break;
                    case 2:
                        value = new ValueInterval();
                        break;
                }
            }           
        }

        public abstract class Value {
            public abstract void setValue(string s);
            public abstract string getValue();
            public abstract bool isFit(string s);
            public abstract bool isCorrectSet(string s);
        };

        public class ValueBinary: Value
        {
            List<string> values;
            public ValueBinary()
            {
             
            }

            public override void setValue(string s)
            {
                if (s.Split(',').Length == 2)
                {
                    values = new List<string> { "да", "нет" };
                }
                else
                {
                    if (s == "да")
                        values = new List<string> { "да" };
                    else
                        values = new List<string> { "нет" };
                }
            }

            public override string getValue()
            {
                string output = string.Join(',', values);
                return output;
            }

            public override bool isFit(string s)
            {
                foreach (var v in values)                
                    if (v == s)                   
                        return true;                                    
                return false;
            }

            public override bool isCorrectSet(string s)
            {
                foreach (string p in s.Split(','))
                    if (p != "да" && p != "нет")
                        return false;

                return true;
            }
        }

        public class ValueEnum: Value
        {
            List<string> values;
            public ValueEnum()
            {
                values = new List<string>();
            }
            
            public override void setValue(string s)
            {
                values = new List<string>();
                string[] parts = s.Split(',');
                foreach (string part in parts)
                    values.Add(part);
            }

            public override string getValue()
            {
                string output = string.Join(',',values);               
                return output;
            }

            public override bool isFit(string s)
            {
                foreach (var v in values)
                    if (v == s)
                        return true;
                return false;
            }

            public override bool isCorrectSet(string s)
            {
                return true;
            }
        }

        public class ValueInterval: Value
        {
            float leftValue;
            float rightValue;

            public ValueInterval() { }
           
            public override void setValue(string s)
            {
                string[] parts = s.Split(':');
                IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                leftValue = float.Parse(parts[0], formatter);
                rightValue = float.Parse(parts[1], formatter);
            }

            public override string getValue()
            {
                return leftValue.ToString() + ":" + rightValue.ToString();
            }

            public override bool isFit(string s)
            {
                IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                float currValue = float.Parse(s);
                if (leftValue <= currValue && currValue <= rightValue)
                    return true;
                else
                    return false;
            }

            public override bool isCorrectSet(string s)
            {
                if (s.Split(':').Length != 2)
                    return false;
                else
                    return true;
            }
        }

        List<Sign> signList; 

        class MetalClass
        {
            public string name;
            public List<Sign> valuesForSigns;
            public int rating;

            public MetalClass(string s)
            {
                name = s;
                valuesForSigns = new List<Sign>();
                rating = 0;
            }
            public MetalClass()
            {
                valuesForSigns = new List<Sign>();
                rating = 0;
            }
        }

        List<MetalClass> classes;
        List<Control> refactorSignElem;
        List<Control> refactorClassElem;
        MetalClass tempClass;
        bool isAdding = false;
        bool isAddingClass = false;
        Sign tempSign;
        
        public Form1()
        {
            InitializeComponent();
            signList = new List<Sign>();
            classes = new List<MetalClass>();
            chooseType.SelectedIndex = 0;
            refactorSignElem = new List<Control>
            {
                nameSignLabel,
                typeSignLabel,
                chooseType,
                nameSignText,
                valuesLabel,
                valuesTextBox,
                okSignButton
            };
            refactorClassElem = new List<Control>
            {
                nameClassLabel,
                nameClassText,               
                valuesForClassLabel,
                saveClassButton,
                signsForClassView
            };
            foreach (var elem in refactorSignElem)
                elem.Enabled = false;
            foreach (var elem in refactorClassElem)
                elem.Enabled = false;
        }


        private void updateSignView()
        {
            signsGrid.Rows.Clear();
            resultSignsView.Rows.Clear();
            foreach (var e in signList) 
            {
                signsGrid.Rows.Add(e.getName(), e.getType(), e.getValue());
                resultSignsView.Rows.Add(e.getName(), "-");
            }
        }

        private void addSignButton_Click(object sender, EventArgs e)
        {
            foreach (var elem in refactorSignElem)
                elem.Enabled = true;
            isAdding = true;
        }

        private void changeSignButton_Click(object sender, EventArgs e)
        {
            tempSign = signList[signsGrid.CurrentCell.RowIndex];
            if (tempSign == null)
            {
                MessageBox.Show("Признак не выбран");
                return;
            }
            foreach (var elem in refactorSignElem)
                elem.Enabled = true;            
            nameSignText.Text = tempSign.getName();
            chooseType.SelectedIndex = tempSign.type;
            valuesTextBox.Text = tempSign.getValue();
            isAdding = false;
        }
        private void okSignButton_Click(object sender, EventArgs e)
        {
            if (isAdding) // добавить новый признак
            {
                Sign sign = new Sign(nameSignText.Text, chooseType.SelectedIndex);
                if (!sign.value.isCorrectSet(valuesTextBox.Text))
                {
                    MessageBox.Show("Неверный формат значения");
                    return;
                }
                sign.value.setValue(valuesTextBox.Text);
                signList.Add(sign);
                signsGrid.Rows.Add(sign.getName(), sign.getType(), sign.getValue());
            }
            else
            {
                if (!tempSign.value.isCorrectSet(valuesTextBox.Text))
                {
                    MessageBox.Show("Неверный формат значения");
                    return;
                }
                tempSign.name = nameSignText.Text;
                tempSign.type = chooseType.SelectedIndex;
                tempSign.value.setValue(valuesTextBox.Text);
            }
            updateSignView();
            nameSignText.Text = "";
            valuesTextBox.Text = "";
            foreach (var elem in refactorSignElem)
                elem.Enabled = false;
        }


        private void chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chooseType.SelectedIndex)
            {
                case 0:
                    valuesLabel.Text = "Значения 'да' или 'нет' через ','";
                    break;
                case 1:
                    valuesLabel.Text = "Значения через ','";
                    break;
                case 2:
                    valuesLabel.Text = "Значения в виде a:b";
                    break;
            }
        }

        public void setClassView()
        {
            classGrid.Rows.Clear();
            string name = "";
            foreach (var e in classes) {
                name = e.name;
                foreach (var t in e.valuesForSigns)
                {
                    classGrid.Rows.Add(name, t.name, t.getValue());
                    if (name != "")
                        name = "";
                }
            }
        }

        private void loadClassesButton_Click(object sender, EventArgs e)
        {
            if (signList.Count == 0)
            {
                MessageBox.Show("Список признаков пуст");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл|*.txt";
            openFileDialog.Title = "Выберите текстовый файл";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName);
                string line;
                Sign sign;
                Sign signinlist = null;
                int indRow = 0;
                MetalClass metal = null;
                string name;
                bool flag = false;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("[")) // значит начало класса
                    {
                        if (!flag)
                            flag = true;
                        else
                            classes.Add(metal); // сохраняем предыдущий
                        name = line.Substring(1, line.Length - 2);
                        metal = new MetalClass(name);
                    }
                    else // значит начало признака
                    {
                        string[] parts = line.Split(';');
                        foreach (var elem in signList)
                        {
                            if (elem.name == parts[0]) // находим этот признак в списке признаков
                            {
                                signinlist = elem;
                                break;
                            }
                        }
                        sign = new Sign(parts[0],signinlist.type);
                        sign.value.setValue(parts[1]);
                        metal.valuesForSigns.Add(sign);
                    }
                }
                classes.Add(metal);
                setClassView();
            }
        }

        private void loadSigns(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл|*.txt";
            openFileDialog.Title = "Выберите текстовый файл";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName);
                string line;
                Sign sign;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    sign = new Sign(parts[0], parts[1]);
                    sign.value.setValue(parts[2]);
                    signList.Add(sign);
                }
                updateSignView();
            }
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            isAddingClass = true;
            signsForClassView.Rows.Clear();
            foreach (var elem in refactorClassElem)
                elem.Enabled = true;
            foreach (var elem in signList)
                signsForClassView.Rows.Add(elem.name, "-");
        }

        private void changeClassButton_Click(object sender, EventArgs e)
        {
            signsForClassView.Rows.Clear();
            int rowInd = classGrid.CurrentCell.RowIndex;
            string nameClass = classGrid.Rows[rowInd].Cells[0].Value.ToString();
            if (nameClass == "")
            {
                MessageBox.Show("Выберите ячейку класса");
                return;
            }
            isAddingClass = false;
            foreach (var m in classes) // ищем класс для редактирования в списке
            {
                if (nameClass == m.name)
                {
                    tempClass = m;
                    break;
                }
            }
            foreach (var elem in refactorClassElem)
                elem.Enabled = true;
            // ставим в таблицу классов значения из tempClass
            foreach (Sign s in tempClass.valuesForSigns)
                signsForClassView.Rows.Add(s.name, s.getValue());
            nameClassText.Text = tempClass.name;
        }

        private void saveClassButton_Click(object sender, EventArgs e)
        {
            string nameSign;
            Sign sign;
            int type = -1;
            if (isAddingClass)
            {               
                MetalClass metal = new MetalClass(nameClassText.Text);                                
                // доделать
                foreach (DataGridViewRow row in signsForClassView.Rows) // добавляем к классу значения признаков
                {
                    if (row.Cells[1].Value == null)
                        break;
                    if (row.Cells[1].Value.ToString() == "-") // если значения в признаке нет пропускаем
                        continue;

                    nameSign = row.Cells[0].Value.ToString();
                    foreach(var s in signList) // ищем признак в списке признаков чтобы определить тип
                    {
                        if (nameSign == s.getName())
                        {
                            type = s.type;
                            break;
                        }
                    }
                    sign = new Sign(nameSign, type);
                    if (!sign.value.isCorrectSet(row.Cells[1].Value.ToString()))
                    {                       
                        MessageBox.Show("Неверный формат значения");
                        return;                       
                    }
                    sign.value.setValue(row.Cells[1].Value.ToString());
                    metal.valuesForSigns.Add(sign);
                }
                classes.Add(metal);
            }
            else
            {
                tempClass.valuesForSigns.Clear();
                foreach (DataGridViewRow row in signsForClassView.Rows) // добавляем к классу значения признаков
                {
                    if (row.Cells[1].Value == null)
                        break;
                    if (row.Cells[1].Value.ToString() == "-") // если значения в признаке нет пропускаем
                        continue;

                    nameSign = row.Cells[0].Value.ToString();
                    foreach (var s in signList) // ищем признак в списке признаков чтобы определить тип
                    {
                        if (nameSign == s.getName())
                        {
                            type = s.type;
                            break;
                        }
                    }
                    sign = new Sign(nameSign, type);
                    if (!sign.value.isCorrectSet(row.Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("Неверный формат значения");
                        return;
                    }
                    sign.value.setValue(row.Cells[1].Value.ToString());
                    tempClass.valuesForSigns.Add(sign);
                }
                tempClass.name = nameClassText.Text;
            }
            foreach (var elem in refactorClassElem)
                elem.Enabled = false;
            setClassView();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (classes.Count == 0 || signList.Count == 0)
            {
                MessageBox.Show("Не загружены классы или признаки");
                return;
            }
            bool flag = true;
            bool searchFlag = false;
            List<MetalClass> resultclasses = new List<MetalClass>();
            int searchInd = -1;
            resultDeterminateText.Text = "";
            resultProbabilityText.Text = "";
            string newLine = Environment.NewLine;
            foreach (MetalClass metal in classes)
            {
                metal.rating = 0;
                flag = true;
                foreach (Sign sign in metal.valuesForSigns)
                {
                    // находим каждый признак из каждого металла в списках введенных значений (непустых)
                    searchFlag = false;
                    for (int i=0;i<resultSignsView.Rows.Count;i++)
                    {
                        if (resultSignsView.Rows[i].Cells[0].Value == null)
                            continue;
                        if (resultSignsView.Rows[i].Cells[0].Value.ToString()==sign.name && resultSignsView.Rows[i].Cells[1].Value.ToString() != "-")
                        {
                            searchFlag = true;
                            searchInd = i;
                            break;
                        }
                    }
                    if (searchFlag) // если признак найден то проверка, подходит ли класс под значения
                    {
                        if (!sign.value.isFit(resultSignsView.Rows[searchInd].Cells[1].Value.ToString()))
                        {
                            flag = false;
                            metal.rating--;
                        }
                        else
                            metal.rating++;
                    }
                }
                if (flag) // если проверка пройдена добавляем этот класс в список подходящих
                {
                    resultclasses.Add(metal);
                }
            }
            if (resultclasses.Count == 0)
                resultDeterminateText.Text = "Классов не найдено";
            else
                foreach (MetalClass m in resultclasses) 
                {
                    resultDeterminateText.Text += m.name + newLine;
                }

            // теперь вероятности
            IEnumerable<MetalClass> results = from m in classes
                                              orderby m.rating descending
                                              select m;
            foreach (MetalClass m in results)
                resultProbabilityText.Text += m.name + " : " + m.rating + newLine;

        }

        private void saveSignsButton_Click(object sender, EventArgs e)
        {
            if (signList.Count == 0)
            {
                MessageBox.Show("Список признаков пуст");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл|*.txt";
            saveFileDialog.Title = "Выберите текстовый файл";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string newLine = Environment.NewLine;
                string outputString = "";
                foreach (Sign sign in signList)
                {
                    outputString += sign.name + ";" + sign.getType() + ";" + sign.getValue() + newLine;
                }
                System.IO.File.WriteAllText(saveFileDialog.FileName, outputString);
            }
        }

        private void saveClassesButton_Click(object sender, EventArgs e)
        {
            if (classes.Count == 0)
            {
                MessageBox.Show("Список классов пуст");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл|*.txt";
            saveFileDialog.Title = "Выберите текстовый файл";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string newLine = Environment.NewLine;
                string outputString = "";
                foreach (MetalClass metal in classes)
                {
                    outputString += "[" + metal.name + "]"+newLine;
                    foreach (Sign sign in metal.valuesForSigns)
                        outputString += sign.name + ";" + sign.getValue() + newLine;
                }
                System.IO.File.WriteAllText(saveFileDialog.FileName, outputString);
            }
        }
    }
}

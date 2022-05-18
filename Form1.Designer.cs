
namespace knowledge_base
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maintabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.okSignButton = new System.Windows.Forms.Button();
            this.valuesTextBox = new System.Windows.Forms.TextBox();
            this.valuesLabel = new System.Windows.Forms.Label();
            this.chooseType = new System.Windows.Forms.ComboBox();
            this.typeSignLabel = new System.Windows.Forms.Label();
            this.nameSignText = new System.Windows.Forms.TextBox();
            this.nameSignLabel = new System.Windows.Forms.Label();
            this.changeSignButton = new System.Windows.Forms.Button();
            this.addSignButton = new System.Windows.Forms.Button();
            this.signsGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.signsForClassView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveClassButton = new System.Windows.Forms.Button();
            this.valuesForClassLabel = new System.Windows.Forms.Label();
            this.nameClassText = new System.Windows.Forms.TextBox();
            this.nameClassLabel = new System.Windows.Forms.Label();
            this.changeClassButton = new System.Windows.Forms.Button();
            this.addClassButton = new System.Windows.Forms.Button();
            this.classGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resultProbabilityText = new System.Windows.Forms.TextBox();
            this.resultDeterminateText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.resultSignsView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSignsButton = new System.Windows.Forms.Button();
            this.loadClassesButton = new System.Windows.Forms.Button();
            this.maintabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signsGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signsForClassView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultSignsView)).BeginInit();
            this.SuspendLayout();
            // 
            // maintabControl
            // 
            this.maintabControl.Controls.Add(this.tabPage1);
            this.maintabControl.Controls.Add(this.tabPage2);
            this.maintabControl.Controls.Add(this.tabPage3);
            this.maintabControl.Location = new System.Drawing.Point(0, 47);
            this.maintabControl.Name = "maintabControl";
            this.maintabControl.SelectedIndex = 0;
            this.maintabControl.Size = new System.Drawing.Size(801, 404);
            this.maintabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.okSignButton);
            this.tabPage1.Controls.Add(this.valuesTextBox);
            this.tabPage1.Controls.Add(this.valuesLabel);
            this.tabPage1.Controls.Add(this.chooseType);
            this.tabPage1.Controls.Add(this.typeSignLabel);
            this.tabPage1.Controls.Add(this.nameSignText);
            this.tabPage1.Controls.Add(this.nameSignLabel);
            this.tabPage1.Controls.Add(this.changeSignButton);
            this.tabPage1.Controls.Add(this.addSignButton);
            this.tabPage1.Controls.Add(this.signsGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Признаки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // okSignButton
            // 
            this.okSignButton.Location = new System.Drawing.Point(632, 308);
            this.okSignButton.Name = "okSignButton";
            this.okSignButton.Size = new System.Drawing.Size(87, 23);
            this.okSignButton.TabIndex = 8;
            this.okSignButton.Text = "Применить";
            this.okSignButton.UseVisualStyleBackColor = true;
            this.okSignButton.Click += new System.EventHandler(this.okSignButton_Click);
            // 
            // valuesTextBox
            // 
            this.valuesTextBox.Location = new System.Drawing.Point(584, 230);
            this.valuesTextBox.Multiline = true;
            this.valuesTextBox.Name = "valuesTextBox";
            this.valuesTextBox.Size = new System.Drawing.Size(185, 55);
            this.valuesTextBox.TabIndex = 7;
            // 
            // valuesLabel
            // 
            this.valuesLabel.AutoSize = true;
            this.valuesLabel.Location = new System.Drawing.Point(563, 203);
            this.valuesLabel.Name = "valuesLabel";
            this.valuesLabel.Size = new System.Drawing.Size(63, 15);
            this.valuesLabel.TabIndex = 0;
            this.valuesLabel.Text = "Значения:";
            // 
            // chooseType
            // 
            this.chooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseType.FormattingEnabled = true;
            this.chooseType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.chooseType.Items.AddRange(new object[] {
            "бинарный",
            "перечислимый",
            "интервальный"});
            this.chooseType.Location = new System.Drawing.Point(632, 161);
            this.chooseType.Name = "chooseType";
            this.chooseType.Size = new System.Drawing.Size(137, 23);
            this.chooseType.TabIndex = 6;
            this.chooseType.SelectedIndexChanged += new System.EventHandler(this.chooseType_SelectedIndexChanged);
            // 
            // typeSignLabel
            // 
            this.typeSignLabel.AutoSize = true;
            this.typeSignLabel.Location = new System.Drawing.Point(584, 164);
            this.typeSignLabel.Name = "typeSignLabel";
            this.typeSignLabel.Size = new System.Drawing.Size(27, 15);
            this.typeSignLabel.TabIndex = 5;
            this.typeSignLabel.Text = "Тип";
            // 
            // nameSignText
            // 
            this.nameSignText.Location = new System.Drawing.Point(632, 115);
            this.nameSignText.Name = "nameSignText";
            this.nameSignText.Size = new System.Drawing.Size(137, 23);
            this.nameSignText.TabIndex = 4;
            // 
            // nameSignLabel
            // 
            this.nameSignLabel.AutoSize = true;
            this.nameSignLabel.Location = new System.Drawing.Point(567, 118);
            this.nameSignLabel.Name = "nameSignLabel";
            this.nameSignLabel.Size = new System.Drawing.Size(59, 15);
            this.nameSignLabel.TabIndex = 3;
            this.nameSignLabel.Text = "Название";
            // 
            // changeSignButton
            // 
            this.changeSignButton.Location = new System.Drawing.Point(672, 55);
            this.changeSignButton.Name = "changeSignButton";
            this.changeSignButton.Size = new System.Drawing.Size(99, 26);
            this.changeSignButton.TabIndex = 2;
            this.changeSignButton.Text = "Изменить";
            this.changeSignButton.UseVisualStyleBackColor = true;
            this.changeSignButton.Click += new System.EventHandler(this.changeSignButton_Click);
            // 
            // addSignButton
            // 
            this.addSignButton.Location = new System.Drawing.Point(567, 55);
            this.addSignButton.Name = "addSignButton";
            this.addSignButton.Size = new System.Drawing.Size(99, 26);
            this.addSignButton.TabIndex = 1;
            this.addSignButton.Text = "Добавить";
            this.addSignButton.UseVisualStyleBackColor = true;
            this.addSignButton.Click += new System.EventHandler(this.addSignButton_Click);
            // 
            // signsGrid
            // 
            this.signsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.signsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.signsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.value});
            this.signsGrid.EnableHeadersVisualStyles = false;
            this.signsGrid.Location = new System.Drawing.Point(8, 28);
            this.signsGrid.Name = "signsGrid";
            this.signsGrid.RowTemplate.Height = 25;
            this.signsGrid.Size = new System.Drawing.Size(535, 304);
            this.signsGrid.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value.HeaderText = "Возможные значения";
            this.value.Name = "value";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.signsForClassView);
            this.tabPage2.Controls.Add(this.saveClassButton);
            this.tabPage2.Controls.Add(this.valuesForClassLabel);
            this.tabPage2.Controls.Add(this.nameClassText);
            this.tabPage2.Controls.Add(this.nameClassLabel);
            this.tabPage2.Controls.Add(this.changeClassButton);
            this.tabPage2.Controls.Add(this.addClassButton);
            this.tabPage2.Controls.Add(this.classGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Классы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // signsForClassView
            // 
            this.signsForClassView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.signsForClassView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.signValue});
            this.signsForClassView.Location = new System.Drawing.Point(508, 151);
            this.signsForClassView.Name = "signsForClassView";
            this.signsForClassView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.signsForClassView.RowHeadersVisible = false;
            this.signsForClassView.RowTemplate.Height = 25;
            this.signsForClassView.Size = new System.Drawing.Size(255, 176);
            this.signsForClassView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Признак";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // signValue
            // 
            this.signValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.signValue.HeaderText = "Значение";
            this.signValue.Name = "signValue";
            // 
            // saveClassButton
            // 
            this.saveClassButton.Location = new System.Drawing.Point(586, 343);
            this.saveClassButton.Name = "saveClassButton";
            this.saveClassButton.Size = new System.Drawing.Size(88, 24);
            this.saveClassButton.TabIndex = 9;
            this.saveClassButton.Text = "Сохранить";
            this.saveClassButton.UseVisualStyleBackColor = true;
            this.saveClassButton.Click += new System.EventHandler(this.saveClassButton_Click);
            // 
            // valuesForClassLabel
            // 
            this.valuesForClassLabel.AutoSize = true;
            this.valuesForClassLabel.Location = new System.Drawing.Point(554, 122);
            this.valuesForClassLabel.Name = "valuesForClassLabel";
            this.valuesForClassLabel.Size = new System.Drawing.Size(146, 15);
            this.valuesForClassLabel.TabIndex = 7;
            this.valuesForClassLabel.Text = " Значения для признаков";
            // 
            // nameClassText
            // 
            this.nameClassText.Location = new System.Drawing.Point(611, 80);
            this.nameClassText.Name = "nameClassText";
            this.nameClassText.Size = new System.Drawing.Size(144, 23);
            this.nameClassText.TabIndex = 4;
            // 
            // nameClassLabel
            // 
            this.nameClassLabel.AutoSize = true;
            this.nameClassLabel.Location = new System.Drawing.Point(506, 83);
            this.nameClassLabel.Name = "nameClassLabel";
            this.nameClassLabel.Size = new System.Drawing.Size(99, 15);
            this.nameClassLabel.TabIndex = 3;
            this.nameClassLabel.Text = "Название класса";
            // 
            // changeClassButton
            // 
            this.changeClassButton.Location = new System.Drawing.Point(637, 36);
            this.changeClassButton.Name = "changeClassButton";
            this.changeClassButton.Size = new System.Drawing.Size(90, 27);
            this.changeClassButton.TabIndex = 2;
            this.changeClassButton.Text = "Изменить";
            this.changeClassButton.UseVisualStyleBackColor = true;
            this.changeClassButton.Click += new System.EventHandler(this.changeClassButton_Click);
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(508, 36);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(97, 27);
            this.addClassButton.TabIndex = 1;
            this.addClassButton.Text = "Добавить";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // classGrid
            // 
            this.classGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.sign,
            this.dataGridViewTextBoxColumn2});
            this.classGrid.Location = new System.Drawing.Point(8, 27);
            this.classGrid.Name = "classGrid";
            this.classGrid.RowTemplate.Height = 25;
            this.classGrid.Size = new System.Drawing.Size(467, 316);
            this.classGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // sign
            // 
            this.sign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sign.HeaderText = "Признак";
            this.sign.Name = "sign";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Значения";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.resultProbabilityText);
            this.tabPage3.Controls.Add(this.resultDeterminateText);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.resultButton);
            this.tabPage3.Controls.Add(this.resultSignsView);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вывод";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // resultProbabilityText
            // 
            this.resultProbabilityText.Location = new System.Drawing.Point(552, 64);
            this.resultProbabilityText.Multiline = true;
            this.resultProbabilityText.Name = "resultProbabilityText";
            this.resultProbabilityText.ReadOnly = true;
            this.resultProbabilityText.Size = new System.Drawing.Size(222, 286);
            this.resultProbabilityText.TabIndex = 5;
            // 
            // resultDeterminateText
            // 
            this.resultDeterminateText.Location = new System.Drawing.Point(314, 64);
            this.resultDeterminateText.Multiline = true;
            this.resultDeterminateText.Name = "resultDeterminateText";
            this.resultDeterminateText.ReadOnly = true;
            this.resultDeterminateText.Size = new System.Drawing.Size(222, 286);
            this.resultDeterminateText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вероятностный";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Детерминированный";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(70, 327);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(134, 23);
            this.resultButton.TabIndex = 1;
            this.resultButton.Text = "Получить класс";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // resultSignsView
            // 
            this.resultSignsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultSignsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.resultSignsView.Location = new System.Drawing.Point(27, 36);
            this.resultSignsView.Name = "resultSignsView";
            this.resultSignsView.RowHeadersVisible = false;
            this.resultSignsView.RowTemplate.Height = 25;
            this.resultSignsView.Size = new System.Drawing.Size(240, 272);
            this.resultSignsView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Признак";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // addSignsButton
            // 
            this.addSignsButton.Location = new System.Drawing.Point(270, 13);
            this.addSignsButton.Name = "addSignsButton";
            this.addSignsButton.Size = new System.Drawing.Size(134, 28);
            this.addSignsButton.TabIndex = 1;
            this.addSignsButton.Text = "Загрузить признаки";
            this.addSignsButton.UseVisualStyleBackColor = true;
            this.addSignsButton.Click += new System.EventHandler(this.loadSigns);
            // 
            // loadClassesButton
            // 
            this.loadClassesButton.Location = new System.Drawing.Point(437, 13);
            this.loadClassesButton.Name = "loadClassesButton";
            this.loadClassesButton.Size = new System.Drawing.Size(126, 28);
            this.loadClassesButton.TabIndex = 2;
            this.loadClassesButton.Text = "Загрузить классы";
            this.loadClassesButton.UseVisualStyleBackColor = true;
            this.loadClassesButton.Click += new System.EventHandler(this.loadClassesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadClassesButton);
            this.Controls.Add(this.addSignsButton);
            this.Controls.Add(this.maintabControl);
            this.Name = "Form1";
            this.Text = "База знаний";
            this.maintabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signsGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signsForClassView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultSignsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl maintabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView signsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button addSignsButton;
        private System.Windows.Forms.Button changeSignButton;
        private System.Windows.Forms.Button addSignButton;
        private System.Windows.Forms.ComboBox chooseType;
        private System.Windows.Forms.Label typeSignLabel;
        private System.Windows.Forms.TextBox nameSignText;
        private System.Windows.Forms.Label nameSignLabel;
        private System.Windows.Forms.Label valuesLabel;
        private System.Windows.Forms.TextBox valuesTextBox;
        private System.Windows.Forms.Button okSignButton;
        private System.Windows.Forms.DataGridView classGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sign;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button loadClassesButton;
        private System.Windows.Forms.Label valuesForClassLabel;
        private System.Windows.Forms.TextBox nameClassText;
        private System.Windows.Forms.Label nameClassLabel;
        private System.Windows.Forms.Button changeClassButton;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.Button saveClassButton;
        private System.Windows.Forms.DataGridView signsForClassView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn signValue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox resultProbabilityText;
        private System.Windows.Forms.TextBox resultDeterminateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.DataGridView resultSignsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}


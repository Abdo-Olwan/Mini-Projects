namespace Pizza_Project
{
    partial class MainMenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gpxSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gpCrust = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTommatos = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtToppings = new System.Windows.Forms.TextBox();
            this.gpxSize.SuspendLayout();
            this.gpCrust.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpWhereToEat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(430, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Own Pizza";
            // 
            // gpxSize
            // 
            this.gpxSize.Controls.Add(this.rbLarge);
            this.gpxSize.Controls.Add(this.rbMedium);
            this.gpxSize.Controls.Add(this.rbSmall);
            this.gpxSize.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxSize.Location = new System.Drawing.Point(77, 116);
            this.gpxSize.Name = "gpxSize";
            this.gpxSize.Size = new System.Drawing.Size(208, 199);
            this.gpxSize.TabIndex = 1;
            this.gpxSize.TabStop = false;
            this.gpxSize.Text = "Pizza Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(6, 136);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(98, 30);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(6, 85);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(126, 30);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(6, 34);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(99, 30);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gpCrust
            // 
            this.gpCrust.Controls.Add(this.rbThickCrust);
            this.gpCrust.Controls.Add(this.rbThinCrust);
            this.gpCrust.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCrust.Location = new System.Drawing.Point(77, 339);
            this.gpCrust.Name = "gpCrust";
            this.gpCrust.Size = new System.Drawing.Size(208, 142);
            this.gpCrust.TabIndex = 3;
            this.gpCrust.TabStop = false;
            this.gpCrust.Text = "Crust";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(6, 85);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(175, 30);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(6, 34);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(161, 30);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.Controls.Add(this.chkMushrooms);
            this.gpToppings.Controls.Add(this.chkTommatos);
            this.gpToppings.Controls.Add(this.chkGreenPeppers);
            this.gpToppings.Controls.Add(this.chkOlives);
            this.gpToppings.Controls.Add(this.chkOnion);
            this.gpToppings.Controls.Add(this.chkExtraChees);
            this.gpToppings.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpToppings.Location = new System.Drawing.Point(438, 116);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(386, 199);
            this.gpToppings.TabIndex = 4;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(29, 88);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(125, 24);
            this.chkMushrooms.TabIndex = 10;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTommatos
            // 
            this.chkTommatos.AutoSize = true;
            this.chkTommatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTommatos.Location = new System.Drawing.Point(29, 142);
            this.chkTommatos.Name = "chkTommatos";
            this.chkTommatos.Size = new System.Drawing.Size(117, 24);
            this.chkTommatos.TabIndex = 9;
            this.chkTommatos.Tag = "5";
            this.chkTommatos.Text = "Tommatos";
            this.chkTommatos.UseVisualStyleBackColor = true;
            this.chkTommatos.CheckedChanged += new System.EventHandler(this.chkTommatos_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(205, 142);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(154, 24);
            this.chkGreenPeppers.TabIndex = 8;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(205, 91);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(82, 24);
            this.chkOlives.TabIndex = 7;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(205, 40);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(79, 24);
            this.chkOnion.TabIndex = 6;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.Location = new System.Drawing.Point(29, 34);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(130, 24);
            this.chkExtraChees.TabIndex = 5;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gpWhereToEat
            // 
            this.gpWhereToEat.Controls.Add(this.rbTakeOut);
            this.gpWhereToEat.Controls.Add(this.rbEatIn);
            this.gpWhereToEat.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpWhereToEat.Location = new System.Drawing.Point(438, 360);
            this.gpWhereToEat.Name = "gpWhereToEat";
            this.gpWhereToEat.Size = new System.Drawing.Size(386, 121);
            this.gpWhereToEat.TabIndex = 4;
            this.gpWhereToEat.TabStop = false;
            this.gpWhereToEat.Text = "Where To Eat ?";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(205, 49);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(149, 30);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Tag = "";
            this.rbTakeOut.Text = "Take Out.";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(16, 49);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(111, 30);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "0";
            this.rbEatIn.Text = "Eat In.";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Green;
            this.btnOrderPizza.Location = new System.Drawing.Point(438, 514);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(172, 35);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.Green;
            this.btnResetForm.Location = new System.Drawing.Point(652, 514);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(172, 35);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lable1.Location = new System.Drawing.Point(983, 149);
            this.lable1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(52, 22);
            this.lable1.TabIndex = 7;
            this.lable1.Text = "Size : ";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lable2.Location = new System.Drawing.Point(983, 186);
            this.lable2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(89, 22);
            this.lable2.TabIndex = 9;
            this.lable2.Text = "Toppings : ";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lable4.Location = new System.Drawing.Point(983, 293);
            this.lable4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(100, 22);
            this.lable4.TabIndex = 10;
            this.lable4.Text = "Crust Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(983, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Where To Eat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(983, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Price : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtToppings);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.lblWhereToEat);
            this.groupBox1.Controls.Add(this.lblCrustType);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(953, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 433);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summery";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Location = new System.Drawing.Point(89, 351);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(79, 54);
            this.lblTotalPrice.TabIndex = 14;
            this.lblTotalPrice.Text = "$0";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWhereToEat.Location = new System.Drawing.Point(69, 257);
            this.lblWhereToEat.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(0, 19);
            this.lblWhereToEat.TabIndex = 16;
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrustType.Location = new System.Drawing.Point(129, 182);
            this.lblCrustType.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(0, 19);
            this.lblCrustType.TabIndex = 15;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSize.Location = new System.Drawing.Point(94, 34);
            this.lblSize.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 22);
            this.lblSize.TabIndex = 14;
            // 
            // txtToppings
            // 
            this.txtToppings.BackColor = System.Drawing.SystemColors.Control;
            this.txtToppings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToppings.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToppings.Location = new System.Drawing.Point(73, 95);
            this.txtToppings.Multiline = true;
            this.txtToppings.Name = "txtToppings";
            this.txtToppings.Size = new System.Drawing.Size(166, 79);
            this.txtToppings.TabIndex = 14;
            // 
            // MainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gpWhereToEat);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.gpCrust);
            this.Controls.Add(this.gpxSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "MainMenue";
            this.Text = "Pizza One";
            this.Load += new System.EventHandler(this.MainMenue_Load);
            this.gpxSize.ResumeLayout(false);
            this.gpxSize.PerformLayout();
            this.gpCrust.ResumeLayout(false);
            this.gpCrust.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpWhereToEat.ResumeLayout(false);
            this.gpWhereToEat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpxSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gpCrust;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTommatos;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox gpWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtToppings;
    }
}


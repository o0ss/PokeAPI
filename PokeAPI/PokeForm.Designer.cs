namespace PokeAPI
{
	partial class PokeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPokemon = new System.Windows.Forms.ListView();
            this.buttonTest = new System.Windows.Forms.Button();
            this.listBoxPokemon = new System.Windows.Forms.ListBox();
            this.groupBoxPokeDetails = new System.Windows.Forms.GroupBox();
            this.labelPokeID = new System.Windows.Forms.Label();
            this.label_PokeID = new System.Windows.Forms.Label();
            this.labelPokeName = new System.Windows.Forms.Label();
            this.buttonSpriteNext = new System.Windows.Forms.Button();
            this.buttonSpritePrev = new System.Windows.Forms.Button();
            this.pictureBoxSprite = new System.Windows.Forms.PictureBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.label_Weight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.groupBoxPokeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pokemon";
            // 
            // listViewPokemon
            // 
            this.listViewPokemon.Location = new System.Drawing.Point(12, 59);
            this.listViewPokemon.Name = "listViewPokemon";
            this.listViewPokemon.Size = new System.Drawing.Size(147, 349);
            this.listViewPokemon.TabIndex = 3;
            this.listViewPokemon.UseCompatibleStateImageBehavior = false;
            this.listViewPokemon.View = System.Windows.Forms.View.Tile;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(430, 12);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Start";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // listBoxPokemon
            // 
            this.listBoxPokemon.FormattingEnabled = true;
            this.listBoxPokemon.ItemHeight = 15;
            this.listBoxPokemon.Location = new System.Drawing.Point(165, 59);
            this.listBoxPokemon.Name = "listBoxPokemon";
            this.listBoxPokemon.Size = new System.Drawing.Size(123, 349);
            this.listBoxPokemon.TabIndex = 5;
            this.listBoxPokemon.SelectedValueChanged += new System.EventHandler(this.listBoxPokemon_SelectedValueChanged);
            // 
            // groupBoxPokeDetails
            // 
            this.groupBoxPokeDetails.Controls.Add(this.labelHeight);
            this.groupBoxPokeDetails.Controls.Add(this.label_Height);
            this.groupBoxPokeDetails.Controls.Add(this.labelWeight);
            this.groupBoxPokeDetails.Controls.Add(this.label_Weight);
            this.groupBoxPokeDetails.Controls.Add(this.labelType);
            this.groupBoxPokeDetails.Controls.Add(this.label_Type);
            this.groupBoxPokeDetails.Controls.Add(this.labelPokeID);
            this.groupBoxPokeDetails.Controls.Add(this.label_PokeID);
            this.groupBoxPokeDetails.Controls.Add(this.labelPokeName);
            this.groupBoxPokeDetails.Controls.Add(this.buttonSpriteNext);
            this.groupBoxPokeDetails.Controls.Add(this.buttonSpritePrev);
            this.groupBoxPokeDetails.Controls.Add(this.pictureBoxSprite);
            this.groupBoxPokeDetails.Location = new System.Drawing.Point(331, 59);
            this.groupBoxPokeDetails.Name = "groupBoxPokeDetails";
            this.groupBoxPokeDetails.Size = new System.Drawing.Size(424, 349);
            this.groupBoxPokeDetails.TabIndex = 6;
            this.groupBoxPokeDetails.TabStop = false;
            this.groupBoxPokeDetails.Text = "Detalles";
            // 
            // labelPokeID
            // 
            this.labelPokeID.AutoSize = true;
            this.labelPokeID.Location = new System.Drawing.Point(324, 50);
            this.labelPokeID.Name = "labelPokeID";
            this.labelPokeID.Size = new System.Drawing.Size(21, 15);
            this.labelPokeID.TabIndex = 5;
            this.labelPokeID.Text = "##";
            // 
            // label_PokeID
            // 
            this.label_PokeID.AutoSize = true;
            this.label_PokeID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_PokeID.Location = new System.Drawing.Point(297, 50);
            this.label_PokeID.Name = "label_PokeID";
            this.label_PokeID.Size = new System.Drawing.Size(21, 15);
            this.label_PokeID.TabIndex = 4;
            this.label_PokeID.Text = "ID:";
            // 
            // labelPokeName
            // 
            this.labelPokeName.AutoSize = true;
            this.labelPokeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPokeName.Location = new System.Drawing.Point(125, 44);
            this.labelPokeName.Name = "labelPokeName";
            this.labelPokeName.Size = new System.Drawing.Size(75, 21);
            this.labelPokeName.TabIndex = 3;
            this.labelPokeName.Text = "Pokemon";
            // 
            // buttonSpriteNext
            // 
            this.buttonSpriteNext.Location = new System.Drawing.Point(73, 146);
            this.buttonSpriteNext.Name = "buttonSpriteNext";
            this.buttonSpriteNext.Size = new System.Drawing.Size(23, 23);
            this.buttonSpriteNext.TabIndex = 2;
            this.buttonSpriteNext.Text = ">";
            this.buttonSpriteNext.UseVisualStyleBackColor = true;
            // 
            // buttonSpritePrev
            // 
            this.buttonSpritePrev.Location = new System.Drawing.Point(44, 146);
            this.buttonSpritePrev.Name = "buttonSpritePrev";
            this.buttonSpritePrev.Size = new System.Drawing.Size(23, 23);
            this.buttonSpritePrev.TabIndex = 1;
            this.buttonSpritePrev.Text = "<";
            this.buttonSpritePrev.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSprite
            // 
            this.pictureBoxSprite.Location = new System.Drawing.Point(23, 44);
            this.pictureBoxSprite.Name = "pictureBoxSprite";
            this.pictureBoxSprite.Size = new System.Drawing.Size(96, 96);
            this.pictureBoxSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSprite.TabIndex = 0;
            this.pictureBoxSprite.TabStop = false;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_Type.Location = new System.Drawing.Point(132, 74);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(33, 15);
            this.label_Type.TabIndex = 6;
            this.label_Type.Text = "Tipo:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(171, 74);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(30, 15);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Tipo";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(171, 95);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(30, 15);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "Tipo";
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_Weight.Location = new System.Drawing.Point(132, 95);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(35, 15);
            this.label_Weight.TabIndex = 8;
            this.label_Weight.Text = "Peso:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(171, 114);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(39, 15);
            this.labelHeight.TabIndex = 11;
            this.labelHeight.Text = "Altura";
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_Height.Location = new System.Drawing.Point(125, 114);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(42, 15);
            this.label_Height.TabIndex = 10;
            this.label_Height.Text = "Altura:";
            // 
            // PokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.groupBoxPokeDetails);
            this.Controls.Add(this.listBoxPokemon);
            this.Controls.Add(this.listViewPokemon);
            this.Controls.Add(this.label1);
            this.Name = "PokeForm";
            this.Text = "PokeAPI - Oscar Sixtos";
            this.groupBoxPokeDetails.ResumeLayout(false);
            this.groupBoxPokeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label label1;
		private ListView listViewPokemon;
		private Button buttonTest;
		private ListBox listBoxPokemon;
		private GroupBox groupBoxPokeDetails;
		private Label labelPokeName;
		private Button buttonSpriteNext;
		private Button buttonSpritePrev;
		private PictureBox pictureBoxSprite;
		private Label labelPokeID;
		private Label label_PokeID;
		private Label labelHeight;
		private Label label_Height;
		private Label labelWeight;
		private Label label_Weight;
		private Label labelType;
		private Label label_Type;
	}
}
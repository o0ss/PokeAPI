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
            this.components = new System.ComponentModel.Container();
            this.labelPokedex = new System.Windows.Forms.Label();
            this.listViewMoves = new System.Windows.Forms.ListView();
            this.listBoxPokemon = new System.Windows.Forms.ListBox();
            this.groupBoxPokeDetails = new System.Windows.Forms.GroupBox();
            this.label_Moves = new System.Windows.Forms.Label();
            this.label_Stats = new System.Windows.Forms.Label();
            this.buttonSpriteNext = new System.Windows.Forms.Button();
            this.buttonSpritePrev = new System.Windows.Forms.Button();
            this.labelXP = new System.Windows.Forms.Label();
            this.label_XP = new System.Windows.Forms.Label();
            this.listViewStats = new System.Windows.Forms.ListView();
            this.Stat = new System.Windows.Forms.ColumnHeader();
            this.Base = new System.Windows.Forms.ColumnHeader();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.label_Weight = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.labelPokeID = new System.Windows.Forms.Label();
            this.label_PokeID = new System.Windows.Forms.Label();
            this.labelPokeName = new System.Windows.Forms.Label();
            this.pictureBoxSprite = new System.Windows.Forms.PictureBox();
            this.toolTipSelect = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxPokeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPokedex
            // 
            this.labelPokedex.AutoSize = true;
            this.labelPokedex.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPokedex.Location = new System.Drawing.Point(35, 18);
            this.labelPokedex.Name = "labelPokedex";
            this.labelPokedex.Size = new System.Drawing.Size(82, 25);
            this.labelPokedex.TabIndex = 0;
            this.labelPokedex.Text = "Pokedex";
            // 
            // listViewMoves
            // 
            this.listViewMoves.Location = new System.Drawing.Point(223, 211);
            this.listViewMoves.Name = "listViewMoves";
            this.listViewMoves.Size = new System.Drawing.Size(221, 146);
            this.listViewMoves.TabIndex = 3;
            this.listViewMoves.UseCompatibleStateImageBehavior = false;
            this.listViewMoves.View = System.Windows.Forms.View.List;
            // 
            // listBoxPokemon
            // 
            this.listBoxPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPokemon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPokemon.FormattingEnabled = true;
            this.listBoxPokemon.ItemHeight = 17;
            this.listBoxPokemon.Location = new System.Drawing.Point(35, 59);
            this.listBoxPokemon.Name = "listBoxPokemon";
            this.listBoxPokemon.Size = new System.Drawing.Size(174, 376);
            this.listBoxPokemon.TabIndex = 5;
            this.listBoxPokemon.SelectedValueChanged += new System.EventHandler(this.listBoxPokemon_SelectedValueChanged);
            // 
            // groupBoxPokeDetails
            // 
            this.groupBoxPokeDetails.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxPokeDetails.Controls.Add(this.label_Moves);
            this.groupBoxPokeDetails.Controls.Add(this.label_Stats);
            this.groupBoxPokeDetails.Controls.Add(this.buttonSpriteNext);
            this.groupBoxPokeDetails.Controls.Add(this.buttonSpritePrev);
            this.groupBoxPokeDetails.Controls.Add(this.labelXP);
            this.groupBoxPokeDetails.Controls.Add(this.label_XP);
            this.groupBoxPokeDetails.Controls.Add(this.listViewStats);
            this.groupBoxPokeDetails.Controls.Add(this.labelHeight);
            this.groupBoxPokeDetails.Controls.Add(this.label_Height);
            this.groupBoxPokeDetails.Controls.Add(this.labelWeight);
            this.groupBoxPokeDetails.Controls.Add(this.listViewMoves);
            this.groupBoxPokeDetails.Controls.Add(this.label_Weight);
            this.groupBoxPokeDetails.Controls.Add(this.labelType);
            this.groupBoxPokeDetails.Controls.Add(this.label_Type);
            this.groupBoxPokeDetails.Controls.Add(this.labelPokeID);
            this.groupBoxPokeDetails.Controls.Add(this.label_PokeID);
            this.groupBoxPokeDetails.Controls.Add(this.labelPokeName);
            this.groupBoxPokeDetails.Controls.Add(this.pictureBoxSprite);
            this.groupBoxPokeDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxPokeDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPokeDetails.Location = new System.Drawing.Point(228, 59);
            this.groupBoxPokeDetails.Name = "groupBoxPokeDetails";
            this.groupBoxPokeDetails.Size = new System.Drawing.Size(468, 376);
            this.groupBoxPokeDetails.TabIndex = 6;
            this.groupBoxPokeDetails.TabStop = false;
            this.groupBoxPokeDetails.Text = "Detalles";
            this.toolTipSelect.SetToolTip(this.groupBoxPokeDetails, "Selecciona un Pokemon de la lista para ver sus detalles.");
            // 
            // label_Moves
            // 
            this.label_Moves.AutoSize = true;
            this.label_Moves.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Moves.Location = new System.Drawing.Point(223, 189);
            this.label_Moves.Name = "label_Moves";
            this.label_Moves.Size = new System.Drawing.Size(50, 19);
            this.label_Moves.TabIndex = 16;
            this.label_Moves.Text = "Moves";
            // 
            // label_Stats
            // 
            this.label_Stats.AutoSize = true;
            this.label_Stats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Stats.Location = new System.Drawing.Point(25, 189);
            this.label_Stats.Name = "label_Stats";
            this.label_Stats.Size = new System.Drawing.Size(39, 19);
            this.label_Stats.TabIndex = 15;
            this.label_Stats.Text = "Stats";
            // 
            // buttonSpriteNext
            // 
            this.buttonSpriteNext.Location = new System.Drawing.Point(86, 148);
            this.buttonSpriteNext.Name = "buttonSpriteNext";
            this.buttonSpriteNext.Size = new System.Drawing.Size(23, 23);
            this.buttonSpriteNext.TabIndex = 2;
            this.buttonSpriteNext.Text = ">";
            this.buttonSpriteNext.UseVisualStyleBackColor = true;
            this.buttonSpriteNext.Click += new System.EventHandler(this.buttonSpriteNext_Click);
            // 
            // buttonSpritePrev
            // 
            this.buttonSpritePrev.Location = new System.Drawing.Point(57, 148);
            this.buttonSpritePrev.Name = "buttonSpritePrev";
            this.buttonSpritePrev.Size = new System.Drawing.Size(23, 23);
            this.buttonSpritePrev.TabIndex = 1;
            this.buttonSpritePrev.Text = "<";
            this.buttonSpritePrev.UseVisualStyleBackColor = true;
            this.buttonSpritePrev.Click += new System.EventHandler(this.buttonSpritePrev_Click);
            // 
            // labelXP
            // 
            this.labelXP.AutoSize = true;
            this.labelXP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelXP.Location = new System.Drawing.Point(402, 99);
            this.labelXP.Name = "labelXP";
            this.labelXP.Size = new System.Drawing.Size(25, 19);
            this.labelXP.TabIndex = 14;
            this.labelXP.Text = "##";
            // 
            // label_XP
            // 
            this.label_XP.AutoSize = true;
            this.label_XP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_XP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_XP.Location = new System.Drawing.Point(377, 99);
            this.label_XP.Name = "label_XP";
            this.label_XP.Size = new System.Drawing.Size(28, 19);
            this.label_XP.TabIndex = 13;
            this.label_XP.Text = "XP:";
            // 
            // listViewStats
            // 
            this.listViewStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stat,
            this.Base});
            this.listViewStats.Location = new System.Drawing.Point(25, 211);
            this.listViewStats.Name = "listViewStats";
            this.listViewStats.Size = new System.Drawing.Size(179, 146);
            this.listViewStats.TabIndex = 12;
            this.listViewStats.UseCompatibleStateImageBehavior = false;
            this.listViewStats.View = System.Windows.Forms.View.Details;
            // 
            // Stat
            // 
            this.Stat.Text = "Stat";
            this.Stat.Width = 100;
            // 
            // Base
            // 
            this.Base.Text = "Base";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeight.Location = new System.Drawing.Point(202, 123);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(37, 19);
            this.labelHeight.TabIndex = 11;
            this.labelHeight.Text = "?? m";
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Height.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_Height.Location = new System.Drawing.Point(155, 123);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(49, 19);
            this.label_Height.TabIndex = 10;
            this.label_Height.Text = "Altura:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWeight.Location = new System.Drawing.Point(202, 99);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(40, 19);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "?? kg";
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Weight.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_Weight.Location = new System.Drawing.Point(164, 99);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(40, 19);
            this.label_Weight.TabIndex = 8;
            this.label_Weight.Text = "Peso:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(202, 75);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(35, 19);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Tipo";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Type.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_Type.Location = new System.Drawing.Point(166, 75);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(38, 19);
            this.label_Type.TabIndex = 6;
            this.label_Type.Text = "Tipo:";
            // 
            // labelPokeID
            // 
            this.labelPokeID.AutoSize = true;
            this.labelPokeID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPokeID.Location = new System.Drawing.Point(402, 75);
            this.labelPokeID.Name = "labelPokeID";
            this.labelPokeID.Size = new System.Drawing.Size(25, 19);
            this.labelPokeID.TabIndex = 5;
            this.labelPokeID.Text = "##";
            // 
            // label_PokeID
            // 
            this.label_PokeID.AutoSize = true;
            this.label_PokeID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PokeID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_PokeID.Location = new System.Drawing.Point(379, 75);
            this.label_PokeID.Name = "label_PokeID";
            this.label_PokeID.Size = new System.Drawing.Size(26, 19);
            this.label_PokeID.TabIndex = 4;
            this.label_PokeID.Text = "ID:";
            // 
            // labelPokeName
            // 
            this.labelPokeName.AutoSize = true;
            this.labelPokeName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPokeName.Location = new System.Drawing.Point(164, 37);
            this.labelPokeName.Name = "labelPokeName";
            this.labelPokeName.Size = new System.Drawing.Size(186, 25);
            this.labelPokeName.TabIndex = 3;
            this.labelPokeName.Text = "Who\'s that Pokemon?";
            this.toolTipSelect.SetToolTip(this.labelPokeName, "Selecciona un Pokemon de la lista para ver sus detalles.");
            // 
            // pictureBoxSprite
            // 
            this.pictureBoxSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSprite.Location = new System.Drawing.Point(25, 22);
            this.pictureBoxSprite.Name = "pictureBoxSprite";
            this.pictureBoxSprite.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSprite.TabIndex = 0;
            this.pictureBoxSprite.TabStop = false;
            // 
            // toolTipSelect
            // 
            this.toolTipSelect.AutoPopDelay = 5000;
            this.toolTipSelect.InitialDelay = 500;
            this.toolTipSelect.ReshowDelay = 35000;
            this.toolTipSelect.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSelect.ToolTipTitle = "Selecciona un Pokemon";
            // 
            // PokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 463);
            this.Controls.Add(this.groupBoxPokeDetails);
            this.Controls.Add(this.listBoxPokemon);
            this.Controls.Add(this.labelPokedex);
            this.Name = "PokeForm";
            this.Text = "PokeAPI - Oscar Sixtos";
            this.Load += new System.EventHandler(this.PokeForm_Load);
            this.groupBoxPokeDetails.ResumeLayout(false);
            this.groupBoxPokeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label labelPokedex;
		private ListView listViewMoves;
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
		private ListView listViewStats;
		private ColumnHeader Stat;
		private ColumnHeader Base;
		private Label label_Moves;
		private Label label_Stats;
		private Label labelXP;
		private Label label_XP;
		private ToolTip toolTipSelect;
	}
}
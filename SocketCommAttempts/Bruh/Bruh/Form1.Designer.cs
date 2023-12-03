namespace Bruh
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
            btnCreateRoom = new Button();
            btnJoinRoom = new Button();
            tbxRoomName = new TextBox();
            lbxGames = new ListBox();
            btnStartGame = new Button();
            SuspendLayout();
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.Location = new Point(217, 7);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(119, 29);
            btnCreateRoom.TabIndex = 0;
            btnCreateRoom.Text = "Create room";
            btnCreateRoom.UseVisualStyleBackColor = true;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // btnJoinRoom
            // 
            btnJoinRoom.Location = new Point(217, 42);
            btnJoinRoom.Name = "btnJoinRoom";
            btnJoinRoom.Size = new Size(119, 29);
            btnJoinRoom.TabIndex = 1;
            btnJoinRoom.Text = "Join room";
            btnJoinRoom.UseVisualStyleBackColor = true;
            // 
            // tbxRoomName
            // 
            tbxRoomName.Location = new Point(12, 23);
            tbxRoomName.Name = "tbxRoomName";
            tbxRoomName.Size = new Size(190, 27);
            tbxRoomName.TabIndex = 2;
            // 
            // lbxGames
            // 
            lbxGames.FormattingEnabled = true;
            lbxGames.Location = new Point(12, 99);
            lbxGames.Name = "lbxGames";
            lbxGames.Size = new Size(323, 124);
            lbxGames.TabIndex = 3;
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(216, 236);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(119, 29);
            btnStartGame.TabIndex = 4;
            btnStartGame.Text = "Start";
            btnStartGame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 277);
            Controls.Add(btnStartGame);
            Controls.Add(lbxGames);
            Controls.Add(tbxRoomName);
            Controls.Add(btnJoinRoom);
            Controls.Add(btnCreateRoom);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateRoom;
        private Button btnJoinRoom;
        private TextBox tbxRoomName;
        private ListBox lbxGames;
        private Button btnStartGame;
    }
}

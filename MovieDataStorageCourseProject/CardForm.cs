﻿using System.Windows.Forms;

namespace MovieDataStorageCourseProject
{
    public partial class CardForm : Form
    {
        public CardForm(string name, int yearOfIssue)
        {
            InitializeComponent();
            PictureBox.Image = PictureBox.InitialImage;
            //NameLabel.Text = name;
            //YearOfIssueLabel.Text = yearOfIssue.ToString();
        }
    }
}

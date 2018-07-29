using System;
using System.Windows.Forms;
using TriangleTypeLibrary.Core.Implementation.Factory;
using TriangleTypeLibrary.Core.Implementation.Repository;
using TriangleTypeLibrary.Core.Interfaces.Repository;
using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeChallengeClient
{
    public partial class FormTriangleType : Form
    {
        private ITriangleRepository _triangle;

        public FormTriangleType()
        {
            InitializeComponent();
        }
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                LabelTriangleTypeResult.Text = @"...";
                _triangle = new TriangleFactory<TriangleRepository>().GetInstance();
                _triangle.TriangleEntity = new TriangleEntity
                {
                    Length = double.Parse(TextBoxTriangleWidth.Text),
                    Height = double.Parse(TextBoxTriangleHeight.Text),
                    Base = double.Parse(TextBoxTriangleBase.Text)
                };
                var validationRes = _triangle.ValidateTriangleValues();
                if (string.IsNullOrEmpty(validationRes))
                    LabelTriangleTypeResult.Text = _triangle.GetTriangleType().ToString();
                else MessageBox.Show(validationRes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
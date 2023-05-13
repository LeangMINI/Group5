using Library.Properties;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Library
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
            
            
        }
        
        
        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks abs = new AddBooks();
            abs.TopLevel = false;
            panel1.Controls.Add(abs);
            abs.BringToFront();
            abs.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.TopLevel = false;
            panel1.Controls.Add(vb);
            vb.BringToFront();
            vb.Show();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser ast = new AddUser();
            ast.TopLevel = false;
            panel1.Controls.Add(ast);
            ast.BringToFront();
            ast.Show();
        }

        private void viewStudentsInFoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ViewStudentInformation vsi = new ViewStudentInformation();
            //vsi.TopLevel = false;
            //panel1.Controls.Add(vsi);
            //vsi.BringToFront();
            //vsi.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks ib = new IssueBooks();
            ib.TopLevel = false;
            panel1.Controls.Add(ib);
            ib.BringToFront();
            ib.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.TopLevel = false;
            panel1.Controls.Add(rb);
            rb.BringToFront();
            rb.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBooks cb = new CompleteBooks();
            cb.TopLevel = false;
            panel1.Controls.Add(cb);
            cb.BringToFront();
            cb.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            /*CustomizeButton();*/
            
            
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookCloset bc = new BookCloset();
            bc.TopLevel = false;
            panel1.Controls.Add(bc);
            bc.BringToFront();
            bc.Show();
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author Author = new Author();
            Author.TopLevel = false;
            panel1.Controls.Add(Author);
            Author.BringToFront();
            Author.Show();
        }

        private void addBookTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booktype bt = new Booktype();
            bt.TopLevel = false;
            panel1.Controls.Add(bt);
            bt.BringToFront();
            bt.Show();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            



        }

        private void btnUserDropdown_Click(object sender, EventArgs e)
        {
            

        }

        

        private void btnAddUser_Click(object sender, EventArgs e)
        {
                
            AddUser ast = new AddUser();
            ast.TopLevel = false;
            panel1.Controls.Add(ast);
            ast.BringToFront();
            ast.Show();
            btnAddUser.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            
            //ViewStudentInformation vsi = new ViewStudentInformation();
            //vsi.TopLevel = false;
            //panel1.Controls.Add(vsi);
            //vsi.BringToFront();
            //vsi.Show();
            ///*btnViewStudent.Visible = true;*/
            //PanelMenu.Visible = false;
            //PanelMenu.Width = 54;
            //guna2Transition1.ShowSync(PanelMenu);
        }

        private void btnAddbook_Click_1(object sender, EventArgs e)
        {
            
           
            AddBooks abs = new AddBooks();
            abs.TopLevel = false;
            panel1.Controls.Add(abs);
            abs.BringToFront();
            abs.Show();
            btnAddbook.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void btnAddAuthor_Click_1(object sender, EventArgs e)
        {
            
            Author Author = new Author();
            Author.TopLevel = false;
            panel1.Controls.Add(Author);
            Author.BringToFront();
            Author.Show();
            btnAddAuthor.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void btnAddbookType_Click_1(object sender, EventArgs e)
        {
            
            Booktype bt = new Booktype();
            bt.TopLevel = false;
            panel1.Controls.Add(bt);
            bt.BringToFront();
            bt.Show();
            btnAddbookType.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void btnAddBookCloset_Click_1(object sender, EventArgs e)
        {
            
            BookCloset bc = new BookCloset();
            bc.TopLevel = false;
            panel1.Controls.Add(bc);
            bc.BringToFront();
            bc.Show();
            btnAddBookCloset.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void btnViewBook_Click_1(object sender, EventArgs e)
        {
            
            ViewBook vb = new ViewBook();
            vb.TopLevel = false;
            panel1.Controls.Add(vb);
            vb.BringToFront();
            vb.Show();
            btnViewBook.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BorrowDetail borrowDetail = new BorrowDetail();
            borrowDetail.TopLevel = false;
            panel1.Controls.Add(borrowDetail);
            borrowDetail.BringToFront();
            borrowDetail.Show();
            btnViewBook.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void guna2Button2AbtnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks();
            returnBooks.TopLevel = false;
            panel1.Controls.Add(returnBooks);
            returnBooks.BringToFront();
            returnBooks.Show();
            btnViewBook.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.TopLevel = false;
            panel1.Controls.Add(payment);
            payment.BringToFront();
            payment.Show();
            btnViewBook.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void btnCompletBook_Click(object sender, EventArgs e)
        {
            paymentdetail pd = new paymentdetail();
            pd.TopLevel = false;
            panel1.Controls.Add(pd);
            pd.BringToFront();
            pd.Show();
            btnCompletBook.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnShow.Visible = false;
            gbtnHide.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void gbtnHide_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
            gbtnHide.Visible = false;
            btnShow.Visible = true;
            PanelMenu.Width = 228;
            guna2Transition1.ShowSync(PanelMenu);
        }



        private void btnReport_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.TopLevel = false;
            panel1.Controls.Add(rp);
            rp.BringToFront();
            rp.Show();
            btnCompletBook.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Student bc = new Student();
            bc.TopLevel = false;
            panel1.Controls.Add(bc);
            bc.BringToFront();
            bc.Show();
            btnstudent.Visible = true;
            PanelMenu.Visible = false;
            PanelMenu.Width = 54;
            guna2Transition1.ShowSync(PanelMenu);
        }
    }
}

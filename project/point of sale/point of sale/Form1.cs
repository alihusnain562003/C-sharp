namespace point_of_sale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Cost_of_Items()
        {
            Double sum = 0;
            int i = 0;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }
        private void AddCost()
        {
            Double tax, q;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                lblTax.Text = String.Format("{0:c2}", (((Cost_of_Items() * tax) / 100)));
                lblSubTotal = String.Format("{0:c2}", Cost_of_Items());
                q = ((Cost_of_Items() * tax) / 100);
                total.Text = String.Format("{0:c2}", (Cost_of_Items() + q));
                lblBarCode.Text = Convert.ToString(q + Cost_of_Items());
            }

        }
        private void Change()
        {
            Double tax, q, c;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((Cost_of_Items() * tax) / 100) + Cost_of_Items();
                c = Convert.ToInt32(cost.Text);
                change.Text = String.Format("{0:c2}", c - q);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPayment.Items.Add("Cash");
            cboPayment.Items.Add("Visa Card");
            cboPayment.Items.Add("Master Card");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (cboPayment.Text == "Cash")
            {
                Change();
            }
            else
            {
                change.Text = "";
                cost.Text = "0";
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        Bitmap bitmap;
        private void button43_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                lblBarCode.Text = "";
                cost.Text = "0";
                change.Text = "";
                lblSubTotal.Text = "";
                lblTax.Text = "";
                total.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cboPayment.Text = "";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button42_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            AddCost();
            if (cboPayment.Text == "Cash")
            {
                Change();
            }
            else
            {
                change.Text = "";
                cost.Text = "0";
            }



        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (cost.Text == "0")
            {
                cost.Text = "";
                cost.Text = b.Text;
            }
            else if (cost.Text == ".")
            {
                if (!cost.Text.Contains("."))
                {
                    cost.Text = cost.Text + b.Text;

                }
            }
            else
            {
                cost.Text = cost.Text + b.Text;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cost.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Double CostofItem = 250;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Latta Coffee"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Latta Coffee", 1, CostofItem);
            AddCost();
        }

        private void bananashake_Click(object sender, EventArgs e)
        {
            Double CostofItem = 300;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Banana Shake"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Banana Shake", 1, CostofItem);
            AddCost();
        }

        private void blackcoffee_Click(object sender, EventArgs e)
        {
            Double CostofItem = 150;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Black Coffee"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Black Coffee", 1, CostofItem);
            AddCost();
        }

        private void chocolatemilkshake_Click(object sender, EventArgs e)
        {
            Double CostofItem = 260;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Chocolate Milk Shake"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Chocolate Milk Shake", 1, CostofItem);
            AddCost();
        }

        private void oolongtea_Click(object sender, EventArgs e)
        {
            Double CostofItem = 130;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Oolong Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Oolong Tea", 1, CostofItem);
            AddCost();
        }

        private void dryfruitsshake_Click(object sender, EventArgs e)
        {
            Double CostofItem = 300;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Dry Fruit Shake"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Dry Fruit Shake", 1, CostofItem);
            AddCost();
        }

        private void greentea_Click(object sender, EventArgs e)
        {
            Double CostofItem = 120;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Green Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Green Tea", 1, CostofItem);
            AddCost();
        }

        private void strawberrymilkshake_Click(object sender, EventArgs e)
        {
            Double CostofItem = 200;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Strawberry Milk Shake"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Strawberry Milk Shake", 1, CostofItem);
            AddCost();
        }

        private void frooto_Click(object sender, EventArgs e)
        {
            Double CostofItem = 170;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "GrapeFruit Juice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Grapefruit Juice", 1, CostofItem);
            AddCost();
        }

        private void applejuice_Click(object sender, EventArgs e)
        {
            Double CostofItem = 280;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Apple Juice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Apple Juice", 1, CostofItem);
            AddCost();
        }

        private void chocolatecoffee_Click(object sender, EventArgs e)
        {
            Double CostofItem = 170;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Chocolate Coffee"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Chocolate Coffee", 1, CostofItem);
            AddCost();
        }

        private void coffee_Click(object sender, EventArgs e)
        {
            Double CostofItem = 170;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Coffee"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Coffee", 1, CostofItem);
            AddCost();
        }

        private void kiwijuice_Click(object sender, EventArgs e)
        {
            Double CostofItem = 300;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Kiwi Juice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Kiwi juice", 1, CostofItem);
            AddCost();
        }

        private void mangojuice_Click(object sender, EventArgs e)
        {
            Double CostofItem = 260;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Mango Juice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Mango Juice", 1, CostofItem);
            AddCost();
        }

        private void milktea_Click(object sender, EventArgs e)
        {
            Double CostofItem = 100;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Milk Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Milk Tea", 1, CostofItem);
            AddCost();
        }

        private void orangejuice_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Orange Juie"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Orange Juice", 1, CostofItem);
            AddCost();
        }

        private void pakolamilkshake_Click(object sender, EventArgs e)
        {
            Double CostofItem = 200;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pakola Milk Shake"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Pakola Milk Shake", 1, CostofItem);
            AddCost();
        }

        private void papayajuice_Click(object sender, EventArgs e)
        {
            Double CostofItem = 250;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Papaya Juice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Papaya Juice", 1, CostofItem);
            AddCost();
        }

        private void pineapplejuice_Click(object sender, EventArgs e)
        {
            Double CostofItem = 220;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pineapple Juice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Pineapple Juice", 1, CostofItem);
            AddCost();
        }

        private void pomegranatejuice_Click(object sender, EventArgs e)
        {
            Double CostofItem = 240;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pomegranate Juice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Pomegranate Juice", 1, CostofItem);
            AddCost();
        }

        private void puerhtea_Click(object sender, EventArgs e)
        {
            Double CostofItem = 150;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Puerh Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Puerh Tea ", 1, CostofItem);
            AddCost();
        }

        private void blacktea_Click(object sender, EventArgs e)
        {
            Double CostofItem = 140;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Black Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Black Tea", 1, CostofItem);
            AddCost();
        }

        private void strawberryjuice_Click(object sender, EventArgs e)
        {
            Double CostofItem = 230;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Strawberry Juice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Strawberry Juice", 1, CostofItem);
            AddCost();
        }

        private void watermelonjuice_Click(object sender, EventArgs e)
        {
            Double CostofItem = 210;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Watermelon Juice"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Watermelon Juice", 1, CostofItem);
            AddCost();
        }

        private void herbalblacktea_Click(object sender, EventArgs e)
        {
            Double CostofItem = 190;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Herbal Black Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value * 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Herbal Black Tea", 1, CostofItem);
            AddCost();
        }
    }
}

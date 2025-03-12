namespace AdrianAmperr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "Inside Out 2", "Deadpool and Wolverine", "Moana 2", "Despicable Me 4" };
            moviesCheckListBox.Items.AddRange(movies);

            moviesCheckListBox.CheckOnClick = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (moviesListBox.SelectedItems.Count >= 1)
            {
                moviesListBox.Items.Remove(moviesListBox.SelectedItems);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearallBtn_Click(object sender, EventArgs e)
        {
            moviesListBox.Items.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movies in moviesCheckListBox.Items)
            {

                bool isSelected = moviesCheckListBox.GetItemChecked(moviesCheckListBox.Items.IndexOf(movies));
                if (isSelected && !moviesCheckListBox.Items.Contains(movies))
                {
                    moviesListBox.Items.Add(movies);

                }
            }
        }

        private void moviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
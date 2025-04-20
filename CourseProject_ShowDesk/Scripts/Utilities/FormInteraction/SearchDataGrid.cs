using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class SearchDataGrid
    {
        private readonly DataGridView dataGridView;
        private readonly List<int> resultIndexes;
        private int currentIndex;

        public SearchDataGrid(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            this.resultIndexes = new List<int>();
            this.currentIndex = 0;
        }

        public bool HasResults()
        {
            return resultIndexes.Count > 0;
        }

        public void ClearResults()
        {
            resultIndexes.Clear();
            currentIndex = 0;
        }

        public void Search(string searchValue)
        {
            ClearResults();

            dataGridView.Focus();

            if (string.IsNullOrWhiteSpace(searchValue)) return;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var row = dataGridView.Rows[i];
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        cell.Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        resultIndexes.Add(i);
                        break;
                    }
                }
            }
        }

        public void HighlightCurrentResult()
        {
            if (!HasResults()) return;

            int rowIndex = resultIndexes[currentIndex];
            dataGridView.ClearSelection();
            dataGridView.Rows[rowIndex].Selected = true;
            dataGridView.FirstDisplayedScrollingRowIndex = rowIndex;
        }

        public void MoveNext()
        {
            if (!HasResults()) return;
            currentIndex = (currentIndex + 1) % resultIndexes.Count;
            HighlightCurrentResult();
        }

        public void MovePrevious()
        {
            if (!HasResults()) return;
            currentIndex = (currentIndex - 1 + resultIndexes.Count) % resultIndexes.Count;
            HighlightCurrentResult();
        }

        public void SearchNavigation(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MoveNext();
                //e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                MovePrevious();
                //e.Handled = true;
            }
        }
    }
}


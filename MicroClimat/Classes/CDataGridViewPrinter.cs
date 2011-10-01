using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MicroClimat.Classes
{
    class DataGridViewPrinter
    {
        private readonly DataGridView _theDataGridView; // The DataGridView Control which will be printed
        private readonly PrintDocument _thePrintDocument; // The PrintDocument to be used for printing
        private readonly bool _isCenterOnPage; // Determine if the report will be printed in the Top-Center of the page
        private readonly bool _isWithTitle; // Determine if the page contain title text
        private readonly string _theTitleText; // The title text to be printed in each page (if IsWithTitle is set to true)
        private readonly Font _theTitleFont; // The font to be used with the title text (if IsWithTitle is set to true)
        private readonly Color _theTitleColor; // The color to be used with the title text (if IsWithTitle is set to true)
        private readonly bool _isWithPaging; // Determine if paging is used

        static int _currentRow; // A static parameter that keep track on which Row (in the DataGridView control) that should be printed

        static int _pageNumber;

        private readonly int _pageWidth;
        private readonly int _pageHeight;
        private readonly int _leftMargin;
        private readonly int _topMargin;
        private readonly int _rightMargin;
        private readonly int _bottomMargin;

        private float _currentY; // A parameter that keep track on the y coordinate of the page, so the next object to be printed will start from this y coordinate

        private float _rowHeaderHeight;
        private readonly List<float> _rowsHeight;
        private readonly List<float> _columnsWidth;
        private float _theDataGridViewWidth;

        // Maintain a generic list to hold start/stop points for the column printing
        // This will be used for wrapping in situations where the DataGridView will not fit on a single page
        private readonly List<int[]> _mColumnPoints;
        private readonly List<float> _mColumnPointsWidth;
        private int _mColumnPoint;

        // The class constructor
        public DataGridViewPrinter(DataGridView aDataGridView, PrintDocument aPrintDocument, bool centerOnPage, bool withTitle, string aTitleText, Font aTitleFont, Color aTitleColor, bool withPaging)
        {
            _theDataGridView = aDataGridView;
            _thePrintDocument = aPrintDocument;
            _isCenterOnPage = centerOnPage;
            _isWithTitle = withTitle;
            _theTitleText = aTitleText;
            _theTitleFont = aTitleFont;
            _theTitleColor = aTitleColor;
            _isWithPaging = withPaging;

            _pageNumber = 0;

            _rowsHeight = new List<float>();
            _columnsWidth = new List<float>();

            _mColumnPoints = new List<int[]>();
            _mColumnPointsWidth = new List<float>();

            // Claculating the PageWidth and the PageHeight
            if (!_thePrintDocument.DefaultPageSettings.Landscape)
            {
                _pageWidth = _thePrintDocument.DefaultPageSettings.PaperSize.Width;
                _pageHeight = _thePrintDocument.DefaultPageSettings.PaperSize.Height;
            }
            else
            {
                _pageHeight = _thePrintDocument.DefaultPageSettings.PaperSize.Width;
                _pageWidth = _thePrintDocument.DefaultPageSettings.PaperSize.Height;
            }

            // Claculating the page margins
            _leftMargin = _thePrintDocument.DefaultPageSettings.Margins.Left;
            _topMargin = _thePrintDocument.DefaultPageSettings.Margins.Top;
            _rightMargin = _thePrintDocument.DefaultPageSettings.Margins.Right;
            _bottomMargin = _thePrintDocument.DefaultPageSettings.Margins.Bottom;

            // First, the current row to be printed is the first row in the DataGridView control
            _currentRow = 0;
        }

        // The function that calculate the height of each row (including the header row), the width of each column (according to the longest text in all its cells including the header cell), and the whole DataGridView width
        private void Calculate(Graphics g)
        {
            if (_pageNumber == 0) // Just calculate once
            {
                _theDataGridViewWidth = 0;
                for (int i = 0; i < _theDataGridView.Columns.Count - 1; i++)
                {
                    Font tmpFont = _theDataGridView.ColumnHeadersDefaultCellStyle.Font ??
                                   _theDataGridView.DefaultCellStyle.Font;

                    SizeF tmpSize = g.MeasureString(_theDataGridView.Columns[i].HeaderText, tmpFont);
                    float tmpWidth = tmpSize.Width;
                    _rowHeaderHeight = tmpSize.Height;

                    for (int j = 0; j < _theDataGridView.Rows.Count; j++)
                    {
                        tmpFont = _theDataGridView.Rows[j].DefaultCellStyle.Font ?? _theDataGridView.DefaultCellStyle.Font;

                        tmpSize = g.MeasureString("Anything", tmpFont);
                        _rowsHeight.Add(tmpSize.Height);

                        tmpSize = g.MeasureString(_theDataGridView.Rows[j].Cells[i].EditedFormattedValue.ToString(), tmpFont);
                        if (tmpSize.Width > tmpWidth)
                            tmpWidth = tmpSize.Width;
                    }
                    if (_theDataGridView.Columns[i].Visible)
                        _theDataGridViewWidth += tmpWidth;
                    _columnsWidth.Add(tmpWidth);
                }

                // Define the start/stop column points based on the page width and the DataGridView Width
                // We will use this to determine the columns which are drawn on each page and how wrapping will be handled
                // By default, the wrapping will occurr such that the maximum number of columns for a page will be determine
                int k;

                int mStartPoint = 0;
                for (k = 0; k < _theDataGridView.Columns.Count; k++)
                    if (_theDataGridView.Columns[k].Visible)
                    {
                        mStartPoint = k;
                        break;
                    }

                int mEndPoint = _theDataGridView.Columns.Count;
                for (k = _theDataGridView.Columns.Count - 1; k >= 0; k--)
                    if (_theDataGridView.Columns[k].Visible)
                    {
                        mEndPoint = k + 1;
                        break;
                    }

                float mTempWidth = _theDataGridViewWidth;
                float mTempPrintArea = _pageWidth - (float)_leftMargin - _rightMargin;

                // We only care about handling where the total datagridview width is bigger then the print area
                if (_theDataGridViewWidth > mTempPrintArea)
                {
                    mTempWidth = 0.0F;
                    for (k = 0; k < _theDataGridView.Columns.Count - 1; k++)
                    {
                        if (_theDataGridView.Columns[k].Visible)
                        {
                            mTempWidth += _columnsWidth[k];
                            // If the width is bigger than the page area, then define a new column print range
                            if (mTempWidth > mTempPrintArea)
                            {
                                mTempWidth -= _columnsWidth[k];
                                _mColumnPoints.Add(new[] { mStartPoint, mEndPoint });
                                _mColumnPointsWidth.Add(mTempWidth);
                                mStartPoint = k;
                                mTempWidth = _columnsWidth[k];
                            }
                        }
                        // Our end point is actually one index above the current index
                        mEndPoint = k + 1;
                    }
                }
                // Add the last set of columns
                _mColumnPoints.Add(new[] { mStartPoint, mEndPoint });
                _mColumnPointsWidth.Add(mTempWidth);
                _mColumnPoint = 0;
            }
        }

        // The funtion that print the title, page number, and the header row
        private void DrawHeader(Graphics g)
        {
            _currentY = _topMargin;

            // Printing the page number (if isWithPaging is set to true)
            if (_isWithPaging)
            {
                _pageNumber++;
                string pageString = "Page " + _pageNumber.ToString();

                var pageStringFormat = new StringFormat
                                           {
                                               Trimming = StringTrimming.Word,
                                               FormatFlags =
                                                   StringFormatFlags.NoWrap | StringFormatFlags.LineLimit |
                                                   StringFormatFlags.NoClip,
                                               Alignment = StringAlignment.Far
                                           };

                var pageStringFont = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);

                var pageStringRectangle = new RectangleF(_leftMargin, _currentY, _pageWidth - (float)_rightMargin - _leftMargin, g.MeasureString(pageString, pageStringFont).Height);

                g.DrawString(pageString, pageStringFont, new SolidBrush(Color.Black), pageStringRectangle, pageStringFormat);

                _currentY += g.MeasureString(pageString, pageStringFont).Height;
            }

            // Printing the title (if IsWithTitle is set to true)
            if (_isWithTitle)
            {
                var titleFormat = new StringFormat
                                      {
                                          Trimming = StringTrimming.Word,
                                          FormatFlags =
                                              StringFormatFlags.NoWrap | StringFormatFlags.LineLimit |
                                              StringFormatFlags.NoClip,
                                          Alignment = _isCenterOnPage ? StringAlignment.Center : StringAlignment.Near
                                      };

                var titleRectangle = new RectangleF(_leftMargin, _currentY, _pageWidth - (float)_rightMargin - _leftMargin, g.MeasureString(_theTitleText, _theTitleFont).Height);

                g.DrawString(_theTitleText, _theTitleFont, new SolidBrush(_theTitleColor), titleRectangle, titleFormat);

                _currentY += g.MeasureString(_theTitleText, _theTitleFont).Height;
            }

            // Calculating the starting x coordinate that the printing process will start from
            float currentX = _leftMargin;
            if (_isCenterOnPage)
                currentX += ((_pageWidth - (float)_rightMargin - _leftMargin) - _mColumnPointsWidth[_mColumnPoint]) / 2.0F;

            // Setting the HeaderFore style
            Color headerForeColor = _theDataGridView.ColumnHeadersDefaultCellStyle.ForeColor;
            if (headerForeColor.IsEmpty) // If there is no special HeaderFore style, then use the default DataGridView style
                headerForeColor = _theDataGridView.DefaultCellStyle.ForeColor;
            var headerForeBrush = new SolidBrush(headerForeColor);

            // Setting the HeaderBack style
            Color headerBackColor = _theDataGridView.ColumnHeadersDefaultCellStyle.BackColor;
            if (headerBackColor.IsEmpty) // If there is no special HeaderBack style, then use the default DataGridView style
                headerBackColor = _theDataGridView.DefaultCellStyle.BackColor;
            var headerBackBrush = new SolidBrush(headerBackColor);

            // Setting the LinePen that will be used to draw lines and rectangles (derived from the GridColor property of the DataGridView control)
            var theLinePen = new Pen(_theDataGridView.GridColor, 1);

            // Setting the HeaderFont style
            Font headerFont = _theDataGridView.ColumnHeadersDefaultCellStyle.Font ??
                              _theDataGridView.DefaultCellStyle.Font;

            // Calculating and drawing the HeaderBounds        
            var headerBounds = new RectangleF(currentX, _currentY, _mColumnPointsWidth[_mColumnPoint], _rowHeaderHeight);
            g.FillRectangle(headerBackBrush, headerBounds);

            // Setting the format that will be used to print each cell of the header row
            var cellFormat = new StringFormat
                                 {
                                     Trimming = StringTrimming.Word,
                                     FormatFlags =
                                         StringFormatFlags.NoWrap | StringFormatFlags.LineLimit |
                                         StringFormatFlags.NoClip
                                 };

            // Printing each visible cell of the header row
            for (var i = (int)_mColumnPoints[_mColumnPoint].GetValue(0); i < (int)_mColumnPoints[_mColumnPoint].GetValue(1); i++)
            {
                if (!_theDataGridView.Columns[i].Visible) continue; // If the column is not visible then ignore this iteration

                float columnWidth = _columnsWidth[i];

                // Check the CurrentCell alignment and apply it to the CellFormat
                if (_theDataGridView.ColumnHeadersDefaultCellStyle.Alignment.ToString().Contains("Right"))
                    cellFormat.Alignment = StringAlignment.Far;
                else if (_theDataGridView.ColumnHeadersDefaultCellStyle.Alignment.ToString().Contains("Center"))
                    cellFormat.Alignment = StringAlignment.Center;
                else
                    cellFormat.Alignment = StringAlignment.Near;

                var cellBounds = new RectangleF(currentX, _currentY, columnWidth, _rowHeaderHeight);

                // Printing the cell text
                g.DrawString(_theDataGridView.Columns[i].HeaderText, headerFont, headerForeBrush, cellBounds, cellFormat);

                // Drawing the cell bounds
                if (_theDataGridView.RowHeadersBorderStyle != DataGridViewHeaderBorderStyle.None) // Draw the cell border only if the HeaderBorderStyle is not None
                    g.DrawRectangle(theLinePen, currentX, _currentY, columnWidth, _rowHeaderHeight);

                currentX += columnWidth;
            }

            _currentY += _rowHeaderHeight;
        }

        // The function that print a bunch of rows that fit in one page
        // When it returns true, meaning that there are more rows still not printed, so another PagePrint action is required
        // When it returns false, meaning that all rows are printed (the CureentRow parameter reaches the last row of the DataGridView control) and no further PagePrint action is required
        private bool DrawRows(Graphics g)
        {
            // Setting the LinePen that will be used to draw lines and rectangles (derived from the GridColor property of the DataGridView control)
            var theLinePen = new Pen(_theDataGridView.GridColor, 1);

            // The style paramters that will be used to print each cell

            // Setting the format that will be used to print each cell
            var cellFormat = new StringFormat
                                 {
                                     Trimming = StringTrimming.Word,
                                     FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit
                                 };

            // Printing each visible cell
            while (_currentRow < _theDataGridView.Rows.Count)
            {
                if (_theDataGridView.Rows[_currentRow].Visible) // Print the cells of the CurrentRow only if that row is visible
                {
                    // Setting the row font style
                    Font rowFont = _theDataGridView.Rows[_currentRow].DefaultCellStyle.Font ??
                                   _theDataGridView.DefaultCellStyle.Font;

                    // Setting the RowFore style
                    Color rowForeColor = _theDataGridView.Rows[_currentRow].DefaultCellStyle.ForeColor;
                    if (rowForeColor.IsEmpty) // If the there is no special RowFore style of the CurrentRow, then use the default one associated with the DataGridView control
                        rowForeColor = _theDataGridView.DefaultCellStyle.ForeColor;
                    var rowForeBrush = new SolidBrush(rowForeColor);

                    // Setting the RowBack (for even rows) and the RowAlternatingBack (for odd rows) styles
                    Color rowBackColor = _theDataGridView.Rows[_currentRow].DefaultCellStyle.BackColor;
                    SolidBrush rowAlternatingBackBrush;
                    SolidBrush rowBackBrush;
                    if (rowBackColor.IsEmpty) // If the there is no special RowBack style of the CurrentRow, then use the default one associated with the DataGridView control
                    {
                        rowBackBrush = new SolidBrush(_theDataGridView.DefaultCellStyle.BackColor);
                        rowAlternatingBackBrush = new SolidBrush(_theDataGridView.AlternatingRowsDefaultCellStyle.BackColor);
                    }
                    else // If the there is a special RowBack style of the CurrentRow, then use it for both the RowBack and the RowAlternatingBack styles
                    {
                        rowBackBrush = new SolidBrush(rowBackColor);
                        rowAlternatingBackBrush = new SolidBrush(rowBackColor);
                    }

                    // Calculating the starting x coordinate that the printing process will start from
                    var currentX = (float)_leftMargin;
                    if (_isCenterOnPage)
                        currentX += ((_pageWidth - (float)_rightMargin - _leftMargin) - _mColumnPointsWidth[_mColumnPoint]) / 2.0F;

                    // Calculating the entire CurrentRow bounds                
                    var rowBounds = new RectangleF(currentX, _currentY, _mColumnPointsWidth[_mColumnPoint], _rowsHeight[_currentRow]);

                    // Filling the back of the CurrentRow
                    g.FillRectangle(_currentRow%2 == 0 ? rowBackBrush : rowAlternatingBackBrush, rowBounds);

                    // Printing each visible cell of the CurrentRow                
                    for (var currentCell = (int)_mColumnPoints[_mColumnPoint].GetValue(0); currentCell < (int)_mColumnPoints[_mColumnPoint].GetValue(1); currentCell++)
                    {
                        if (!_theDataGridView.Columns[currentCell].Visible) continue; // If the cell is belong to invisible column, then ignore this iteration

                        // Check the CurrentCell alignment and apply it to the CellFormat
                        if (_theDataGridView.Columns[currentCell].DefaultCellStyle.Alignment.ToString().Contains("Right"))
                            cellFormat.Alignment = StringAlignment.Far;
                        else if (_theDataGridView.Columns[currentCell].DefaultCellStyle.Alignment.ToString().Contains("Center"))
                            cellFormat.Alignment = StringAlignment.Center;
                        else
                            cellFormat.Alignment = StringAlignment.Near;

                        float columnWidth = _columnsWidth[currentCell];
                        var cellBounds = new RectangleF(currentX, _currentY, columnWidth, _rowsHeight[_currentRow]);

                        // Printing the cell text
                        g.DrawString(_theDataGridView.Rows[_currentRow].Cells[currentCell].EditedFormattedValue.ToString(), rowFont, rowForeBrush, cellBounds, cellFormat);

                        // Drawing the cell bounds
                        if (_theDataGridView.CellBorderStyle != DataGridViewCellBorderStyle.None) // Draw the cell border only if the CellBorderStyle is not None
                            g.DrawRectangle(theLinePen, currentX, _currentY, columnWidth, _rowsHeight[_currentRow]);

                        currentX += columnWidth;
                    }
                    _currentY += _rowsHeight[_currentRow];

                    // Checking if the CurrentY is exceeds the page boundries
                    // If so then exit the function and returning true meaning another PagePrint action is required
                    if ((int)_currentY > (_pageHeight - _topMargin - _bottomMargin))
                    {
                        _currentRow++;
                        return true;
                    }
                }
                _currentRow++;
            }

            _currentRow = 0;
            _mColumnPoint++; // Continue to print the next group of columns

            if (_mColumnPoint == _mColumnPoints.Count) // Which means all columns are printed
            {
                _mColumnPoint = 0;
                return false;
            }
            return true;
        }

        // The method that calls all other functions
        public bool DrawDataGridView(Graphics g)
        {
            try
            {
                Calculate(g);
                DrawHeader(g);
                bool bContinue = DrawRows(g);
                return bContinue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Operation failed: " + ex.Message, Application.ProductName + @" - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CLogger.AddException(ex);
                return false;
            }
        }
    }
}
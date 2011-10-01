using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using MicroClimat.Classes;

namespace MicroClimat.Controls
{
    public partial class SplitButton : Button
    {
        #region Fields

        private bool _doubleClickedEnabled;

        private bool _alwaysDropDown;
        private bool _alwaysHoverChange;

        private bool _calculateSplitRect = true;
        private bool _fillSplitHeight = true;
        private int _splitHeight;
        private int _splitWidth;

        private String _normalImage;
        private String _hoverImage;
        private String _clickedImage;
        private String _disabledImage;
        private String _focusedImage;

        private ImageList _defaultSplitImages;


        [Browsable(true)]
        [Category("Action")]
        [Description("Occurs when the button part of the SplitButton is clicked.")]
        public event EventHandler ButtonClick;

        [Browsable(true)]
        [Category("Action")]
        [Description("Occurs when the button part of the SplitButton is clicked.")]
        public event EventHandler ButtonDoubleClick;

        #endregion


        #region Properties
        /// <summary>
        /// 
        /// </summary>
        [Category("Behavior")]
        [Description("Indicates whether the double click event is raised on the SplitButton")]
        [DefaultValue(false)]
        public bool DoubleClickedEnabled
        {
            get { return _doubleClickedEnabled; }
            set { _doubleClickedEnabled = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button")]
        [Description("Indicates whether the SplitButton always shows the drop down menu even if the button part of the SplitButton is clicked.")]
        [DefaultValue(false)]
        public bool AlwaysDropDown
        {
            get
            {
                return _alwaysDropDown;
            }
            set
            {
                _alwaysDropDown = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button")]
        [Description("Indicates whether the SplitButton always shows the Hover image status in the split part even if the button part of the SplitButton is hovered.")]
        [DefaultValue(false)]
        public bool AlwaysHoverChange
        {
            get
            {
                return _alwaysHoverChange;
            }
            set
            {
                _alwaysHoverChange = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button")]
        [Description("Indicates whether the split rectange must be calculated (basing on Split image size)")]
        [DefaultValue(true)]
        private bool CalculateSplitRect
        {
            get
            {
                return _calculateSplitRect;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [fill split height].
        /// </summary>
        /// <value><c>true</c> if [fill split height]; otherwise, <c>false</c>.</value>
        [Category("Split Button")]
        [Description("Indicates whether the split height must be filled to the button height even if the split image height is lower.")]
        [DefaultValue(true)]
        public bool FillSplitHeight
        {
            get
            {
                return _fillSplitHeight;
            }
            set
            {
                _fillSplitHeight = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button")]
        [Description("The split height (ignored if CalculateSplitRect is setted to true).")]
        [DefaultValue(0)]
        private int SplitHeight
        {
            get
            {
                return _splitHeight;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button")]
        [Description("The split width (ignored if CalculateSplitRect is setted to true).")]
        [DefaultValue(0)]
        public int SplitWidth
        {
            get
            {
                return _splitWidth;
            }
            set
            {
                _splitWidth = value;

                if (!_calculateSplitRect)
                {
                    if (_splitWidth > 0 && _splitHeight > 0)
                    {
                        InitDefaultSplitImages(true);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button Images")]
        [Description("The Normal status image name in the ImageList.")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)), Localizable(true), RefreshProperties(RefreshProperties.Repaint), TypeConverter(typeof(ImageKeyConverter))]
        public String NormalImage
        {
            get
            {
                return _normalImage;
            }
            set
            {
                _normalImage = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button Images")]
        [Description("The Hover status image name in the ImageList.")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)), Localizable(true), RefreshProperties(RefreshProperties.Repaint), TypeConverter(typeof(ImageKeyConverter))]
        public String HoverImage
        {
            get
            {
                return _hoverImage;
            }
            set
            {
                _hoverImage = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button Images")]
        [Description("The Clicked status image name in the ImageList.")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)), Localizable(true), RefreshProperties(RefreshProperties.Repaint), TypeConverter(typeof(ImageKeyConverter))]
        public String ClickedImage
        {
            get
            {
                return _clickedImage;
            }
            set
            {
                _clickedImage = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button Images")]
        [Description("The Disabled status image name in the ImageList.")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)), Localizable(true), RefreshProperties(RefreshProperties.Repaint), TypeConverter(typeof(ImageKeyConverter))]
        public String DisabledImage
        {
            get
            {
                return _disabledImage;
            }
            set
            {
                _disabledImage = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Split Button Images")]
        [Description("The Focused status image name in the ImageList.")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)), Localizable(true), RefreshProperties(RefreshProperties.Repaint), TypeConverter(typeof(ImageKeyConverter))]
        public String FocusedImage
        {
            get
            {
                return _focusedImage;
            }
            set
            {
                _focusedImage = value;
            }
        }

        #endregion


        #region Construction

        public SplitButton()
        {
            InitializeComponent();
        }

        #endregion


        #region Methods

        protected override void OnCreateControl()
        {
            InitDefaultSplitImages();

            if (ImageList == null)
                ImageList = _defaultSplitImages;

            SetSplit(Enabled ? _normalImage : _disabledImage);

            base.OnCreateControl();
        }

        private void InitDefaultSplitImages(bool refresh = false)
        {
            if (String.IsNullOrEmpty(_normalImage))
                _normalImage = "Normal";

            if (String.IsNullOrEmpty(_hoverImage))
                _hoverImage = "Hover";

            if (String.IsNullOrEmpty(_clickedImage))
                _clickedImage = "Clicked";

            if (String.IsNullOrEmpty(_disabledImage))
                _disabledImage = "Disabled";

            if (String.IsNullOrEmpty(_focusedImage))
                _focusedImage = "Focused";

            if (_defaultSplitImages == null)
                _defaultSplitImages = new ImageList();

            if (_defaultSplitImages.Images.Count == 0 || refresh)
            {
                if (_defaultSplitImages.Images.Count > 0)
                    _defaultSplitImages.Images.Clear();

                try
                {
                    int w;
                    int h;

                    if (!_calculateSplitRect && _splitWidth > 0)
                        w = _splitWidth;
                    else
                        w = 18;

                    if (!CalculateSplitRect && SplitHeight > 0)
                        h = SplitHeight;
                    else
                        h = Height;

                    h -= 8;

                    _defaultSplitImages.ImageSize = new Size(w, h);

                    int mw = w / 2;
                    mw += (mw % 2);
                    int mh = h / 2;

                    var fPen = new Pen(ForeColor, 1);
                    var fBrush = new SolidBrush(ForeColor);

                    var imgN = new Bitmap(w, h);
                    Graphics g = Graphics.FromImage(imgN);

                    g.CompositingQuality = CompositingQuality.HighQuality;

                    g.DrawLine(SystemPens.ButtonShadow, new Point(1, 1), new Point(1, h - 2));
                    g.DrawLine(SystemPens.ButtonFace, new Point(2, 1), new Point(2, h));

                    g.FillPolygon(fBrush, new[] { new Point(mw - 2, mh - 1), 
                                                         new Point(mw + 3, mh - 1),
                                                         new Point(mw, mh + 2) });

                    g.Dispose();

                    var imgH = new Bitmap(w, h);
                    g = Graphics.FromImage(imgH);

                    g.CompositingQuality = CompositingQuality.HighQuality;

                    g.DrawLine(SystemPens.ButtonShadow, new Point(1, 1), new Point(1, h - 2));
                    g.DrawLine(SystemPens.ButtonFace, new Point(2, 1), new Point(2, h));

                    g.FillPolygon(fBrush, new[] { new Point(mw - 3, mh - 2), 
                                                         new Point(mw + 4, mh - 2),
                                                         new Point(mw, mh + 2) });

                    g.Dispose();

                    var imgC = new Bitmap(w, h);
                    g = Graphics.FromImage(imgC);

                    g.CompositingQuality = CompositingQuality.HighQuality;

                    g.DrawLine(SystemPens.ButtonShadow, new Point(1, 1), new Point(1, h - 2));
                    g.DrawLine(SystemPens.ButtonFace, new Point(2, 1), new Point(2, h));

                    g.FillPolygon(fBrush, new[] { new Point(mw - 2, mh - 1), 
                                                         new Point(mw + 3, mh - 1),
                                                         new Point(mw, mh + 2) });

                    g.Dispose();

                    var imgD = new Bitmap(w, h);
                    g = Graphics.FromImage(imgD);

                    g.CompositingQuality = CompositingQuality.HighQuality;

                    g.DrawLine(SystemPens.GrayText, new Point(1, 1), new Point(1, h - 2));

                    g.FillPolygon(new SolidBrush(SystemColors.GrayText), new[] { new Point(mw - 2, mh - 1), 
                                                         new Point(mw + 3, mh - 1),
                                                         new Point(mw, mh + 2) });

                    g.Dispose();

                    var imgF = new Bitmap(w, h);
                    g = Graphics.FromImage(imgF);

                    g.CompositingQuality = CompositingQuality.HighQuality;

                    g.DrawLine(SystemPens.ButtonShadow, new Point(1, 1), new Point(1, h - 2));
                    g.DrawLine(SystemPens.ButtonFace, new Point(2, 1), new Point(2, h));

                    g.FillPolygon(fBrush, new[] { new Point(mw - 2, mh - 1), 
                                                         new Point(mw + 3, mh - 1),
                                                         new Point(mw, mh + 2) });

                    g.Dispose();

                    fPen.Dispose();
                    fBrush.Dispose();

                    _defaultSplitImages.Images.Add(_normalImage, imgN);
                    _defaultSplitImages.Images.Add(_hoverImage, imgH);
                    _defaultSplitImages.Images.Add(_clickedImage, imgC);
                    _defaultSplitImages.Images.Add(_disabledImage, imgD);
                    _defaultSplitImages.Images.Add(_focusedImage, imgF);
                }
                catch (Exception ex)
                {
                    CLogger.AddException(ex);
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            if (_alwaysDropDown || _alwaysHoverChange || MouseInSplit())
            {
                if (Enabled)
                    SetSplit(_hoverImage);
            }
            else
            {
                if (Enabled)
                    SetSplit(_normalImage);
            }

            base.OnMouseMove(mevent);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (Enabled)
                SetSplit(_normalImage);

            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (_alwaysDropDown || MouseInSplit())
            {
                if (Enabled)
                {
                    SetSplit(_clickedImage);

                    if (ContextMenuStrip != null && ContextMenuStrip.Items.Count > 0)
                        ContextMenuStrip.Show(this, new Point(0, Height));
                }
            }
            else
            {
                if (Enabled)
                    SetSplit(_normalImage);
            }

            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            if (_alwaysDropDown || _alwaysHoverChange || MouseInSplit())
            {
                if (Enabled)
                    SetSplit(_hoverImage);
            }
            else
            {
                if (Enabled)
                    SetSplit(_normalImage);
            }

            base.OnMouseUp(mevent);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (!Enabled)
                SetSplit(_disabledImage);
            else
            {
                SetSplit(MouseInSplit() ? _hoverImage : _normalImage);
            }

            base.OnEnabledChanged(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if (Enabled)
                SetSplit(_focusedImage);

            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (Enabled)
                SetSplit(_normalImage);

            base.OnLostFocus(e);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (!MouseInSplit() && !_alwaysDropDown)
            {
                if (ButtonClick != null)
                    ButtonClick(this, e);
            }
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            if (_doubleClickedEnabled)
            {
                base.OnDoubleClick(e);

                if (!MouseInSplit() && !_alwaysDropDown)
                {
                    if (ButtonClick != null)
                        ButtonDoubleClick(this, e);
                }
            }
        }

        private void SetSplit(String imageName)
        {
            if (imageName != null && ImageList != null && ImageList.Images.ContainsKey(imageName))
                ImageKey = imageName;
        }

        private bool MouseInSplit()
        {
            return PointInSplit(PointToClient(MousePosition));
        }

        private bool PointInSplit(Point pt)
        {
            Rectangle splitRect = GetImageRect(_normalImage);

            if (!_calculateSplitRect)
            {
                splitRect.Width = _splitWidth;
                splitRect.Height = _splitHeight;
            }

            return splitRect.Contains(pt);
        }

        private Rectangle GetImageRect(String imageKey)
        {
                Image currImg = GetImage(imageKey);

                if (currImg != null)
                {
                    int x = 0,
                        y = 0,
                        w = currImg.Width+1,
                        h = currImg.Height+1;

                    if (w > Width)
                        w = Width;

                    if (h > Width)
                        h = Width;

                    switch (ImageAlign)
                    {
                        case ContentAlignment.TopLeft:
                            {
                                x = 0;
                                y = 0;

                                break;
                            }
                        case ContentAlignment.TopCenter:
                            {
                                x = (Width - w) / 2;
                                y = 0;

                                if ((Width - w) % 2 > 0)
                                {
                                    x += 1;
                                }

                                break;
                            }
                        case ContentAlignment.TopRight:
                            {
                                x = Width - w;
                                y = 0;

                                break;
                            }
                        case ContentAlignment.MiddleLeft:
                            {
                                x = 0;
                                y = (Height - h) / 2;

                                if ((Height - h) % 2 > 0)
                                {
                                    y += 1;
                                }

                                break;
                            }
                        case ContentAlignment.MiddleCenter:
                            {
                                x = (Width - w) / 2;
                                y = (Height - h) / 2;

                                if ((Width - w) % 2 > 0)
                                {
                                    x += 1;
                                }
                                if ((Height - h) % 2 > 0)
                                {
                                    y += 1;
                                }

                                break;
                            }
                        case ContentAlignment.MiddleRight:
                            {
                                x = Width - w;
                                y = (Height - h) / 2;

                                if ((Height - h) % 2 > 0)
                                {
                                    y += 1;
                                }

                                break;
                            }
                        case ContentAlignment.BottomLeft:
                            {
                                x = 0;
                                y = Height - h;

                                if ((Height - h) % 2 > 0)
                                {
                                    y += 1;
                                }

                                break;
                            }
                        case ContentAlignment.BottomCenter:
                            {
                                x = (Width - w) / 2;
                                y = Height - h;

                                if ((Width - w) % 2 > 0)
                                {
                                    x += 1;
                                }

                                break;
                            }
                        case ContentAlignment.BottomRight:
                            {
                                x = Width - w;
                                y = Height - h;

                                break;
                            }
                    }

                    if (_fillSplitHeight && h < Height)
                        h = Height;

                    if (x > 0)
                        x -= 1;
                    if (y > 0)
                        y -= 1;

                    return new Rectangle(x, y, w, h);
                }

            return Rectangle.Empty;
        }

        private Image GetImage(String imageName)
        {
            if (ImageList != null && ImageList.Images.ContainsKey(imageName))
                return ImageList.Images[imageName];

            return null;
        }

        #endregion
    }
}

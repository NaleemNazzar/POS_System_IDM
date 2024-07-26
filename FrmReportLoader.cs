using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    public partial class FrmReportLoader : Form
    {
        private Timer animationTimer;
        private int progressValue;
        private const int AnimationStep = 5; // Adjust the step size for smoother or faster animation
        private const int AnimationInterval = 100; // Adjust the interval for smoother or faster animation
        private const float FadeStep = 0.1f; // Step size for fade-in effect
        private const int FadeInterval = 50; // Interval for fade-in timer

        public FrmReportLoader()
        {
            InitializeComponent();
            InitializeAnimation();
        }

        private void InitializeAnimation()
        {
            animationTimer = new Timer
            {
                Interval = AnimationInterval
            };
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {
                progressValue += AnimationStep;
                UpdateProgress(progressValue);
            }
            else
            {
                animationTimer.Stop();
                // Add any additional actions after loading completes
            }
        }

        public void StartLoading(string reportName)
        {
            progressValue = 0;
            SetReportName(reportName);
            animationTimer.Start();
        }

        public void UpdateProgress(int percentage)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action(() => progressBar.Value = percentage));
                lblLoading.Invoke(new Action(() => lblLoading.Text = $"Loading... {percentage}%"));
            }
            else
            {
                progressBar.Value = percentage;
                lblLoading.Text = $"Loading... {percentage}%";
            }
        }

        public void SetReportName(string reportName)
        {
            if (lblReportName.InvokeRequired)
            {
                lblReportName.Invoke(new Action(() => lblReportName.Text = reportName));
                FadeInLabel(lblReportName);
            }
            else
            {
                lblReportName.Text = reportName;
                FadeInLabel(lblReportName);
            }
        }

        private void FadeInLabel(Label label)
        {
            Timer fadeTimer = new Timer
            {
                Interval = FadeInterval
            };
            float opacity = 0;
            label.ForeColor = Color.FromArgb(0, label.ForeColor); // Start with transparent color

            fadeTimer.Tick += (s, e) =>
            {
                if (opacity < 1)
                {
                    opacity += FadeStep;
                    label.ForeColor = Color.FromArgb((int)(255 * opacity), label.ForeColor);
                }
                else
                {
                    fadeTimer.Stop();
                }
            };
            fadeTimer.Start();
        }

        private void FrmReportLoader_Load(object sender, EventArgs e)
        {
            // Initialize form components here, if needed
        }
    }
}
namespace delegaterPractice
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sortResult = new System.Windows.Forms.ListBox();
            this.productBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sortButton1 = new System.Windows.Forms.Button();
            this.sortButton2 = new System.Windows.Forms.Button();
            this.sortButton3 = new System.Windows.Forms.Button();
            this.sortResetButton = new System.Windows.Forms.Button();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sortResult
            // 
            this.sortResult.DataSource = this.productBindingSource3;
            this.sortResult.DisplayMember = "NamePrice";
            this.sortResult.FormattingEnabled = true;
            this.sortResult.ItemHeight = 12;
            this.sortResult.Location = new System.Drawing.Point(12, 12);
            this.sortResult.Name = "sortResult";
            this.sortResult.Size = new System.Drawing.Size(173, 244);
            this.sortResult.TabIndex = 0;
            // 
            // productBindingSource3
            // 
            this.productBindingSource3.DataSource = typeof(delegaterPractice.Product);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(delegaterPractice.Product);
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(delegaterPractice.Product);
            // 
            // sortButton1
            // 
            this.sortButton1.Location = new System.Drawing.Point(12, 269);
            this.sortButton1.Name = "sortButton1";
            this.sortButton1.Size = new System.Drawing.Size(173, 31);
            this.sortButton1.TabIndex = 1;
            this.sortButton1.Text = "정렬하기1(메소드이름)";
            this.sortButton1.UseVisualStyleBackColor = true;
            this.sortButton1.Click += new System.EventHandler(this.sortButton1_Click);
            // 
            // sortButton2
            // 
            this.sortButton2.Location = new System.Drawing.Point(12, 306);
            this.sortButton2.Name = "sortButton2";
            this.sortButton2.Size = new System.Drawing.Size(173, 31);
            this.sortButton2.TabIndex = 2;
            this.sortButton2.Text = "정렬하기2(무명델리게이트)";
            this.sortButton2.UseVisualStyleBackColor = true;
            this.sortButton2.Click += new System.EventHandler(this.sortButton2_Click);
            // 
            // sortButton3
            // 
            this.sortButton3.Location = new System.Drawing.Point(12, 343);
            this.sortButton3.Name = "sortButton3";
            this.sortButton3.Size = new System.Drawing.Size(173, 31);
            this.sortButton3.TabIndex = 3;
            this.sortButton3.Text = "정렬하기3(람다)";
            this.sortButton3.UseVisualStyleBackColor = true;
            this.sortButton3.Click += new System.EventHandler(this.sortButton3_Click);
            // 
            // sortResetButton
            // 
            this.sortResetButton.Location = new System.Drawing.Point(13, 381);
            this.sortResetButton.Name = "sortResetButton";
            this.sortResetButton.Size = new System.Drawing.Size(171, 30);
            this.sortResetButton.TabIndex = 4;
            this.sortResetButton.Text = "정렬 초기화";
            this.sortResetButton.UseVisualStyleBackColor = true;
            this.sortResetButton.Click += new System.EventHandler(this.sortResetButton_Click);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(delegaterPractice.Product);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 423);
            this.Controls.Add(this.sortResetButton);
            this.Controls.Add(this.sortButton3);
            this.Controls.Add(this.sortButton2);
            this.Controls.Add(this.sortButton1);
            this.Controls.Add(this.sortResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox sortResult;
        private System.Windows.Forms.Button sortButton1;
        private System.Windows.Forms.Button sortButton2;
        private System.Windows.Forms.Button sortButton3;
        private System.Windows.Forms.Button sortResetButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.BindingSource productBindingSource3;
    }
}


namespace ExendControl
{
    partial class ParamSet
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_Param = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Param
            // 
            this.lab_Param.AutoSize = true;
            this.lab_Param.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Param.Location = new System.Drawing.Point(3, 0);
            this.lab_Param.Name = "lab_Param";
            this.lab_Param.Size = new System.Drawing.Size(26, 28);
            this.lab_Param.TabIndex = 0;
            this.lab_Param.Text = "0";
            // 
            // ParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab_Param);
            this.Name = "ParamSet";
            this.Size = new System.Drawing.Size(200, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Param;
    }
}

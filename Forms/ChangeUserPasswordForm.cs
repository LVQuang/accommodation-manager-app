﻿using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms
{
    public partial class ChangeUserPasswordForm : BaseForm
    {
        private User _user;
        private readonly UserService _userService;

        public ChangeUserPasswordForm(User user)
        {
            InitializeComponent();
            
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _user = user;

            if (_user == null)
            {
                new ToastForm("Đã có lỗi xảy ra!", true);
            }
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            if (!IsAllTextBoxFilled() || !IsPasswordMatch()) return; 
            if (textBoxPassword.Text.Length > 30)
            {
                new ToastForm("Độ dài mật khẩu không được vượt quá 30 ký tự",true).Show();
                return;
            }

            _user.Password = PasswordHelper.HashPassword(textBoxPassword.Text);
            if (_userService.Update(_user.Id, _user)) {
                new ToastForm("Sửa mật khẩu thành công").Show();
                Close();
            }
            else {
                new ToastForm("Sửa mật khẩu thất bại", true).Show();
            }
        }

        private bool IsPasswordMatch() {
            if (textBoxPassword.Text != textBoxConfirmPassword.Text) {
                new ToastForm("Mật khẩu không khớp. Vui lòng nhập lại.", true).Show();
                return false;
            }

            return true;
        }

        private bool IsAllTextBoxFilled() {
            var result = string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxConfirmPassword.Text);
            
            if (result) {
                new ToastForm("Vui lòng điền đầy đủ các trường.", true).Show();
            }

            return !result;
        }
    }
}
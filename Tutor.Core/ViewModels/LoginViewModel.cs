using Cirrious.MvvmCross.ViewModels;

namespace Tutor.Core.ViewModels
{
    public class LoginViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
    }
}

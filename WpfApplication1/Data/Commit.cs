namespace WpfApplication1.Data {
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    public class Commit : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Message { get; set; }
        public string User { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string Hash { get; set; }
        public int FilesCount { get; set; }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

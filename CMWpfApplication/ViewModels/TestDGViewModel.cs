using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace CMWpfApplication
{
    public class TestDGViewModel : ViewModelBaseEx, ITestDGViewModel
    {
        IList<TestModel> _List;
        public IList<TestModel> List
        {
            get { return _List; }
            set
            {
                _List = value;
                NotifyOfPropertyChange(() => List);
            }
        }

        public TestDGViewModel() {
            List = new List<TestModel>
            {
                new TestModel{Name = "name1", Text = "text1"},
                new TestModel{Name = "name2", Text = "text2"},
                new TestModel{Name = "name3", Text = "text3"},
                new TestModel{Name = "name4", Text = "text4"}
            };
        }
    }
}

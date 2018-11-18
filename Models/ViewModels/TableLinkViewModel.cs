using System;
using System.Collections.Generic;
using System.Text;
using Models.Entities;

namespace Models.ViewModels
{
    public class LinkViewModel
    {
        public LinkViewModel(Link link)
        {
            this.LinkId = link.LinkId;
            this.TableOneId = link.TableOneId;
            this.TableOneName = link.TableOne.Name;
            this.TableTwoId = link.TableTwoId;
            this.TableTwoName = link.TableTwo.Name;
            this.SeatsLost = link.SeatsLost;

        }
        public int LinkId { get; set; }
        public int TableOneId { get; set; }
        public string TableOneName { get; set; }
        public int TableTwoId { get; set; }
        public string TableTwoName { get; set; }
        public int SeatsLost { get; set; }
    }
}

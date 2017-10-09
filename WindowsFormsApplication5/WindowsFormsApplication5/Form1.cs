using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        struct pItem 
            {
                public long ID;
                public string surname;
                public string name;
                public string sname;
                public string town;
                public string street;
                public long house;
                public long flat;
                public string numberphone;
            }

        Dictionary<int, pItem> phonebook = new Dictionary<int,pItem>();
        
        int kolphone = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            pItem newItem = new pItem();

            newItem.ID = kolphone;
            newItem.surname = TBSurname.Text;
            newItem.name = TBName.Text;
            newItem.sname = TBSname.Text;
            newItem.town = TBTown.Text;
            newItem.street = TBStreet.Text;
            newItem.house = Convert.ToInt64(NMHouse.Value);
            newItem.flat = Convert.ToInt64(NMFlat.Value);
            newItem.numberphone = MTBPhone.Text;

            phonebook.Add(kolphone, newItem);

            kolphone++;
            tsRCount.Text = phonebook.Keys.Count.ToString();

            ClearForm();
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            if (PBNumber.Text != "")
            {
                phonebook.Remove(int.Parse(PBNumber.Text));
            }
            ClearForm();
            tsRCount.Text = phonebook.Keys.Count.ToString();
        }

        private void ClearForm()
        {
            TBSurname.Text = "";
            TBName.Text = "";
            TBSname.Text = "";
            TBTown.Text = "";
            TBStreet.Text = "";
            NMHouse.Value = 0;
            NMFlat.Value = 0;
            MTBPhone.Text = "";
            PBNumber.Text = "";
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            if (phonebook.Keys.Count > 0)
            {
                pItem curItem = new pItem();
                int cnt = 0;

                if (PBNumber.Text == "")
                {
                    curItem = phonebook[phonebook.Keys.Last()];
                }
                else
                {
                    cnt = int.Parse(PBNumber.Text);

                    if (cnt > 0)
                    {
                        while (cnt > 0)
                        {
                            cnt--;
                            if (phonebook.Keys.Contains(cnt))
                            {
                                curItem = phonebook[cnt];
                                break;
                            }
                        }
                        if (cnt > 0)
                        {
                            curItem = phonebook[cnt];
                        }
                        else
                        {
                            ClearForm();
                        }
                    }
                    else
                    {
                        curItem = phonebook[0];
                    }
                }

                if (curItem.ID != 0)
                {
                    PBNumber.Text = curItem.ID.ToString();

                    TBSurname.Text = curItem.surname;
                    TBName.Text = curItem.name;
                    TBSname.Text = curItem.sname;
                    TBTown.Text = curItem.town;
                    TBStreet.Text = curItem.street;
                    NMHouse.Value = curItem.house;
                    NMFlat.Value = curItem.flat;
                    MTBPhone.Text = curItem.numberphone;
                }
            }
        }

        private void Bforward_Click(object sender, EventArgs e)
        {
            if (phonebook.Keys.Count > 0)
            {
            pItem curItem = new pItem();
            int cnt = 0;

                if (PBNumber.Text == "")
                {
                    if (phonebook.Keys.Count > 0)
                        curItem = phonebook[phonebook.Keys.First()];
                }
                else
                {
                    cnt = int.Parse(PBNumber.Text);

                    if (cnt > 0)
                    {
                        while (cnt <= phonebook.Keys.Count)
                        {
                            cnt++;
                            if (phonebook.Keys.Contains(cnt))
                            {
                                curItem = phonebook[cnt];
                                break;
                            }
                        }
                        if (cnt <= phonebook.Keys.Count)
                        {
                            curItem = phonebook[cnt];
                        }
                        else
                        {
                            ClearForm();
                        }
                    }
                    else
                    {
                        curItem = phonebook[0];
                    }
                }

                if (curItem.ID != 0)
                {
                    PBNumber.Text = curItem.ID.ToString();

                    TBSurname.Text = curItem.surname;
                    TBName.Text = curItem.name;
                    TBSname.Text = curItem.sname;
                    TBTown.Text = curItem.town;
                    TBStreet.Text = curItem.street;
                    NMHouse.Value = curItem.house;
                    NMFlat.Value = curItem.flat;
                    MTBPhone.Text = curItem.numberphone;
                }
            }
        }

        private void Btransform_Click(object sender, EventArgs e)
        {
            if (phonebook.Keys.Count > 0)
            {
                pItem curItem = new pItem();

                if (PBNumber.Text != "")
                {
                    curItem = phonebook[int.Parse(PBNumber.Text)];

                    curItem.surname = TBSurname.Text;
                    curItem.name = TBName.Text;
                    curItem.sname = TBSname.Text;
                    curItem.town = TBTown.Text;
                    curItem.street = TBStreet.Text;
                    curItem.house = Convert.ToInt64(NMHouse.Value);
                    curItem.flat = Convert.ToInt64(NMFlat.Value);
                    curItem.numberphone = MTBPhone.Text;

                    phonebook[int.Parse(PBNumber.Text)] = curItem;
                }
            }
        }
    }
}

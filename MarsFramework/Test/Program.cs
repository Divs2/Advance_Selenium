using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void EnterShareSkill()
            {

                ShareSkill shareskillobj = new ShareSkill();
                shareskillobj.EnterShareSkill();
                Thread.Sleep(5000);
                shareskillobj.validateskill();


            }
            [Test]
            public void ManageListingEdit()
            {

                ShareSkill editobj = new ShareSkill();
                editobj.EditShareSkill();
                Thread.Sleep(5000);
                editobj.validateeditskill();


            }

            [Test]
            public void ShareSkillDelete()
            {
                ManageListings deleteobj = new ManageListings();
                deleteobj.Listings();
                Thread.Sleep(5000);
                deleteobj.validatedelete();
            }




        }
        [TestFixture]
        [Category("Sprint2")]
        class User1 : Global.Base
        {
            [Test]
            public void availabilty()
            {
                Availabilty selava = new Availabilty();
                selava.selectavailabilty();
            }
            [Test]

            public void hours()
            {
                Hours selhours = new Hours();
                selhours.Selecthours();

            }
            [Test]
            public void earntarget()
            {
                EarnTarget seltar = new EarnTarget();
                seltar.Selectearntarget();
            }

        }
        [TestFixture]
        [Category("Language")]
        class User3 : Global.Base
        {
            [Test]
            public void addlanguage()
            {
                Languges addlan = new Languges();
                addlan.addlanguage();
            }
            [Test]
            public void editlanguage()
            {
                Languges elan = new Languges();
                elan.editlanguage();
            }
            [Test]
            public void languagedelete()
            {
                Languges dellan = new Languges();
                dellan.languagedel();
            }
        }
        [TestFixture]
        [Category("Skills")]
        class User4 : Global.Base
        {
            [Test]
            public void addskills()
            {
                Skills addskill = new Skills();
                addskill.addskill();
            }
            [Test]
            public void editskills()
            {
                Skills eskill = new Skills();
                eskill.editskill();

            }
            [Test]
            public void skilldelete()
            {
                Skills delskill = new Skills();
                delskill.deleteskills();

            }

        }
        [TestFixture]
        [Category("Education")]
        class User5 : Global.Base
        {
            [Test]

            public void addedu()
            {
                Education edu = new Education();
                edu.addeducation();

            }
            [Test]
            public void editeducation()
            {
                Education eedu = new Education();
                eedu.editeducation();
            }
            [Test]
            public void edudelete()
            {
                Education dedu = new Education();
                dedu.deleteedu();
            }


        }
        [TestFixture]
        [Category("Certification")]
        class User6 : Global.Base
        {
            [Test]
            public void addcertification()
            {
                Certifiction cer = new Certifiction();
                cer.addcertificate();
            }
            [Test]
            public void certificationedit()
            {
                Certifiction eer = new Certifiction();
                eer.editcertification();
            }
            [Test]
            public void deletecertificate()
            {
                Certifiction der = new Certifiction();
                der.deletecertificaate();
            }

        }
        [TestFixture]
        [Category("Description")]
        class User7 : Global.Base
        {
            [Test]
            public void adddescription()
            {
                Description ad = new Description();
                ad.adddescription();
            }
        }
        [TestFixture]
        [Category("Notification")]
        class User8 : Global.Base
        {
            [Test]
            public void deletenotification()
            {
                Notification ad = new Notification();
                ad.notification();
            }
        }
        [TestFixture]
        [Category("Sent Request")]
        class User9 : Global.Base
        {
            [Test]
            public void sentrequest()
            {
                SentRequest SR = new SentRequest();
                SR.sentreq();
            }
        }
        [TestFixture]
        [Category("Receive Request")]
        class User10 : Global.Base
        {
            [Test]
            public void receiverequest()
            {
                ReceiveRequest rr = new ReceiveRequest();
                rr.receivereque();
            }
        }
        [TestFixture]
        [Category("Chat")]
        class User11 : Global.Base
        {
            [Test]
            public void Chat()
            {
                Chat rr = new Chat();
                rr.chat();
            }
        }
        [TestFixture]
        [Category("Change Password")]
        class User12 : Global.Base
        {
            [Test]
            public void Changepassword()
            {
                ChangePassword cp = new ChangePassword();
                cp.changepwd();
            }
        }
    }
}
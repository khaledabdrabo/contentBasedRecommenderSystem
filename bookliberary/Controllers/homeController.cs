using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookliberary.Models;
using System.IO;

namespace bookliberary.Controllers
{
    public class homeController : Controller
    {



        int ID = 0;
       static List<bookcategory> l = new List<bookcategory>() {
           new bookcategory {id=1,catName= " نصوص" },
           new bookcategory {id=2,catName= "تاريخ" },
           new bookcategory {id=3,catName= "روايات" },
           new bookcategory {id=4,catName= "سياسى" },
           new bookcategory {id=5,catName= " علم نفس" },
           new bookcategory {id=6,catName= " فلسفة" },
           new bookcategory {id=7,catName= " مقالات" },
           new bookcategory {id=8,catName= " قصص قصيرة" },
           new bookcategory {id=9,catName= " فكر اسلامى" },
           new bookcategory {id=10,catName= " تنمية بشرية" },
           new bookcategory {id=11,catName= " مقالات ساخرة" },
           new bookcategory {id=12,catName= " ادب صوفى" }
       };
        static List<books> text = new List<books>() {
            new books { id = 1, image = "1.png", author = "يوسف الدموكى", bookyear = "2019", category = "نصوص", category2="text", bookName="التنهيدة" },
            new books { id = 1, image = "2.png", author = "ادهم شرقاوى", bookyear = "2015", category = "نصوص",category2="text",bookName="حديث الصباح"},
            new books { id = 1, image = "3.png", author = "ادهم شرقاوى", bookyear = "2016", category = "نصوص",category2="text",bookName="حديث المساء"},
            new books { id = 1, image = "4.png", author = "ادهم شرقاوى", bookyear = "2015", category = "نصوص",category2="text",bookName="نبض"},
            new books { id = 1, image = "5.png", author = "ادهم شرقاوى", bookyear = "2014", category = "نصوص",category2="text",bookName="عن شئ اسمه الحب"},
            new books { id = 1, image = "6.png", author = "ادهم شرقاوى", bookyear = "2018", category = "نصوص",category2="text",bookName="عن وطن من لحم ودم"},
            new books { id = 1, image = "7.png", author = "ادهم شرقاوى", bookyear = "2016", category = "نصوص",category2="text",bookName="للرجال فقط"},
            new books { id = 1, image = "8.png", author = "حنان لاشين", bookyear = "2016", category = "نصوص",category2="text", bookName="منارات الحب"},
        };

        static List<books> literature = new List<books>() {
            new books { id = 1, image = "9.png", author = "عباس محمود العقاد", bookyear = "2019", category = "تاريخ",category2="literature", bookName="عبقريات العقاد" },
            new books { id = 2, image = "10.jpeg", author = " حنان لاشين  ", bookyear = "2015", category = "تاريخ",category2="literature", bookName="غزل البنات"},
            new books { id = 3, image = "11.png", author = " مصطفى صادق الرافعى ", bookyear = "2016", category = "تاريخ",category2="literature",bookName="وحى القلم"},
            new books { id = 4, image = "12.jpeg", author = "ادهم شرقاوى", bookyear = "2015", category = "تاريخ", category2="literature",bookName="الام فى ادب غسان كنبانى"},
            new books { id = 5, image = "13.jpeg", author = "ادهم شرقاوى", bookyear = "2014", category = "تاريخ", category2="literature",bookName="اضغاث اقلام"},
            new books { id = 6, image = "14.jpeg", author = "ادهم شرقاوى", bookyear = "2018", category = "تاريخ",category2="literature", bookName="تاملات قصيرة جدا"},
            new books { id = 7, image = "15.jpeg", author = "ادهم شرقاوى", bookyear = "2016", category = "تاريخ",category2="literature", bookName="كش ملك"},
            new books { id = 8, image = "16.jpeg", author = "ابراهيم عيسى ", bookyear = "2016", category = "تاريخ",category2="literature", bookName="حروب الرحماء"},
        };

        static List<books> Novels = new List<books>() {
            new books { id = 1, image = "17.png", author ="جيمس هنرى بريستيد", bookyear = "2019", category = "روايات",category2="Novels", bookName="فجر الضمير" },
            new books { id = 2, image = "18.jpeg", author ="غوستاف لوبون  ", bookyear = "2015", category = "روايات",category2="Novels", bookName="حضارة العرب"},
            new books { id = 3, image = "19.jpeg", author = " فيكتور مارسدن ", bookyear = "2016", category = "روايات",category2="Novels",bookName="بروتكولات حكماء العرب "},
            new books { id = 4, image = "20.jpeg", author = "محمد سمير", bookyear = "2015", category = "روايات", category2="Novels",bookName="مصارع النبلاء"},
            new books { id = 5, image = "21.jpeg", author = "عمر جوبا", bookyear = "2014", category = "روايات", category2="Novels",bookName="قبس من حكايا"},
            new books { id = 6, image = "22.png", author = "ادهم شرقاوى", bookyear = "2018", category = "روايات",category2="Novels", bookName="نطفة"},
            new books { id = 7, image = "23.png", author = " احمد خيرى العمرى", bookyear = "2016", category = "روايات",category2="Novels", bookName="ابى اسمه ابراهيم"},
            new books { id = 8, image = "24.png", author = "احمد خيرى العمرى ", bookyear = "2016", category = "روايات",category2="Novels", bookName="شيفرة بلال "},
        };
        static List<books> Policy = new List<books>() {
            new books { id = 1, image = "25.png", author ="احمد خيرى العمرى", bookyear = "2019", category = "سياسى",category2="Policy", bookName="الواح ودسر" },
            new books { id = 2, image = "26.png", author ="احمد خالد مصطفى  ", bookyear = "2015", category = "سياسى",category2="Policy", bookName=" ملائك نصابين"},
            new books { id = 3, image = "27.png", author = " منى سلامة ", bookyear = "2016", category = "سياسى",category2="Policy",bookName="بلاد تركب العنكبوت "},
            new books { id = 4, image = "28.jpeg", author = "عمر عبدالحميد", bookyear = "2015", category = "سياسى",category2="Policy", bookName="قواعد جارتين2 "},
            new books { id = 5, image = "29.png", author = "حنان لاشين", bookyear = "2014", category = "سياسى",category2="Policy", bookName="الهالة المقدسة"},
            new books { id = 6, image = "30.png", author = "ادولف هتلر", bookyear = "2018", category = "سياسى",category2="Policy", bookName="كفاحى"},
            new books { id = 7, image = "31.jpeg", author = " احمد ابراهيم اسماعيل", bookyear = "2016",category2="Policy", category = "سياسى", bookName="مدينة العتمة"},
            new books { id = 8, image = "32.png", author = "الكسيس كارليل ", bookyear = "2016", category2="Policy",category = "سياسى", bookName="الانسان ذلك المجهول "},

        };
        static List<books> psychology = new List<books>() { };
        static List<books> Sociology = new List<books>() { };
        static List<books> Articles = new List<books>() { };
        static List<books> short_stories = new List<books>() { };
        static List<books> Islamic_thought = new List<books>() { };
        static List<books> Human_Development= new List<books>() { };
        static List<books> Sarcastic_articles = new List<books>() { };
        static List<books> philosophy = new List<books>() { };



        static List<intersts> o = new List<intersts>() { };

        // GET: home
        public ActionResult home()
        {
            return View(l);
        }
        [HttpGet]
        public ActionResult addcat()
        {
            return View();
        }


        [HttpPost]
        public ActionResult addcat(bookcategory b)
        {
            l.Add(b);
            return RedirectToAction("home");
            
        }

        [HttpGet]
        public ActionResult addbook(int id)
        {
            ID = id;
            return View();
        }


        [HttpPost]
        public ActionResult addbook(books b)
        {




            //text.Add(b);

            switch (b.id)
            {
                case 1: text.Add(b); break;
                case 2: literature.Add(b); break;
                case 3: Novels.Add(b); break;
                case 4: Policy.Add(b); break;
                case 5: psychology.Add(b); break;
                case 6: Sociology.Add(b); break;
                case 7: Articles.Add(b); break;
                case 8: short_stories.Add(b); break;
                case 9: Islamic_thought.Add(b); break;
                case 10: Human_Development.Add(b); break;
                case 11: Sarcastic_articles.Add(b); break;
                case 12: philosophy.Add(b); break;

                    ViewBag.name = "done";



            }
            //return View("test");
            return RedirectToAction("getbooks",new { id=b.id });
        }
        public ActionResult getbooks(int id)
        {
            ViewBag.id = id;
            switch (id)
            {
                case 1: return View(text);break;
                case 2: return View(literature); break;
                case 3: return View(Novels); break;
                case 4: return View(Policy); break;
                case 5: return View(psychology); break;
                case 6: return View(Sociology); break;
                case 7: return View(Articles); break;
                case 8: return View(short_stories); break;
                case 9: return View(Islamic_thought); break;
                case 10: return View(Human_Development); break;
                case 11: return View(Sarcastic_articles); break;
                case 12: return View(philosophy); break;



                default:
                    break;
            }

            return View("error");
        }



        [HttpGet]
        public ActionResult add_interst()
        {
            
            return View(new intersts() {

                year = new SelectList(new List<years> {
                new years { id=1,name="2014" },
                new years { id=2,name="2015" },
                new years { id=3,name="2016" },
                new years { id=4,name="2018" },
                new years { id=5,name="2017" },
                 new years { id=1,name="2019" },
                
                }, "name", "name"),
                author = new SelectList(new List<authors> {
                new authors { id=1,name="يوسف الدموكى" },
                new authors { id=2,name="ادهم شرقاوى" },
                new authors { id=3,name="حنان لاشين" },
                new authors { id=4,name="عباس محمود العقاد" },
                new authors { id=5,name="مصطفى صادق الرافعى" },
                 new authors { id=1,name="ابراهيم عيسى" },
                new authors { id=2,name="جيمس هنرى بريستيد" },
                new authors { id=3,name="غوستاف لوبون" },
                new authors { id=4,name="محمد سمير" },
                new authors { id=5,name="فيكتور مارسدن" },

                 new authors { id=1,name="عمر جوبا" },
                new authors { id=2,name="احمد خيرى العمرى" },
                new authors { id=3,name="منى سلامة" },
                new authors { id=4,name="عمر عبدالحميد" },
                new authors { id=5,name="ادولف هتلر" },
                 new authors { id=1,name="احمد ابراهيم اسماعيل" },
                new authors { id=2,name="الكسيس كارليل" },
                
                }, "name", "name"),

                booktype = new SelectList(new List<booktypes> {
                new booktypes { id="text",name="نصوص" },
                new booktypes { id="literature",name="تاريخ" },
                new booktypes { id="Novels",name="روايات" },
                new booktypes { id="Policy",name="سياسى" },
                new booktypes { id="5",name="فلسفة" },
                 new booktypes { id="6",name="علم نفس" },
                new booktypes { id="7",name="مقالات" },
                new booktypes { id="8",name="قصص قصيرة" },
                new booktypes { id="9",name="فكر اسلامى" },
                new booktypes { id="10",name="تنمية بشرية" },

                 new booktypes { id="11",name="مقالات ساخرة" },
                new booktypes { id="12",name="ادب صوفى" },
                

                }, "id", "name")



            });



            
        }
        static public List<bookscore> b = new List<bookscore>();
        static public List<books> recommended = new List<books>();

        [HttpPost]
        public ActionResult add_interst(intersts i)
        {
            
            //string word = "تاريخ";
            //bool result = false;

            //if (word=="تاريخ") { result = true; }

            //ViewBag.msg = i.selectedbooktype;
            
            if (i.selectedbooktype == "text")
            {
                b.Clear();

                foreach (var item in text)
                {
                    
                    int counter = 0;
                    bookscore bb = new bookscore();
                    if (item.author == i.author_name) { counter++; }
                    if (item.bookyear == i.selectedyear) { counter++; }
                    if (item.category2 == i.selectedbooktype) { counter++; }
                    if ((counter * 100) / 3>=50)
                    {
                        bb.bookname = item.bookName;
                        bb.score = (counter * 100) / 3;
                    }
                    
                    b.Add(bb);
                }



                foreach (var item in text)
                {
                    foreach (var x in b)
                    {
                        if (item.bookName==x.bookname)
                        {
                            recommended.Add(item);
                        }
                    }

                }



















            }
            if (i.selectedbooktype == "literature")
            {
                b.Clear();
                foreach (var item in literature)
                {
                    int counter = 0;
                    bookscore bb = new bookscore();
                    if (item.author == i.author_name) { counter++; }
                    if (item.bookyear == i.selectedyear) { counter++; }
                    if (item.category2 == i.selectedbooktype) { counter++; }

                    if ((counter * 100) / 3 >= 70)
                    {
                        bb.bookname = item.bookName;
                        bb.score = (counter * 100) / 3;
                    }
                    b.Add(bb);
                }




                foreach (var item in literature)
                {
                    foreach (var x in b)
                    {
                        if (item.bookName == x.bookname)
                        {
                            recommended.Add(item);
                        }
                    }

                }
            }
            if (i.selectedbooktype == "Novels")
            {
                b.Clear();

                foreach (var item in Novels)
                {
                    int counter = 0;
                    bookscore bb = new bookscore();
                    if (item.author == i.author_name) { counter++; }
                    if (item.bookyear == i.selectedyear) { counter++; }
                    if (item.category2 == i.selectedbooktype) { counter++; }

                    if ((counter * 100) / 3 >= 70)
                    {
                        bb.bookname = item.bookName;
                        bb.score = (counter * 100) / 3;
                    }
                    b.Add(bb);
                }



                foreach (var item in Novels)
                {
                    foreach (var x in b)
                    {
                        if (item.bookName == x.bookname)
                        {
                            recommended.Add(item);
                        }
                    }

                }
            }
            if (i.selectedbooktype == "Policy")
            {
                b.Clear();
                foreach (var item in Policy)
                {
                    int counter = 0;
                    bookscore bb = new bookscore();
                    if (item.author == i.author_name) { counter++; }
                    if (item.bookyear == i.selectedyear) { counter++; }
                    if (item.category2 == i.selectedbooktype) { counter++; }

                    if ((counter * 100) / 3 >= 70)
                    {
                        bb.bookname = item.bookName;
                        bb.score = (counter * 100) / 3;
                    }
                    b.Add(bb);
                }
                foreach (var item in Policy)
                {
                    foreach (var x in b)
                    {
                        if (item.bookName == x.bookname)
                        {
                            recommended.Add(item);
                        }
                    }

                }
            }



            o.Add(i);
            return View("recommended", recommended);
        }
    }
}
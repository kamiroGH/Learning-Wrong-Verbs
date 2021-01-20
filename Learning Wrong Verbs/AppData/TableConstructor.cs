using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Learning_Wrong_Verbs.AppData
{
    public class TableConstructor
    {
        public TableConstructor() 
        {
            allWrongVerbs.Add(new WrongVerb("бути", "be", "was, were", "been"));
            allWrongVerbs.Add(new WrongVerb("ставати", "become", "became", "become"));
            allWrongVerbs.Add(new WrongVerb("починати", "begin", "began", "begun"));
            allWrongVerbs.Add(new WrongVerb("згинати", "bend", "bent", "bent"));
            allWrongVerbs.Add(new WrongVerb("кусати", "bite", "bit", "bitten"));
            allWrongVerbs.Add(new WrongVerb("дути", "blow", "blew", "blown"));
            allWrongVerbs.Add(new WrongVerb("ламати", "break", "broke", "broken"));
            allWrongVerbs.Add(new WrongVerb("приносити", "bring", "brought", "brought"));
            allWrongVerbs.Add(new WrongVerb("будувати", "build", "built", "built"));
            allWrongVerbs.Add(new WrongVerb("горіти", "burn", "burnt", "burnt"));
            allWrongVerbs.Add(new WrongVerb("купляти", "buy", "bought", "bought"));
            allWrongVerbs.Add(new WrongVerb("могти", "can", "could", "been able to"));
            allWrongVerbs.Add(new WrongVerb("ловити", "catch", "caught", "caught"));
            allWrongVerbs.Add(new WrongVerb("вибирати", "choose", "chose", "chosen"));
            allWrongVerbs.Add(new WrongVerb("приходити", "come", "came", "come"));
            allWrongVerbs.Add(new WrongVerb("коштувати", "cost", "cost", "cost"));
            allWrongVerbs.Add(new WrongVerb("різати", "cut", "cut", "cut"));
            allWrongVerbs.Add(new WrongVerb("робити", "do", "did", "done"));
            allWrongVerbs.Add(new WrongVerb("малювати", "draw", "drew", "drawn"));
            allWrongVerbs.Add(new WrongVerb("пити", "drink", "drank", "drunk"));
            allWrongVerbs.Add(new WrongVerb("водити", "drive", "drove", "driven"));
            allWrongVerbs.Add(new WrongVerb("їсти", "eat", "ate", "eaten"));
            allWrongVerbs.Add(new WrongVerb("падати", "fall", "fell", "fallen"));
            allWrongVerbs.Add(new WrongVerb("відчувати", "feel", "felt", "felt"));
            allWrongVerbs.Add(new WrongVerb("боротися", "fight", "fought", "fought"));
            allWrongVerbs.Add(new WrongVerb("находити", "find", "found", "found"));
            allWrongVerbs.Add(new WrongVerb("літати", "fly", "flew", "flown"));
            allWrongVerbs.Add(new WrongVerb("забувати", "forget", "forgot", "forgotten"));
            allWrongVerbs.Add(new WrongVerb("отримувати", "get", "got", "got"));
            allWrongVerbs.Add(new WrongVerb("давати", "give", "gave", "given"));
            allWrongVerbs.Add(new WrongVerb("йти", "go", "went", "gone"));
            allWrongVerbs.Add(new WrongVerb("рости", "grow", "grew", "grown"));
            allWrongVerbs.Add(new WrongVerb("вішати", "hang", "hung", "hung"));
            allWrongVerbs.Add(new WrongVerb("мати", "have", "had", "had"));
            allWrongVerbs.Add(new WrongVerb("чути", "hear", "heard", "heard"));
            allWrongVerbs.Add(new WrongVerb("ховати", "hide", "hid", "hidden"));
            allWrongVerbs.Add(new WrongVerb("влучати", "hit", "hit", "hit"));
            allWrongVerbs.Add(new WrongVerb("тримати", "keep", "kept", "kept"));
            allWrongVerbs.Add(new WrongVerb("знати", "know", "knew", "known"));
            allWrongVerbs.Add(new WrongVerb("класти", "lay", "laid", "laid"));
            allWrongVerbs.Add(new WrongVerb("вести", "lead", "led", "led"));
            allWrongVerbs.Add(new WrongVerb("вчити", "learn", "learnt", "learnt"));
            allWrongVerbs.Add(new WrongVerb("залишати", "leave", "left", "left"));
            allWrongVerbs.Add(new WrongVerb("давати в борг", "lend", "lent", "lent"));
            allWrongVerbs.Add(new WrongVerb("втрачати", "lose", "lost", "lost"));
            allWrongVerbs.Add(new WrongVerb("виробляти", "make", "made", "made"));
            allWrongVerbs.Add(new WrongVerb("значити", "mean", "meant", "meant"));
            allWrongVerbs.Add(new WrongVerb("зустрічати", "meet", "met", "met"));
            allWrongVerbs.Add(new WrongVerb("подолати", "overcome", "overcame", "overcome"));
            allWrongVerbs.Add(new WrongVerb("платити", "pay", "paid", "paid"));
            allWrongVerbs.Add(new WrongVerb("покласти", "put", "put", "put"));
            allWrongVerbs.Add(new WrongVerb("читати", "read", "read", "read"));
            allWrongVerbs.Add(new WrongVerb("їздити верхи", "ride", "rode", "ridden"));
            allWrongVerbs.Add(new WrongVerb("звеніти", "ring", "rang", "rung"));
            allWrongVerbs.Add(new WrongVerb("бігти", "run", "ran", "run"));
            allWrongVerbs.Add(new WrongVerb("казати", "say", "said", "said"));
            allWrongVerbs.Add(new WrongVerb("бачити", "see", "saw", "seen"));
            allWrongVerbs.Add(new WrongVerb("продавати", "sell", "sold", "sold"));
            allWrongVerbs.Add(new WrongVerb("посилати", "send", "sent", "sent"));
            allWrongVerbs.Add(new WrongVerb("ставити", "set", "set", "set"));
            allWrongVerbs.Add(new WrongVerb("струсити", "shake", "shook", "shaken"));
            allWrongVerbs.Add(new WrongVerb("світити", "shine", "shot", "shot"));
            allWrongVerbs.Add(new WrongVerb("показувати", "show", "showed", "shown"));
            allWrongVerbs.Add(new WrongVerb("закривати", "shut", "shut", "shut"));
            allWrongVerbs.Add(new WrongVerb("співати", "sing", "sang", "sung"));
            allWrongVerbs.Add(new WrongVerb("тонути", "sink", "sank", "sunk"));
            allWrongVerbs.Add(new WrongVerb("сидіти", "sit", "sat", "sat"));
            allWrongVerbs.Add(new WrongVerb("спати", "sleep", "slept", "slept"));
            allWrongVerbs.Add(new WrongVerb("пахнути", "smell", "smelt", "smelt"));
            allWrongVerbs.Add(new WrongVerb("говорити", "speak", "spoke", "spoken"));
            allWrongVerbs.Add(new WrongVerb("вимовляти по буквах", "spell", "spelt", "spelt"));
            allWrongVerbs.Add(new WrongVerb("витрачати", "spend", "spent", "spent"));
            allWrongVerbs.Add(new WrongVerb("проливати", "spill", "spilt", "spilt"));
            allWrongVerbs.Add(new WrongVerb("стояти", "stand", "stood", "stood"));
            allWrongVerbs.Add(new WrongVerb("красти", "steal", "stole", "stolen"));
            allWrongVerbs.Add(new WrongVerb("плавати", "swim", "swam", "swum"));
            allWrongVerbs.Add(new WrongVerb("качати", "swing", "swung", "swung"));
            allWrongVerbs.Add(new WrongVerb("брати", "take", "took", "taken"));
            allWrongVerbs.Add(new WrongVerb("вчити", "teach", "taught", "taught"));
            allWrongVerbs.Add(new WrongVerb("розповідати", "tell", "told", "told"));
            allWrongVerbs.Add(new WrongVerb("думати", "think", "thought", "thought"));
            allWrongVerbs.Add(new WrongVerb("кидати", "throw", "threw", "thrown"));
            allWrongVerbs.Add(new WrongVerb("розуміти", "understand", "understood", "understood"));
            allWrongVerbs.Add(new WrongVerb("прокинатися", "wake", "woke", "woken"));
            allWrongVerbs.Add(new WrongVerb("носити (одяг)", "wear", "wore", "worn"));
            allWrongVerbs.Add(new WrongVerb("вигравати", "win", "won", "won"));
            allWrongVerbs.Add(new WrongVerb("писати", "write", "wrote", "written"));
        }

        public static List<WrongVerb> allWrongVerbs = new List<WrongVerb>{};
        public List<WrongVerb> taskVerbs1 = new List<WrongVerb>{};
        public List<WrongVerb> taskVerbs2 = new List<WrongVerb>{};
        public List<WrongVerb> taskVerbs3 = new List<WrongVerb>{};
        public List<WrongVerb> taskVerbs4 = new List<WrongVerb>{};
        public static List<WrongVerb> checkVerbs = new List<WrongVerb> {};

        public void ClearTranslation()
        {
            for (int i = 0; i < taskVerbs1.Count; i++)
            {
                taskVerbs1[i].Translation = "";
            }
        }
        public void ClearFForm()
        {
            for (int i = 0; i < taskVerbs2.Count; i++)
            {
                taskVerbs2[i].FForm = "";
            }
        }
        public void ClearSForm()
        {
            for (int i = 0; i < taskVerbs3.Count; i++)
            {
                taskVerbs3[i].SForm = "";
            }
        }
        public void ClearTForm()
        {
            for (int i = 0; i < taskVerbs4.Count; i++)
            {
                taskVerbs4[i].TForm = "";
            }
        }
        public void makeFirstList(List<Char> chars)
        {
            MakeList(chars, taskVerbs1);
            ClearTranslation();
        }
        public void makeSecondList(List<Char> chars)
        {
            MakeList(chars, taskVerbs2);
            ClearFForm();
        }
        public void makeThirdList(List<Char> chars)
        {
            MakeList(chars, taskVerbs3);
            ClearSForm();
        }
        public void makeFourthList(List<Char> chars)
        {
            MakeList(chars, taskVerbs4);
            ClearTForm();
        }
        public void makeCheckList(List<Char> chars)
        {
            MakeList(chars, checkVerbs);
        }
        public void MakeList(List<Char> chars, List<WrongVerb> objList)
        {
            for (int i = 0; i < chars.Count; i++)
            {
                for (int j = 0; j < allWrongVerbs.Count; j++)
                {
                    if (allWrongVerbs[j].ChekFirstLetter(chars[i]))
                    {
                        WrongVerb wrongVerb = new WrongVerb(allWrongVerbs[j].Translation,
                                    allWrongVerbs[j].FForm,
                                    allWrongVerbs[j].SForm,
                                    allWrongVerbs[j].TForm);
                        objList.Add(wrongVerb);
                    }
                }
            }
        }
        public bool CheckTranslation(WrongVerb v, int index)
        {
            if (v.Translation == checkVerbs[index].Translation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckFForm(WrongVerb v, int index)
        {
            if (v.FForm == checkVerbs[index].FForm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckSForm(WrongVerb v, int index)
        {
            if (v.SForm == checkVerbs[index].SForm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckTForm(WrongVerb v, int index)
        {
            if (v.TForm == checkVerbs[index].TForm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PrintList(List<WrongVerb> wrongVerbs)
        {
            string res = "";
            for (int i = 0; i < wrongVerbs.Count; i++)
            {
                res += wrongVerbs[i].Translation;
                res += ", ";
                res += wrongVerbs[i].FForm;
                res += ", ";
                res += wrongVerbs[i].SForm;
                res += ", ";
                res += wrongVerbs[i].TForm;
                res += ";\n";
            }
            MessageBox.Show(res);
        }
    }
}

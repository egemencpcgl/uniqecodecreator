using System;
using System.Collections.Generic;

namespace CreateCode.CodeOperation
{
    public class CodeManager
    {
        #region Private Properties
        private string _generatedCode = "";
        private List<string> _availableChar = new List<string>() { "A", "C", "D", "E", "F", "G", "H", "K", "L", "M", "N",
            "P", "R", "T", "X", "Y", "Z", "2", "3", "4", "5", "7", "9" };//22
        private static CodeManager _codeManager;
        

        #endregion

        #region Public Properties
        public string GeneratedCode
        {
            get { return _generatedCode; }
            set { _generatedCode = value; }
        }
        public List<string> GeneratedCodeList = new List<string>();
        #endregion

        #region Singleton
        public static CodeManager Codemanager
        {
            get
            {
                if (_codeManager == null)
                {
                    _codeManager = new CodeManager();
                }
                return _codeManager;
            }

        }
        #endregion

        /// <summary>
        /// Generate code for campaign
        /// </summary>
        public void GenerateCode(int last=1000)
        {
            for (int i = 0; i < last; i++)
            {
                if (!GeneratedCodeList.Contains(GenerateOperation()))
                {
                    GeneratedCodeList.Add(GenerateOperation());
                }
                else
                {
                    i--;
                }
            }
        }

        private string GenerateOperation()
        {
            int oldnumber = 0;

            Random random = new Random();
            _generatedCode = "";
            for (int i = 0; i < 8; i++)
            {
                int charnumber = random.Next(0, 22);
                if (i == 0)
                {
                    GeneratedCode = GeneratedCode + _availableChar[charnumber];
                    oldnumber = charnumber;
                }
                else
                {
                    int _isConsecutive = Math.Abs(oldnumber - charnumber);
                    if (_isConsecutive != 1)
                    {
                        GeneratedCode= GeneratedCode+_availableChar[charnumber];
                        oldnumber = charnumber;
                    }
                    else
                    {
                        i--;
                    }
                }
            }            
            return GeneratedCode;
        }

        /// <summary>
        /// Checking of available for entered code
        /// </summary>
        /// <param name="_code"></param>
        /// <returns></returns>
        public bool CheckCode(string _code)
        {
            string[] code = _code.Split();
            bool _isFirstChar=true;
            int oldIndex=-1;
            bool result = false;
            int newIndex = 0;
            foreach (var item in _code)
            {               
                if (_isFirstChar)
                {
                    newIndex = _availableChar.IndexOf(item.ToString());
                    _isFirstChar = false;   
                }
                else
                {
                    oldIndex = newIndex;
                    newIndex = _availableChar.IndexOf(item.ToString());                    
                }
                if (oldIndex != -1)
                {
                    int _isConsecutive = Math.Abs(oldIndex - newIndex);
                    if(_isConsecutive == 1)
                    {
                        result= false;
                        break;
                    }
                    else result= true;
                }
            }  
            return result;
        } 
    }
}

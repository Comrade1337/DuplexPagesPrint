namespace DuplexPagesPrint
{
    class PrintingPages
    {
        public string OddPages { get; private set; }
        public string EvenPages { get; private set; }
        int amountPages;

        public PrintingPages(int amountPages)
        {
            this.amountPages = amountPages;
            InitializationProperties(amountPages);
        }

        void InitializationProperties(int amountPages)
        {
            #region
            //for (int i = 0; i < amountPages; i++)
            //{
            //    if (i % 8 < 4)
            //    {
            //        OddPages += $"{i + 1}" +
            //                    $"-{(i + 4 > amountPages ? amountPages : i + 4)}" +
            //                    $"{(amountPages - i > 8 ? ", " : string.Empty)}";
            //    }
            //    else
            //    {
            //        EvenPages += $"{i + 1}" +
            //                     $"-{(i + 4 > amountPages ? amountPages : i + 4)}" +
            //                     $"{(amountPages - i > 4 ? ", " : string.Empty)}";
            //    }
            //    i += 3;
            //}
            #endregion

            for (int i = 0; i < amountPages; i++)
            {
                if (i % 8 < 4)
                {
                    OddPages += (i + 1).ToString();
                    OddPages += (i + 1 == amountPages) ? string.Empty : $"-{(i + 4 > amountPages ? amountPages : i + 4)}";
                    OddPages += $"{(amountPages - i > 8 ? ", " : string.Empty)}";
                }
                else
                {
                    EvenPages += (i + 1).ToString();
                    EvenPages += (i + 1 == amountPages) ? string.Empty : $"-{(i + 4 > amountPages ? amountPages : i + 4)}";
                    EvenPages += $"{(amountPages - i > 8 ? ", " : string.Empty)}";
                }
                i += 3;
            }
        }
    }
}

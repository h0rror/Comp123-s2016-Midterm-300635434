using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This class is a subclass of the LottoGame abstract superclass
     * </summary>
     * 
     * @class Lotto649
     */
    public class Lotto649 : LottoGame, IGenerateLottoNumbers
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public Lotto649()
            : base(6, 49)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------

        public class GenerateLottoNumbers();
           private int _setNum = 49;
           private int _counter1 = 6;
           private int _number;
        {
           

           while (_counter1 > 0)
        {
            _counter1 - 1;
            _number = Random(1,49);

        }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RandomMusicRest
{
    public class sangpart
    {
        public int tone { get; set; }
        public int sangid { get; set; }
        public string tid { get; set; }

        public sangpart(int tone, int sangid, string tid)
        {
            this.tone = tone;
            this.sangid = sangid;
            this.tid = tid;
        }

        public override string ToString()
        {
            return $"{nameof(sangid)}: {sangid}, {nameof(tid)}: {tid}, {nameof(tone)}: {tone}";
        }
    }
}

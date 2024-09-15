using System;

namespace ZRA_VSDC_API.Models;

public class Code
{
    public int TPin {get; set;}

     public int BHFID { get; set; }

     public DateTime LastReqDt { get; set; }

     public required string CdCls  {get;set;}

    public required string CdClsNm {get;set;}

    public required string Cd {get;set;}

    public required string CdNm  {get;set;}

    public required string UserDfnNm1   {get;set;}

}

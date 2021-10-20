using Pulumi;
using System.Collections.Generic;
using System.Collections.Immutable;
using static Helpers;
class Dwh
{

    [Output]
    public ImmutableDictionary<string, Output<string>> LogsBucket { get; set; }
    [Output]
    public ImmutableDictionary<string, Output<string>> EtlBucket { get; set; }
    [Output]
    public ImmutableDictionary<string, Output<string>> DwhBucket { get; set; }

    public Dwh() 
    {

      var defaultTags = ImmutableDictionary
        .Create<string, string>()
        .Add("Stage", "Prod");
      
      var logsBucket = CreateBucket("datadeft-logs", defaultTags);
      var dwhBucket = CreateBucket("datadeft-dwh", defaultTags);
      var etlBucket = CreateBucket("datadeft-etl", defaultTags);
      
      this.LogsBucket = GetBucketDetails(logsBucket);
      this.DwhBucket = GetBucketDetails(dwhBucket);
      this.EtlBucket = GetBucketDetails(etlBucket);

    }
}

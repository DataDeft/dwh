using Pulumi;
using Pulumi.Aws.S3;
using System.Collections.Immutable;
static class Helpers
{


  static public Bucket CreateBucket (string bucketName, ImmutableDictionary<string, string> tags) {

    var bucket = new Bucket(bucketName,  new BucketArgs {
      BucketName = bucketName,
      Acl = "private",
      Tags = tags.Add("Name", bucketName)
    }); 
    
    return bucket;

  }

  static public ImmutableDictionary<string, Output<string>> GetBucketDetails (Bucket bucket) {
    return ImmutableDictionary
            .Create<string, Output<string>>()
            .Add("bucketId", bucket.Id)
            .Add("bucketName", bucket.BucketName)
            .Add("bucketRegion", bucket.Region);
  }
}
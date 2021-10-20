using Pulumi;
using Pulumi.Aws.S3;

class Infra : Stack
{
  public Infra()
  {
    var dwh = new Dwh();
    // var website = new WebsiteUs();
    // var website = new WebsiteEu();
    // var website = new Website();
    // var website = new Website(); 
  }
}

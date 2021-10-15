

```TypeScript
// global
import * as aws from "@pulumi/aws";
// local
import getBucketDetails from "./helpers";

//
// Configuring buckets
//

const logsBucket = new aws.s3.Bucket("datadeft-logs", {
  acl: "private",
  tags: {
    Stage: "Prod",
    Name: "datadeft-logs",
  },
});

const dwhBucket = new aws.s3.Bucket("datadeft-dwh", {
  acl: "private",
  tags: {
    Stage: "Prod",
    Name: "datadeft-dwh",
  },
});

const etlBucket = new aws.s3.Bucket("datadeft-etl", {
  acl: "private",
  tags: {
    Stage: "Prod",
    Name: "datadeft-etl",
  },
});

//
// Exports
//

export const logsBucketOutput = getBucketDetails(logsBucket)
export const dwhBucketOutput = getBucketDetails(dwhBucket)
export const etlBucketOutput = getBucketDetails(etlBucket)
```



```bash
> pulumi up
Previewing update (datadeft/prod)

View Live: https://app.pulumi.com/datadeft/dwh/prod/previews/2d9fae31-05a5-4434-beb4-637c4a70ad74

     Type                 Name           Plan
     pulumi:pulumi:Stack  dwh-prod
 +   ├─ aws:s3:Bucket     datadeft-etl   create
 +   ├─ aws:s3:Bucket     datadeft-dwh   create
 +   └─ aws:s3:Bucket     datadeft-logs  create

Outputs:
  + dwhBucketOutput : {
      + Name  : output<string>
      + Region: output<string>
      + Tags  : {
          + Name : "datadeft-dwh"
          + Stage: "Prod"
        }
    }
  + etlBucketOutput : {
      + Name  : output<string>
      + Region: output<string>
      + Tags  : {
          + Name : "datadeft-etl"
          + Stage: "Prod"
        }
    }
  + logsBucketOutput: {
      + Name  : output<string>
      + Region: output<string>
      + Tags  : {
          + Name : "datadeft-logs"
          + Stage: "Prod"
        }
    }

Resources:
    + 3 to create
    1 unchanged

Do you want to perform this update?  [Use arrows to move, enter to select, type to filter]
  yes
> no
  details
```
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
import { Bucket } from "@pulumi/aws/s3";

export default function getBucketDetails(bucket: Bucket) {
  return { Name: bucket.id, Region: bucket.region, Tags: bucket.tagsAll }
}

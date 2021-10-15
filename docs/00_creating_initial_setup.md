
pulumi new aws-typescript -s datadeft/dwh/prod --force

Pulumi.yaml

```yaml
name: dwh
runtime: nodejs
description: IaC for DWH on AWS
```


pulumi config set aws:profile datadeft-dev

Pulumi.prod.yaml

```yaml
config:
  aws:profile: datadeft-dev
  aws:region: eu-west-1
  pulumi:template: aws-typescript
```
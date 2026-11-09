# django/contrib/sites/migrations/0002_alter_domain_unique

- Subject: django/contrib/sites/migrations/0002_alter_domain_unique (id `7395d535-15a1-4b54-8482-bbfc028f788f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 131 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="site", name="domain", field=models.CharField( max_length=100, unique=True, validators=[django.contrib.sites.models._simple_domain_name_validator], verbose_name="domain name", ), ), ] [83eb643a]
- class Migration(migrations.Migration): dependencies = [ ("sites", "0001_initial"), ] [8350cf2498f01bcb-3]
- import django.contrib.sites.models from django.db import migrations, models [e3a0e61a]

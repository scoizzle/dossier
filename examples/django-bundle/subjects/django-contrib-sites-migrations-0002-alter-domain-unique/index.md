# django/contrib/sites/migrations/0002_alter_domain_unique

- Subject: django/contrib/sites/migrations/0002_alter_domain_unique (id `5d5041c4-b85c-4ee8-9c32-0f731649cd84`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 131 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="site", name="domain", field=models.CharField( max_length=100, unique=True, validators=[django.contrib.sites.models._simple_domain_name_validator], verbose_name="domain name", ), ), ] [83eb643a]
- class Migration(migrations.Migration): dependencies = [ ("sites", "0001_initial"), ] [8350cf2498f01bcb-3]
- import django.contrib.sites.models from django.db import migrations, models [e3a0e61a]

# django/contrib/sites/migrations/0001_initial

- Subject: django/contrib/sites/migrations/0001_initial (id `8e0f6323-9b08-4bdd-8582-4c56218978a6`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 228 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.CreateModel( name="Site", fields=[ ( "id", models.AutoField( verbose_name="ID", serialize=False, auto_created=True, primary_key=True, ), ), ( "domain", models.CharField( max_length=100, verbose_name="domain name", validators=[_simple_domain_name_validator], ), ), ("name", models.CharField(max_length=50, verbose_name="display name")), ], options={ "ordering": ["domain"], "db_table": "django_site", "verbose_name": "site", "verbose_name_plural": "sites", }, bases=(models.Model,), managers=[ ("objects", django.contrib.sites.models.SiteManager()), ], ), ] [a6fe92b5]
- class Migration(migrations.Migration): dependencies = [] [25db17bb852de530-3]
- import django.contrib.sites.models from django.contrib.sites.models import _simple_domain_name_validator from django.db import migrations, models [910e7a91]

# django/contrib/redirects/migrations/0001_initial

- Subject: django/contrib/redirects/migrations/0001_initial (id `5627784b-c848-4b01-9543-eeb0474dd4ad`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 285 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.CreateModel( name="Redirect", fields=[ ( "id", models.AutoField( verbose_name="ID", serialize=False, auto_created=True, primary_key=True, ), ), ( "site", models.ForeignKey( to="sites.Site", on_delete=models.CASCADE, verbose_name="site", ), ), ( "old_path", models.CharField( help_text=( "This should be an absolute path, excluding the domain " "name. Example: “/events/search/”." ), max_length=200, verbose_name="redirect from", db_index=True, ), ), ( "new_path", models.CharField( help_text=( "This can be either an absolute path (as above) or a full " "URL starting with “http://”." ), max_length=200, verbose_name="redirect to", blank=True, ), ), ], options={ "ordering": ["old_path"], "unique_together": {("site", "old_path")}, "db_table": "django_redirect", "verbose_name": "redirect", "verbose_name_plural": "redirects", }, bases=(models.Model,), ), ] [3bb0b3d0]
- class Migration(migrations.Migration): dependencies = [ ("sites", "0001_initial"), ] [8350cf2498f01bcb-2]
- from django.db import migrations, models [b2ef032411bd05de-10]

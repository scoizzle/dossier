# django/contrib/redirects/migrations/0002_alter_redirect_new_path_help_text

- Subject: django/contrib/redirects/migrations/0002_alter_redirect_new_path_help_text (id `34d73709-8a85-4c1b-87fd-93b95fa3b766`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 137 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="redirect", name="new_path", field=models.CharField( blank=True, help_text=( "This can be either an absolute path (as above) or a full " "URL starting with a scheme such as “https://”." ), max_length=200, verbose_name="redirect to", ), ), ] [da9c0a5f]
- class Migration(migrations.Migration): dependencies = [ ("redirects", "0001_initial"), ] [f0bbf0b5]
- from django.db import migrations, models [b2ef032411bd05de-11]

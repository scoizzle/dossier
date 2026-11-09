# django/contrib/flatpages/migrations/0001_initial

- Subject: django/contrib/flatpages/migrations/0001_initial (id `e0060ed0-0fc4-4319-9180-8012e755a029`)
- Kind: subject
- Budget: 1200 tokens
- Used: 350 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.CreateModel( name="FlatPage", fields=[ ( "id", models.AutoField( verbose_name="ID", serialize=False, auto_created=True, primary_key=True, ), ), ( "url", models.CharField(max_length=100, verbose_name="URL", db_index=True), ), ("title", models.CharField(max_length=200, verbose_name="title")), ("content", models.TextField(verbose_name="content", blank=True)), ( "enable_comments", models.BooleanField(default=False, verbose_name="enable comments"), ), ( "template_name", models.CharField( help_text=( "Example: “flatpages/contact_page.html”. If this isn’t " "provided, the system will use “flatpages/default.html”." ), max_length=70, verbose_name="template name", blank=True, ), ), ( "registration_required", models.BooleanField( default=False, help_text=( "If this is checked, only logged-in users will be able to " "view the page." ), verbose_name="registration required", ), ), ( "sites", models.ManyToManyField(to="sites.Site", verbose_name="sites"), ), ], options={ "ordering": ["url"], "db_table": "django_flatpage", "verbose_name": "flat page", "verbose_name_plural": "flat pages", }, bases=(models.Model,), ), ] [f7171b25]
- class Migration(migrations.Migration): dependencies = [ ("sites", "0001_initial"), ] [8350cf2498f01bcb]
- from django.db import migrations, models [b2ef032411bd05de-9]

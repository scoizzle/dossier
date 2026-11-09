# django/contrib/admin/migrations/0001_initial

- Subject: django/contrib/admin/migrations/0001_initial (id `154c57ec-913d-4573-b2dc-301cf4b0c806`)
- Kind: subject
- Budget: 1200 tokens
- Used: 371 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.CreateModel( name="LogEntry", fields=[ ( "id", models.AutoField( verbose_name="ID", serialize=False, auto_created=True, primary_key=True, ), ), ( "action_time", models.DateTimeField(auto_now=True, verbose_name="action time"), ), ( "object_id", models.TextField(null=True, verbose_name="object id", blank=True), ), ( "object_repr", models.CharField(max_length=200, verbose_name="object repr"), ), ( "action_flag", models.PositiveSmallIntegerField(verbose_name="action flag"), ), ( "change_message", models.TextField(verbose_name="change message", blank=True), ), ( "content_type", models.ForeignKey( on_delete=models.SET_NULL, blank=True, null=True, to="contenttypes.ContentType", verbose_name="content type", ), ), ( "user", models.ForeignKey( to=settings.AUTH_USER_MODEL, on_delete=models.CASCADE, verbose_name="user", ), ), ], options={ "ordering": ["-action_time"], "db_table": "django_admin_log", "verbose_name": "log entry", "verbose_name_plural": "log entries", }, bases=(models.Model,), managers=[ ("objects", django.contrib.admin.models.LogEntryManager()), ], ), ] [7672a754]
- class Migration(migrations.Migration): dependencies = [ migrations.swappable_dependency(settings.AUTH_USER_MODEL), ("contenttypes", "__first__"), ] [e9b48291]
- import django.contrib.admin.models from django.conf import settings from django.db import migrations, models [71929733]

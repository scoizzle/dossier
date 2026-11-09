# docs/ref/models/meta

- Subject: docs/ref/models/meta (id `3c51551b-8865-4dd2-ab5c-ebee15af679f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 18 of 39
- Conflicts: 0
- Gaps: 0

## Facts

- # A field from another model that has a relation with the current model >>> User._meta.get_field("logentry") <ManyToOneRel: admin.logentry> [57274b12]
- # A field on the model >>> User._meta.get_field("username") <django.db.models.fields.CharField: username> [322e207f]
- # A non existent field >>> User._meta.get_field("does_not_exist") Traceback (most recent call last): ... FieldDoesNotExist: User has no field named 'does_not_exist' [b4d3258c]
- # Also include hidden fields. >>> User._meta.get_fields(include_hidden=True) (<ManyToOneRel: auth.user_groups>, <ManyToOneRel: auth.user_user_permissions>, <ManyToOneRel: admin.logentry>, <django.db.models.fields.AutoField: id>, <django.db.models.fields.CharField: password>, <django.db.models.fields.DateTimeField: last_login>, <django.db.models.fields.BooleanField: is_superuser>, <django.db.models.fields.CharField: username>, <django.db.models.fields.CharField: first_name>, <django.db.models.fields.CharField: last_name>, <django.db.models.fields.EmailField: email>, <django.db.models.fields.BooleanField: is_staff>, <django.db.models.fields.BooleanField: is_active>, <django.db.models.fields.DateTimeField: date_joined>, <django.db.models.fields.related.ManyToManyField: groups>, <django.db.models.fields.related.ManyToManyField: user_permissions>) [05dd4f31]
- >>> TenantUser._meta.pk_fields [ <django.db.models.fields.IntegerField: tenant_id>, <django.db.models.fields.IntegerField: id> ] [2742dcef]
- >>> User._meta.pk_fields [<django.db.models.fields.AutoField: id>] [856d7ac0]
- >>> from django.contrib.auth.models import User [d512641b]
- >>> from django.contrib.auth.models import User >>> User._meta.get_fields() (<ManyToOneRel: admin.logentry>, <django.db.models.fields.AutoField: id>, <django.db.models.fields.CharField: password>, <django.db.models.fields.DateTimeField: last_login>, <django.db.models.fields.BooleanField: is_superuser>, <django.db.models.fields.CharField: username>, <django.db.models.fields.CharField: first_name>, <django.db.models.fields.CharField: last_name>, <django.db.models.fields.EmailField: email>, <django.db.models.fields.BooleanField: is_staff>, <django.db.models.fields.BooleanField: is_active>, <django.db.models.fields.DateTimeField: date_joined>, <django.db.models.fields.related.ManyToManyField: groups>, <django.db.models.fields.related.ManyToManyField: user_permissions>) [55667038]
- class TenantUser(models.Model): pk = models.CompositePrimaryKey("tenant_id", "id") tenant_id = models.IntegerField() id = models.IntegerField() [3310bae2]
- from django.db import models [4af926756c29efa6-30]
- .. code-block:: pycon [eaf050be34acb41d-465]
- .. code-block:: pycon [eaf050be34acb41d-466]
- .. code-block:: pycon [eaf050be34acb41d-467]
- .. code-block:: pycon [eaf050be34acb41d-468]
- .. code-block:: python [dfa717732ab88b73-4]
- Hidden fields, fields with :attr:`hidden=True <django.db.models.Field.hidden>`, cannot be retrieved by name. [eedf2db6]
- If a field with the given name is not found a :class:`~django.core.exceptions.FieldDoesNotExist` exception will be raised. [0e937b1b]
- .. _model-meta-field-api: [0fa3302f]

## Beyond the budget

21 more facts did not fit in the budget: [7ee83e97] [d33fb206] [9b4398f2] [42790233] [89d18a73] [fcbad013] [4640ae7b] [3e4b710e] [46abf4e0] [e7105610] [c24075a7] [187fac23] [1bec9627] [4f6cb2b6] [b0d17ecc] [56598502] [affd72dc] [68513ecd] [0c7d65a1] [4b09b57b] [42be49a7]

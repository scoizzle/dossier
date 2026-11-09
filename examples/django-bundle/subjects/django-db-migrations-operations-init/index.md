# django/db/migrations/operations/__init__

- Subject: django/db/migrations/operations/__init__ (id `d8f854f4-a7f4-4ebd-b882-4b80e2701cc9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 234 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- __all__ = [ "CreateModel", "DeleteModel", "AlterModelTable", "AlterModelTableComment", "AlterUniqueTogether", "RenameModel", "AlterIndexTogether", "AlterModelOptions", "AddIndex", "RemoveIndex", "RenameIndex", "AddField", "RemoveField", "AlterField", "RenameField", "AddConstraint", "RemoveConstraint", "AlterConstraint", "SeparateDatabaseAndState", "RunSQL", "RunPython", "AlterOrderWithRespectTo", "AlterModelManagers", ] [c1c23d8b]
- from .fields import AddField, AlterField, RemoveField, RenameField from .models import ( AddConstraint, AddIndex, AlterConstraint, AlterIndexTogether, AlterModelManagers, AlterModelOptions, AlterModelTable, AlterModelTableComment, AlterOrderWithRespectTo, AlterUniqueTogether, CreateModel, DeleteModel, RemoveConstraint, RemoveIndex, RenameIndex, RenameModel, ) from .special import RunPython, RunSQL, SeparateDatabaseAndState [012bc211]

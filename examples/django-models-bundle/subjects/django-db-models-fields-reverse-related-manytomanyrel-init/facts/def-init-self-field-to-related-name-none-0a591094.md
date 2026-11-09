# Fact 0a591094

Store id: 833908e2-7af2-445a-a101-71bd2e903878

## Text

```text
def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, symmetrical=True, through=None, through_fields=None, db_constraint=True, )
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:45.3893570+00:00`

## Data

```json
{
  "end_line": 383,
  "entity_kind": "method",
  "parent": "ManyToManyRel",
  "start_line": 354,
  "symbol": "ManyToManyRel.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":354,"selector":"L354-L383","symbol":"ManyToManyRel.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToManyRel.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 383,
    "entity_kind": "method",
    "parent": "ManyToManyRel",
    "start_line": 354,
    "symbol": "ManyToManyRel.__init__"
  },
  "id": "833908e2-7af2-445a-a101-71bd2e903878",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3893570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 354,
        "selector": "L354-L383",
        "symbol": "ManyToManyRel.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "8a8ec6fb-4dd6-4bf5-8b48-68199b9d3357",
  "subject_name": "django/db/models/fields/reverse_related::ManyToManyRel.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, symmetrical=True, through=None, through_fields=None, db_constraint=True, )"
}
```

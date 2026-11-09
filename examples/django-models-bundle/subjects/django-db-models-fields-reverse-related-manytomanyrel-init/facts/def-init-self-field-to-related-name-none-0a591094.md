# Fact 0a591094

Store id: 6cecc491-9e2b-4c0e-842e-41654a6831a5

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
- posted_at: `2026-11-09T23:44:52.5276650+00:00`

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
  "id": "6cecc491-9e2b-4c0e-842e-41654a6831a5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.5276650+00:00"
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
  "subject_id": "b2e891b1-cb49-42c9-9f44-b2b9fa4b8596",
  "subject_name": "django/db/models/fields/reverse_related::ManyToManyRel.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, symmetrical=True, through=None, through_fields=None, db_constraint=True, )"
}
```

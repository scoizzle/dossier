# Fact 0a591094

Store id: 315a3668-66cd-42ff-9e26-f3fdc5316cdf

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
- posted_at: `2026-11-09T23:32:00.3497390+00:00`

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
  "id": "315a3668-66cd-42ff-9e26-f3fdc5316cdf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.3497390+00:00"
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
  "subject_id": "7723fa23-afd5-4a5a-a738-4fc3392b5dd7",
  "subject_name": "django/db/models/fields/reverse_related::ManyToManyRel.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, symmetrical=True, through=None, through_fields=None, db_constraint=True, )"
}
```

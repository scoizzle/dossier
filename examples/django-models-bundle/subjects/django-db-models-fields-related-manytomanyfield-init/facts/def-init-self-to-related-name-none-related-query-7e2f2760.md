# Fact 7e2f2760

Store id: 82624ec1-76be-4a8c-afdc-e753dd784fc0

## Text

```text
def __init__( self, to, related_name=None, related_query_name=None, limit_choices_to=None, symmetrical=None, through=None, through_fields=None, db_constraint=True, db_table=None, swappable=True, **kwargs, )
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
- posted_at: `2026-11-09T23:44:51.6309730+00:00`

## Data

```json
{
  "end_line": 1535,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1478,
  "symbol": "ManyToManyField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1478,"selector":"L1478-L1535","symbol":"ManyToManyField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1535,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1478,
    "symbol": "ManyToManyField.__init__"
  },
  "id": "82624ec1-76be-4a8c-afdc-e753dd784fc0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6309730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1478,
        "selector": "L1478-L1535",
        "symbol": "ManyToManyField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "a217dc49-beb5-4da9-8b03-c5c3150cb07d",
  "subject_name": "django/db/models/fields/related::ManyToManyField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, to, related_name=None, related_query_name=None, limit_choices_to=None, symmetrical=None, through=None, through_fields=None, db_constraint=True, db_table=None, swappable=True, **kwargs, )"
}
```

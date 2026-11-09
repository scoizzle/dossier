# Fact 2f6cd20f

Store id: e41d1dcd-d89b-4570-8094-bd922d76b3ae

## Text

```text
def get_db_prep_lookup(self, value, connection)
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
- posted_at: `2026-11-09T23:32:03.2241550+00:00`

## Data

```json
{
  "end_line": 282,
  "entity_kind": "method",
  "parent": "FieldGetDbPrepValueMixin",
  "start_line": 262,
  "symbol": "FieldGetDbPrepValueMixin.get_db_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":262,"selector":"L262-L282","symbol":"FieldGetDbPrepValueMixin.get_db_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::FieldGetDbPrepValueMixin.get_db_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 282,
    "entity_kind": "method",
    "parent": "FieldGetDbPrepValueMixin",
    "start_line": 262,
    "symbol": "FieldGetDbPrepValueMixin.get_db_prep_lookup"
  },
  "id": "e41d1dcd-d89b-4570-8094-bd922d76b3ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2241550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 262,
        "selector": "L262-L282",
        "symbol": "FieldGetDbPrepValueMixin.get_db_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "566bdb66-2c56-4098-909a-7e72cd09f3f8",
  "subject_name": "django/db/models/lookups::FieldGetDbPrepValueMixin.get_db_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_lookup(self, value, connection)"
}
```

# Fact 51dd6335

Store id: e6528db8-45be-4efc-939a-43f27a540132

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:48.0848830+00:00`

## Data

```json
{
  "end_line": 334,
  "entity_kind": "method",
  "parent": "FieldGetDbPrepValueIterableMixin",
  "start_line": 322,
  "symbol": "FieldGetDbPrepValueIterableMixin.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":322,"selector":"L322-L334","symbol":"FieldGetDbPrepValueIterableMixin.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::FieldGetDbPrepValueIterableMixin.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 334,
    "entity_kind": "method",
    "parent": "FieldGetDbPrepValueIterableMixin",
    "start_line": 322,
    "symbol": "FieldGetDbPrepValueIterableMixin.process_rhs"
  },
  "id": "e6528db8-45be-4efc-939a-43f27a540132",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0848830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 322,
        "selector": "L322-L334",
        "symbol": "FieldGetDbPrepValueIterableMixin.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a9ec40e9-c915-49de-a6ba-126ffc18e1ba",
  "subject_name": "django/db/models/lookups::FieldGetDbPrepValueIterableMixin.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```

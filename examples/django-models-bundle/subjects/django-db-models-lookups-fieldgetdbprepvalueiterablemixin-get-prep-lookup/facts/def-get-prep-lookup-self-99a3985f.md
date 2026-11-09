# Fact 99a3985f

Store id: e6d110e7-1062-4cf7-aa07-071ba002487e

## Text

```text
def get_prep_lookup(self)
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
- posted_at: `2026-11-09T23:32:03.2300110+00:00`

## Data

```json
{
  "end_line": 320,
  "entity_kind": "method",
  "parent": "FieldGetDbPrepValueIterableMixin",
  "start_line": 293,
  "symbol": "FieldGetDbPrepValueIterableMixin.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":293,"selector":"L293-L320","symbol":"FieldGetDbPrepValueIterableMixin.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::FieldGetDbPrepValueIterableMixin.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 320,
    "entity_kind": "method",
    "parent": "FieldGetDbPrepValueIterableMixin",
    "start_line": 293,
    "symbol": "FieldGetDbPrepValueIterableMixin.get_prep_lookup"
  },
  "id": "e6d110e7-1062-4cf7-aa07-071ba002487e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2300110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 293,
        "selector": "L293-L320",
        "symbol": "FieldGetDbPrepValueIterableMixin.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "fb11f39e-eeef-4f2e-a20a-884aa96803e5",
  "subject_name": "django/db/models/lookups::FieldGetDbPrepValueIterableMixin.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```

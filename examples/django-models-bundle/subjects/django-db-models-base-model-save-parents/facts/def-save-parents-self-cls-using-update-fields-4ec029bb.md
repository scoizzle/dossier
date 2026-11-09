# Fact 4ec029bb

Store id: 5d9af755-c8ac-4c0c-90ef-ae3cfdeb3ac1

## Text

```text
def _save_parents( self, cls, using, update_fields, force_insert, updated_parents=None )
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
- posted_at: `2026-11-09T22:39:40.3400410+00:00`

## Data

```json
{
  "end_line": 1067,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1022,
  "symbol": "Model._save_parents"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1022,"selector":"L1022-L1067","symbol":"Model._save_parents"}`

## Items

```json
[
  {
    "text": "Save all the parents of cls using values from self.",
    "locator": {
      "line": 1025
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._save_parents](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1067,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1022,
    "symbol": "Model._save_parents"
  },
  "id": "5d9af755-c8ac-4c0c-90ef-ae3cfdeb3ac1",
  "items": [
    {
      "locator": {
        "line": 1025
      },
      "text": "Save all the parents of cls using values from self."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3400410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1022,
        "selector": "L1022-L1067",
        "symbol": "Model._save_parents"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "a23b5eed-d666-48b7-ab06-2765b59112d2",
  "subject_name": "django/db/models/base::Model._save_parents",
  "tags": [
    "entity:method"
  ],
  "text": "def _save_parents( self, cls, using, update_fields, force_insert, updated_parents=None )"
}
```

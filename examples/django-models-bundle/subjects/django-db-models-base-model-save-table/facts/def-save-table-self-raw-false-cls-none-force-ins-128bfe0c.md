# Fact 128bfe0c

Store id: c63b25fb-fadf-4ff7-9136-e78cfd7c7e5e

## Text

```text
def _save_table( self, raw=False, cls=None, force_insert=False, force_update=False, using=None, update_fields=None, )
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
- posted_at: `2026-11-09T22:39:40.3407240+00:00`

## Data

```json
{
  "end_line": 1206,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1069,
  "symbol": "Model._save_table"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1069,"selector":"L1069-L1206","symbol":"Model._save_table"}`

## Items

```json
[
  {
    "text": "Do the heavy-lifting involved in saving. Update or insert the data for a single table.",
    "locator": {
      "line": 1078
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._save_table](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1206,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1069,
    "symbol": "Model._save_table"
  },
  "id": "c63b25fb-fadf-4ff7-9136-e78cfd7c7e5e",
  "items": [
    {
      "locator": {
        "line": 1078
      },
      "text": "Do the heavy-lifting involved in saving. Update or insert the data for a single table."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3407240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1069,
        "selector": "L1069-L1206",
        "symbol": "Model._save_table"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "e3ab5ef8-9150-4db4-9f64-ea42c732902b",
  "subject_name": "django/db/models/base::Model._save_table",
  "tags": [
    "entity:method"
  ],
  "text": "def _save_table( self, raw=False, cls=None, force_insert=False, force_update=False, using=None, update_fields=None, )"
}
```

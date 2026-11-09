# Fact 4ec029bb

Store id: 2f707858-0116-411a-b1cb-45c4ccbba4e7

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
- posted_at: `2026-11-09T23:44:48.5346290+00:00`

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
  "id": "2f707858-0116-411a-b1cb-45c4ccbba4e7",
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
    "posted_at": "2026-11-09T23:44:48.5346290+00:00"
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
  "subject_id": "0371c974-04e6-49af-a356-2baf9ab7dc81",
  "subject_name": "django/db/models/base::Model._save_parents",
  "tags": [
    "entity:method"
  ],
  "text": "def _save_parents( self, cls, using, update_fields, force_insert, updated_parents=None )"
}
```

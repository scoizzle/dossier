# Fact f90b6f5a

Store id: 73402b84-7616-4f5d-a2b5-2bd5f37a5a6e

## Text

```text
def db_parameters(self, connection)
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
- posted_at: `2026-11-09T22:39:44.4162130+00:00`

## Data

```json
{
  "end_line": 1328,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1322,
  "symbol": "ForeignKey.db_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1322,"selector":"L1322-L1328","symbol":"ForeignKey.db_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.db_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1328,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1322,
    "symbol": "ForeignKey.db_parameters"
  },
  "id": "73402b84-7616-4f5d-a2b5-2bd5f37a5a6e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4162130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1322,
        "selector": "L1322-L1328",
        "symbol": "ForeignKey.db_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "0c25a138-dd56-48c9-9171-e5d16181c44e",
  "subject_name": "django/db/models/fields/related::ForeignKey.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```

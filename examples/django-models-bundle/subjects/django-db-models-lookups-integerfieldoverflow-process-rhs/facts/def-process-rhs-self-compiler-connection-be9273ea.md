# Fact be9273ea

Store id: 57d7f5f2-959a-40d2-a613-bdd8f5e55139

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
- posted_at: `2026-11-09T23:32:03.2878980+00:00`

## Data

```json
{
  "end_line": 460,
  "entity_kind": "method",
  "parent": "IntegerFieldOverflow",
  "start_line": 449,
  "symbol": "IntegerFieldOverflow.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":449,"selector":"L449-L460","symbol":"IntegerFieldOverflow.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerFieldOverflow.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 460,
    "entity_kind": "method",
    "parent": "IntegerFieldOverflow",
    "start_line": 449,
    "symbol": "IntegerFieldOverflow.process_rhs"
  },
  "id": "57d7f5f2-959a-40d2-a613-bdd8f5e55139",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2878980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 449,
        "selector": "L449-L460",
        "symbol": "IntegerFieldOverflow.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "cc318db2-ac1f-41fb-9b8c-b1dd1f0644a2",
  "subject_name": "django/db/models/lookups::IntegerFieldOverflow.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```

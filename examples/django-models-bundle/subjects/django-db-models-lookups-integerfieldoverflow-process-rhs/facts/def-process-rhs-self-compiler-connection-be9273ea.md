# Fact be9273ea

Store id: 0e90916f-e8c3-4589-8478-bc3e6017e4aa

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
- posted_at: `2026-11-09T22:39:48.1276140+00:00`

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
  "id": "0e90916f-e8c3-4589-8478-bc3e6017e4aa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1276140+00:00"
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
  "subject_id": "f010de25-3557-476d-8a2a-d342730dd97d",
  "subject_name": "django/db/models/lookups::IntegerFieldOverflow.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```

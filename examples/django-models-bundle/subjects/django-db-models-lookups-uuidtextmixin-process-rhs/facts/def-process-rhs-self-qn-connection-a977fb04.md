# Fact a977fb04

Store id: 534db5e5-a83d-4e64-b3d2-dc232fd31828

## Text

```text
def process_rhs(self, qn, connection)
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
- posted_at: `2026-11-09T23:32:03.4688040+00:00`

## Data

```json
{
  "end_line": 797,
  "entity_kind": "method",
  "parent": "UUIDTextMixin",
  "start_line": 787,
  "symbol": "UUIDTextMixin.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":787,"selector":"L787-L797","symbol":"UUIDTextMixin.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDTextMixin.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 797,
    "entity_kind": "method",
    "parent": "UUIDTextMixin",
    "start_line": 787,
    "symbol": "UUIDTextMixin.process_rhs"
  },
  "id": "534db5e5-a83d-4e64-b3d2-dc232fd31828",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4688040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 787,
        "selector": "L787-L797",
        "symbol": "UUIDTextMixin.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "ba993fd6-65d7-4417-97e5-56fe13e7977b",
  "subject_name": "django/db/models/lookups::UUIDTextMixin.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, qn, connection)"
}
```

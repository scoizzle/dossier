# Fact a977fb04

Store id: 2fcf89dd-e6b4-4de7-a262-b7b4a8bfb2f9

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
- posted_at: `2026-11-09T22:39:48.2751650+00:00`

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
  "id": "2fcf89dd-e6b4-4de7-a262-b7b4a8bfb2f9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2751650+00:00"
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
  "subject_id": "739e3177-786e-457e-a57b-1dfc567a0a6c",
  "subject_name": "django/db/models/lookups::UUIDTextMixin.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, qn, connection)"
}
```

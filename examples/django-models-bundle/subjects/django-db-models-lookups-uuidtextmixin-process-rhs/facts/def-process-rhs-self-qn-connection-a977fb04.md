# Fact a977fb04

Store id: f8cbec24-a7a3-4061-bb05-661084be4529

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
- posted_at: `2026-11-09T23:44:55.1026570+00:00`

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
  "id": "f8cbec24-a7a3-4061-bb05-661084be4529",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.1026570+00:00"
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
  "subject_id": "e8a60108-c5ea-4fbd-85d3-4d32126f66c5",
  "subject_name": "django/db/models/lookups::UUIDTextMixin.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, qn, connection)"
}
```

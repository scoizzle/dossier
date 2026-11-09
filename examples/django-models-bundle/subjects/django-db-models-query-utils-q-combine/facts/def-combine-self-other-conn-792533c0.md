# Fact 792533c0

Store id: c5b7ca98-8db1-4f31-81da-bbee8e3453e0

## Text

```text
def _combine(self, other, conn)
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
- posted_at: `2026-11-09T23:44:56.5263000+00:00`

## Data

```json
{
  "end_line": 85,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 74,
  "symbol": "Q._combine"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L85","symbol":"Q._combine"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q._combine](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 85,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 74,
    "symbol": "Q._combine"
  },
  "id": "c5b7ca98-8db1-4f31-81da-bbee8e3453e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.5263000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L85",
        "symbol": "Q._combine"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "311a8bdb-d227-4955-89f9-005beca885f8",
  "subject_name": "django/db/models/query_utils::Q._combine",
  "tags": [
    "entity:method"
  ],
  "text": "def _combine(self, other, conn)"
}
```

# Fact 792533c0

Store id: ec803830-840b-4043-bee6-41562cdae13f

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
- posted_at: `2026-11-09T23:32:05.0423360+00:00`

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
  "id": "ec803830-840b-4043-bee6-41562cdae13f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0423360+00:00"
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
  "subject_id": "c932c680-2812-4b9d-b3a9-0c9cfe1d0c91",
  "subject_name": "django/db/models/query_utils::Q._combine",
  "tags": [
    "entity:method"
  ],
  "text": "def _combine(self, other, conn)"
}
```

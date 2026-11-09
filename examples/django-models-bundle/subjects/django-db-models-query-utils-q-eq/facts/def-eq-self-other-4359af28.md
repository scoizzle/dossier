# Fact 4359af28

Store id: 41933dec-694f-4df8-b93c-a11396d7ec86

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:32:05.0940520+00:00`

## Data

```json
{
  "end_line": 231,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 228,
  "symbol": "Q.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":228,"selector":"L228-L231","symbol":"Q.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 231,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 228,
    "symbol": "Q.__eq__"
  },
  "id": "41933dec-694f-4df8-b93c-a11396d7ec86",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0940520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 228,
        "selector": "L228-L231",
        "symbol": "Q.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "b085037b-775c-4143-bca9-b57bf1374e52",
  "subject_name": "django/db/models/query_utils::Q.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```

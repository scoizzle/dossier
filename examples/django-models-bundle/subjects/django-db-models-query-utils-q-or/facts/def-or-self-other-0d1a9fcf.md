# Fact 0d1a9fcf

Store id: 248ae33a-3e72-46cf-9f37-867251edb079

## Text

```text
def __or__(self, other)
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
- posted_at: `2026-11-09T22:39:50.0628390+00:00`

## Data

```json
{
  "end_line": 88,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 87,
  "symbol": "Q.__or__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":87,"selector":"L87-L88","symbol":"Q.__or__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__or__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 88,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 87,
    "symbol": "Q.__or__"
  },
  "id": "248ae33a-3e72-46cf-9f37-867251edb079",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0628390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 87,
        "selector": "L87-L88",
        "symbol": "Q.__or__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "ae2c99fc-82d4-4f40-9dcb-e28b7a27719f",
  "subject_name": "django/db/models/query_utils::Q.__or__",
  "tags": [
    "entity:method"
  ],
  "text": "def __or__(self, other)"
}
```

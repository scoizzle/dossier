# Fact 6c2a6b99

Store id: 72a7a638-c289-45f0-be7a-880c611b0598

## Text

```text
def identity(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:05.0906170+00:00`

## Data

```json
{
  "end_line": 226,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 215,
  "symbol": "Q.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":215,"selector":"L215-L226","symbol":"Q.identity"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 226,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 215,
    "symbol": "Q.identity"
  },
  "id": "72a7a638-c289-45f0-be7a-880c611b0598",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0906170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 215,
        "selector": "L215-L226",
        "symbol": "Q.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "7cf816d6-f833-4b4c-81ba-9235c3667b75",
  "subject_name": "django/db/models/query_utils::Q.identity",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def identity(self)"
}
```

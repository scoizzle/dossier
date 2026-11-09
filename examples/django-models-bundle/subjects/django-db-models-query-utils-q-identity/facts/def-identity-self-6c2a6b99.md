# Fact 6c2a6b99

Store id: c62bcdcd-de3b-4bf5-acba-84684e0f42de

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
- posted_at: `2026-11-09T23:44:56.5865830+00:00`

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
  "id": "c62bcdcd-de3b-4bf5-acba-84684e0f42de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.5865830+00:00"
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
  "subject_id": "963199e1-ebd5-4973-8b08-07a56e6fa9a6",
  "subject_name": "django/db/models/query_utils::Q.identity",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def identity(self)"
}
```
